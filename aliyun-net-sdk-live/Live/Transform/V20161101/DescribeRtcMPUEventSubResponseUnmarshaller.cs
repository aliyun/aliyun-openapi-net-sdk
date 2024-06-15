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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRtcMPUEventSubResponseUnmarshaller
    {
        public static DescribeRtcMPUEventSubResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcMPUEventSubResponse describeRtcMPUEventSubResponse = new DescribeRtcMPUEventSubResponse();

			describeRtcMPUEventSubResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcMPUEventSubResponse.RequestId = _ctx.StringValue("DescribeRtcMPUEventSub.RequestId");

			DescribeRtcMPUEventSubResponse.DescribeRtcMPUEventSub_SubInfo subInfo = new DescribeRtcMPUEventSubResponse.DescribeRtcMPUEventSub_SubInfo();
			subInfo.SubId = _ctx.StringValue("DescribeRtcMPUEventSub.SubInfo.SubId");
			subInfo.AppId = _ctx.StringValue("DescribeRtcMPUEventSub.SubInfo.AppId");
			subInfo.ChannelIds = _ctx.StringValue("DescribeRtcMPUEventSub.SubInfo.ChannelIds");
			subInfo.CreateTime = _ctx.StringValue("DescribeRtcMPUEventSub.SubInfo.CreateTime");
			subInfo.CallbackUrl = _ctx.StringValue("DescribeRtcMPUEventSub.SubInfo.CallbackUrl");
			describeRtcMPUEventSubResponse.SubInfo = subInfo;
        
			return describeRtcMPUEventSubResponse;
        }
    }
}
