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
    public class DescribeIpLocationAndIspResponseUnmarshaller
    {
        public static DescribeIpLocationAndIspResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpLocationAndIspResponse describeIpLocationAndIspResponse = new DescribeIpLocationAndIspResponse();

			describeIpLocationAndIspResponse.HttpResponse = context.HttpResponse;
			describeIpLocationAndIspResponse.RequestId = context.StringValue("DescribeIpLocationAndIsp.RequestId");
			describeIpLocationAndIspResponse.IpAddress = context.StringValue("DescribeIpLocationAndIsp.IpAddress");
			describeIpLocationAndIspResponse.Country = context.StringValue("DescribeIpLocationAndIsp.Country");
			describeIpLocationAndIspResponse.City = context.StringValue("DescribeIpLocationAndIsp.City");
			describeIpLocationAndIspResponse.ISP = context.StringValue("DescribeIpLocationAndIsp.ISP");
			describeIpLocationAndIspResponse.CountryCode = context.StringValue("DescribeIpLocationAndIsp.CountryCode");
			describeIpLocationAndIspResponse.CityCode = context.StringValue("DescribeIpLocationAndIsp.CityCode");
			describeIpLocationAndIspResponse.ISPCode = context.StringValue("DescribeIpLocationAndIsp.ISPCode");
        
			return describeIpLocationAndIspResponse;
        }
    }
}
