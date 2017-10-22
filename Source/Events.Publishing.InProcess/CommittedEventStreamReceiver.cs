﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using doLittle.Logging;

namespace doLittle.Runtime.Events.Publishing.InProcess
{
    /// <summary>
    /// Represents an implementation of <see cref="ICanReceiveCommittedEventStream"/> for in-process purpose
    /// Works in conjuction with <see cref="CommittedEventStreamSender"/> through a <see cref="ICommittedEventStreamBridge">bridge</see>
    /// </summary>
    public class CommittedEventStreamReceiver : ICanReceiveCommittedEventStream
    {
        /// <inheritdoc/>
        public event CommittedEventStreamReceived Received = (s) => { };

        /// <summary>
        /// Initializes a new instance of <see cref="CommittedEventStreamReceiver"/>
        /// </summary>
        /// <param name="committedEventStreamBridge"><see cref="ICommittedEventStreamBridge"/> to use</param>
        /// <param name="logger"><see cref="ILogger"/> for logging</param>
        public CommittedEventStreamReceiver(ICommittedEventStreamBridge committedEventStreamBridge, ILogger logger)
        {
            committedEventStreamBridge.Received += (s) =>
            {
                logger.Trace("Committed event stream received");
                Received(s);
            };
        }
    }
}
