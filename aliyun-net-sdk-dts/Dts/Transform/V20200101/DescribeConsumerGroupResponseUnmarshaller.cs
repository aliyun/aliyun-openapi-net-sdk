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
    public class DescribeConsumerGroupResponseUnmarshaller
    {
        public static DescribeConsumerGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConsumerGroupResponse describeConsumerGroupResponse = new DescribeConsumerGroupResponse();

			describeConsumerGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeConsumerGroupResponse.PageNumber = _ctx.IntegerValue("DescribeConsumerGroup.PageNumber");
			describeConsumerGroupResponse.PageRecordCount = _ctx.IntegerValue("DescribeConsumerGroup.PageRecordCount");
			describeConsumerGroupResponse.RequestId = _ctx.StringValue("DescribeConsumerGroup.RequestId");
			describeConsumerGroupResponse.TotalRecordCount = _ctx.IntegerValue("DescribeConsumerGroup.TotalRecordCount");
			describeConsumerGroupResponse.ErrCode = _ctx.StringValue("DescribeConsumerGroup.ErrCode");
			describeConsumerGroupResponse.ErrMessage = _ctx.StringValue("DescribeConsumerGroup.ErrMessage");
			describeConsumerGroupResponse.Success = _ctx.StringValue("DescribeConsumerGroup.Success");

			List<DescribeConsumerGroupResponse.DescribeConsumerGroup_DescribeConsumerChannel> describeConsumerGroupResponse_consumerChannels = new List<DescribeConsumerGroupResponse.DescribeConsumerGroup_DescribeConsumerChannel>();
			for (int i = 0; i < _ctx.Length("DescribeConsumerGroup.ConsumerChannels.Length"); i++) {
				DescribeConsumerGroupResponse.DescribeConsumerGroup_DescribeConsumerChannel describeConsumerChannel = new DescribeConsumerGroupResponse.DescribeConsumerGroup_DescribeConsumerChannel();
				describeConsumerChannel.ConsumerGroupID = _ctx.StringValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].ConsumerGroupID");
				describeConsumerChannel.ConsumerGroupName = _ctx.StringValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].ConsumerGroupName");
				describeConsumerChannel.ConsumerGroupUserName = _ctx.StringValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].ConsumerGroupUserName");
				describeConsumerChannel.ConsumptionCheckpoint = _ctx.StringValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].ConsumptionCheckpoint");
				describeConsumerChannel.MessageDelay = _ctx.LongValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].MessageDelay");
				describeConsumerChannel.UnconsumedData = _ctx.LongValue("DescribeConsumerGroup.ConsumerChannels["+ i +"].UnconsumedData");

				describeConsumerGroupResponse_consumerChannels.Add(describeConsumerChannel);
			}
			describeConsumerGroupResponse.ConsumerChannels = describeConsumerGroupResponse_consumerChannels;
        
			return describeConsumerGroupResponse;
        }
    }
}
