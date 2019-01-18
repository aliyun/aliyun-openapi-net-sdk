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
    public class DescribeOrganizationChannelsResponseUnmarshaller
    {
        public static DescribeOrganizationChannelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationChannelsResponse describeOrganizationChannelsResponse = new DescribeOrganizationChannelsResponse();

			describeOrganizationChannelsResponse.HttpResponse = context.HttpResponse;
			describeOrganizationChannelsResponse.RequestId = context.StringValue("DescribeOrganizationChannels.RequestId");
			describeOrganizationChannelsResponse.Success = context.BooleanValue("DescribeOrganizationChannels.Success");
			describeOrganizationChannelsResponse.ErrorCode = context.IntegerValue("DescribeOrganizationChannels.ErrorCode");

			List<DescribeOrganizationChannelsResponse.DescribeOrganizationChannels_ResultItem> describeOrganizationChannelsResponse_result = new List<DescribeOrganizationChannelsResponse.DescribeOrganizationChannels_ResultItem>();
			for (int i = 0; i < context.Length("DescribeOrganizationChannels.Result.Length"); i++) {
				DescribeOrganizationChannelsResponse.DescribeOrganizationChannels_ResultItem resultItem = new DescribeOrganizationChannelsResponse.DescribeOrganizationChannels_ResultItem();
				resultItem.ChannelId = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].ChannelId");
				resultItem.Name = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].Name");
				resultItem.ConsortiumId = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].ConsortiumId");
				resultItem.State = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].State");
				resultItem.OwnerBid = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].OwnerBid");
				resultItem.OwnerUid = context.IntegerValue("DescribeOrganizationChannels.Result["+ i +"].OwnerUid");
				resultItem.OwnerName = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].OwnerName");
				resultItem.MemberCount = context.IntegerValue("DescribeOrganizationChannels.Result["+ i +"].MemberCount");
				resultItem.ChaincodeCount = context.IntegerValue("DescribeOrganizationChannels.Result["+ i +"].ChaincodeCount");
				resultItem.BlockCount = context.IntegerValue("DescribeOrganizationChannels.Result["+ i +"].BlockCount");
				resultItem.RequestId = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].RequestId");
				resultItem.CreateTime = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].CreateTime");
				resultItem.UpdateTime = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].UpdateTime");
				resultItem.Deleted = context.BooleanValue("DescribeOrganizationChannels.Result["+ i +"].Deleted");
				resultItem.DeleteTime = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].DeleteTime");
				resultItem.ConsortiumName = context.StringValue("DescribeOrganizationChannels.Result["+ i +"].ConsortiumName");

				describeOrganizationChannelsResponse_result.Add(resultItem);
			}
			describeOrganizationChannelsResponse.Result = describeOrganizationChannelsResponse_result;
        
			return describeOrganizationChannelsResponse;
        }
    }
}