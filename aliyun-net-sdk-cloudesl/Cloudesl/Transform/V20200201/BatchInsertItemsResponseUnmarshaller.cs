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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class BatchInsertItemsResponseUnmarshaller
    {
        public static BatchInsertItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchInsertItemsResponse batchInsertItemsResponse = new BatchInsertItemsResponse();

			batchInsertItemsResponse.HttpResponse = _ctx.HttpResponse;
			batchInsertItemsResponse.ErrorMessage = _ctx.StringValue("BatchInsertItems.ErrorMessage");
			batchInsertItemsResponse.ErrorCode = _ctx.StringValue("BatchInsertItems.ErrorCode");
			batchInsertItemsResponse.Message = _ctx.StringValue("BatchInsertItems.Message");
			batchInsertItemsResponse.DynamicCode = _ctx.StringValue("BatchInsertItems.DynamicCode");
			batchInsertItemsResponse.Code = _ctx.StringValue("BatchInsertItems.Code");
			batchInsertItemsResponse.DynamicMessage = _ctx.StringValue("BatchInsertItems.DynamicMessage");
			batchInsertItemsResponse.RequestId = _ctx.StringValue("BatchInsertItems.RequestId");
			batchInsertItemsResponse.Success = _ctx.BooleanValue("BatchInsertItems.Success");

			List<BatchInsertItemsResponse.BatchInsertItems_BatchResult> batchInsertItemsResponse_batchResults = new List<BatchInsertItemsResponse.BatchInsertItems_BatchResult>();
			for (int i = 0; i < _ctx.Length("BatchInsertItems.BatchResults.Length"); i++) {
				BatchInsertItemsResponse.BatchInsertItems_BatchResult batchResult = new BatchInsertItemsResponse.BatchInsertItems_BatchResult();
				batchResult.Message = _ctx.StringValue("BatchInsertItems.BatchResults["+ i +"].Message");
				batchResult.Index = _ctx.IntegerValue("BatchInsertItems.BatchResults["+ i +"].Index");
				batchResult.ErrorCode = _ctx.StringValue("BatchInsertItems.BatchResults["+ i +"].ErrorCode");
				batchResult.Success = _ctx.BooleanValue("BatchInsertItems.BatchResults["+ i +"].Success");

				batchInsertItemsResponse_batchResults.Add(batchResult);
			}
			batchInsertItemsResponse.BatchResults = batchInsertItemsResponse_batchResults;
        
			return batchInsertItemsResponse;
        }
    }
}
