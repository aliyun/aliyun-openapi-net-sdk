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
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryBatchTaskDetailListResponseUnmarshaller
    {
        public static QueryBatchTaskDetailListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBatchTaskDetailListResponse queryBatchTaskDetailListResponse = new QueryBatchTaskDetailListResponse();

			queryBatchTaskDetailListResponse.HttpResponse = context.HttpResponse;
			queryBatchTaskDetailListResponse.RequestId = context.StringValue("QueryBatchTaskDetailList.RequestId");
			queryBatchTaskDetailListResponse.TotalItemNum = context.IntegerValue("QueryBatchTaskDetailList.TotalItemNum");
			queryBatchTaskDetailListResponse.CurrentPageNum = context.IntegerValue("QueryBatchTaskDetailList.CurrentPageNum");
			queryBatchTaskDetailListResponse.TotalPageNum = context.IntegerValue("QueryBatchTaskDetailList.TotalPageNum");
			queryBatchTaskDetailListResponse.PageSize = context.IntegerValue("QueryBatchTaskDetailList.PageSize");
			queryBatchTaskDetailListResponse.PrePage = context.BooleanValue("QueryBatchTaskDetailList.PrePage");
			queryBatchTaskDetailListResponse.NextPage = context.BooleanValue("QueryBatchTaskDetailList.NextPage");

			List<QueryBatchTaskDetailListResponse.QueryBatchTaskDetailList_TaskDetail> queryBatchTaskDetailListResponse_data = new List<QueryBatchTaskDetailListResponse.QueryBatchTaskDetailList_TaskDetail>();
			for (int i = 0; i < context.Length("QueryBatchTaskDetailList.Data.Length"); i++) {
				QueryBatchTaskDetailListResponse.QueryBatchTaskDetailList_TaskDetail taskDetail = new QueryBatchTaskDetailListResponse.QueryBatchTaskDetailList_TaskDetail();
				taskDetail.TaskNo = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].TaskNo");
				taskDetail.TaskType = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].TaskType");
				taskDetail.DomainName = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].DomainName");
				taskDetail.TaskStatus = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].TaskStatus");
				taskDetail.UpdateTime = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].UpdateTime");
				taskDetail.TryCount = context.IntegerValue("QueryBatchTaskDetailList.Data["+ i +"].TryCount");
				taskDetail.ErrorMsg = context.StringValue("QueryBatchTaskDetailList.Data["+ i +"].ErrorMsg");

				queryBatchTaskDetailListResponse_data.Add(taskDetail);
			}
			queryBatchTaskDetailListResponse.Data = queryBatchTaskDetailListResponse_data;
        
			return queryBatchTaskDetailListResponse;
        }
    }
}