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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeInstanceTenantModesResponseUnmarshaller
    {
        public static DescribeInstanceTenantModesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceTenantModesResponse describeInstanceTenantModesResponse = new DescribeInstanceTenantModesResponse();

			describeInstanceTenantModesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceTenantModesResponse.RequestId = _ctx.StringValue("DescribeInstanceTenantModes.RequestId");

			List<string> describeInstanceTenantModesResponse_instanceModes = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTenantModes.InstanceModes.Length"); i++) {
				describeInstanceTenantModesResponse_instanceModes.Add(_ctx.StringValue("DescribeInstanceTenantModes.InstanceModes["+ i +"]"));
			}
			describeInstanceTenantModesResponse.InstanceModes = describeInstanceTenantModesResponse_instanceModes;
        
			return describeInstanceTenantModesResponse;
        }
    }
}
