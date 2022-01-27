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
    public class GetSubAccountInfoResponseUnmarshaller
    {
        public static GetSubAccountInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubAccountInfoResponse getSubAccountInfoResponse = new GetSubAccountInfoResponse();

			getSubAccountInfoResponse.HttpResponse = _ctx.HttpResponse;
			getSubAccountInfoResponse.Code = _ctx.IntegerValue("GetSubAccountInfo.Code");
			getSubAccountInfoResponse.Message = _ctx.StringValue("GetSubAccountInfo.Message");
			getSubAccountInfoResponse.RequestId = _ctx.StringValue("GetSubAccountInfo.RequestId");

			GetSubAccountInfoResponse.GetSubAccountInfo_Authorization authorization = new GetSubAccountInfoResponse.GetSubAccountInfo_Authorization();
			authorization.AdminUserId = _ctx.StringValue("GetSubAccountInfo.Authorization.AdminUserId");
			authorization.AdminEdasId = _ctx.StringValue("GetSubAccountInfo.Authorization.AdminEdasId");
			authorization.UserId = _ctx.StringValue("GetSubAccountInfo.Authorization.UserId");
			authorization.EdasId = _ctx.StringValue("GetSubAccountInfo.Authorization.EdasId");
			authorization.AppIdData = _ctx.StringValue("GetSubAccountInfo.Authorization.AppIdData");
			authorization.RoleIdData = _ctx.StringValue("GetSubAccountInfo.Authorization.RoleIdData");
			authorization.CreateTime = _ctx.LongValue("GetSubAccountInfo.Authorization.CreateTime");
			authorization.UpdateTime = _ctx.LongValue("GetSubAccountInfo.Authorization.UpdateTime");
			authorization.ResGroupId = _ctx.LongValue("GetSubAccountInfo.Authorization.ResGroupId");
			authorization.ResGroupIdData = _ctx.StringValue("GetSubAccountInfo.Authorization.ResGroupIdData");
			authorization.IsRamSlave = _ctx.BooleanValue("GetSubAccountInfo.Authorization.IsRamSlave");
			authorization.IsRamDel = _ctx.BooleanValue("GetSubAccountInfo.Authorization.IsRamDel");
			authorization.SubUserKp = _ctx.StringValue("GetSubAccountInfo.Authorization.SubUserKp");
			authorization.RamOperation = _ctx.BooleanValue("GetSubAccountInfo.Authorization.RamOperation");
			authorization.DelegateAdmin = _ctx.BooleanValue("GetSubAccountInfo.Authorization.DelegateAdmin");
			authorization.Sts = _ctx.BooleanValue("GetSubAccountInfo.Authorization.Sts");
			getSubAccountInfoResponse.Authorization = authorization;
        
			return getSubAccountInfoResponse;
        }
    }
}
