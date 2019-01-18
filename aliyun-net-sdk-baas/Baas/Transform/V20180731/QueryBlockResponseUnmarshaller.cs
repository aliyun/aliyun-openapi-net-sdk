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
    public class QueryBlockResponseUnmarshaller
    {
        public static QueryBlockResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBlockResponse queryBlockResponse = new QueryBlockResponse();

			queryBlockResponse.HttpResponse = context.HttpResponse;
			queryBlockResponse.RequestId = context.StringValue("QueryBlock.RequestId");

			QueryBlockResponse.QueryBlock_Result result = new QueryBlockResponse.QueryBlock_Result();
			result.Alias = context.StringValue("QueryBlock.Result.Alias");
			result.BlockHash = context.StringValue("QueryBlock.Result.BlockHash");
			result.RootTxHash = context.StringValue("QueryBlock.Result.RootTxHash");
			result.Height = context.IntegerValue("QueryBlock.Result.Height");
			result.PreviousHash = context.StringValue("QueryBlock.Result.PreviousHash");
			result.CreateTime = context.LongValue("QueryBlock.Result.CreateTime");
			result.TransactionSize = context.IntegerValue("QueryBlock.Result.TransactionSize");
			result.TransSummaryList = context.StringValue("QueryBlock.Result.TransSummaryList");
			queryBlockResponse.Result = result;
        
			return queryBlockResponse;
        }
    }
}