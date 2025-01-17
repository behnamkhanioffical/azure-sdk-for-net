// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The entity timeline result operation response. </summary>
    internal partial class EntityTimelineResponse
    {
        /// <summary> Initializes a new instance of EntityTimelineResponse. </summary>
        internal EntityTimelineResponse()
        {
            Value = new ChangeTrackingList<EntityTimelineItem>();
        }

        /// <summary> Initializes a new instance of EntityTimelineResponse. </summary>
        /// <param name="metaData"> The metadata from the timeline operation results. </param>
        /// <param name="value">
        /// The timeline result values.
        /// Please note <see cref="EntityTimelineItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActivityTimelineItem"/>, <see cref="AnomalyTimelineItem"/>, <see cref="BookmarkTimelineItem"/> and <see cref="SecurityAlertTimelineItem"/>.
        /// </param>
        internal EntityTimelineResponse(TimelineResultsMetadata metaData, IReadOnlyList<EntityTimelineItem> value)
        {
            MetaData = metaData;
            Value = value;
        }

        /// <summary> The metadata from the timeline operation results. </summary>
        public TimelineResultsMetadata MetaData { get; }
        /// <summary>
        /// The timeline result values.
        /// Please note <see cref="EntityTimelineItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActivityTimelineItem"/>, <see cref="AnomalyTimelineItem"/>, <see cref="BookmarkTimelineItem"/> and <see cref="SecurityAlertTimelineItem"/>.
        /// </summary>
        public IReadOnlyList<EntityTimelineItem> Value { get; }
    }
}
