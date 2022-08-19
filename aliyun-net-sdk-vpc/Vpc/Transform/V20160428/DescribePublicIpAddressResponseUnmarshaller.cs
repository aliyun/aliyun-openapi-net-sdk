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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribePublicIpAddressResponseUnmarshaller
    {
        public static DescribePublicIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePublicIpAddressResponse describePublicIpAddressResponse = new DescribePublicIpAddressResponse();

			describePublicIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			describePublicIpAddressResponse.RequestId = _ctx.StringValue("DescribePublicIpAddress.RequestId");
			describePublicIpAddressResponse.Success = _ctx.BooleanValue("DescribePublicIpAddress.Success");
			describePublicIpAddressResponse.Code = _ctx.StringValue("DescribePublicIpAddress.Code");
			describePublicIpAddressResponse.Message = _ctx.StringValue("DescribePublicIpAddress.Message");
			describePublicIpAddressResponse.PageSize = _ctx.IntegerValue("DescribePublicIpAddress.PageSize");
			describePublicIpAddressResponse.PageNumber = _ctx.IntegerValue("DescribePublicIpAddress.PageNumber");
			describePublicIpAddressResponse.TotalCount = _ctx.IntegerValue("DescribePublicIpAddress.TotalCount");
			describePublicIpAddressResponse.RegionId = _ctx.StringValue("DescribePublicIpAddress.RegionId");
			describePublicIpAddressResponse.PublicIpAddress = _ctx.StringValue("DescribePublicIpAddress.PublicIpAddress");

			List<string> describePublicIpAddressResponse_ipRange = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePublicIpAddress.IpRange.Length"); i++) {
				describePublicIpAddressResponse_ipRange.Add(_ctx.StringValue("DescribePublicIpAddress.IpRange["+ i +"]"));
			}
			describePublicIpAddressResponse.IpRange = describePublicIpAddressResponse_ipRange;
        
			return describePublicIpAddressResponse;
        }
    }
}
