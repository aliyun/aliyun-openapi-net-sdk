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
    public class ChangeWorkModeResponseUnmarshaller
    {
        public static ChangeWorkModeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeWorkModeResponse changeWorkModeResponse = new ChangeWorkModeResponse();

			changeWorkModeResponse.HttpResponse = _ctx.HttpResponse;
			changeWorkModeResponse.Code = _ctx.StringValue("ChangeWorkMode.Code");
			changeWorkModeResponse.HttpStatusCode = _ctx.IntegerValue("ChangeWorkMode.HttpStatusCode");
			changeWorkModeResponse.Message = _ctx.StringValue("ChangeWorkMode.Message");
			changeWorkModeResponse.RequestId = _ctx.StringValue("ChangeWorkMode.RequestId");

			List<string> changeWorkModeResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ChangeWorkMode.Params.Length"); i++) {
				changeWorkModeResponse_params.Add(_ctx.StringValue("ChangeWorkMode.Params["+ i +"]"));
			}
			changeWorkModeResponse._Params = changeWorkModeResponse_params;

			ChangeWorkModeResponse.ChangeWorkMode_Data data = new ChangeWorkModeResponse.ChangeWorkMode_Data();
			data.BreakCode = _ctx.StringValue("ChangeWorkMode.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("ChangeWorkMode.Data.DeviceId");
			data.Extension = _ctx.StringValue("ChangeWorkMode.Data.Extension");
			data.InstanceId = _ctx.StringValue("ChangeWorkMode.Data.InstanceId");
			data.JobId = _ctx.StringValue("ChangeWorkMode.Data.JobId");
			data.OutboundScenario = _ctx.BooleanValue("ChangeWorkMode.Data.OutboundScenario");
			data.UserId = _ctx.StringValue("ChangeWorkMode.Data.UserId");
			data.UserState = _ctx.StringValue("ChangeWorkMode.Data.UserState");
			data.WorkMode = _ctx.StringValue("ChangeWorkMode.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("ChangeWorkMode.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("ChangeWorkMode.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			changeWorkModeResponse.Data = data;
        
			return changeWorkModeResponse;
        }
    }
}
