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
    public class DescribeConsortiumChannelsResponseUnmarshaller
    {
        public static DescribeConsortiumChannelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumChannelsResponse describeConsortiumChannelsResponse = new DescribeConsortiumChannelsResponse();

			describeConsortiumChannelsResponse.HttpResponse = context.HttpResponse;
			describeConsortiumChannelsResponse.RequestId = context.StringValue("DescribeConsortiumChannels.RequestId");
			describeConsortiumChannelsResponse.Success = context.BooleanValue("DescribeConsortiumChannels.Success");
			describeConsortiumChannelsResponse.ErrorCode = context.IntegerValue("DescribeConsortiumChannels.ErrorCode");

			List<DescribeConsortiumChannelsResponse.DescribeConsortiumChannels_ResultItem> describeConsortiumChannelsResponse_result = new List<DescribeConsortiumChannelsResponse.DescribeConsortiumChannels_ResultItem>();
			for (int i = 0; i < context.Length("DescribeConsortiumChannels.Result.Length"); i++) {
				DescribeConsortiumChannelsResponse.DescribeConsortiumChannels_ResultItem resultItem = new DescribeConsortiumChannelsResponse.DescribeConsortiumChannels_ResultItem();
				resultItem.Id = context.IntegerValue("DescribeConsortiumChannels.Result["+ i +"].Id");
				resultItem.ChannelId = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].ChannelId");
				resultItem.Name = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].Name");
				resultItem.ConsortiumId = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].ConsortiumId");
				resultItem.State = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].State");
				resultItem.OwnerBid = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].OwnerBid");
				resultItem.OwnerUid = context.IntegerValue("DescribeConsortiumChannels.Result["+ i +"].OwnerUid");
				resultItem.OwnerName = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].OwnerName");
				resultItem.MemberCount = context.IntegerValue("DescribeConsortiumChannels.Result["+ i +"].MemberCount");
				resultItem.ChaincodeCount = context.IntegerValue("DescribeConsortiumChannels.Result["+ i +"].ChaincodeCount");
				resultItem.BlockCount = context.IntegerValue("DescribeConsortiumChannels.Result["+ i +"].BlockCount");
				resultItem.RequestId = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].RequestId");
				resultItem.CreateTime = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].CreateTime");
				resultItem.UpdateTime = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].UpdateTime");
				resultItem.Deleted = context.BooleanValue("DescribeConsortiumChannels.Result["+ i +"].Deleted");
				resultItem.DeleteTime = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].DeleteTime");
				resultItem.ConsortiumName = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].ConsortiumName");
				resultItem.MemberJoinedCount = context.StringValue("DescribeConsortiumChannels.Result["+ i +"].MemberJoinedCount");
				resultItem.NeedJoined = context.BooleanValue("DescribeConsortiumChannels.Result["+ i +"].NeedJoined");

				describeConsortiumChannelsResponse_result.Add(resultItem);
			}
			describeConsortiumChannelsResponse.Result = describeConsortiumChannelsResponse_result;
        
			return describeConsortiumChannelsResponse;
        }
    }
}