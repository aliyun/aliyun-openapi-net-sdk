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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListQuotaReviewTasksResponseUnmarshaller
    {
        public static ListQuotaReviewTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaReviewTasksResponse listQuotaReviewTasksResponse = new ListQuotaReviewTasksResponse();

			listQuotaReviewTasksResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaReviewTasksResponse.TotalCount = _ctx.IntegerValue("ListQuotaReviewTasks.totalCount");
			listQuotaReviewTasksResponse.RequestId = _ctx.StringValue("ListQuotaReviewTasks.requestId");

			List<ListQuotaReviewTasksResponse.ListQuotaReviewTasks_ResultItem> listQuotaReviewTasksResponse_result = new List<ListQuotaReviewTasksResponse.ListQuotaReviewTasks_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListQuotaReviewTasks.Result.Length"); i++) {
				ListQuotaReviewTasksResponse.ListQuotaReviewTasks_ResultItem resultItem = new ListQuotaReviewTasksResponse.ListQuotaReviewTasks_ResultItem();
				resultItem.OldDocSize = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].oldDocSize");
				resultItem.Pending = _ctx.BooleanValue("ListQuotaReviewTasks.Result["+ i +"].pending");
				resultItem.Memo = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].memo");
				resultItem.Approved = _ctx.BooleanValue("ListQuotaReviewTasks.Result["+ i +"].approved");
				resultItem.OldSpec = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].oldSpec");
				resultItem.OldComputeResource = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].oldComputeResource");
				resultItem.AppGroupType = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].appGroupType");
				resultItem.Available = _ctx.BooleanValue("ListQuotaReviewTasks.Result["+ i +"].available");
				resultItem.GmtCreate = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].gmtCreate");
				resultItem.NewSocSize = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].newSocSize");
				resultItem.Id = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].id");
				resultItem.AppGroupId = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].appGroupId");
				resultItem.NewComputeResource = _ctx.IntegerValue("ListQuotaReviewTasks.Result["+ i +"].newComputeResource");
				resultItem.AppGroupName = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].appGroupName");
				resultItem.GmtModified = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].gmtModified");
				resultItem.NewSpec = _ctx.StringValue("ListQuotaReviewTasks.Result["+ i +"].newSpec");

				listQuotaReviewTasksResponse_result.Add(resultItem);
			}
			listQuotaReviewTasksResponse.Result = listQuotaReviewTasksResponse_result;
        
			return listQuotaReviewTasksResponse;
        }
    }
}
