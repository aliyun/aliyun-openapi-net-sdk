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

			List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress> describeEipAddressesResponse_eipAddresses = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress>();
			for (int i = 0; i < context.Length("DescribeEipAddresses.EipAddresses.Length"); i++) {
				DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress eipAddress = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress();
				eipAddress.RegionId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].RegionId");
				eipAddress.IpAddress = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].IpAddress");
				eipAddress.PrivateIpAddress = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].PrivateIpAddress");
				eipAddress.AllocationId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationId");
				eipAddress.Status = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Status");
				eipAddress.InstanceId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceId");
				eipAddress.Bandwidth = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Bandwidth");
				eipAddress.EipBandwidth = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].EipBandwidth");
				eipAddress.InternetChargeType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InternetChargeType");
				eipAddress.AllocationTime = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AllocationTime");
				eipAddress.InstanceType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceType");
				eipAddress.InstanceRegionId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].InstanceRegionId");
				eipAddress.ChargeType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ChargeType");
				eipAddress.ExpiredTime = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ExpiredTime");
				eipAddress.HDMonitorStatus = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].HDMonitorStatus");
				eipAddress.Name = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Name");
				eipAddress.ISP = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ISP");
				eipAddress.Descritpion = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Descritpion");
				eipAddress.BandwidthPackageId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageId");
				eipAddress.BandwidthPackageType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageType");
				eipAddress.BandwidthPackageBandwidth = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].BandwidthPackageBandwidth");
				eipAddress.ResourceGroupId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ResourceGroupId");
				eipAddress.HasReservationData = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].HasReservationData");
				eipAddress.ReservationBandwidth = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationBandwidth");
				eipAddress.ReservationInternetChargeType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationInternetChargeType");
				eipAddress.ReservationActiveTime = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationActiveTime");
				eipAddress.ReservationOrderType = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].ReservationOrderType");
				eipAddress.Mode = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Mode");
				eipAddress.DeletionProtection = context.BooleanValue("DescribeEipAddresses.EipAddresses["+ i +"].DeletionProtection");
				eipAddress.SecondLimited = context.BooleanValue("DescribeEipAddresses.EipAddresses["+ i +"].SecondLimited");
				eipAddress.SegmentInstanceId = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].SegmentInstanceId");

				List<string> eipAddress_availableRegions = new List<string>();
				for (int j = 0; j < context.Length("DescribeEipAddresses.EipAddresses["+ i +"].AvailableRegions.Length"); j++) {
					eipAddress_availableRegions.Add(context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].AvailableRegions["+ j +"]"));
				}
				eipAddress.AvailableRegions = eipAddress_availableRegions;

				List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason> eipAddress_operationLocks = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason>();
				for (int j = 0; j < context.Length("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks.Length"); j++) {
					DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason lockReason = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_LockReason();
					lockReason.LockReason = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].OperationLocks["+ j +"].LockReason");

					eipAddress_operationLocks.Add(lockReason);
				}
				eipAddress.OperationLocks = eipAddress_operationLocks;

				List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag> eipAddress_tags = new List<DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag>();
				for (int j = 0; j < context.Length("DescribeEipAddresses.EipAddresses["+ i +"].Tags.Length"); j++) {
					DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag tag = new DescribeEipAddressesResponse.DescribeEipAddresses_EipAddress.DescribeEipAddresses_Tag();
					tag.Key = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeEipAddresses.EipAddresses["+ i +"].Tags["+ j +"].Value");

					eipAddress_tags.Add(tag);
				}
				eipAddress.Tags = eipAddress_tags;

				describeEipAddressesResponse_eipAddresses.Add(eipAddress);
			}
			describeEipAddressesResponse.EipAddresses = describeEipAddressesResponse_eipAddresses;
        
			return describeEipAddressesResponse;
        }
    }
}
