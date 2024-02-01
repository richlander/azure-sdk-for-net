// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The call transfer accepted event. </summary>
    internal partial class CallTransferAcceptedInternal
    {
        /// <summary> Initializes a new instance of <see cref="CallTransferAcceptedInternal"/>. </summary>
        internal CallTransferAcceptedInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CallTransferAcceptedInternal"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transferTarget"> Target who the call is transferred to. </param>
        /// <param name="transferee"> the participant who is being transferred away. </param>
        internal CallTransferAcceptedInternal(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, CommunicationIdentifierModel transferTarget, CommunicationIdentifierModel transferee)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            TransferTarget = transferTarget;
            Transferee = transferee;
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code, sub-code and message. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Target who the call is transferred to. </summary>
        public CommunicationIdentifierModel TransferTarget { get; }
        /// <summary> the participant who is being transferred away. </summary>
        public CommunicationIdentifierModel Transferee { get; }
    }
}
