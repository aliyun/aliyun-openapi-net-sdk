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
    public class ListSQLExecAuditLogResponseUnmarshaller
    {
        public static ListSQLExecAuditLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSQLExecAuditLogResponse listSQLExecAuditLogResponse = new ListSQLExecAuditLogResponse();

			listSQLExecAuditLogResponse.HttpResponse = _ctx.HttpResponse;
			listSQLExecAuditLogResponse.TotalCount = _ctx.LongValue("ListSQLExecAuditLog.TotalCount");
			listSQLExecAuditLogResponse.RequestId = _ctx.StringValue("ListSQLExecAuditLog.RequestId");
			listSQLExecAuditLogResponse.ErrorCode = _ctx.StringValue("ListSQLExecAuditLog.ErrorCode");
			listSQLExecAuditLogResponse.ErrorMessage = _ctx.StringValue("ListSQLExecAuditLog.ErrorMessage");
			listSQLExecAuditLogResponse.Success = _ctx.BooleanValue("ListSQLExecAuditLog.Success");

			List<ListSQLExecAuditLogResponse.ListSQLExecAuditLog_SQLExecAuditLog> listSQLExecAuditLogResponse_sQLExecAuditLogList = new List<ListSQLExecAuditLogResponse.ListSQLExecAuditLog_SQLExecAuditLog>();
			for (int i = 0; i < _ctx.Length("ListSQLExecAuditLog.SQLExecAuditLogList.Length"); i++) {
				ListSQLExecAuditLogResponse.ListSQLExecAuditLog_SQLExecAuditLog sQLExecAuditLog = new ListSQLExecAuditLogResponse.ListSQLExecAuditLog_SQLExecAuditLog();
				sQLExecAuditLog.OpTime = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].OpTime");
				sQLExecAuditLog.UserName = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].UserName");
				sQLExecAuditLog.UserId = _ctx.LongValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].UserId");
				sQLExecAuditLog.InstanceName = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].InstanceName");
				sQLExecAuditLog.InstanceId = _ctx.LongValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].InstanceId");
				sQLExecAuditLog.SchemaName = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].SchemaName");
				sQLExecAuditLog.DbId = _ctx.LongValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].DbId");
				sQLExecAuditLog.Logic = _ctx.BooleanValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].Logic");
				sQLExecAuditLog.SQLType = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].SQLType");
				sQLExecAuditLog.SQL = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].SQL");
				sQLExecAuditLog.ExecState = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].ExecState");
				sQLExecAuditLog.AffectRows = _ctx.LongValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].AffectRows");
				sQLExecAuditLog.ElapsedTime = _ctx.LongValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].ElapsedTime");
				sQLExecAuditLog.Remark = _ctx.StringValue("ListSQLExecAuditLog.SQLExecAuditLogList["+ i +"].Remark");

				listSQLExecAuditLogResponse_sQLExecAuditLogList.Add(sQLExecAuditLog);
			}
			listSQLExecAuditLogResponse.SQLExecAuditLogList = listSQLExecAuditLogResponse_sQLExecAuditLogList;
        
			return listSQLExecAuditLogResponse;
        }
    }
}
