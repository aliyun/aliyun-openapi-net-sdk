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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcScaleResponseUnmarshaller
    {
        public static DescribeRtcScaleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcScaleResponse describeRtcScaleResponse = new DescribeRtcScaleResponse();

			describeRtcScaleResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcScaleResponse.RequestId = _ctx.StringValue("DescribeRtcScale.RequestId");

			List<DescribeRtcScaleResponse.DescribeRtcScale_ScaleItem> describeRtcScaleResponse_scale = new List<DescribeRtcScaleResponse.DescribeRtcScale_ScaleItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcScale.Scale.Length"); i++) {
				DescribeRtcScaleResponse.DescribeRtcScale_ScaleItem scaleItem = new DescribeRtcScaleResponse.DescribeRtcScale_ScaleItem();
				scaleItem.Time = _ctx.StringValue("DescribeRtcScale.Scale["+ i +"].Time");
				scaleItem.ChannelCount = _ctx.LongValue("DescribeRtcScale.Scale["+ i +"].ChannelCount");
				scaleItem.UserCount = _ctx.LongValue("DescribeRtcScale.Scale["+ i +"].UserCount");
				scaleItem.SessionCount = _ctx.LongValue("DescribeRtcScale.Scale["+ i +"].SessionCount");
				scaleItem.AudioDuration = _ctx.LongValue("DescribeRtcScale.Scale["+ i +"].AudioDuration");
				scaleItem.VideoDuration = _ctx.LongValue("DescribeRtcScale.Scale["+ i +"].VideoDuration");

				describeRtcScaleResponse_scale.Add(scaleItem);
			}
			describeRtcScaleResponse.Scale = describeRtcScaleResponse_scale;
        
			return describeRtcScaleResponse;
        }
    }
}
