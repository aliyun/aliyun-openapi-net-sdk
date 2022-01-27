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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryTaskDetailListResponseUnmarshaller
    {
        public static QueryTaskDetailListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskDetailListResponse queryTaskDetailListResponse = new QueryTaskDetailListResponse();

			queryTaskDetailListResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskDetailListResponse.RequestId = _ctx.StringValue("QueryTaskDetailList.RequestId");
			queryTaskDetailListResponse.TotalItemNum = _ctx.IntegerValue("QueryTaskDetailList.TotalItemNum");
			queryTaskDetailListResponse.CurrentPageNum = _ctx.IntegerValue("QueryTaskDetailList.CurrentPageNum");
			queryTaskDetailListResponse.TotalPageNum = _ctx.IntegerValue("QueryTaskDetailList.TotalPageNum");
			queryTaskDetailListResponse.PageSize = _ctx.IntegerValue("QueryTaskDetailList.PageSize");
			queryTaskDetailListResponse.PrePage = _ctx.BooleanValue("QueryTaskDetailList.PrePage");
			queryTaskDetailListResponse.NextPage = _ctx.BooleanValue("QueryTaskDetailList.NextPage");

			List<QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail> queryTaskDetailListResponse_data = new List<QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail>();
			for (int i = 0; i < _ctx.Length("QueryTaskDetailList.Data.Length"); i++) {
				QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail taskDetail = new QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail();
				taskDetail.TaskNo = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskNo");
				taskDetail.TaskDetailNo = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskDetailNo");
				taskDetail.TaskType = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskType");
				taskDetail.InstanceId = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].InstanceId");
				taskDetail.DomainName = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].DomainName");
				taskDetail.TaskStatus = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskStatus");
				taskDetail.UpdateTime = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].UpdateTime");
				taskDetail.CreateTime = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].CreateTime");
				taskDetail.TryCount = _ctx.IntegerValue("QueryTaskDetailList.Data["+ i +"].TryCount");
				taskDetail.ErrorMsg = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].ErrorMsg");
				taskDetail.TaskStatusCode = _ctx.IntegerValue("QueryTaskDetailList.Data["+ i +"].TaskStatusCode");
				taskDetail.TaskResult = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskResult");
				taskDetail.TaskTypeDescription = _ctx.StringValue("QueryTaskDetailList.Data["+ i +"].TaskTypeDescription");

				queryTaskDetailListResponse_data.Add(taskDetail);
			}
			queryTaskDetailListResponse.Data = queryTaskDetailListResponse_data;
        
			return queryTaskDetailListResponse;
        }
    }
}
