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
    public class StartInstanceResponseUnmarshaller
    {
        public static StartInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartInstanceResponse startInstanceResponse = new StartInstanceResponse();

			startInstanceResponse.HttpResponse = _ctx.HttpResponse;
			startInstanceResponse.Code = _ctx.StringValue("StartInstance.Code");
			startInstanceResponse.Message = _ctx.StringValue("StartInstance.Message");
			startInstanceResponse.Success = _ctx.BooleanValue("StartInstance.Success");

			StartInstanceResponse.StartInstance_Data data = new StartInstanceResponse.StartInstance_Data();
			data.RequestId = _ctx.StringValue("StartInstance.Data.RequestId");
			data.SessionId = _ctx.StringValue("StartInstance.Data.SessionId");
			data.Token = _ctx.StringValue("StartInstance.Data.Token");

			StartInstanceResponse.StartInstance_Data.StartInstance_Channel channel = new StartInstanceResponse.StartInstance_Data.StartInstance_Channel();
			channel.ChannelId = _ctx.StringValue("StartInstance.Data.Channel.ChannelId");
			channel.Token = _ctx.StringValue("StartInstance.Data.Channel.Token");
			channel.Type = _ctx.StringValue("StartInstance.Data.Channel.Type");
			channel.ExpiredTime = _ctx.StringValue("StartInstance.Data.Channel.ExpiredTime");
			channel.Nonce = _ctx.StringValue("StartInstance.Data.Channel.Nonce");
			channel.UserId = _ctx.StringValue("StartInstance.Data.Channel.UserId");
			channel.AppId = _ctx.StringValue("StartInstance.Data.Channel.AppId");
			channel.UserInfoInChannel = _ctx.StringValue("StartInstance.Data.Channel.UserInfoInChannel");

			List<string> channel_gslb = new List<string>();
			for (int i = 0; i < _ctx.Length("StartInstance.Data.Channel.Gslb.Length"); i++) {
				channel_gslb.Add(_ctx.StringValue("StartInstance.Data.Channel.Gslb["+ i +"]"));
			}
			channel.Gslb = channel_gslb;
			data.Channel = channel;
			startInstanceResponse.Data = data;
        
			return startInstanceResponse;
        }
    }
}
