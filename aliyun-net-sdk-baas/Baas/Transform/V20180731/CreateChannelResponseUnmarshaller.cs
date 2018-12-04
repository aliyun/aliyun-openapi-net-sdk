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
    public class CreateChannelResponseUnmarshaller
    {
        public static CreateChannelResponse Unmarshall(UnmarshallerContext context)
        {
			CreateChannelResponse createChannelResponse = new CreateChannelResponse();

			createChannelResponse.HttpResponse = context.HttpResponse;
			createChannelResponse.RequestId = context.StringValue("CreateChannel.RequestId");
			createChannelResponse.Success = context.BooleanValue("CreateChannel.Success");
			createChannelResponse.ErrorCode = context.IntegerValue("CreateChannel.ErrorCode");

			CreateChannelResponse.CreateChannel_Result result = new CreateChannelResponse.CreateChannel_Result();
			result.ChannelId = context.StringValue("CreateChannel.Result.ChannelId");
			result.Name = context.StringValue("CreateChannel.Result.Name");
			result.ConsortiumId = context.StringValue("CreateChannel.Result.ConsortiumId");
			result.State = context.StringValue("CreateChannel.Result.State");
			result.OwnerBid = context.StringValue("CreateChannel.Result.OwnerBid");
			result.OwnerUid = context.IntegerValue("CreateChannel.Result.OwnerUid");
			result.OwnerName = context.StringValue("CreateChannel.Result.OwnerName");
			result.MemberCount = context.IntegerValue("CreateChannel.Result.MemberCount");
			result.ChaincodeCount = context.IntegerValue("CreateChannel.Result.ChaincodeCount");
			result.BlockCount = context.IntegerValue("CreateChannel.Result.BlockCount");
			result.RequestId = context.StringValue("CreateChannel.Result.RequestId");
			result.CreateTime = context.StringValue("CreateChannel.Result.CreateTime");
			result.UpdateTime = context.StringValue("CreateChannel.Result.UpdateTime");
			result.ConsortiumName = context.StringValue("CreateChannel.Result.ConsortiumName");
			createChannelResponse.Result = result;
        
			return createChannelResponse;
        }
    }
}