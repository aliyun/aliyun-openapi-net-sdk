/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// All erorr codes returned by MNS.
    /// </summary>
    public static class MNSErrorCode
    {
        public const string AccessDenied = "AccessDenied";
        public const string InternalError = "InternalError";

        public const string InvalidAccessKeyId = "InvalidAccessKeyId";
        public const string InvalidAuthorizationHeader = "InvalidAuthorizationHeader";
        public const string InvalidDateHeader = "InvalidDateHeader";
        public const string InvalidArgument = "InvalidArgument";
        public const string InvalidDigest = "InvalidDigest";
        public const string InvalidRequestURL = "InvalidRequestURL";
        public const string InvalidQueryString = "InvalidQueryString";
        public const string InvalidQueueName = "InvalidQueueName";
        public const string InvalidVersionHeader = "InvalidVersionHeader";
        public const string InvalidContentType = "InvalidContentType";

        public const string MissingAuthorizationHeader = "MissingAuthorizationHeader";
        public const string MissingDateHeader = "MissingDateHeader";
        public const string MissingVersionHeader = "MissingVersionHeader";
        public const string MissingReceiptHandle = "MissingReceiptHandle";
        public const string MissingVisibilityTimeout = "MissingVisibilityTimeout";

        public const string MessageNotExist = "MessageNotExist";

        public const string TopicAlreadyExist = "TopicAlreadyExist";
        public const string TopicDeletedRecently = "TopicDeletedRecently";
        public const string TopicNameLengthError = "TopicNameLengthError";
        public const string TopicNameInvalid = "TopicNameInvalid";
        public const string TopicNotExist = "TopicNotExist";

        public const string SubscriptionNameLengthError = "SubscriptionNameLengthError";
        public const string SubscriptionNameInvalid = "SubscriptionNameInvalid";
        public const string SubscriptionAlreadyExist = "SubscriptionAlreadyExist";
        public const string SubscriptionNotExist = "SubscriptionNotExist";
        public const string EndpointInvalid = "EndpointInvalid";

        public const string QueueAlreadyExist = "QueueAlreadyExist";
        public const string QueueDeletedRecently = "QueueDeletedRecently"; 
        public const string QueueNameLengthError = "QueueNameLengthError";
        public const string QueueNotExist = "QueueNotExist";

        public const string ReceiptHandleError = "ReceiptHandleError";
        public const string SignatureDoesNotMatch = "SignatureDoesNotMatch";
        public const string TimeExpired = "TimeExpired";
        public const string MalformedXML = "MalformedXML";

        // BatchDeleteFail is used by BatchDeleteFailException
        // ErrorDetails are in BatchDeleteFailException.ErrorItems
        public const string BatchDeleteFail = "BatchDeleteFail";

        // BatchSendFail is used by BatchSendFailException
        public const string BatchSendFail = "BatchSendFail";
    }
}