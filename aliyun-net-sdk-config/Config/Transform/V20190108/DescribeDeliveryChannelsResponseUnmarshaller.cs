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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class DescribeDeliveryChannelsResponseUnmarshaller
    {
        public static DescribeDeliveryChannelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeliveryChannelsResponse describeDeliveryChannelsResponse = new DescribeDeliveryChannelsResponse();

			describeDeliveryChannelsResponse.HttpResponse = _ctx.HttpResponse;
			describeDeliveryChannelsResponse.RequestId = _ctx.StringValue("DescribeDeliveryChannels.RequestId");

			List<DescribeDeliveryChannelsResponse.DescribeDeliveryChannels_DeliveryChannel> describeDeliveryChannelsResponse_deliveryChannels = new List<DescribeDeliveryChannelsResponse.DescribeDeliveryChannels_DeliveryChannel>();
			for (int i = 0; i < _ctx.Length("DescribeDeliveryChannels.DeliveryChannels.Length"); i++) {
				DescribeDeliveryChannelsResponse.DescribeDeliveryChannels_DeliveryChannel deliveryChannel = new DescribeDeliveryChannelsResponse.DescribeDeliveryChannels_DeliveryChannel();
				deliveryChannel.Status = _ctx.IntegerValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].Status");
				deliveryChannel.DeliveryChannelName = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelName");
				deliveryChannel.DeliveryChannelId = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelId");
				deliveryChannel.DeliveryChannelType = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelType");
				deliveryChannel.DeliveryChannelAssumeRoleArn = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelAssumeRoleArn");
				deliveryChannel.Description = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].Description");
				deliveryChannel.DeliveryChannelCondition = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelCondition");
				deliveryChannel.DeliveryChannelTargetArn = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].DeliveryChannelTargetArn");
				deliveryChannel.ConfigurationSnapshot = _ctx.BooleanValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].ConfigurationSnapshot");
				deliveryChannel.ConfigurationItemChangeNotification = _ctx.BooleanValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].ConfigurationItemChangeNotification");
				deliveryChannel.NonCompliantNotification = _ctx.BooleanValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].NonCompliantNotification");
				deliveryChannel.OversizedDataOSSTargetArn = _ctx.StringValue("DescribeDeliveryChannels.DeliveryChannels["+ i +"].OversizedDataOSSTargetArn");

				describeDeliveryChannelsResponse_deliveryChannels.Add(deliveryChannel);
			}
			describeDeliveryChannelsResponse.DeliveryChannels = describeDeliveryChannelsResponse_deliveryChannels;
        
			return describeDeliveryChannelsResponse;
        }
    }
}
