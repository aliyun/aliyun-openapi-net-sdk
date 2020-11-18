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
    public class DescribeRtcDurationDataResponseUnmarshaller
    {
        public static DescribeRtcDurationDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcDurationDataResponse describeRtcDurationDataResponse = new DescribeRtcDurationDataResponse();

			describeRtcDurationDataResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcDurationDataResponse.RequestId = _ctx.StringValue("DescribeRtcDurationData.RequestId");

			List<DescribeRtcDurationDataResponse.DescribeRtcDurationData_DurationModule> describeRtcDurationDataResponse_durationDataPerInterval = new List<DescribeRtcDurationDataResponse.DescribeRtcDurationData_DurationModule>();
			for (int i = 0; i < _ctx.Length("DescribeRtcDurationData.DurationDataPerInterval.Length"); i++) {
				DescribeRtcDurationDataResponse.DescribeRtcDurationData_DurationModule durationModule = new DescribeRtcDurationDataResponse.DescribeRtcDurationData_DurationModule();
				durationModule.TimeStamp = _ctx.StringValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].TimeStamp");
				durationModule.TotalDuration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].TotalDuration");
				durationModule.AudioDuration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].AudioDuration");
				durationModule.V360Duration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].V360Duration");
				durationModule.V720Duration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].V720Duration");
				durationModule.V1080Duration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].V1080Duration");
				durationModule.ContentDuration = _ctx.LongValue("DescribeRtcDurationData.DurationDataPerInterval["+ i +"].ContentDuration");

				describeRtcDurationDataResponse_durationDataPerInterval.Add(durationModule);
			}
			describeRtcDurationDataResponse.DurationDataPerInterval = describeRtcDurationDataResponse_durationDataPerInterval;
        
			return describeRtcDurationDataResponse;
        }
    }
}
