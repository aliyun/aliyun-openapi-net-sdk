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
        public static DescribeCustomLineResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCustomLineResponse describeCustomLineResponse = new DescribeCustomLineResponse();

			describeCustomLineResponse.HttpResponse = context.HttpResponse;
			describeCustomLineResponse.RequestId = context.StringValue("DescribeCustomLine.RequestId");
			describeCustomLineResponse.Id = context.LongValue("DescribeCustomLine.Id");
			describeCustomLineResponse.Name = context.StringValue("DescribeCustomLine.Name");
			describeCustomLineResponse.DomainName = context.StringValue("DescribeCustomLine.DomainName");
			describeCustomLineResponse.CreateTime = context.StringValue("DescribeCustomLine.CreateTime");
			describeCustomLineResponse.CreateTimestamp = context.LongValue("DescribeCustomLine.CreateTimestamp");
			describeCustomLineResponse.IpSegments = context.StringValue("DescribeCustomLine.IpSegments");
			describeCustomLineResponse.Code = context.StringValue("DescribeCustomLine.Code");

			List<DescribeCustomLineResponse.DescribeCustomLine_IpSegment> describeCustomLineResponse_ipSegmentList = new List<DescribeCustomLineResponse.DescribeCustomLine_IpSegment>();
			for (int i = 0; i < context.Length("DescribeCustomLine.IpSegmentList.Length"); i++) {
				DescribeCustomLineResponse.DescribeCustomLine_IpSegment ipSegment = new DescribeCustomLineResponse.DescribeCustomLine_IpSegment();
				ipSegment.Name = context.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].Name");
				ipSegment.StartIp = context.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].StartIp");
				ipSegment.EndIp = context.StringValue("DescribeCustomLine.IpSegmentList["+ i +"].EndIp");

				describeCustomLineResponse_ipSegmentList.Add(ipSegment);
			}
			describeCustomLineResponse.IpSegmentList = describeCustomLineResponse_ipSegmentList;
        
			return describeCustomLineResponse;
        }
    }
}
