/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class CreateTransactionResponseUnmarshaller
    {
        public static CreateTransactionResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTransactionResponse createTransactionResponse = new CreateTransactionResponse();

			createTransactionResponse.HttpResponse = context.HttpResponse;
			createTransactionResponse.Code = context.StringValue("CreateTransaction.Code");
			createTransactionResponse.Message = context.StringValue("CreateTransaction.Message");
			createTransactionResponse.RequestId = context.StringValue("CreateTransaction.RequestId");
			createTransactionResponse.Action = context.StringValue("CreateTransaction.Action");

			CreateTransactionResponse.CreateTransaction_Transaction transaction = new CreateTransactionResponse.CreateTransaction_Transaction();

			CreateTransactionResponse.CreateTransaction_Transaction.CreateTransaction_Upload upload = new CreateTransactionResponse.CreateTransaction_Transaction.CreateTransaction_Upload();
			upload.Bucket = context.StringValue("CreateTransaction.Transaction.Upload.Bucket");
			upload.FileId = context.StringValue("CreateTransaction.Transaction.Upload.FileId");
			upload.OssEndpoint = context.StringValue("CreateTransaction.Transaction.Upload.OssEndpoint");
			upload.ObjectKey = context.StringValue("CreateTransaction.Transaction.Upload.ObjectKey");
			upload.SessionId = context.StringValue("CreateTransaction.Transaction.Upload.SessionId");
			upload.AccessKeyId = context.StringValue("CreateTransaction.Transaction.Upload.AccessKeyId");
			upload.AccessKeySecret = context.StringValue("CreateTransaction.Transaction.Upload.AccessKeySecret");
			upload.StsToken = context.StringValue("CreateTransaction.Transaction.Upload.StsToken");
			transaction.Upload = upload;
			createTransactionResponse.Transaction = transaction;
        
			return createTransactionResponse;
        }
    }
}