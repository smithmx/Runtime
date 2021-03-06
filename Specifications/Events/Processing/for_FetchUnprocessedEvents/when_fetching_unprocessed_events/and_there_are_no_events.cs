namespace Dolittle.Runtime.Events.Specs.when_fetching_unprocessed_events
{
    using Dolittle.Runtime.Events.Processing;
    using specs = Dolittle.Runtime.Events.Specs.given;
    using Machine.Specifications;
    using Dolittle.Artifacts;
    using Dolittle.Runtime.Events.Store;
    using System.Collections.Generic;
    using System.Linq;

    [Subject(typeof(IFetchUnprocessedEvents),nameof(IFetchUnprocessedEvents.GetUnprocessedEvents))]
    public class and_there_are_no_events : given.a_fetch_unprocessed_events
    {
        static Artifact artifact;
        static CommittedEventVersion version;
        static SingleEventTypeEventStream event_stream;

        Establish context = () => 
        {
            artifact = specs.Artifacts.artifact_for_simple_event;
            version = new CommittedEventVersion(10,0,0);
            event_store.Setup(es => es.FetchAllEventsOfTypeAfter(artifact.Id,version.Major)).Returns(new SingleEventTypeEventStream(null));
        };

        Because of = () => event_stream = fetcher.GetUnprocessedEvents(artifact.Id,version);

        It should_return_an_empty_event_stream = () => event_stream.IsEmpty.ShouldBeTrue();
    }
}