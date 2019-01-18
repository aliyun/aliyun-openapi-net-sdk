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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class JoinChannelResponseUnmarshaller
    {
        public static JoinChannelResponse Unmarshall(UnmarshallerContext context)
        {
			JoinChannelResponse joinChannelResponse = new JoinChannelResponse();

			joinChannelResponse.HttpResponse = context.HttpResponse;
			joinChannelResponse.RequestId = context.StringValue("JoinChannel.RequestId");
			joinChannelResponse.Success = context.BooleanValue("JoinChannel.Success");
			joinChannelResponse.ErrorCode = context.IntegerValue("JoinChannel.ErrorCode");

			List<JoinChannelResponse.JoinChannel_ResultItem> joinChannelResponse_result = new List<JoinChannelResponse.JoinChannel_ResultItem>();
			for (int i = 0; i < context.Length("JoinChannel.Result.Length"); i++) {
				JoinChannelResponse.JoinChannel_ResultItem resultItem = new JoinChannelResponse.JoinChannel_ResultItem();
				resultItem.ChannelId = context.StringValue("JoinChannel.Result["+ i +"].ChannelId");
				resultItem.OrganizationId = context.StringValue("JoinChannel.Result["+ i +"].OrganizationId");
				resultItem.WithPeer = context.BooleanValue("JoinChannel.Result["+ i +"].WithPeer");
				resultItem.State = context.StringValue("JoinChannel.Result["+ i +"].State");
				resultItem.InviteTime = context.StringValue("JoinChannel.Result["+ i +"].InviteTime");
				resultItem.AcceptTime = context.StringValue("JoinChannel.Result["+ i +"].AcceptTime");
				resultItem.ApproveTime = context.StringValue("JoinChannel.Result["+ i +"].ApproveTime");
				resultItem.ConfirmTime = context.StringValue("JoinChannel.Result["+ i +"].ConfirmTime");
				resultItem.DestroyTime = context.StringValue("JoinChannel.Result["+ i +"].DestroyTime");

				joinChannelResponse_result.Add(resultItem);
			}
			joinChannelResponse.Result = joinChannelResponse_result;
        
			return joinChannelResponse;
        }
    }
}