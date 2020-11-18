// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for creating a chat thread. </summary>
    internal partial class CreateChatThreadRequest
    {
        /// <summary> Initializes a new instance of CreateChatThreadRequest. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <param name="members"> Members to be added to the chat thread. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topic"/> or <paramref name="members"/> is null. </exception>
        public CreateChatThreadRequest(string topic, IEnumerable<ChatThreadMemberInternal> members)
        {
            if (topic == null)
            {
                throw new ArgumentNullException(nameof(topic));
            }
            if (members == null)
            {
                throw new ArgumentNullException(nameof(members));
            }

            Topic = topic;
            Members = members.ToList();
        }

        /// <summary> The chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> Members to be added to the chat thread. </summary>
        public IList<ChatThreadMemberInternal> Members { get; }
    }
}
