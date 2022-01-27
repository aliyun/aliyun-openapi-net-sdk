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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListOperationLogsResponseUnmarshaller
    {
        public static ListOperationLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOperationLogsResponse listOperationLogsResponse = new ListOperationLogsResponse();

			listOperationLogsResponse.HttpResponse = _ctx.HttpResponse;
			listOperationLogsResponse.RequestId = _ctx.StringValue("ListOperationLogs.RequestId");
			listOperationLogsResponse.Code = _ctx.IntegerValue("ListOperationLogs.Code");
			listOperationLogsResponse.Message = _ctx.StringValue("ListOperationLogs.Message");
			listOperationLogsResponse.TotalSize = _ctx.IntegerValue("ListOperationLogs.TotalSize");
			listOperationLogsResponse.CurrentPage = _ctx.IntegerValue("ListOperationLogs.CurrentPage");
			listOperationLogsResponse.PageSize = _ctx.IntegerValue("ListOperationLogs.PageSize");

			List<ListOperationLogsResponse.ListOperationLogs_Log> listOperationLogsResponse_logList = new List<ListOperationLogsResponse.ListOperationLogs_Log>();
			for (int i = 0; i < _ctx.Length("ListOperationLogs.LogList.Length"); i++) {
				ListOperationLogsResponse.ListOperationLogs_Log log = new ListOperationLogsResponse.ListOperationLogs_Log();
				log.ActionGroup = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].ActionGroup");
				log.ActionName = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].ActionName");
				log.BeginTime = _ctx.LongValue("ListOperationLogs.LogList["+ i +"].BeginTime");
				log.EndTime = _ctx.LongValue("ListOperationLogs.LogList["+ i +"].EndTime");
				log.OperatorName = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].OperatorName");
				log.OperatorId = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].OperatorId");
				log.Source = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].Source");
				log.Status = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].Status");
				log.Message = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].Message");
				log.ExtraParameters = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].ExtraParameters");
				log.AppId = _ctx.StringValue("ListOperationLogs.LogList["+ i +"].AppId");

				listOperationLogsResponse_logList.Add(log);
			}
			listOperationLogsResponse.LogList = listOperationLogsResponse_logList;
        
			return listOperationLogsResponse;
        }
    }
}
