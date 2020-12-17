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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSpotAdviceResponseUnmarshaller
    {
        public static DescribeSpotAdviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSpotAdviceResponse describeSpotAdviceResponse = new DescribeSpotAdviceResponse();

			describeSpotAdviceResponse.HttpResponse = _ctx.HttpResponse;
			describeSpotAdviceResponse.RequestId = _ctx.StringValue("DescribeSpotAdvice.RequestId");
			describeSpotAdviceResponse.RegionId = _ctx.StringValue("DescribeSpotAdvice.RegionId");

			List<DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone> describeSpotAdviceResponse_availableSpotZones = new List<DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone>();
			for (int i = 0; i < _ctx.Length("DescribeSpotAdvice.AvailableSpotZones.Length"); i++) {
				DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone availableSpotZone = new DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone();
				availableSpotZone.ZoneId = _ctx.StringValue("DescribeSpotAdvice.AvailableSpotZones["+ i +"].ZoneId");

				List<DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone.DescribeSpotAdvice_AvailableSpotResource> availableSpotZone_availableSpotResources = new List<DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone.DescribeSpotAdvice_AvailableSpotResource>();
				for (int j = 0; j < _ctx.Length("DescribeSpotAdvice.AvailableSpotZones["+ i +"].AvailableSpotResources.Length"); j++) {
					DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone.DescribeSpotAdvice_AvailableSpotResource availableSpotResource = new DescribeSpotAdviceResponse.DescribeSpotAdvice_AvailableSpotZone.DescribeSpotAdvice_AvailableSpotResource();
					availableSpotResource.InstanceType = _ctx.StringValue("DescribeSpotAdvice.AvailableSpotZones["+ i +"].AvailableSpotResources["+ j +"].InstanceType");
					availableSpotResource.InterruptionRate = _ctx.FloatValue("DescribeSpotAdvice.AvailableSpotZones["+ i +"].AvailableSpotResources["+ j +"].InterruptionRate");
					availableSpotResource.InterruptRateDesc = _ctx.StringValue("DescribeSpotAdvice.AvailableSpotZones["+ i +"].AvailableSpotResources["+ j +"].InterruptRateDesc");
					availableSpotResource.AverageSpotDiscount = _ctx.IntegerValue("DescribeSpotAdvice.AvailableSpotZones["+ i +"].AvailableSpotResources["+ j +"].AverageSpotDiscount");

					availableSpotZone_availableSpotResources.Add(availableSpotResource);
				}
				availableSpotZone.AvailableSpotResources = availableSpotZone_availableSpotResources;

				describeSpotAdviceResponse_availableSpotZones.Add(availableSpotZone);
			}
			describeSpotAdviceResponse.AvailableSpotZones = describeSpotAdviceResponse_availableSpotZones;
        
			return describeSpotAdviceResponse;
        }
    }
}
