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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class QueryTimedResetOperateStatusResponseUnmarshaller
    {
        public static QueryTimedResetOperateStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTimedResetOperateStatusResponse queryTimedResetOperateStatusResponse = new QueryTimedResetOperateStatusResponse();

			queryTimedResetOperateStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryTimedResetOperateStatusResponse.RequestId = _ctx.StringValue("QueryTimedResetOperateStatus.RequestId");
			queryTimedResetOperateStatusResponse.Code = _ctx.StringValue("QueryTimedResetOperateStatus.Code");
			queryTimedResetOperateStatusResponse.Message = _ctx.StringValue("QueryTimedResetOperateStatus.Message");
			queryTimedResetOperateStatusResponse.Success = _ctx.BooleanValue("QueryTimedResetOperateStatus.Success");

			QueryTimedResetOperateStatusResponse.QueryTimedResetOperateStatus_Data data = new QueryTimedResetOperateStatusResponse.QueryTimedResetOperateStatus_Data();
			data.InstanceId = _ctx.StringValue("QueryTimedResetOperateStatus.Data.InstanceId");
			data.StatusStr = _ctx.StringValue("QueryTimedResetOperateStatus.Data.StatusStr");
			data.TenantId = _ctx.StringValue("QueryTimedResetOperateStatus.Data.TenantId");
			data.Status = _ctx.LongValue("QueryTimedResetOperateStatus.Data.Status");
			queryTimedResetOperateStatusResponse.Data = data;
        
			return queryTimedResetOperateStatusResponse;
        }
    }
}
