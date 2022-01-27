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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribePdnsUdpIpSegmentsResponseUnmarshaller
    {
        public static DescribePdnsUdpIpSegmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsUdpIpSegmentsResponse describePdnsUdpIpSegmentsResponse = new DescribePdnsUdpIpSegmentsResponse();

			describePdnsUdpIpSegmentsResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsUdpIpSegmentsResponse.TotalCount = _ctx.LongValue("DescribePdnsUdpIpSegments.TotalCount");
			describePdnsUdpIpSegmentsResponse.RequestId = _ctx.StringValue("DescribePdnsUdpIpSegments.RequestId");
			describePdnsUdpIpSegmentsResponse.PageSize = _ctx.LongValue("DescribePdnsUdpIpSegments.PageSize");
			describePdnsUdpIpSegmentsResponse.PageNumber = _ctx.LongValue("DescribePdnsUdpIpSegments.PageNumber");

			List<DescribePdnsUdpIpSegmentsResponse.DescribePdnsUdpIpSegments_IpSegment> describePdnsUdpIpSegmentsResponse_ipSegments = new List<DescribePdnsUdpIpSegmentsResponse.DescribePdnsUdpIpSegments_IpSegment>();
			for (int i = 0; i < _ctx.Length("DescribePdnsUdpIpSegments.IpSegments.Length"); i++) {
				DescribePdnsUdpIpSegmentsResponse.DescribePdnsUdpIpSegments_IpSegment ipSegment = new DescribePdnsUdpIpSegmentsResponse.DescribePdnsUdpIpSegments_IpSegment();
				ipSegment.UpdateDate = _ctx.StringValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].UpdateDate");
				ipSegment.State = _ctx.StringValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].State");
				ipSegment.Ip = _ctx.StringValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].Ip");
				ipSegment.Mask = _ctx.LongValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].Mask");
				ipSegment.CreateDate = _ctx.StringValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].CreateDate");
				ipSegment.Name = _ctx.StringValue("DescribePdnsUdpIpSegments.IpSegments["+ i +"].Name");

				describePdnsUdpIpSegmentsResponse_ipSegments.Add(ipSegment);
			}
			describePdnsUdpIpSegmentsResponse.IpSegments = describePdnsUdpIpSegmentsResponse_ipSegments;
        
			return describePdnsUdpIpSegmentsResponse;
        }
    }
}
