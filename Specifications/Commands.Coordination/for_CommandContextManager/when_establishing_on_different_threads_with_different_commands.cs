﻿using System.Dynamic;
using System.Threading;
using Dolittle.Artifacts;
using Dolittle.Runtime.Transactions;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Dolittle.Runtime.Commands.Coordination.Specs.for_CommandContextManager
{
    [Subject(Subjects.establishing_context)]
    public class when_establishing_on_different_threads_with_different_commands : given.a_command_context_manager
    {
        static CommandRequest command;
        static ICommandContext firstCommandContext;
        static ICommandContext secondCommandContext;

        Establish context = () =>
                                {
                                    var artifact = Artifact.New();
                                    command = new CommandRequest(TransactionCorrelationId.NotSet, artifact.Id, artifact.Generation, new ExpandoObject());
                                    var resetEvent = new ManualResetEvent(false);
                                    firstCommandContext = Manager.EstablishForCommand(command);
                                    var thread = new Thread(
                                        () =>
                                            {
                                                secondCommandContext = Manager.EstablishForCommand(command);
                                                resetEvent.Reset();
                                            }
                                        );
                                    thread.Start();
                                    resetEvent.WaitOne(1000);
                                };

        It should_return_different_contexts = () => firstCommandContext.ShouldNotEqual(secondCommandContext);
    }
}