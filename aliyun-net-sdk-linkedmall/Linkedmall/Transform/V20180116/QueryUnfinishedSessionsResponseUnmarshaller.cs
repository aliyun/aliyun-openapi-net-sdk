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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryUnfinishedSessionsResponseUnmarshaller
    {
        public static QueryUnfinishedSessionsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUnfinishedSessionsResponse queryUnfinishedSessionsResponse = new QueryUnfinishedSessionsResponse();

			queryUnfinishedSessionsResponse.HttpResponse = context.HttpResponse;
			queryUnfinishedSessionsResponse.Code = context.StringValue("QueryUnfinishedSessions.Code");
			queryUnfinishedSessionsResponse.Message = context.StringValue("QueryUnfinishedSessions.Message");
			queryUnfinishedSessionsResponse.RequestId = context.StringValue("QueryUnfinishedSessions.RequestId");
			queryUnfinishedSessionsResponse.TotalCount = context.LongValue("QueryUnfinishedSessions.TotalCount");
			queryUnfinishedSessionsResponse.PageNumber = context.LongValue("QueryUnfinishedSessions.PageNumber");
			queryUnfinishedSessionsResponse.PageSize = context.LongValue("QueryUnfinishedSessions.PageSize");

			List<QueryUnfinishedSessionsResponse.QueryUnfinishedSessions_LmActivitySessionModel> queryUnfinishedSessionsResponse_lmActivitySessionModelList = new List<QueryUnfinishedSessionsResponse.QueryUnfinishedSessions_LmActivitySessionModel>();
			for (int i = 0; i < context.Length("QueryUnfinishedSessions.LmActivitySessionModelList.Length"); i++) {
				QueryUnfinishedSessionsResponse.QueryUnfinishedSessions_LmActivitySessionModel lmActivitySessionModel = new QueryUnfinishedSessionsResponse.QueryUnfinishedSessions_LmActivitySessionModel();
				lmActivitySessionModel.StartDate = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].StartDate");
				lmActivitySessionModel.SubBizCode = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].SubBizCode");
				lmActivitySessionModel.Name = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].Name");
				lmActivitySessionModel.LmActivityId = context.LongValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].LmActivityId");
				lmActivitySessionModel.LmSessionId = context.LongValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].LmSessionId");
				lmActivitySessionModel.EndDate = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].EndDate");
				lmActivitySessionModel.DisplayDate = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].DisplayDate");
				lmActivitySessionModel.Description = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].Description");
				lmActivitySessionModel.BizId = context.StringValue("QueryUnfinishedSessions.LmActivitySessionModelList["+ i +"].BizId");

				queryUnfinishedSessionsResponse_lmActivitySessionModelList.Add(lmActivitySessionModel);
			}
			queryUnfinishedSessionsResponse.LmActivitySessionModelList = queryUnfinishedSessionsResponse_lmActivitySessionModelList;
        
			return queryUnfinishedSessionsResponse;
        }
    }
}
