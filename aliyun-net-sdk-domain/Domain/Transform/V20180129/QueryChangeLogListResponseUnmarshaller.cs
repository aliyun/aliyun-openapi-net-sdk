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
    public class QueryChangeLogListResponseUnmarshaller
    {
        public static QueryChangeLogListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryChangeLogListResponse queryChangeLogListResponse = new QueryChangeLogListResponse();

			queryChangeLogListResponse.HttpResponse = context.HttpResponse;
			queryChangeLogListResponse.RequestId = context.StringValue("QueryChangeLogList.RequestId");
			queryChangeLogListResponse.TotalItemNum = context.IntegerValue("QueryChangeLogList.TotalItemNum");
			queryChangeLogListResponse.CurrentPageNum = context.IntegerValue("QueryChangeLogList.CurrentPageNum");
			queryChangeLogListResponse.TotalPageNum = context.IntegerValue("QueryChangeLogList.TotalPageNum");
			queryChangeLogListResponse.PageSize = context.IntegerValue("QueryChangeLogList.PageSize");
			queryChangeLogListResponse.PrePage = context.BooleanValue("QueryChangeLogList.PrePage");
			queryChangeLogListResponse.NextPage = context.BooleanValue("QueryChangeLogList.NextPage");
			queryChangeLogListResponse.ResultLimit = context.BooleanValue("QueryChangeLogList.ResultLimit");

			List<QueryChangeLogListResponse.QueryChangeLogList_ChangeLog> queryChangeLogListResponse_data = new List<QueryChangeLogListResponse.QueryChangeLogList_ChangeLog>();
			for (int i = 0; i < context.Length("QueryChangeLogList.Data.Length"); i++) {
				QueryChangeLogListResponse.QueryChangeLogList_ChangeLog changeLog = new QueryChangeLogListResponse.QueryChangeLogList_ChangeLog();
				changeLog.DomainName = context.StringValue("QueryChangeLogList.Data["+ i +"].DomainName");
				changeLog.Result = context.StringValue("QueryChangeLogList.Data["+ i +"].Result");
				changeLog.Operation = context.StringValue("QueryChangeLogList.Data["+ i +"].Operation");
				changeLog.OperationIPAddress = context.StringValue("QueryChangeLogList.Data["+ i +"].OperationIPAddress");
				changeLog.Details = context.StringValue("QueryChangeLogList.Data["+ i +"].Details");
				changeLog.Time = context.StringValue("QueryChangeLogList.Data["+ i +"].Time");

				queryChangeLogListResponse_data.Add(changeLog);
			}
			queryChangeLogListResponse.Data = queryChangeLogListResponse_data;
        
			return queryChangeLogListResponse;
        }
    }
}
