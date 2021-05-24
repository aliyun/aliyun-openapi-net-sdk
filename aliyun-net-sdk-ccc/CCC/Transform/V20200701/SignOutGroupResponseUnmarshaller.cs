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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class SignOutGroupResponseUnmarshaller
    {
        public static SignOutGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SignOutGroupResponse signOutGroupResponse = new SignOutGroupResponse();

			signOutGroupResponse.HttpResponse = _ctx.HttpResponse;
			signOutGroupResponse.Code = _ctx.StringValue("SignOutGroup.Code");
			signOutGroupResponse.HttpStatusCode = _ctx.IntegerValue("SignOutGroup.HttpStatusCode");
			signOutGroupResponse.Message = _ctx.StringValue("SignOutGroup.Message");
			signOutGroupResponse.RequestId = _ctx.StringValue("SignOutGroup.RequestId");

			List<string> signOutGroupResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("SignOutGroup.Params.Length"); i++) {
				signOutGroupResponse_params.Add(_ctx.StringValue("SignOutGroup.Params["+ i +"]"));
			}
			signOutGroupResponse._Params = signOutGroupResponse_params;

			SignOutGroupResponse.SignOutGroup_Data data = new SignOutGroupResponse.SignOutGroup_Data();
			data.BreakCode = _ctx.StringValue("SignOutGroup.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("SignOutGroup.Data.DeviceId");
			data.Extension = _ctx.StringValue("SignOutGroup.Data.Extension");
			data.Heartbeat = _ctx.LongValue("SignOutGroup.Data.Heartbeat");
			data.InstanceId = _ctx.StringValue("SignOutGroup.Data.InstanceId");
			data.JobId = _ctx.StringValue("SignOutGroup.Data.JobId");
			data.Mobile = _ctx.StringValue("SignOutGroup.Data.Mobile");
			data.OutboundScenario = _ctx.BooleanValue("SignOutGroup.Data.OutboundScenario");
			data.Reserved = _ctx.LongValue("SignOutGroup.Data.Reserved");
			data.UserId = _ctx.StringValue("SignOutGroup.Data.UserId");
			data.UserState = _ctx.StringValue("SignOutGroup.Data.UserState");
			data.WorkMode = _ctx.StringValue("SignOutGroup.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("SignOutGroup.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("SignOutGroup.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			signOutGroupResponse.Data = data;
        
			return signOutGroupResponse;
        }
    }
}
