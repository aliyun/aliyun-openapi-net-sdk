/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using Aliyun.Acs.Dybaseapi.MNS.Model;
using System.Collections.Generic;

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// Interface for accessing MNS queue
    /// </summary>
    public partial interface IQueue
    {
        
        #region  DeleteMessage

        /// <summary>
        /// Deletes the specified message from the specified queue. 
        /// </summary>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        /// 
        /// <returns>The response returned by the MNS DeleteMessage service.</returns>
        /// <exception cref="ReceiptHandleErrorException">
        /// The receipt handle you provide is not valid.
        /// </exception>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The value of Element should between Low and High seconds/bytes.
        /// </exception>
        DeleteMessageResponse DeleteMessage(string receiptHandle);

        /// <summary>
        /// Deletes the specified message from the specified queue. 
        /// </summary>
        /// <param name="request">The request object to be sent to MNS DeleteMessage service.</param>
        /// 
        /// <returns>The response returned by the MNS DeleteMessage service.</returns>
        /// <exception cref="ReceiptHandleErrorException">
        /// The receipt handle you provide is not valid.
        /// </exception>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The value of Element should between Low and High seconds/bytes.
        /// </exception>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);

        /// <summary>
        /// Deletes the specified message from the specified queue. 
        /// </summary>
        /// <param name="request">The request object to be sent to MNS BatchDeleteMessage service.</param>
        /// 
        /// <returns>The response returned by the MNS BatchDeleteMessage service.</returns>
        /// <exception cref="ReceiptHandleErrorException">
        /// The receipt handle you provide is not valid.
        /// </exception>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="InvalidArgumentException">
        /// The value of Element should between MIN and MAX seconds/bytes.
        /// </exception>
        /// <exception cref="BatchDeleteFailException">
        /// Some messages are not deleted.
        /// </exception>
        BatchDeleteMessageResponse BatchDeleteMessage(BatchDeleteMessageRequest request);

        /// <summary>
        /// Begins an asynchronous request to MNS DeleteMessage service.
        /// </summary>
        /// 
        /// <param name="request">The request object to be sent to MNS DeleteMessage service.</param>
        /// <param name="callback">The AsyncCallback delegate.</param>
        /// <param name="state">The state object for this request.</param>
        /// 
        /// <returns>An IAsyncResult that references the asynchronous request for a response.</returns>
        IAsyncResult BeginDeleteMessage(DeleteMessageRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Ends an asynchronous request for MNS DeleteMessage service.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessage.</param>
        /// 
        /// <returns>The response returned by the MNS DeleteMessage service.</returns>
        DeleteMessageResponse EndDeleteMessage(IAsyncResult asyncResult);

        /// <summary>
        /// Begins an asynchronous request to MNS BatchDeleteMessage service.
        /// </summary>
        /// 
        /// <param name="request">The request object to be sent to MNS BatchDeleteMessage service.</param>
        /// <param name="callback">The AsyncCallback delegate.</param>
        /// <param name="state">The state object for this request.</param>
        /// 
        /// <returns>An IAsyncResult that references the asynchronous request for a response.</returns>
        IAsyncResult BeginBatchDeleteMessage(BatchDeleteMessageRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Ends an asynchronous request for MNS BatchDeleteMessage service.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteMessage.</param>
        /// 
        /// <returns>The response returned by the MNS BatchDeleteMessage service.</returns>
        BatchDeleteMessageResponse EndBatchDeleteMessage(IAsyncResult asyncResult);

        #endregion

        #region  ReceiveMessage

        /// <summary>
        /// Retrieves one message from this queue.
        /// </summary>
        /// 
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// 
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        ReceiveMessageResponse ReceiveMessage();

        /// <summary>
        /// Retrieves one message.
        /// </summary>
        /// <param name="waitSeconds">Wait polling time for this request.</param>
        ///  
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        ReceiveMessageResponse ReceiveMessage(uint waitSeconds);

        /// <summary>
        /// Retrieves one message.
        /// </summary>
        ///  <param name="request">The request object to be sent to MNS ReceiveMessage service.</param>
        /// 
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request);

        /// <summary>
        /// batch retrieves messages.
        /// </summary>
        /// <param name="batchSize">the most count limit of retrieved messages</param>
        /// <param name="waitSeconds">Wait polling time for this request.</param>
        ///  
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        BatchReceiveMessageResponse BatchReceiveMessage(uint batchSize);

        /// <summary>
        /// batch retrieves messages.
        /// </summary>
        /// <param name="batchSize">the most count limit of retrieved messages</param>
        /// <param name="waitSeconds">Wait polling time for this request.</param>
        ///  
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        BatchReceiveMessageResponse BatchReceiveMessage(uint batchSize, uint waitSeconds);

        /// <summary>
        /// batch retrieves messages.
        /// </summary>
        /// <param name="batchSize">the most count limit of retrieved messages</param>
        /// <param name="waitSeconds">Wait polling time for this request.</param>
        ///  
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        /// <exception cref="QueueNotExistException">
        /// The queue name you provided is not exist.
        /// </exception>
        /// <exception cref="MessageNotExistException">
        /// no messages exist.
        /// </exception>
        BatchReceiveMessageResponse BatchReceiveMessage(BatchReceiveMessageRequest request);

        /// <summary>
        /// Begins an asynchronous request to MNS ReceiveMessage service.
        /// </summary>
        /// 
        /// <param name="request">The request object to be sent to MNS ReceiveMessage service.</param>
        /// <param name="callback">The AsyncCallback delegate.</param>
        /// <param name="state">The state object for this request.</param>
        /// 
        /// <returns>An IAsyncResult that references the asynchronous request for a response.</returns>
        IAsyncResult BeginReceiveMessage(ReceiveMessageRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Ends an asynchronous request for MNS ReceiveMessage service.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReceiveMessage.</param>
        /// 
        /// <returns>The response returned by the MNS ReceiveMessage service.</returns>
        ReceiveMessageResponse EndReceiveMessage(IAsyncResult asyncResult);

        /// <summary>
        /// Begins an asynchronous request to MNS BatchReceiveMessage service.
        /// </summary>
        /// 
        /// <param name="request">The request object to be sent to MNS BatchReceiveMessage service.</param>
        /// <param name="callback">The AsyncCallback delegate.</param>
        /// <param name="state">The state object for this request.</param>
        /// 
        /// <returns>An IAsyncResult that references the asynchronous request for a response.</returns>
        IAsyncResult BeginBatchReceiveMessage(BatchReceiveMessageRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Ends an asynchronous request for MNS BatchReceiveMessage service.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchReceiveMessage.</param>
        /// 
        /// <returns>The response returned by the MNS BatchReceiveMessage service.</returns>
        BatchReceiveMessageResponse EndBatchReceiveMessage(IAsyncResult asyncResult);

        #endregion
    }
}
