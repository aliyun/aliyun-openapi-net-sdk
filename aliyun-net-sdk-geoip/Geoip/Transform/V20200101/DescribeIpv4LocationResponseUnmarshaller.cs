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
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeIpv4LocationResponseUnmarshaller
    {
        public static DescribeIpv4LocationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpv4LocationResponse describeIpv4LocationResponse = new DescribeIpv4LocationResponse();

			describeIpv4LocationResponse.HttpResponse = context.HttpResponse;
			describeIpv4LocationResponse.RequestId = context.StringValue("DescribeIpv4Location.RequestId");
			describeIpv4LocationResponse.Ip = context.StringValue("DescribeIpv4Location.Ip");
			describeIpv4LocationResponse.Country = context.StringValue("DescribeIpv4Location.Country");
			describeIpv4LocationResponse.Province = context.StringValue("DescribeIpv4Location.Province");
			describeIpv4LocationResponse.City = context.StringValue("DescribeIpv4Location.City");
			describeIpv4LocationResponse.County = context.StringValue("DescribeIpv4Location.County");
			describeIpv4LocationResponse.Isp = context.StringValue("DescribeIpv4Location.Isp");
        
			return describeIpv4LocationResponse;
        }
    }
}
