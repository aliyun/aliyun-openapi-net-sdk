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
    public class AssignPrivateIpAddressesResponseUnmarshaller
    {
        public static AssignPrivateIpAddressesResponse Unmarshall(UnmarshallerContext context)
        {
			AssignPrivateIpAddressesResponse assignPrivateIpAddressesResponse = new AssignPrivateIpAddressesResponse();

			assignPrivateIpAddressesResponse.HttpResponse = context.HttpResponse;
			assignPrivateIpAddressesResponse.RequestId = context.StringValue("AssignPrivateIpAddresses.RequestId");

			AssignPrivateIpAddressesResponse.AssignPrivateIpAddresses_AssignedPrivateIpAddressesSet assignedPrivateIpAddressesSet = new AssignPrivateIpAddressesResponse.AssignPrivateIpAddresses_AssignedPrivateIpAddressesSet();
			assignedPrivateIpAddressesSet.NetworkInterfaceId = context.StringValue("AssignPrivateIpAddresses.AssignedPrivateIpAddressesSet.NetworkInterfaceId");

			List<string> assignedPrivateIpAddressesSet_privateIpSet = new List<string>();
			for (int i = 0; i < context.Length("AssignPrivateIpAddresses.AssignedPrivateIpAddressesSet.PrivateIpSet.Length"); i++) {
				assignedPrivateIpAddressesSet_privateIpSet.Add(context.StringValue("AssignPrivateIpAddresses.AssignedPrivateIpAddressesSet.PrivateIpSet["+ i +"]"));
			}
			assignedPrivateIpAddressesSet.PrivateIpSet = assignedPrivateIpAddressesSet_privateIpSet;
			assignPrivateIpAddressesResponse.AssignedPrivateIpAddressesSet = assignedPrivateIpAddressesSet;
        
			return assignPrivateIpAddressesResponse;
        }
    }
}
