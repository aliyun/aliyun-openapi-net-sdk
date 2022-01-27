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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class ListEmrHiveAuditLogsResponseUnmarshaller
    {
        public static ListEmrHiveAuditLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmrHiveAuditLogsResponse listEmrHiveAuditLogsResponse = new ListEmrHiveAuditLogsResponse();

			listEmrHiveAuditLogsResponse.HttpResponse = _ctx.HttpResponse;
			listEmrHiveAuditLogsResponse.ErrorCode = _ctx.StringValue("ListEmrHiveAuditLogs.ErrorCode");
			listEmrHiveAuditLogsResponse.ErrorMessage = _ctx.StringValue("ListEmrHiveAuditLogs.ErrorMessage");
			listEmrHiveAuditLogsResponse.RequestId = _ctx.StringValue("ListEmrHiveAuditLogs.RequestId");

			ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data data = new ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data();
			data.PageNumber = _ctx.IntegerValue("ListEmrHiveAuditLogs.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListEmrHiveAuditLogs.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListEmrHiveAuditLogs.Data.TotalCount");

			List<ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data.ListEmrHiveAuditLogs_AuditLog> data_pagedData = new List<ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data.ListEmrHiveAuditLogs_AuditLog>();
			for (int i = 0; i < _ctx.Length("ListEmrHiveAuditLogs.Data.PagedData.Length"); i++) {
				ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data.ListEmrHiveAuditLogs_AuditLog auditLog = new ListEmrHiveAuditLogsResponse.ListEmrHiveAuditLogs_Data.ListEmrHiveAuditLogs_AuditLog();
				auditLog.Table = _ctx.StringValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].Table");
				auditLog.Database = _ctx.StringValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].Database");
				auditLog.User = _ctx.StringValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].User");
				auditLog.Operation = _ctx.StringValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].Operation");
				auditLog.EventTime = _ctx.LongValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].EventTime");

				List<string> auditLog_groups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].Groups.Length"); j++) {
					auditLog_groups.Add(_ctx.StringValue("ListEmrHiveAuditLogs.Data.PagedData["+ i +"].Groups["+ j +"]"));
				}
				auditLog.Groups = auditLog_groups;

				data_pagedData.Add(auditLog);
			}
			data.PagedData = data_pagedData;
			listEmrHiveAuditLogsResponse.Data = data;
        
			return listEmrHiveAuditLogsResponse;
        }
    }
}
