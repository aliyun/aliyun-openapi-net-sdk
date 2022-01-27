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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackGroupOperationResultsResponseUnmarshaller
    {
        public static ListStackGroupOperationResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackGroupOperationResultsResponse listStackGroupOperationResultsResponse = new ListStackGroupOperationResultsResponse();

			listStackGroupOperationResultsResponse.HttpResponse = _ctx.HttpResponse;
			listStackGroupOperationResultsResponse.RequestId = _ctx.StringValue("ListStackGroupOperationResults.RequestId");
			listStackGroupOperationResultsResponse.PageNumber = _ctx.IntegerValue("ListStackGroupOperationResults.PageNumber");
			listStackGroupOperationResultsResponse.PageSize = _ctx.IntegerValue("ListStackGroupOperationResults.PageSize");
			listStackGroupOperationResultsResponse.TotalCount = _ctx.IntegerValue("ListStackGroupOperationResults.TotalCount");

			List<ListStackGroupOperationResultsResponse.ListStackGroupOperationResults_StackGroupOperationResult> listStackGroupOperationResultsResponse_stackGroupOperationResults = new List<ListStackGroupOperationResultsResponse.ListStackGroupOperationResults_StackGroupOperationResult>();
			for (int i = 0; i < _ctx.Length("ListStackGroupOperationResults.StackGroupOperationResults.Length"); i++) {
				ListStackGroupOperationResultsResponse.ListStackGroupOperationResults_StackGroupOperationResult stackGroupOperationResult = new ListStackGroupOperationResultsResponse.ListStackGroupOperationResults_StackGroupOperationResult();
				stackGroupOperationResult.AccountId = _ctx.StringValue("ListStackGroupOperationResults.StackGroupOperationResults["+ i +"].AccountId");
				stackGroupOperationResult.RegionId = _ctx.StringValue("ListStackGroupOperationResults.StackGroupOperationResults["+ i +"].RegionId");
				stackGroupOperationResult.Status = _ctx.StringValue("ListStackGroupOperationResults.StackGroupOperationResults["+ i +"].Status");
				stackGroupOperationResult.StatusReason = _ctx.StringValue("ListStackGroupOperationResults.StackGroupOperationResults["+ i +"].StatusReason");

				listStackGroupOperationResultsResponse_stackGroupOperationResults.Add(stackGroupOperationResult);
			}
			listStackGroupOperationResultsResponse.StackGroupOperationResults = listStackGroupOperationResultsResponse_stackGroupOperationResults;
        
			return listStackGroupOperationResultsResponse;
        }
    }
}
