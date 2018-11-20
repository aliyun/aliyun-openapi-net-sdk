/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using Aliyun.Acs.Dybaseapi.MNS.Model;
using Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System.Collections.Generic;

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// Implementation for accessing MNS queue
    /// </summary>
    public partial class Queue : IQueue
    {
        #region Properties

        private string _queueName;
        private readonly AliyunServiceClient _serviceClient;

        #endregion

        #region Constructor

        /// <summary>
        /// Instantiates Queue with the parameterized properties
        /// </summary>
        public Queue(string queueName, AliyunServiceClient serviceClient)
        {
            _queueName = queueName;
            _serviceClient = serviceClient;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets and sets the property QueueName
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        /// <summary>
        /// Check to see if QueueName property is set
        /// </summary>
        public bool IsSetQueueName()
        {
            return this._queueName != null;
        }

        #endregion


        #region DeleteMessage

        /// <inheritdoc/>
        public DeleteMessageResponse DeleteMessage(string receiptHandle)
        {
            var request = new DeleteMessageRequest {ReceiptHandle = receiptHandle};
            return DeleteMessage(request);
        }

        /// <inheritdoc/>
        public DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            request.QueueName = this.QueueName;

            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return _serviceClient.Invoke<DeleteMessageRequest, DeleteMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <inheritdoc/>
        public BatchDeleteMessageResponse BatchDeleteMessage(BatchDeleteMessageRequest request)
        {
            request.QueueName = this.QueueName;

            var marshaller = new BatchDeleteMessageRequestMarshaller();
            var unmarshaller = BatchDeleteMessageResponseUnmarshaller.Instance;

            return _serviceClient.Invoke<BatchDeleteMessageRequest, BatchDeleteMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <inheritdoc/>
        public IAsyncResult BeginDeleteMessage(DeleteMessageRequest request, AsyncCallback callback, object state)
        {
            request.QueueName = this.QueueName;

            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return _serviceClient.BeginInvoke<DeleteMessageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <inheritdoc/>
        public DeleteMessageResponse EndDeleteMessage(IAsyncResult asyncResult)
        {
            return AliyunServiceClient.EndInvoke<DeleteMessageResponse>(asyncResult);
        }

        /// <inheritdoc/>
        public IAsyncResult BeginBatchDeleteMessage(BatchDeleteMessageRequest request, AsyncCallback callback, object state)
        {
            request.QueueName = this.QueueName;

            var marshaller = new BatchDeleteMessageRequestMarshaller();
            var unmarshaller = BatchDeleteMessageResponseUnmarshaller.Instance;

            return _serviceClient.BeginInvoke<BatchDeleteMessageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <inheritdoc/>
        public BatchDeleteMessageResponse EndBatchDeleteMessage(IAsyncResult asyncResult)
        {
            return AliyunServiceClient.EndInvoke<BatchDeleteMessageResponse>(asyncResult);
        }

        #endregion

        #region ReceiveMessage

        /// <inheritdoc/>
        public ReceiveMessageResponse ReceiveMessage()
        {
            var request = new ReceiveMessageRequest();
            return ReceiveMessage(request);
        }

        /// <inheritdoc/>
        public ReceiveMessageResponse ReceiveMessage(uint waitSeconds)
        {
            var request = new ReceiveMessageRequest() {WaitSeconds = waitSeconds};
            return ReceiveMessage(request);
        }

        /// <inheritdoc/>
        public ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            request.QueueName = this.QueueName;

            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return _serviceClient.Invoke<ReceiveMessageRequest, ReceiveMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <inheritdoc/>
        public BatchReceiveMessageResponse BatchReceiveMessage(uint batchSize)
        {
            var request = new BatchReceiveMessageRequest(batchSize);
            return BatchReceiveMessage(request);
        }

        /// <inheritdoc/>
        public BatchReceiveMessageResponse BatchReceiveMessage(uint batchSize, uint waitSeconds)
        {
            var request = new BatchReceiveMessageRequest(batchSize, waitSeconds);
            return BatchReceiveMessage(request);
        }

        /// <inheritdoc/>
        public BatchReceiveMessageResponse BatchReceiveMessage(BatchReceiveMessageRequest request)
        {
            request.QueueName = this.QueueName;

            var marshaller = new BatchReceiveMessageRequestMarshaller();
            var unmarshaller = BatchReceiveMessageResponseUnmarshaller.Instance;

            return _serviceClient.Invoke<BatchReceiveMessageRequest, BatchReceiveMessageResponse>(request, marshaller, unmarshaller);
        }


        /// <inheritdoc/>
        public IAsyncResult BeginReceiveMessage(ReceiveMessageRequest request, AsyncCallback callback, object state)
        {
            request.QueueName = this.QueueName;

            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return _serviceClient.BeginInvoke<ReceiveMessageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <inheritdoc/>
        public ReceiveMessageResponse EndReceiveMessage(IAsyncResult asyncResult)
        {
            return AliyunServiceClient.EndInvoke<ReceiveMessageResponse>(asyncResult);
        }

        /// <inheritdoc/>
        public IAsyncResult BeginBatchReceiveMessage(BatchReceiveMessageRequest request, AsyncCallback callback, object state)
        {
            request.QueueName = this.QueueName;

            var marshaller = new BatchReceiveMessageRequestMarshaller();
            var unmarshaller = BatchReceiveMessageResponseUnmarshaller.Instance;

            return _serviceClient.BeginInvoke<BatchReceiveMessageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <inheritdoc/>
        public BatchReceiveMessageResponse EndBatchReceiveMessage(IAsyncResult asyncResult)
        {
            return AliyunServiceClient.EndInvoke<BatchReceiveMessageResponse>(asyncResult);
        }

        #endregion
    }
}
