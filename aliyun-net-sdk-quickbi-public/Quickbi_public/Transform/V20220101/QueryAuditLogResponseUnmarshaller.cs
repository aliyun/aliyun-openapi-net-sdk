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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryAuditLogResponseUnmarshaller
    {
        public static QueryAuditLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAuditLogResponse queryAuditLogResponse = new QueryAuditLogResponse();

			queryAuditLogResponse.HttpResponse = _ctx.HttpResponse;
			queryAuditLogResponse.RequestId = _ctx.StringValue("QueryAuditLog.RequestId");
			queryAuditLogResponse.Success = _ctx.BooleanValue("QueryAuditLog.Success");

			List<QueryAuditLogResponse.QueryAuditLog_LogApiResultModel> queryAuditLogResponse_result = new List<QueryAuditLogResponse.QueryAuditLog_LogApiResultModel>();
			for (int i = 0; i < _ctx.Length("QueryAuditLog.Result.Length"); i++) {
				QueryAuditLogResponse.QueryAuditLog_LogApiResultModel logApiResultModel = new QueryAuditLogResponse.QueryAuditLog_LogApiResultModel();
				logApiResultModel.GmtCreate = _ctx.StringValue("QueryAuditLog.Result["+ i +"].GmtCreate");
				logApiResultModel.OperatorAccountName = _ctx.StringValue("QueryAuditLog.Result["+ i +"].OperatorAccountName");
				logApiResultModel.OperatorName = _ctx.StringValue("QueryAuditLog.Result["+ i +"].OperatorName");
				logApiResultModel.OperatorType = _ctx.StringValue("QueryAuditLog.Result["+ i +"].OperatorType");
				logApiResultModel.TargetName = _ctx.StringValue("QueryAuditLog.Result["+ i +"].TargetName");
				logApiResultModel.TargetType = _ctx.StringValue("QueryAuditLog.Result["+ i +"].TargetType");
				logApiResultModel.WorkspaceId = _ctx.StringValue("QueryAuditLog.Result["+ i +"].WorkspaceId");

				queryAuditLogResponse_result.Add(logApiResultModel);
			}
			queryAuditLogResponse.Result = queryAuditLogResponse_result;
        
			return queryAuditLogResponse;
        }
    }
}
