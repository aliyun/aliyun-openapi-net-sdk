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
    public class DescribeCommonBandwidthPackagesResponseUnmarshaller
    {
        public static DescribeCommonBandwidthPackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCommonBandwidthPackagesResponse describeCommonBandwidthPackagesResponse = new DescribeCommonBandwidthPackagesResponse();

			describeCommonBandwidthPackagesResponse.HttpResponse = _ctx.HttpResponse;
			describeCommonBandwidthPackagesResponse.PageSize = _ctx.IntegerValue("DescribeCommonBandwidthPackages.PageSize");
			describeCommonBandwidthPackagesResponse.RequestId = _ctx.StringValue("DescribeCommonBandwidthPackages.RequestId");
			describeCommonBandwidthPackagesResponse.PageNumber = _ctx.IntegerValue("DescribeCommonBandwidthPackages.PageNumber");
			describeCommonBandwidthPackagesResponse.TotalCount = _ctx.IntegerValue("DescribeCommonBandwidthPackages.TotalCount");

			List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage> describeCommonBandwidthPackagesResponse_commonBandwidthPackages = new List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage>();
			for (int i = 0; i < _ctx.Length("DescribeCommonBandwidthPackages.CommonBandwidthPackages.Length"); i++) {
				DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage commonBandwidthPackage = new DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage();
				commonBandwidthPackage.ReservationActiveTime = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ReservationActiveTime");
				commonBandwidthPackage.Status = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Status");
				commonBandwidthPackage.CreationTime = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].CreationTime");
				commonBandwidthPackage.ReservationOrderType = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ReservationOrderType");
				commonBandwidthPackage.DeletionProtection = _ctx.BooleanValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].DeletionProtection");
				commonBandwidthPackage.ReservationInternetChargeType = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ReservationInternetChargeType");
				commonBandwidthPackage.Ratio = _ctx.IntegerValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Ratio");
				commonBandwidthPackage.InstanceChargeType = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].InstanceChargeType");
				commonBandwidthPackage.RegionId = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].RegionId");
				commonBandwidthPackage.BandwidthPackageId = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].BandwidthPackageId");
				commonBandwidthPackage.ServiceManaged = _ctx.IntegerValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ServiceManaged");
				commonBandwidthPackage.Bandwidth = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Bandwidth");
				commonBandwidthPackage.Description = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Description");
				commonBandwidthPackage.ExpiredTime = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ExpiredTime");
				commonBandwidthPackage.ReservationBandwidth = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ReservationBandwidth");
				commonBandwidthPackage.ResourceGroupId = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ResourceGroupId");
				commonBandwidthPackage.InternetChargeType = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].InternetChargeType");
				commonBandwidthPackage.BusinessStatus = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].BusinessStatus");
				commonBandwidthPackage.Name = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Name");
				commonBandwidthPackage.ISP = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ISP");
				commonBandwidthPackage.HasReservationData = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].HasReservationData");

				List<string> commonBandwidthPackage_securityProtectionTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].SecurityProtectionTypes.Length"); j++) {
					commonBandwidthPackage_securityProtectionTypes.Add(_ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].SecurityProtectionTypes["+ j +"]"));
				}
				commonBandwidthPackage.SecurityProtectionTypes = commonBandwidthPackage_securityProtectionTypes;

				List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse> commonBandwidthPackage_publicIpAddresses = new List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse>();
				for (int j = 0; j < _ctx.Length("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses.Length"); j++) {
					DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse publicIpAddresse = new DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse();
					publicIpAddresse.IpAddress = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].IpAddress");
					publicIpAddresse.AllocationId = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].AllocationId");
					publicIpAddresse.BandwidthPackageIpRelationStatus = _ctx.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].BandwidthPackageIpRelationStatus");

					commonBandwidthPackage_publicIpAddresses.Add(publicIpAddresse);
				}
				commonBandwidthPackage.PublicIpAddresses = commonBandwidthPackage_publicIpAddresses;

				describeCommonBandwidthPackagesResponse_commonBandwidthPackages.Add(commonBandwidthPackage);
			}
			describeCommonBandwidthPackagesResponse.CommonBandwidthPackages = describeCommonBandwidthPackagesResponse_commonBandwidthPackages;
        
			return describeCommonBandwidthPackagesResponse;
        }
    }
}
