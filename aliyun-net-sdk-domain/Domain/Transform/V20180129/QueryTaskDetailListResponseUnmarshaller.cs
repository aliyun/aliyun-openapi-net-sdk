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
        public static QueryTaskDetailListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTaskDetailListResponse queryTaskDetailListResponse = new QueryTaskDetailListResponse();

			queryTaskDetailListResponse.HttpResponse = context.HttpResponse;
			queryTaskDetailListResponse.RequestId = context.StringValue("QueryTaskDetailList.RequestId");
			queryTaskDetailListResponse.TotalItemNum = context.IntegerValue("QueryTaskDetailList.TotalItemNum");
			queryTaskDetailListResponse.CurrentPageNum = context.IntegerValue("QueryTaskDetailList.CurrentPageNum");
			queryTaskDetailListResponse.TotalPageNum = context.IntegerValue("QueryTaskDetailList.TotalPageNum");
			queryTaskDetailListResponse.PageSize = context.IntegerValue("QueryTaskDetailList.PageSize");
			queryTaskDetailListResponse.PrePage = context.BooleanValue("QueryTaskDetailList.PrePage");
			queryTaskDetailListResponse.NextPage = context.BooleanValue("QueryTaskDetailList.NextPage");

			List<QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail> queryTaskDetailListResponse_data = new List<QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail>();
			for (int i = 0; i < context.Length("QueryTaskDetailList.Data.Length"); i++) {
				QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail taskDetail = new QueryTaskDetailListResponse.QueryTaskDetailList_TaskDetail();
				taskDetail.TaskNo = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskNo");
				taskDetail.TaskDetailNo = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskDetailNo");
				taskDetail.TaskType = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskType");
				taskDetail.InstanceId = context.StringValue("QueryTaskDetailList.Data["+ i +"].InstanceId");
				taskDetail.DomainName = context.StringValue("QueryTaskDetailList.Data["+ i +"].DomainName");
				taskDetail.TaskStatus = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskStatus");
				taskDetail.UpdateTime = context.StringValue("QueryTaskDetailList.Data["+ i +"].UpdateTime");
				taskDetail.CreateTime = context.StringValue("QueryTaskDetailList.Data["+ i +"].CreateTime");
				taskDetail.TryCount = context.IntegerValue("QueryTaskDetailList.Data["+ i +"].TryCount");
				taskDetail.ErrorMsg = context.StringValue("QueryTaskDetailList.Data["+ i +"].ErrorMsg");
				taskDetail.TaskStatusCode = context.IntegerValue("QueryTaskDetailList.Data["+ i +"].TaskStatusCode");
				taskDetail.TaskResult = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskResult");
				taskDetail.TaskTypeDescription = context.StringValue("QueryTaskDetailList.Data["+ i +"].TaskTypeDescription");

				queryTaskDetailListResponse_data.Add(taskDetail);
			}
			queryTaskDetailListResponse.Data = queryTaskDetailListResponse_data;
        
			return queryTaskDetailListResponse;
        }
    }
}
