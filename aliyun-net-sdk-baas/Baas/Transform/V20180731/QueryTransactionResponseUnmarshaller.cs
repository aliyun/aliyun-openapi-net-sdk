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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class QueryTransactionResponseUnmarshaller
    {
        public static QueryTransactionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTransactionResponse queryTransactionResponse = new QueryTransactionResponse();

			queryTransactionResponse.HttpResponse = context.HttpResponse;
			queryTransactionResponse.RequestId = context.StringValue("QueryTransaction.RequestId");

			QueryTransactionResponse.QueryTransaction_Result result = new QueryTransactionResponse.QueryTransaction_Result();
			result.Hash = context.StringValue("QueryTransaction.Result.Hash");
			result.BlockHeight = context.LongValue("QueryTransaction.Result.BlockHeight");
			result.BlockVersion = context.IntegerValue("QueryTransaction.Result.BlockVersion");
			result.CreateTime = context.LongValue("QueryTransaction.Result.CreateTime");
			result.Category = context.IntegerValue("QueryTransaction.Result.Category");
			result.Type = context.IntegerValue("QueryTransaction.Result.Type");
			result.ReferenceCount = context.IntegerValue("QueryTransaction.Result.ReferenceCount");
			result.Content = context.StringValue("QueryTransaction.Result.Content");
			result.ContentHash = context.StringValue("QueryTransaction.Result.ContentHash");
			result.KeyWrap = context.StringValue("QueryTransaction.Result.KeyWrap");
			result.Nonce = context.StringValue("QueryTransaction.Result.Nonce");
			result.KeyName = context.StringValue("QueryTransaction.Result.KeyName");

			QueryTransactionResponse.QueryTransaction_Result.QueryTransaction_ReferenceList referenceList = new QueryTransactionResponse.QueryTransaction_Result.QueryTransaction_ReferenceList();
			referenceList.Type = context.IntegerValue("QueryTransaction.Result.ReferenceList.Type");
			referenceList.Length = context.IntegerValue("QueryTransaction.Result.ReferenceList.Length");
			referenceList.Data = context.StringValue("QueryTransaction.Result.ReferenceList.Data");
			result.ReferenceList = referenceList;
			queryTransactionResponse.Result = result;
        
			return queryTransactionResponse;
        }
    }
}