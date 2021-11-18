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
    public class ListInstanceLoginAuditLogResponseUnmarshaller
    {
        public static ListInstanceLoginAuditLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceLoginAuditLogResponse listInstanceLoginAuditLogResponse = new ListInstanceLoginAuditLogResponse();

			listInstanceLoginAuditLogResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceLoginAuditLogResponse.TotalCount = _ctx.LongValue("ListInstanceLoginAuditLog.TotalCount");
			listInstanceLoginAuditLogResponse.RequestId = _ctx.StringValue("ListInstanceLoginAuditLog.RequestId");
			listInstanceLoginAuditLogResponse.ErrorCode = _ctx.StringValue("ListInstanceLoginAuditLog.ErrorCode");
			listInstanceLoginAuditLogResponse.ErrorMessage = _ctx.StringValue("ListInstanceLoginAuditLog.ErrorMessage");
			listInstanceLoginAuditLogResponse.Success = _ctx.BooleanValue("ListInstanceLoginAuditLog.Success");

			List<ListInstanceLoginAuditLogResponse.ListInstanceLoginAuditLog_InstanceLoginAuditLog> listInstanceLoginAuditLogResponse_instanceLoginAuditLogList = new List<ListInstanceLoginAuditLogResponse.ListInstanceLoginAuditLog_InstanceLoginAuditLog>();
			for (int i = 0; i < _ctx.Length("ListInstanceLoginAuditLog.InstanceLoginAuditLogList.Length"); i++) {
				ListInstanceLoginAuditLogResponse.ListInstanceLoginAuditLog_InstanceLoginAuditLog instanceLoginAuditLog = new ListInstanceLoginAuditLogResponse.ListInstanceLoginAuditLog_InstanceLoginAuditLog();
				instanceLoginAuditLog.OpTime = _ctx.StringValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].OpTime");
				instanceLoginAuditLog.UserName = _ctx.StringValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].UserName");
				instanceLoginAuditLog.UserId = _ctx.LongValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].UserId");
				instanceLoginAuditLog.InstanceName = _ctx.StringValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].InstanceName");
				instanceLoginAuditLog.InstanceId = _ctx.LongValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].InstanceId");
				instanceLoginAuditLog.DbUser = _ctx.StringValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].DbUser");
				instanceLoginAuditLog.RequestIp = _ctx.StringValue("ListInstanceLoginAuditLog.InstanceLoginAuditLogList["+ i +"].RequestIp");

				listInstanceLoginAuditLogResponse_instanceLoginAuditLogList.Add(instanceLoginAuditLog);
			}
			listInstanceLoginAuditLogResponse.InstanceLoginAuditLogList = listInstanceLoginAuditLogResponse_instanceLoginAuditLogList;
        
			return listInstanceLoginAuditLogResponse;
        }
    }
}
