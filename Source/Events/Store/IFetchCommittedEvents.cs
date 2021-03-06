﻿using Dolittle.Runtime.Events;
using Dolittle.Events;
using Dolittle.Artifacts;

namespace Dolittle.Runtime.Events.Store
{
    /// <summary>
    /// Defines how <see cref="Commits" /> can be retrieved from the Event Store
    /// </summary>
    public interface IFetchCommittedEvents
    {
        /// <summary>
        /// Fetches all <see cref="CommittedEventStream" />s for an <see cref="IEventSource" />
        /// </summary>
        /// <param name="eventSourceKey">The Key of the <see cref="IEventSource" /></param>
        /// <returns>All <see cref="CommittedEventStream" />s for the <see cref="IEventSource" /> in ascending order</returns>
        Commits Fetch(EventSourceKey eventSourceKey);
        /// <summary>
        /// Fetches all <see cref="CommittedEventStream" />s for an <see cref="IEventSource" /> from the specified version
        /// </summary>
        /// <param name="eventSourceKey">The Key for the <see cref="IEventSource" /></param>
        /// <param name="commitVersion">The <see cref="CommitVersion" /> to fetch events from</param>
        /// <returns>All <see cref="CommittedEventStream" />s for the <see cref="IEventSource" /> from the specified <see cref="CommitVersion" /> in ascending order</returns>
        Commits FetchFrom(EventSourceKey eventSourceKey, CommitVersion commitVersion);
        /// <summary>
        /// Fetches all <see cref="CommittedEventStream" />s for all <see cref="IEventSource" />s greater than the specified <see cref="CommitSequenceNumber" />
        /// </summary>
        /// <param name="commit">The <see cref="CommitSequenceNumber" /> that the <see cref="CommittedEventStream" />s should be greater than</param>
        /// <returns>All <see cref="CommittedEventStream" />s great than specified <see cref="CommitSequenceNumber" /> in ascending order</returns>
        Commits FetchAllCommitsAfter(CommitSequenceNumber commit);

        /// <summary>
        /// Fetches all the instances of a particular event type in order of occurrence
        /// </summary>
        /// <param name="eventType">The <see cref="ArtifactId"> event type</see> to fetch</param>
        /// <returns>An ordered stream of events of the request type</returns>
        SingleEventTypeEventStream FetchAllEventsOfType(ArtifactId eventType);

        /// <summary>
        /// Fetches all the instances of a particular event type in order of occurrence that occurred in commits after the specified commit
        /// </summary>
        /// <param name="eventType">The <see cref="ArtifactId"> event type</see> to fetch</param>
        /// <param name="commit">The <see cref="CommitSequenceNumber" /> that the <see cref="CommittedEventStream" />s should be greater than</param>
        /// <returns>An ordered stream of events of the request type</returns>
        SingleEventTypeEventStream FetchAllEventsOfTypeAfter(ArtifactId eventType, CommitSequenceNumber commit);
    }
}