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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class BatchInsertItemsResponseUnmarshaller
    {
        public static BatchInsertItemsResponse Unmarshall(UnmarshallerContext context)
        {
			BatchInsertItemsResponse batchInsertItemsResponse = new BatchInsertItemsResponse();

			batchInsertItemsResponse.HttpResponse = context.HttpResponse;
			batchInsertItemsResponse.RequestId = context.StringValue("BatchInsertItems.RequestId");
			batchInsertItemsResponse.Success = context.BooleanValue("BatchInsertItems.Success");
			batchInsertItemsResponse.Message = context.StringValue("BatchInsertItems.Message");
			batchInsertItemsResponse.ErrorCode = context.StringValue("BatchInsertItems.ErrorCode");

			List<BatchInsertItemsResponse.BatchInsertItems_BatchResult> batchInsertItemsResponse_batchResults = new List<BatchInsertItemsResponse.BatchInsertItems_BatchResult>();
			for (int i = 0; i < context.Length("BatchInsertItems.BatchResults.Length"); i++) {
				BatchInsertItemsResponse.BatchInsertItems_BatchResult batchResult = new BatchInsertItemsResponse.BatchInsertItems_BatchResult();
				batchResult.Index = context.IntegerValue("BatchInsertItems.BatchResults["+ i +"].Index");
				batchResult.Success = context.BooleanValue("BatchInsertItems.BatchResults["+ i +"].Success");
				batchResult.Message = context.StringValue("BatchInsertItems.BatchResults["+ i +"].Message");
				batchResult.ErrorCode = context.StringValue("BatchInsertItems.BatchResults["+ i +"].ErrorCode");

				batchInsertItemsResponse_batchResults.Add(batchResult);
			}
			batchInsertItemsResponse.BatchResults = batchInsertItemsResponse_batchResults;
        
			return batchInsertItemsResponse;
        }
    }
}
