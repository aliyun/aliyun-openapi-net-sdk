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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListClusterLogsResponseUnmarshaller
    {
        public static ListClusterLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterLogsResponse listClusterLogsResponse = new ListClusterLogsResponse();

			listClusterLogsResponse.HttpResponse = _ctx.HttpResponse;
			listClusterLogsResponse.RequestId = _ctx.StringValue("ListClusterLogs.RequestId");
			listClusterLogsResponse.TotalCount = _ctx.IntegerValue("ListClusterLogs.TotalCount");
			listClusterLogsResponse.PageNumber = _ctx.IntegerValue("ListClusterLogs.PageNumber");
			listClusterLogsResponse.PageSize = _ctx.IntegerValue("ListClusterLogs.PageSize");
			listClusterLogsResponse.ClusterId = _ctx.StringValue("ListClusterLogs.ClusterId");

			List<ListClusterLogsResponse.ListClusterLogs_LogInfo> listClusterLogsResponse_logs = new List<ListClusterLogsResponse.ListClusterLogs_LogInfo>();
			for (int i = 0; i < _ctx.Length("ListClusterLogs.Logs.Length"); i++) {
				ListClusterLogsResponse.ListClusterLogs_LogInfo logInfo = new ListClusterLogsResponse.ListClusterLogs_LogInfo();
				logInfo.Operation = _ctx.StringValue("ListClusterLogs.Logs["+ i +"].Operation");
				logInfo.Level = _ctx.StringValue("ListClusterLogs.Logs["+ i +"].Level");
				logInfo.Message = _ctx.StringValue("ListClusterLogs.Logs["+ i +"].Message");
				logInfo.CreateTime = _ctx.StringValue("ListClusterLogs.Logs["+ i +"].CreateTime");

				listClusterLogsResponse_logs.Add(logInfo);
			}
			listClusterLogsResponse.Logs = listClusterLogsResponse_logs;
        
			return listClusterLogsResponse;
        }
    }
}
