﻿using Machine.Specifications;
using System;
using Dolittle.Events;
using Dolittle.Runtime.Events;

namespace Dolittle.Runtime.Commands.Coordination.Specs.for_CommandContext.given
{
    public class a_command_context_for_a_simple_command_with_one_tracked_object : a_command_context_for_a_simple_command
    {
        protected static StatefulEventSource aggregated_root;
        protected static EventSourceId event_source_id;

        Establish context = () =>
        {
            event_source_id = Guid.NewGuid();
            aggregated_root = new StatefulEventSource(event_source_id);
            command_context.RegisterForTracking(aggregated_root);
        };
    }
}
