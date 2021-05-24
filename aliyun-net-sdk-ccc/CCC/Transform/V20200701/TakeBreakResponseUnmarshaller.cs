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
    public class TakeBreakResponseUnmarshaller
    {
        public static TakeBreakResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TakeBreakResponse takeBreakResponse = new TakeBreakResponse();

			takeBreakResponse.HttpResponse = _ctx.HttpResponse;
			takeBreakResponse.Code = _ctx.StringValue("TakeBreak.Code");
			takeBreakResponse.HttpStatusCode = _ctx.IntegerValue("TakeBreak.HttpStatusCode");
			takeBreakResponse.Message = _ctx.StringValue("TakeBreak.Message");
			takeBreakResponse.RequestId = _ctx.StringValue("TakeBreak.RequestId");

			List<string> takeBreakResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("TakeBreak.Params.Length"); i++) {
				takeBreakResponse_params.Add(_ctx.StringValue("TakeBreak.Params["+ i +"]"));
			}
			takeBreakResponse._Params = takeBreakResponse_params;

			TakeBreakResponse.TakeBreak_Data data = new TakeBreakResponse.TakeBreak_Data();
			data.BreakCode = _ctx.StringValue("TakeBreak.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("TakeBreak.Data.DeviceId");
			data.Extension = _ctx.StringValue("TakeBreak.Data.Extension");
			data.Heartbeat = _ctx.LongValue("TakeBreak.Data.Heartbeat");
			data.InstanceId = _ctx.StringValue("TakeBreak.Data.InstanceId");
			data.JobId = _ctx.StringValue("TakeBreak.Data.JobId");
			data.Mobile = _ctx.StringValue("TakeBreak.Data.Mobile");
			data.OutboundScenario = _ctx.BooleanValue("TakeBreak.Data.OutboundScenario");
			data.Reserved = _ctx.LongValue("TakeBreak.Data.Reserved");
			data.UserId = _ctx.StringValue("TakeBreak.Data.UserId");
			data.UserState = _ctx.StringValue("TakeBreak.Data.UserState");
			data.WorkMode = _ctx.StringValue("TakeBreak.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("TakeBreak.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("TakeBreak.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			takeBreakResponse.Data = data;
        
			return takeBreakResponse;
        }
    }
}
