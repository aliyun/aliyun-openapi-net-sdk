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
    public class DescribeLivePrivateLineAvailGAResponseUnmarshaller
    {
        public static DescribeLivePrivateLineAvailGAResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePrivateLineAvailGAResponse describeLivePrivateLineAvailGAResponse = new DescribeLivePrivateLineAvailGAResponse();

			describeLivePrivateLineAvailGAResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePrivateLineAvailGAResponse.RequestId = _ctx.StringValue("DescribeLivePrivateLineAvailGA.RequestId");

			List<DescribeLivePrivateLineAvailGAResponse.DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA> describeLivePrivateLineAvailGAResponse_livePrivateLineAvailGAs = new List<DescribeLivePrivateLineAvailGAResponse.DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA>();
			for (int i = 0; i < _ctx.Length("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs.Length"); i++) {
				DescribeLivePrivateLineAvailGAResponse.DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA livePrivateLineAvailGA = new DescribeLivePrivateLineAvailGAResponse.DescribeLivePrivateLineAvailGA_LivePrivateLineAvailGA();
				livePrivateLineAvailGA.AccelerationArea = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].AccelerationArea");
				livePrivateLineAvailGA.AccelerationType = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].AccelerationType");
				livePrivateLineAvailGA.AppName = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].AppName");
				livePrivateLineAvailGA.BindingStatus = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].BindingStatus");
				livePrivateLineAvailGA.DomainName = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].DomainName");
				livePrivateLineAvailGA.IP = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].IP");
				livePrivateLineAvailGA.InstanceId = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].InstanceId");
				livePrivateLineAvailGA.Status = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].Status");
				livePrivateLineAvailGA.StreamName = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].StreamName");
				livePrivateLineAvailGA.Uid = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].Uid");
				livePrivateLineAvailGA.VideoCenter = _ctx.StringValue("DescribeLivePrivateLineAvailGA.LivePrivateLineAvailGAs["+ i +"].VideoCenter");

				describeLivePrivateLineAvailGAResponse_livePrivateLineAvailGAs.Add(livePrivateLineAvailGA);
			}
			describeLivePrivateLineAvailGAResponse.LivePrivateLineAvailGAs = describeLivePrivateLineAvailGAResponse_livePrivateLineAvailGAs;
        
			return describeLivePrivateLineAvailGAResponse;
        }
    }
}
