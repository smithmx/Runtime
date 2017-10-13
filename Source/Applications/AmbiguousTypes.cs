﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace doLittle.Runtime.Applications
{
    /// <summary>
    /// Exception that gets thrown when trying to <see cref="IApplicationResourceResolver">resolve</see>
    /// and there is an ambiguous match
    /// </summary>
    public class AmbiguousTypes : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AmbiguousTypes"/>
        /// </summary>
        /// <param name="identifier"></param>
        public AmbiguousTypes(IApplicationResourceIdentifier identifier)
            :base($"Ambiguous types found for identifier '{identifier.Resource.Name}'")
        { }
    }
}
