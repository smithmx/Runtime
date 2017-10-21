﻿using System;
using doLittle.Commands;
using Machine.Specifications;

namespace doLittle.Runtime.Commands.Specs.for_CommandCoordinator
{
    [Subject(typeof(CommandCoordinator))]
    public class when_handling_command_and_an_exception_occurs_during_validation : given.a_command_coordinator
    {
        static CommandResult result;
        static Exception exception;

        Establish context = () =>
        {
            exception = new Exception();
            command_validators_mock.Setup(cvs => cvs.Validate(command)).Throws(exception);
        };

        Because of = () => result = coordinator.Handle(command);

        It should_have_authorized_the_command = () => command_security_manager_mock.VerifyAll();
        It should_have_exception_in_result = () => result.Exception.ShouldEqual(exception);
        It should_have_success_set_to_false = () => result.Success.ShouldBeFalse();
    }
}