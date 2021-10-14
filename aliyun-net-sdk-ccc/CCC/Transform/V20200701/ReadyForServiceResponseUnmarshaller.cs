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
    public class ReadyForServiceResponseUnmarshaller
    {
        public static ReadyForServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReadyForServiceResponse readyForServiceResponse = new ReadyForServiceResponse();

			readyForServiceResponse.HttpResponse = _ctx.HttpResponse;
			readyForServiceResponse.Code = _ctx.StringValue("ReadyForService.Code");
			readyForServiceResponse.HttpStatusCode = _ctx.IntegerValue("ReadyForService.HttpStatusCode");
			readyForServiceResponse.Message = _ctx.StringValue("ReadyForService.Message");
			readyForServiceResponse.RequestId = _ctx.StringValue("ReadyForService.RequestId");

			List<string> readyForServiceResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ReadyForService.Params.Length"); i++) {
				readyForServiceResponse_params.Add(_ctx.StringValue("ReadyForService.Params["+ i +"]"));
			}
			readyForServiceResponse._Params = readyForServiceResponse_params;

			ReadyForServiceResponse.ReadyForService_Data data = new ReadyForServiceResponse.ReadyForService_Data();
			data.BreakCode = _ctx.StringValue("ReadyForService.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("ReadyForService.Data.DeviceId");
			data.Extension = _ctx.StringValue("ReadyForService.Data.Extension");
			data.InstanceId = _ctx.StringValue("ReadyForService.Data.InstanceId");
			data.JobId = _ctx.StringValue("ReadyForService.Data.JobId");
			data.OutboundScenario = _ctx.BooleanValue("ReadyForService.Data.OutboundScenario");
			data.UserId = _ctx.StringValue("ReadyForService.Data.UserId");
			data.UserState = _ctx.StringValue("ReadyForService.Data.UserState");
			data.WorkMode = _ctx.StringValue("ReadyForService.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("ReadyForService.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("ReadyForService.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			readyForServiceResponse.Data = data;
        
			return readyForServiceResponse;
        }
    }
}
