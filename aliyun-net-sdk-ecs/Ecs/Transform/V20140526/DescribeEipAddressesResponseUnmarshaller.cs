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
    public class DescribeEipAddressesResponseUnmarshaller
    {
        public static DescribeEipAddressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEipAddressesResponse describeEipAddressesResponse = new DescribeEipAddressesResponse();

			describeEipAddressesResponse.HttpResponse = _ctx.HttpResponse;
			describeEipAddressesResponse.PageSize = _ctx.IntegerValue("DescribeEipAddresses.PageSize");
			describeEipAddressesResponse.RequestId = _ctx.StringValue("DescribeEipAddresses.RequestId");
			describeEipAddressesResponse.PageNumber = _ctx.IntegerValue("DescribeEipAddresses.PageNumber");
			describeEipAddressesResponse.TotalCount = _ctx.IntegerValue("DescribeEipAddresses.TotalCount");

			List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress> describeEipAddressesResponse_eipAddresses = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress>();
			for (int i = 0; i < _ctx.Length("DescribeEipAddresses.EipAddresses.Length"); i++) {
				DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress eipAddress = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress();
				eipAddress.Status = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Status");
				eipAddress.AllocationTime = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationTime");
				eipAddress.ChargeType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ChargeType");
				eipAddress.InstanceId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceId");
				eipAddress.InstanceType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceType");
				eipAddress.RegionId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].RegionId");
				eipAddress.IpAddress = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].IpAddress");
				eipAddress.Bandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Bandwidth");
				eipAddress.ExpiredTime = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ExpiredTime");
				eipAddress.AllocationId = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationId");
				eipAddress.InternetChargeType = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InternetChargeType");
				eipAddress.EipBandwidth = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].EipBandwidth");

				List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason> eipAddress_operationLocks = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason>();
				for (int j = 0; j < _ctx.Length("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks.Length"); j++) {
					DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason lockReason = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason();
					lockReason.LockReason = _ctx.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks["+ j +"].LockReason");

					eipAddress_operationLocks.Add(lockReason);
				}
				eipAddress.OperationLocks = eipAddress_operationLocks;

				describeEipAddressesResponse_eipAddresses.Add(eipAddress);
			}
			describeEipAddressesResponse.EipAddresses = describeEipAddressesResponse_eipAddresses;
        
			return describeEipAddressesResponse;
        }
    }
}
