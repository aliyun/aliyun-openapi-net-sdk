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
    public class SignInGroupResponseUnmarshaller
    {
        public static SignInGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SignInGroupResponse signInGroupResponse = new SignInGroupResponse();

			signInGroupResponse.HttpResponse = _ctx.HttpResponse;
			signInGroupResponse.Code = _ctx.StringValue("SignInGroup.Code");
			signInGroupResponse.HttpStatusCode = _ctx.IntegerValue("SignInGroup.HttpStatusCode");
			signInGroupResponse.Message = _ctx.StringValue("SignInGroup.Message");
			signInGroupResponse.RequestId = _ctx.StringValue("SignInGroup.RequestId");

			List<string> signInGroupResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("SignInGroup.Params.Length"); i++) {
				signInGroupResponse_params.Add(_ctx.StringValue("SignInGroup.Params["+ i +"]"));
			}
			signInGroupResponse._Params = signInGroupResponse_params;

			SignInGroupResponse.SignInGroup_Data data = new SignInGroupResponse.SignInGroup_Data();
			data.BreakCode = _ctx.StringValue("SignInGroup.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("SignInGroup.Data.DeviceId");
			data.Extension = _ctx.StringValue("SignInGroup.Data.Extension");
			data.InstanceId = _ctx.StringValue("SignInGroup.Data.InstanceId");
			data.JobId = _ctx.StringValue("SignInGroup.Data.JobId");
			data.OutboundScenario = _ctx.BooleanValue("SignInGroup.Data.OutboundScenario");
			data.UserId = _ctx.StringValue("SignInGroup.Data.UserId");
			data.UserState = _ctx.StringValue("SignInGroup.Data.UserState");
			data.WorkMode = _ctx.StringValue("SignInGroup.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("SignInGroup.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("SignInGroup.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			signInGroupResponse.Data = data;
        
			return signInGroupResponse;
        }
    }
}
