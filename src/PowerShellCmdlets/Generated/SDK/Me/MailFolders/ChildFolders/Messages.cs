// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.message&quot; objects.</para>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.message&quot; objects in the &quot;messages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_MailFolders_ChildFolders_Messages", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    [ResourceReference]
    public class Get_Me_MailFolders_ChildFolders_Messages : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset receivedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset sentDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String internetMessageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.internetMessageHeader")]
        [Selectable]
        public System.Object[] internetMessageHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Sortable]
        public System.Object body { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String bodyPreview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [Sortable]
        public System.String importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Sortable]
        public System.Object sender { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Sortable]
        public System.Object from { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        public System.Object[] toRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        public System.Object[] ccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        public System.Object[] bccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        public System.Object[] replyTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String conversationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Sortable]
        public System.Object uniqueBody { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isDeliveryReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isReadReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isRead { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isDraft { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [Sortable]
        public System.String inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.followupFlag")]
        [Selectable]
        [Sortable]
        public System.Object flag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attachment")]
        [Selectable]
        [Expandable]
        public System.Object[] attachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [Expandable]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] multiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] categories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.meetingMessageType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.eventMessage")]
        public System.String meetingMessageType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.eventMessage")]
        public System.Object @event { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.message&quot; object.</para>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.message&quot; object to the &quot;messages&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_MailFolders_ChildFolders_Messages", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.message")]
    [ResourceReference]
    public class New_Me_MailFolders_ChildFolders_Messages : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.message")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.")]
        public System.Management.Automation.SwitchParameter message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset receivedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset sentDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String internetMessageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.internetMessageHeader")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        public System.Object[] internetMessageHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object body { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bodyPreview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;normal&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [ValidateSet(@"low", @"normal", @"high")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        public System.String importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object sender { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object from { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] toRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] bccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] replyTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String conversationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object uniqueBody { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDeliveryReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isRead { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDraft { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;focused&apos;, &apos;other&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [ValidateSet(@"focused", @"other")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.followupFlag")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        public System.Object flag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attachment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        public System.Object[] attachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] categories { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.eventMessage")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.")]
        public System.Management.Automation.SwitchParameter eventMessage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;meetingRequest&apos;, &apos;meetingCancelled&apos;, &apos;meetingAccepted&apos;, &apos;meetingTenativelyAccepted&apos;, &apos;meetingDeclined&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.meetingMessageType")]
        [Selectable]
        [ValidateSet(@"none", @"meetingRequest", @"meetingCancelled", @"meetingAccepted", @"meetingTenativelyAccepted", @"meetingDeclined")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.")]
        public System.String meetingMessageType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object @event { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">PATCH ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_MailFolders_ChildFolders_Messages", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Update_Me_MailFolders_ChildFolders_Messages : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.message")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.")]
        public System.Management.Automation.SwitchParameter message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset receivedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset sentDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String internetMessageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.internetMessageHeader")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        public System.Object[] internetMessageHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object body { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bodyPreview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;normal&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [ValidateSet(@"low", @"normal", @"high")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        public System.String importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object sender { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object from { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] toRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] bccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] replyTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String conversationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object uniqueBody { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDeliveryReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isRead { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDraft { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;focused&apos;, &apos;other&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [ValidateSet(@"focused", @"other")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.followupFlag")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        public System.Object flag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attachment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        public System.Object[] attachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] categories { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.eventMessage")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.")]
        public System.Management.Automation.SwitchParameter eventMessage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;meetingRequest&apos;, &apos;meetingCancelled&apos;, &apos;meetingAccepted&apos;, &apos;meetingTenativelyAccepted&apos;, &apos;meetingDeclined&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.meetingMessageType")]
        [Selectable]
        [ValidateSet(@"none", @"meetingRequest", @"meetingCancelled", @"meetingAccepted", @"meetingTenativelyAccepted", @"meetingDeclined")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.")]
        public System.String meetingMessageType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object @event { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.message&quot; object.</para>
    ///     <para type="description">DELETE ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/messageId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.message&quot; object from the &quot;messages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_MailFolders_ChildFolders_Messages", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Remove_Me_MailFolders_ChildFolders_Messages : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/copy</para>
    ///     <para type="description">The action &quot;microsoft.graph.copy&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.message&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Copy", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Copy : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/copy";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/move</para>
    ///     <para type="description">The action &quot;microsoft.graph.move&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.message&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Move", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Move : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/move";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/createReply</para>
    ///     <para type="description">The action &quot;microsoft.graph.createReply&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.message&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_CreateReply", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_CreateReply : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/createReply";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/createReplyAll</para>
    ///     <para type="description">The action &quot;microsoft.graph.createReplyAll&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.message&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_CreateReplyAll", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_CreateReplyAll : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/createReplyAll";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/createForward</para>
    ///     <para type="description">The action &quot;microsoft.graph.createForward&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.message&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_CreateForward", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_CreateForward : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/createForward";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/reply</para>
    ///     <para type="description">The action &quot;microsoft.graph.reply&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Reply", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Reply : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.reply&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.reply&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/reply";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/replyAll</para>
    ///     <para type="description">The action &quot;microsoft.graph.replyAll&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_ReplyAll", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_ReplyAll : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.replyAll&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.replyAll&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/replyAll";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/forward</para>
    ///     <para type="description">The action &quot;microsoft.graph.forward&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Forward", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Forward : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.forward&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.forward&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ToRecipients&quot; parameter, which is accepted by the &quot;microsoft.graph.forward&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;ToRecipients&quot; parameter, which is accepted by the &quot;microsoft.graph.forward&quot; action.")]
        public System.Object[] ToRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/forward";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/send</para>
    ///     <para type="description">The action &quot;microsoft.graph.send&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Send", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.message")]
    [ResourceIdPropertyName("messageId")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Send : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/send";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.message&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.message&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Messages_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.message")]
    public class Invoke_Me_MailFolders_ChildFolders_Messages_Delta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/delta({this.GetFunctionUrlSegment()})";
        }
    }
}