// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Graph.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// message
    /// </summary>
    public partial class Microsoftgraphmessage : MicrosoftgraphoutlookItem
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphmessage class.
        /// </summary>
        public Microsoftgraphmessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphmessage class.
        /// </summary>
        /// <param name="id">Read-only.</param>
        /// <param name="categories">The categories associated with the
        /// item</param>
        /// <param name="changeKey">Identifies the version of the item. Every
        /// time the item is changed, changeKey changes as well. This allows
        /// Exchange to apply changes to the correct version of the object.
        /// Read-only.</param>
        /// <param name="createdDateTime">The Timestamp type represents date
        /// and time information using ISO 8601 format and is always in UTC
        /// time. For example, midnight UTC on Jan 1, 2014 would look like
        /// this: '2014-01-01T00:00:00Z'</param>
        /// <param name="lastModifiedDateTime">The Timestamp type represents
        /// date and time information using ISO 8601 format and is always in
        /// UTC time. For example, midnight UTC on Jan 1, 2014 would look like
        /// this: '2014-01-01T00:00:00Z'</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="bccRecipients">The Bcc: recipients for the
        /// message.</param>
        /// <param name="bodyPreview">The first 255 characters of the message
        /// body. It is in text format.</param>
        /// <param name="ccRecipients">The Cc: recipients for the
        /// message.</param>
        /// <param name="conversationId">The ID of the conversation the email
        /// belongs to.</param>
        /// <param name="conversationIndex">Indicates the position of the
        /// message within the conversation.</param>
        /// <param name="hasAttachments">Indicates whether the message has
        /// attachments. This property doesn't include inline attachments, so
        /// if a message contains only inline attachments, this property is
        /// false. To verify the existence of inline attachments, parse the
        /// body property to look for a src attribute, such as &lt;IMG
        /// src='cid:image001.jpg@01D26CD8.6C05F070'&gt;.</param>
        /// <param name="importance">Possible values include: 'low', 'normal',
        /// 'high'</param>
        /// <param name="inferenceClassification">Possible values include:
        /// 'focused', 'other'</param>
        /// <param name="internetMessageHeaders">A collection of message
        /// headers defined by RFC5322. The set includes message headers
        /// indicating the network path taken by a message from the sender to
        /// the recipient. It can also contain custom message headers that hold
        /// app data for the message.  Returned only on applying a $select
        /// query option. Read-only.</param>
        /// <param name="internetMessageId">The message ID in the format
        /// specified by RFC2822.</param>
        /// <param name="isDeliveryReceiptRequested">Indicates whether a read
        /// receipt is requested for the message.</param>
        /// <param name="isDraft">Indicates whether the message is a draft. A
        /// message is a draft if it hasn't been sent yet.</param>
        /// <param name="isRead">Indicates whether the message has been
        /// read.</param>
        /// <param name="isReadReceiptRequested">Indicates whether a read
        /// receipt is requested for the message.</param>
        /// <param name="parentFolderId">The unique identifier for the
        /// message's parent mailFolder.</param>
        /// <param name="receivedDateTime">The date and time the message was
        /// received.</param>
        /// <param name="replyTo">The email addresses to use when
        /// replying.</param>
        /// <param name="sentDateTime">The date and time the message was
        /// sent.</param>
        /// <param name="subject">The subject of the message.</param>
        /// <param name="toRecipients">The To: recipients for the
        /// message.</param>
        /// <param name="webLink">The URL to open the message in Outlook Web
        /// App.You can append an ispopout argument to the end of the URL to
        /// change how the message is displayed. If ispopout is not present or
        /// if it is set to 1, then the message is shown in a popout window. If
        /// ispopout is set to 0, then the browser will show the message in the
        /// Outlook Web App review pane.The message will open in the browser if
        /// you are logged in to your mailbox via Outlook Web App. You will be
        /// prompted to login if you are not already logged in with the
        /// browser.This URL can be accessed from within an iFrame.</param>
        /// <param name="attachments">The fileAttachment and itemAttachment
        /// attachments for the message.</param>
        /// <param name="extensions">The collection of open extensions defined
        /// for the message. Nullable.</param>
        /// <param name="multiValueExtendedProperties">The collection of
        /// multi-value extended properties defined for the message.
        /// Nullable.</param>
        /// <param name="singleValueExtendedProperties">The collection of
        /// single-value extended properties defined for the message.
        /// Nullable.</param>
        public Microsoftgraphmessage(string id = default(string), IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<string> categories = default(IList<string>), string changeKey = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), IList<Microsoftgraphrecipient> bccRecipients = default(IList<Microsoftgraphrecipient>), MicrosoftgraphitemBody body = default(MicrosoftgraphitemBody), string bodyPreview = default(string), IList<Microsoftgraphrecipient> ccRecipients = default(IList<Microsoftgraphrecipient>), string conversationId = default(string), byte[] conversationIndex = default(byte[]), MicrosoftgraphfollowupFlag flag = default(MicrosoftgraphfollowupFlag), Microsoftgraphrecipient fromProperty = default(Microsoftgraphrecipient), bool? hasAttachments = default(bool?), string importance = default(string), string inferenceClassification = default(string), IList<MicrosoftgraphinternetMessageHeader> internetMessageHeaders = default(IList<MicrosoftgraphinternetMessageHeader>), string internetMessageId = default(string), bool? isDeliveryReceiptRequested = default(bool?), bool? isDraft = default(bool?), bool? isRead = default(bool?), bool? isReadReceiptRequested = default(bool?), string parentFolderId = default(string), System.DateTime? receivedDateTime = default(System.DateTime?), IList<Microsoftgraphrecipient> replyTo = default(IList<Microsoftgraphrecipient>), Microsoftgraphrecipient sender = default(Microsoftgraphrecipient), System.DateTime? sentDateTime = default(System.DateTime?), string subject = default(string), IList<Microsoftgraphrecipient> toRecipients = default(IList<Microsoftgraphrecipient>), MicrosoftgraphitemBody uniqueBody = default(MicrosoftgraphitemBody), string webLink = default(string), IList<Microsoftgraphattachment> attachments = default(IList<Microsoftgraphattachment>), IList<IDictionary<string, object>> extensions = default(IList<IDictionary<string, object>>), IList<MicrosoftgraphmultiValueLegacyExtendedProperty> multiValueExtendedProperties = default(IList<MicrosoftgraphmultiValueLegacyExtendedProperty>), IList<MicrosoftgraphsingleValueLegacyExtendedProperty> singleValueExtendedProperties = default(IList<MicrosoftgraphsingleValueLegacyExtendedProperty>))
            : base(id, additionalProperties, categories, changeKey, createdDateTime, lastModifiedDateTime)
        {
            // AdditionalProperties = additionalProperties;
            BccRecipients = bccRecipients;
            Body = body;
            BodyPreview = bodyPreview;
            CcRecipients = ccRecipients;
            ConversationId = conversationId;
            ConversationIndex = conversationIndex;
            Flag = flag;
            FromProperty = fromProperty;
            HasAttachments = hasAttachments;
            Importance = importance;
            InferenceClassification = inferenceClassification;
            InternetMessageHeaders = internetMessageHeaders;
            InternetMessageId = internetMessageId;
            IsDeliveryReceiptRequested = isDeliveryReceiptRequested;
            IsDraft = isDraft;
            IsRead = isRead;
            IsReadReceiptRequested = isReadReceiptRequested;
            ParentFolderId = parentFolderId;
            ReceivedDateTime = receivedDateTime;
            ReplyTo = replyTo;
            Sender = sender;
            SentDateTime = sentDateTime;
            Subject = subject;
            ToRecipients = toRecipients;
            UniqueBody = uniqueBody;
            WebLink = webLink;
            Attachments = attachments;
            Extensions = extensions;
            MultiValueExtendedProperties = multiValueExtendedProperties;
            SingleValueExtendedProperties = singleValueExtendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        // [JsonExtensionData]
        // public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the Bcc: recipients for the message.
        /// </summary>
        [JsonProperty(PropertyName = "bccRecipients")]
        public IList<Microsoftgraphrecipient> BccRecipients { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public MicrosoftgraphitemBody Body { get; set; }

        /// <summary>
        /// Gets or sets the first 255 characters of the message body. It is in
        /// text format.
        /// </summary>
        [JsonProperty(PropertyName = "bodyPreview")]
        public string BodyPreview { get; set; }

        /// <summary>
        /// Gets or sets the Cc: recipients for the message.
        /// </summary>
        [JsonProperty(PropertyName = "ccRecipients")]
        public IList<Microsoftgraphrecipient> CcRecipients { get; set; }

        /// <summary>
        /// Gets or sets the ID of the conversation the email belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "conversationId")]
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets or sets indicates the position of the message within the
        /// conversation.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "conversationIndex")]
        public byte[] ConversationIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flag")]
        public MicrosoftgraphfollowupFlag Flag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public Microsoftgraphrecipient FromProperty { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the message has attachments. This
        /// property doesn't include inline attachments, so if a message
        /// contains only inline attachments, this property is false. To verify
        /// the existence of inline attachments, parse the body property to
        /// look for a src attribute, such as &amp;lt;IMG
        /// src='cid:image001.jpg@01D26CD8.6C05F070'&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "hasAttachments")]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'low', 'normal', 'high'
        /// </summary>
        [JsonProperty(PropertyName = "importance")]
        public string Importance { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'focused', 'other'
        /// </summary>
        [JsonProperty(PropertyName = "inferenceClassification")]
        public string InferenceClassification { get; set; }

        /// <summary>
        /// Gets or sets a collection of message headers defined by RFC5322.
        /// The set includes message headers indicating the network path taken
        /// by a message from the sender to the recipient. It can also contain
        /// custom message headers that hold app data for the message.
        /// Returned only on applying a $select query option. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "internetMessageHeaders")]
        public IList<MicrosoftgraphinternetMessageHeader> InternetMessageHeaders { get; set; }

        /// <summary>
        /// Gets or sets the message ID in the format specified by RFC2822.
        /// </summary>
        [JsonProperty(PropertyName = "internetMessageId")]
        public string InternetMessageId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether a read receipt is requested for the
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "isDeliveryReceiptRequested")]
        public bool? IsDeliveryReceiptRequested { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the message is a draft. A message is
        /// a draft if it hasn't been sent yet.
        /// </summary>
        [JsonProperty(PropertyName = "isDraft")]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the message has been read.
        /// </summary>
        [JsonProperty(PropertyName = "isRead")]
        public bool? IsRead { get; set; }

        /// <summary>
        /// Gets or sets indicates whether a read receipt is requested for the
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "isReadReceiptRequested")]
        public bool? IsReadReceiptRequested { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the message's parent
        /// mailFolder.
        /// </summary>
        [JsonProperty(PropertyName = "parentFolderId")]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message was received.
        /// </summary>
        [JsonProperty(PropertyName = "receivedDateTime")]
        public System.DateTime? ReceivedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the email addresses to use when replying.
        /// </summary>
        [JsonProperty(PropertyName = "replyTo")]
        public IList<Microsoftgraphrecipient> ReplyTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sender")]
        public Microsoftgraphrecipient Sender { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message was sent.
        /// </summary>
        [JsonProperty(PropertyName = "sentDateTime")]
        public System.DateTime? SentDateTime { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the To: recipients for the message.
        /// </summary>
        [JsonProperty(PropertyName = "toRecipients")]
        public IList<Microsoftgraphrecipient> ToRecipients { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueBody")]
        public MicrosoftgraphitemBody UniqueBody { get; set; }

        /// <summary>
        /// Gets or sets the URL to open the message in Outlook Web App.You can
        /// append an ispopout argument to the end of the URL to change how the
        /// message is displayed. If ispopout is not present or if it is set to
        /// 1, then the message is shown in a popout window. If ispopout is set
        /// to 0, then the browser will show the message in the Outlook Web App
        /// review pane.The message will open in the browser if you are logged
        /// in to your mailbox via Outlook Web App. You will be prompted to
        /// login if you are not already logged in with the browser.This URL
        /// can be accessed from within an iFrame.
        /// </summary>
        [JsonProperty(PropertyName = "webLink")]
        public string WebLink { get; set; }

        /// <summary>
        /// Gets or sets the fileAttachment and itemAttachment attachments for
        /// the message.
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<Microsoftgraphattachment> Attachments { get; set; }

        /// <summary>
        /// Gets or sets the collection of open extensions defined for the
        /// message. Nullable.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<IDictionary<string, object>> Extensions { get; set; }

        /// <summary>
        /// Gets or sets the collection of multi-value extended properties
        /// defined for the message. Nullable.
        /// </summary>
        [JsonProperty(PropertyName = "multiValueExtendedProperties")]
        public IList<MicrosoftgraphmultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets the collection of single-value extended properties
        /// defined for the message. Nullable.
        /// </summary>
        [JsonProperty(PropertyName = "singleValueExtendedProperties")]
        public IList<MicrosoftgraphsingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }

    }
}