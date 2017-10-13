﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace doLittle.Runtime.Events.Versioning
{
    /// <summary>
    /// Represents an exceptional situation where an <see cref="IEvent">Event</see> in an <see cref="EventMigrationHierarchy">EventMigrationHierarchy</see>
    /// has not implemented the correct <see cref="doLittle.Runtime.Events.Versioning.IAmNextGenerationOf{T}">interface</see>.
    /// </summary>
    public class NotAMigratedEventTypeException : Exception
    {
        /// <summary>
        /// Initializes a <see cref="NotAMigratedEventTypeException">NotAMigratedEventTypeException</see>
        /// </summary>
        /// <param name="message">Error Message</param>
        public NotAMigratedEventTypeException(string message) : base(message)
        {}
    }
}