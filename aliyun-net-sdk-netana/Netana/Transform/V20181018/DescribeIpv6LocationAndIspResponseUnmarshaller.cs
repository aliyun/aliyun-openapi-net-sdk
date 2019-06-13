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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class DescribeIpv6LocationAndIspResponseUnmarshaller
    {
        public static DescribeIpv6LocationAndIspResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpv6LocationAndIspResponse describeIpv6LocationAndIspResponse = new DescribeIpv6LocationAndIspResponse();

			describeIpv6LocationAndIspResponse.HttpResponse = context.HttpResponse;
			describeIpv6LocationAndIspResponse.RequestId = context.StringValue("DescribeIpv6LocationAndIsp.RequestId");
			describeIpv6LocationAndIspResponse.IpAddress = context.StringValue("DescribeIpv6LocationAndIsp.IpAddress");
			describeIpv6LocationAndIspResponse.Country = context.StringValue("DescribeIpv6LocationAndIsp.Country");
			describeIpv6LocationAndIspResponse.City = context.StringValue("DescribeIpv6LocationAndIsp.City");
			describeIpv6LocationAndIspResponse.ISP = context.StringValue("DescribeIpv6LocationAndIsp.ISP");
			describeIpv6LocationAndIspResponse.CountryCode = context.StringValue("DescribeIpv6LocationAndIsp.CountryCode");
			describeIpv6LocationAndIspResponse.CityCode = context.StringValue("DescribeIpv6LocationAndIsp.CityCode");
			describeIpv6LocationAndIspResponse.ISPCode = context.StringValue("DescribeIpv6LocationAndIsp.ISPCode");
        
			return describeIpv6LocationAndIspResponse;
        }
    }
}
