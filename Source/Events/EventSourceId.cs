﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.Concepts;

namespace Dolittle.Runtime.Events
{
    /// <summary>
    /// Represents the identification of an event source
    /// </summary>
    public class EventSourceId : ConceptAs<Guid>
    {
        /// <summary>
        /// A static singleton instance to represent an "Empty" <see cref="EventSourceId" />
        /// </summary>
        public static readonly EventSourceId Empty = Guid.Empty;

        /// <summary>
        /// Creates a new instance of an <see cref="EventSourceId"/> with an empty guid 
        /// </summary>
        public EventSourceId() => new EventSourceId(Guid.Empty);

        /// <summary>
        /// Instantiates a new instance of an <see cref="EventSourceId"/> with a unique id
        /// </summary>
        /// <param name="guid"></param>
        public EventSourceId(Guid guid) => Value = guid;


        /// <summary>
        /// Creates a new instance of <see cref="EventSourceId"/> with a unique id
        /// </summary>
        /// <returns>A new <see cref="EventSourceId"/></returns>
        public static EventSourceId New()
        {
            return new EventSourceId { Value = Guid.NewGuid() };
        }

        /// <summary>
        /// Implicitly convert from a <see cref="Guid"/> to an <see cref="EventSourceId"/>
        /// </summary>
        /// <param name="eventId"></param>
        public static implicit operator EventSourceId(Guid eventId)
        {
            return new EventSourceId { Value = eventId };
        }
    }
}
