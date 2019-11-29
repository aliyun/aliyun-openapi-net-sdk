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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class BatchInsertItemsResponseUnmarshaller
    {
        public static BatchInsertItemsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchInsertItemsResponse batchInsertItemsResponse = new BatchInsertItemsResponse();

			batchInsertItemsResponse.HttpResponse = context.HttpResponse;
			batchInsertItemsResponse.ErrorMessage = context.StringValue("BatchInsertItems.ErrorMessage");
			batchInsertItemsResponse.ErrorCode = context.StringValue("BatchInsertItems.ErrorCode");
			batchInsertItemsResponse.Message = context.StringValue("BatchInsertItems.Message");
			batchInsertItemsResponse.DynamicCode = context.StringValue("BatchInsertItems.DynamicCode");
			batchInsertItemsResponse.Code = context.StringValue("BatchInsertItems.Code");
			batchInsertItemsResponse.DynamicMessage = context.StringValue("BatchInsertItems.DynamicMessage");
			batchInsertItemsResponse.RequestId = context.StringValue("BatchInsertItems.RequestId");
			batchInsertItemsResponse.Success = context.BooleanValue("BatchInsertItems.Success");

			List<BatchInsertItemsResponse.BatchInsertItems_BatchResult> batchInsertItemsResponse_batchResults = new List<BatchInsertItemsResponse.BatchInsertItems_BatchResult>();
			for (int i = 0; i < context.Length("BatchInsertItems.BatchResults.Length"); i++) {
				BatchInsertItemsResponse.BatchInsertItems_BatchResult batchResult = new BatchInsertItemsResponse.BatchInsertItems_BatchResult();
				batchResult.Message = context.StringValue("BatchInsertItems.BatchResults["+ i +"].Message");
				batchResult.Index = context.IntegerValue("BatchInsertItems.BatchResults["+ i +"].Index");
				batchResult.ErrorCode = context.StringValue("BatchInsertItems.BatchResults["+ i +"].ErrorCode");
				batchResult.Success = context.BooleanValue("BatchInsertItems.BatchResults["+ i +"].Success");

				batchInsertItemsResponse_batchResults.Add(batchResult);
			}
			batchInsertItemsResponse.BatchResults = batchInsertItemsResponse_batchResults;
        
			return batchInsertItemsResponse;
        }
    }
}
