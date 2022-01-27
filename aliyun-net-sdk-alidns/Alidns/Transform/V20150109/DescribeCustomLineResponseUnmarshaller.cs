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
    public class DescribeCustomLineResponseUnmarshaller
    {
        public static DescribeCustomLineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomLineResponse describeCustomLineResponse = new DescribeCustomLineResponse();

			describeCustomLineResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomLineResponse.RequestId = _ctx.StringValue("DescribeCustomLine.RequestId");
			describeCustomLineResponse.Id = _ctx.LongValue("DescribeCustomLine.Id");
			describeCustomLineResponse.Name = _ctx.StringValue("DescribeCustomLine.Name");
			describeCustomLineResponse.DomainName = _ctx.StringValue("DescribeCustomLine.DomainName");
			describeCustomLineResponse.CreateTime = _ctx.StringValue("DescribeCustomLine.CreateTime");
			describeCustomLineResponse.CreateTimestamp = _ctx.LongValue("DescribeCustomLine.CreateTimestamp");
			describeCustomLineResponse.IpSegments = _ctx.StringValue("DescribeCustomLine.IpSegments");
			describeCustomLineResponse.Code = _ctx.StringValue("DescribeCustomLine.Code");

			List<DescribeCustomLineResponse.DescribeCustomLine_IpSegment> describeCustomLineResponse_ipSegmentList = new List<DescribeCustomLineResponse.DescribeCustomLine_IpSegment>();
			for (int i = 0; i < _ctx.Length("DescribeCustomLine.IpSegmentList.Length"); i++) {
				DescribeCustomLineResponse.DescribeCustomLine_IpSegment ipSegment = new DescribeCustomLineResponse.DescribeCustomLine_IpSegment();
				ipSegment.Name = _ctx.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].Name");
				ipSegment.StartIp = _ctx.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].StartIp");
				ipSegment.EndIp = _ctx.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].EndIp");

				describeCustomLineResponse_ipSegmentList.Add(ipSegment);
			}
			describeCustomLineResponse.IpSegmentList = describeCustomLineResponse_ipSegmentList;
        
			return describeCustomLineResponse;
        }
    }
}
