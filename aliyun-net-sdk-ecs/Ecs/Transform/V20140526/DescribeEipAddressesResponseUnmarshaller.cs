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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEipAddressesResponseUnmarshaller
    {
        public static DescribeEipAddressesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEipAddressesResponse describeEipAddressesResponse = new DescribeEipAddressesResponse();

			describeEipAddressesResponse.HttpResponse = context.HttpResponse;
			describeEipAddressesResponse.RequestId = context.StringValue("DescribeEipAddresses.RequestId");
			describeEipAddressesResponse.TotalCount = context.IntegerValue("DescribeEipAddresses.TotalCount");
			describeEipAddressesResponse.PageNumber = context.IntegerValue("DescribeEipAddresses.PageNumber");
			describeEipAddressesResponse.PageSize = context.IntegerValue("DescribeEipAddresses.PageSize");

			List<DescribeEipAddressesResponse.EipAddress> eipAddresses = new List<DescribeEipAddressesResponse.EipAddress>();
			for (int i = 0; i < context.Length("DescribeEipAddresses.EipAddresses.Length"); i++) {
				DescribeEipAddressesResponse.EipAddress eipAddress = new DescribeEipAddressesResponse.EipAddress();
				eipAddress.RegionId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].RegionId");
				eipAddress.IpAddress = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].IpAddress");
				eipAddress.AllocationId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationId");
				eipAddress.Status = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Status");
				eipAddress.InstanceId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceId");
				eipAddress.Bandwidth = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Bandwidth");
				eipAddress.InternetChargeType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InternetChargeType");
				eipAddress.AllocationTime = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationTime");

				List<DescribeEipAddressesResponse.EipAddress.LockReason> operationLocks = new List<DescribeEipAddressesResponse.EipAddress.LockReason>();
				for (int j = 0; j < context.Length("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks.Length"); j++) {
					DescribeEipAddressesResponse.EipAddress.LockReason lockReason = new DescribeEipAddressesResponse.EipAddress.LockReason();
					lockReason.LockReason_ = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks["+ j +"].LockReason");

					operationLocks.Add(lockReason);
				}
				eipAddress.OperationLocks = operationLocks;

				eipAddresses.Add(eipAddress);
			}
			describeEipAddressesResponse.EipAddresses = eipAddresses;
        
			return describeEipAddressesResponse;
        }
    }
}