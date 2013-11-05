﻿using System;

namespace TrackableEntities.Client
{
    /// <summary>
    /// TrackableEntities constants.
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// Change-tracking property names.
        /// </summary>
        public static class TrackingProperties
        {
            /// <summary>TrackingState property name</summary>
            public const string TrackingState = "TrackingState";
            /// <summary>ModifiedProperties property name</summary>
            public const string ModifiedProperties = "ModifiedProperties";
        }
    }
}
