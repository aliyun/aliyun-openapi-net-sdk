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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeConsumerChannelResponseUnmarshaller
    {
        public static DescribeConsumerChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConsumerChannelResponse describeConsumerChannelResponse = new DescribeConsumerChannelResponse();

			describeConsumerChannelResponse.HttpResponse = _ctx.HttpResponse;
			describeConsumerChannelResponse.ErrCode = _ctx.StringValue("DescribeConsumerChannel.ErrCode");
			describeConsumerChannelResponse.ErrMessage = _ctx.StringValue("DescribeConsumerChannel.ErrMessage");
			describeConsumerChannelResponse.RequestId = _ctx.StringValue("DescribeConsumerChannel.RequestId");
			describeConsumerChannelResponse.Success = _ctx.StringValue("DescribeConsumerChannel.Success");
			describeConsumerChannelResponse.HttpStatusCode = _ctx.StringValue("DescribeConsumerChannel.HttpStatusCode");
			describeConsumerChannelResponse.PageNumber = _ctx.IntegerValue("DescribeConsumerChannel.PageNumber");
			describeConsumerChannelResponse.PageRecordCount = _ctx.IntegerValue("DescribeConsumerChannel.PageRecordCount");
			describeConsumerChannelResponse.TotalRecordCount = _ctx.LongValue("DescribeConsumerChannel.TotalRecordCount");

			List<DescribeConsumerChannelResponse.DescribeConsumerChannel_ConsumerChannel> describeConsumerChannelResponse_consumerChannels = new List<DescribeConsumerChannelResponse.DescribeConsumerChannel_ConsumerChannel>();
			for (int i = 0; i < _ctx.Length("DescribeConsumerChannel.ConsumerChannels.Length"); i++) {
				DescribeConsumerChannelResponse.DescribeConsumerChannel_ConsumerChannel consumerChannel = new DescribeConsumerChannelResponse.DescribeConsumerChannel_ConsumerChannel();
				consumerChannel.ConsumerGroupId = _ctx.StringValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].ConsumerGroupId");
				consumerChannel.ConsumerGroupName = _ctx.StringValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].ConsumerGroupName");
				consumerChannel.ConsumptionCheckpoint = _ctx.StringValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].ConsumptionCheckpoint");
				consumerChannel.UnconsumedData = _ctx.LongValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].UnconsumedData");
				consumerChannel.MessageDelay = _ctx.LongValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].MessageDelay");
				consumerChannel.ConsumerGroupUserName = _ctx.StringValue("DescribeConsumerChannel.ConsumerChannels["+ i +"].ConsumerGroupUserName");

				describeConsumerChannelResponse_consumerChannels.Add(consumerChannel);
			}
			describeConsumerChannelResponse.ConsumerChannels = describeConsumerChannelResponse_consumerChannels;
        
			return describeConsumerChannelResponse;
        }
    }
}
