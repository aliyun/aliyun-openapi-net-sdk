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
    public class AssignIpv6AddressesResponseUnmarshaller
    {
        public static AssignIpv6AddressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssignIpv6AddressesResponse assignIpv6AddressesResponse = new AssignIpv6AddressesResponse();

			assignIpv6AddressesResponse.HttpResponse = _ctx.HttpResponse;
			assignIpv6AddressesResponse.RequestId = _ctx.StringValue("AssignIpv6Addresses.RequestId");
			assignIpv6AddressesResponse.NetworkInterfaceId = _ctx.StringValue("AssignIpv6Addresses.NetworkInterfaceId");

			List<string> assignIpv6AddressesResponse_ipv6Sets = new List<string>();
			for (int i = 0; i < _ctx.Length("AssignIpv6Addresses.Ipv6Sets.Length"); i++) {
				assignIpv6AddressesResponse_ipv6Sets.Add(_ctx.StringValue("AssignIpv6Addresses.Ipv6Sets["+ i +"]"));
			}
			assignIpv6AddressesResponse.Ipv6Sets = assignIpv6AddressesResponse_ipv6Sets;
        
			return assignIpv6AddressesResponse;
        }
    }
}
