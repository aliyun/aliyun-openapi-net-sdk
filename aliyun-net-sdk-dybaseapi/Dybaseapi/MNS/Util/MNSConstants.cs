namespace Aliyun.Acs.Dybaseapi.MNS.Util
{
    internal static class MNSConstants
    {
        public const string MNS_SERVICE_NAME = "Aliyun.Acs.Dybaseapi.MNS";

        public const uint DEFAULT_MAX_RETURNS = 1000;
        public const uint DEFAULT_MESSAGE_PRIORITY = 8;

        public const uint DEFAULT_DELAY_SECONDS = 0;
        public const uint DEFAULT_VISIBILITY_TIMEOUT = 30;
        public const uint DEFAULT_MAXIMUM_MESSAGE_SIZE = 65536;
        public const uint DEFAULT_MESSAGE_RETENTION_PERIOD = 345600;
        public const uint DEFAULT_POLLING_WAIT_SECONDS = 0;
        public const bool DEFAULT_LOGGING_ENABLED = false;

        public const string ATTRIBUTE_DELAY_SECONDS = "DelaySeconds";
        public const string ATTRIBUTE_VISIBILITY_TIMEOUT = "VisibilityTimeout";
        public const string ATTRIBUTE_MAXIMUM_MESSAGE_SIZE = "MaximumMessageSize";
        public const string ATTRIBUTE_MESSAGE_RETENTION_PERIOD = "MessageRetentionPeriod";
        public const string ATTRIBUTE_POLLING_WAIT_SECONDS = "PollingWaitSeconds";

        public const string ATTRIBUTE_CREAT_TIME = "CreateTime";
        public const string ATTRIBUTE_LAST_MODIFY_TIME = "LastModifyTime";

        public const string ATTRIBUTE_ACTIVE_MESSAGES = "ActiveMessages";
        public const string ATTRIBUTE_INACTIVE_MESSAGES = "InactiveMessages";
        public const string ATTRIBUTE_DELAY_MESSAGES = "DelayMessages";

        public const string MNS_XML_NAMESPACE = "http://mns.aliyuncs.com/doc/v1";
        public const string MNS_AUTHORIZATION_HEADER_PREFIX = "MNS";
        public const string X_MNS_VERSION = "2015-06-06";
        public const string X_MNS_HEADER_PREFIX = "x-mns-";

        public const string XML_ROOT_SUBSCRIPTION = "Subscription";
        public const string XML_ROOT_ERRORS = "Errors";
        public const string XML_ROOT_ERROR_RESPONSE = "Error";
        public const string XML_ROOT_LIST_QUEUE_RESPONSE = "Queues";
        public const string XML_ROOT_QUEUE = "Queue";
        public const string XML_ROOT_TOPIC = "Topic";
        public const string XML_ROOT_TOPICS = "Topics";
        public const string XML_ROOT_MESSAGES = "Messages";
        public const string XML_ROOT_MESSAGE = "Message";
        public const string XML_ROOT_RECEIPT_HANDLES = "ReceiptHandles";
        public const string XML_ROOT_CHANGE_MESSAGE_VISIBILITY_RESPONSE = "ChangeVisibility";
        public const string XML_ROOT_ACCOUNT = "Account";

        public const string XML_ELEMENT_CODE = "Code";
        public const string XML_ELEMENT_ERROR_CODE = "ErrorCode";
        public const string XML_ELEMENT_MESSAGE = "Message";
        public const string XML_ELEMENT_ERROR_MESSAGE = "ErrorMessage";
        public const string XML_ELEMENT_REQUEST_ID = "RequestId";
        public const string XML_ELEMENT_HOST_ID = "HostId";
        public const string XML_ELEMENT_ENDPOINT = "Endpoint";
        public const string XML_ELEMENT_FILTER_TAG = "FilterTag";
        public const string XML_ELEMENT_NOTIFY_STRATEGY = "NotifyStrategy";
        public const string XML_ELEMENT_NOTIFY_CONTENT_FORMAT = "NotifyContentFormat";

        public const string XML_ELEMENT_QUEUE = "Queue";
        public const string XML_ELEMENT_QUEUE_URL = "QueueURL";
        public const string XML_ELEMENT_TOPIC_URL = "TopicURL";
        public const string XML_ELEMENT_SUBSCRIPTION_URL = "SubscriptionURL";
        public const string XML_ELEMENT_NEXT_MARKER = "NextMarker";

        public const string XML_ELEMENT_QUEUE_NAME = "QueueName";
        public const string XML_ELEMENT_TOPIC_NAME = "TopicName";
        public const string XML_ELEMENT_MESSAGE_COUNT = "MessageCount";
        public const string XML_ELEMENT_TOPIC_OWNER = "TopicOwner";
        public const string XML_ELEMENT_SUBSCRIPTION_NAME = "SubscriptionName";
        public const string XML_ELEMENT_CREATE_TIME = "CreateTime";
        public const string XML_ELEMENT_LAST_MODIFY_TIME = "LastModifyTime";
        public const string XML_ELEMENT_VISIBILITY_TIMEOUT = "VisibilityTimeout";
        public const string XML_ELEMENT_MAXIMUM_MESSAGE_SIZE = "MaximumMessageSize";
        public const string XML_ELEMENT_MESSAGE_RETENTION_PERIOD = "MessageRetentionPeriod";
        public const string XML_ELEMENT_DELAY_SECONDS = "DelaySeconds";
        public const string XML_ELEMENT_POLLING_WAIT_SECONDS = "PollingWaitSeconds";
        public const string XML_ELEMENT_INACTIVE_MESSAGES = "InactiveMessages";
        public const string XML_ELEMENT_ACTIVE_MESSAGES = "ActiveMessages";
        public const string XML_ELEMENT_DELAY_MESSAGES = "DelayMessages";
        public const string XML_ELEMENT_LOGGING_ENABLED = "LoggingEnabled";
        public const string XML_ELEMENT_LOGGING_BUCKET = "LoggingBucket";

        public const string XML_ELEMENT_MESSAGE_BODY = "MessageBody";
        public const string XML_ELEMENT_MESSAGE_TAG = "MessageTag";
        public const string XML_ELEMENT_MESSAGE_ATTRIBUTES = "MessageAttributes";
        public const string XML_ELEMENT_DIRECT_MAIL = "DirectMail";
        public const string XML_ELEMENT_DIRECT_SMS = "DirectSMS";
        public const string XML_ELEMENT_PRIORITY = "Priority";
        public const string XML_ELEMENT_MESSAGE_BODY_MD5 = "MessageBodyMD5";
        public const string XML_ELEMENT_MESSAGE_ID = "MessageId";
        public const string XML_ELEMENT_RECEIPT_HANDLE = "ReceiptHandle";
        public const string XML_ELEMENT_ENQUEUE_TIME = "EnqueueTime";
        public const string XML_ELEMENT_NEXT_VISIBLE_TIME = "NextVisibleTime";
        public const string XML_ELEMENT_FIRST_DEQUEUE_TIME = "FirstDequeueTime";
        public const string XML_ELEMENT_DEQUEUE_COUNT = "DequeueCount";

        public const string MNS_PARAMETER_ACCOUNT_META = "accountmeta";
        public const string MNS_PARAMETER_META_OVERRIDE = "metaoverride";
        public const string MNS_PARAMETER_WAIT_SECONDS = "waitseconds";
        public const string MNS_PARAMETER_BATCH_SIZE = "numOfMessages";
        public const string MNS_PARAMETER_PEEK_ONLY = "peekonly";
        public const string MNS_PARAMETER_RECEIPT_HANDLE = "ReceiptHandle";
        public const string MNS_PARAMETER_VISIBILITY_TIMEOUT = "VisibilityTimeout";

        public const string MNS_MESSAGE_SUB_RESOURCE = "/messages";
        public const string MNS_MESSAGE_PRE_RESOURCE = "queues/";
        public const string MNS_TOPIC_PRE_RESOURCE = "topics/";
        public const string MNS_SUBSCRIBE_PRE_RESOURCE = "/subscriptions/";

        public const string ContentTypeTextXml = "text/xml";
    }
}
