﻿namespace WampSharp.V2
{
    /// <summary>
    /// Represents a raw form of an event received from a WAMP topic.
    /// </summary>
    public interface IWampSerializedEvent
    {
        /// <summary>
        /// Gets the publication id of this event.
        /// </summary>
        long PublicationId { get; }

        /// <summary>
        /// Gets the details associated with this event.
        /// </summary>
        ISerializedValue Details { get; }

        /// <summary>
        /// Gets the arguments of this event.
        /// </summary>
        ISerializedValue[] Arguments { get; }

        /// <summary>
        /// Gets the arguments keywords of this event.
        /// </summary>
        ISerializedValue ArgumentsKeywords { get; }
    }
}