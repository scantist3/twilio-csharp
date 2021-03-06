/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1.Conversation
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// CreateMessageOptions
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// The channel specific identifier of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this message. </param>
        public CreateMessageOptions(string pathConversationSid)
        {
            PathConversationSid = pathConversationSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// UpdateMessageOptions
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The channel specific identifier of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateMessageOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// DeleteMessageOptions
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteMessageOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchMessageOptions
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchMessageOptions(string pathConversationSid, string pathSid)
        {
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadMessageOptions
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
        /// <summary>
        /// The unique id of the Conversation for messages.
        /// </summary>
        public string PathConversationSid { get; }

        /// <summary>
        /// Construct a new ReadMessageOptions
        /// </summary>
        /// <param name="pathConversationSid"> The unique id of the Conversation for messages. </param>
        public ReadMessageOptions(string pathConversationSid)
        {
            PathConversationSid = pathConversationSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}