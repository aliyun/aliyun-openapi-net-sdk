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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListProxySQLExecAuditLogResponseUnmarshaller
    {
        public static ListProxySQLExecAuditLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProxySQLExecAuditLogResponse listProxySQLExecAuditLogResponse = new ListProxySQLExecAuditLogResponse();

			listProxySQLExecAuditLogResponse.HttpResponse = _ctx.HttpResponse;
			listProxySQLExecAuditLogResponse.TotalCount = _ctx.LongValue("ListProxySQLExecAuditLog.TotalCount");
			listProxySQLExecAuditLogResponse.RequestId = _ctx.StringValue("ListProxySQLExecAuditLog.RequestId");
			listProxySQLExecAuditLogResponse.ErrorCode = _ctx.StringValue("ListProxySQLExecAuditLog.ErrorCode");
			listProxySQLExecAuditLogResponse.ErrorMessage = _ctx.StringValue("ListProxySQLExecAuditLog.ErrorMessage");
			listProxySQLExecAuditLogResponse.Success = _ctx.BooleanValue("ListProxySQLExecAuditLog.Success");

			List<ListProxySQLExecAuditLogResponse.ListProxySQLExecAuditLog_ProxySQLExecAuditLog> listProxySQLExecAuditLogResponse_proxySQLExecAuditLogList = new List<ListProxySQLExecAuditLogResponse.ListProxySQLExecAuditLog_ProxySQLExecAuditLog>();
			for (int i = 0; i < _ctx.Length("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList.Length"); i++) {
				ListProxySQLExecAuditLogResponse.ListProxySQLExecAuditLog_ProxySQLExecAuditLog proxySQLExecAuditLog = new ListProxySQLExecAuditLogResponse.ListProxySQLExecAuditLog_ProxySQLExecAuditLog();
				proxySQLExecAuditLog.OpTime = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].OpTime");
				proxySQLExecAuditLog.UserName = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].UserName");
				proxySQLExecAuditLog.UserId = _ctx.LongValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].UserId");
				proxySQLExecAuditLog.InstanceName = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].InstanceName");
				proxySQLExecAuditLog.InstanceId = _ctx.LongValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].InstanceId");
				proxySQLExecAuditLog.SchemaName = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].SchemaName");
				proxySQLExecAuditLog.SQLType = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].SQLType");
				proxySQLExecAuditLog.SQL = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].SQL");
				proxySQLExecAuditLog.ExecState = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].ExecState");
				proxySQLExecAuditLog.AffectRows = _ctx.LongValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].AffectRows");
				proxySQLExecAuditLog.ElapsedTime = _ctx.LongValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].ElapsedTime");
				proxySQLExecAuditLog.Remark = _ctx.StringValue("ListProxySQLExecAuditLog.ProxySQLExecAuditLogList["+ i +"].Remark");

				listProxySQLExecAuditLogResponse_proxySQLExecAuditLogList.Add(proxySQLExecAuditLog);
			}
			listProxySQLExecAuditLogResponse.ProxySQLExecAuditLogList = listProxySQLExecAuditLogResponse_proxySQLExecAuditLogList;
        
			return listProxySQLExecAuditLogResponse;
        }
    }
}
