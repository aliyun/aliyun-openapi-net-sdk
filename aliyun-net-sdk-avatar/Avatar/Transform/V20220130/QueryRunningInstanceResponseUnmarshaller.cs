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
    public class QueryRunningInstanceResponseUnmarshaller
    {
        public static QueryRunningInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRunningInstanceResponse queryRunningInstanceResponse = new QueryRunningInstanceResponse();

			queryRunningInstanceResponse.HttpResponse = _ctx.HttpResponse;
			queryRunningInstanceResponse.RequestId = _ctx.StringValue("QueryRunningInstance.RequestId");
			queryRunningInstanceResponse.Code = _ctx.StringValue("QueryRunningInstance.Code");
			queryRunningInstanceResponse.Message = _ctx.StringValue("QueryRunningInstance.Message");
			queryRunningInstanceResponse.Success = _ctx.BooleanValue("QueryRunningInstance.Success");

			List<QueryRunningInstanceResponse.QueryRunningInstance_DataItem> queryRunningInstanceResponse_data = new List<QueryRunningInstanceResponse.QueryRunningInstance_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryRunningInstance.Data.Length"); i++) {
				QueryRunningInstanceResponse.QueryRunningInstance_DataItem dataItem = new QueryRunningInstanceResponse.QueryRunningInstance_DataItem();
				dataItem.SessionId = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].SessionId");

				QueryRunningInstanceResponse.QueryRunningInstance_DataItem.QueryRunningInstance_Channel channel = new QueryRunningInstanceResponse.QueryRunningInstance_DataItem.QueryRunningInstance_Channel();
				channel.ChannelId = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.ChannelId");
				channel.Token = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.Token");
				channel.Type = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.Type");
				channel.ExpiredTime = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.ExpiredTime");
				channel.Nonce = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.Nonce");
				channel.UserId = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.UserId");
				channel.AppId = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.AppId");
				channel.UserInfoInChannel = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.UserInfoInChannel");

				List<string> channel_gslb = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryRunningInstance.Data["+ i +"].Channel.Gslb.Length"); j++) {
					channel_gslb.Add(_ctx.StringValue("QueryRunningInstance.Data["+ i +"].Channel.Gslb["+ j +"]"));
				}
				channel.Gslb = channel_gslb;
				dataItem.Channel = channel;

				QueryRunningInstanceResponse.QueryRunningInstance_DataItem.QueryRunningInstance_User user = new QueryRunningInstanceResponse.QueryRunningInstance_DataItem.QueryRunningInstance_User();
				user.UserId = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].User.UserId");
				user.UserName = _ctx.StringValue("QueryRunningInstance.Data["+ i +"].User.UserName");
				dataItem.User = user;

				queryRunningInstanceResponse_data.Add(dataItem);
			}
			queryRunningInstanceResponse.Data = queryRunningInstanceResponse_data;
        
			return queryRunningInstanceResponse;
        }
    }
}
