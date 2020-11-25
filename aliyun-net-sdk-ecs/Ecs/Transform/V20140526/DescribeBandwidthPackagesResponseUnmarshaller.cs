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
    public class DescribeBandwidthPackagesResponseUnmarshaller
    {
        public static DescribeBandwidthPackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBandwidthPackagesResponse describeBandwidthPackagesResponse = new DescribeBandwidthPackagesResponse();

			describeBandwidthPackagesResponse.HttpResponse = _ctx.HttpResponse;
			describeBandwidthPackagesResponse.RequestId = _ctx.StringValue("DescribeBandwidthPackages.RequestId");
			describeBandwidthPackagesResponse.TotalCount = _ctx.IntegerValue("DescribeBandwidthPackages.TotalCount");
			describeBandwidthPackagesResponse.PageNumber = _ctx.IntegerValue("DescribeBandwidthPackages.PageNumber");
			describeBandwidthPackagesResponse.PageSize = _ctx.IntegerValue("DescribeBandwidthPackages.PageSize");

			List<DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage> describeBandwidthPackagesResponse_bandwidthPackages = new List<DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage>();
			for (int i = 0; i < _ctx.Length("DescribeBandwidthPackages.BandwidthPackages.Length"); i++) {
				DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage bandwidthPackage = new DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage();
				bandwidthPackage.BandwidthPackageId = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].BandwidthPackageId");
				bandwidthPackage.RegionId = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].RegionId");
				bandwidthPackage.Name = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].Name");
				bandwidthPackage.Description = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].Description");
				bandwidthPackage.ZoneId = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].ZoneId");
				bandwidthPackage.NatGatewayId = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].NatGatewayId");
				bandwidthPackage.Bandwidth = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].Bandwidth");
				bandwidthPackage.InstanceChargeType = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].InstanceChargeType");
				bandwidthPackage.InternetChargeType = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].InternetChargeType");
				bandwidthPackage.BusinessStatus = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].BusinessStatus");
				bandwidthPackage.IpCount = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].IpCount");
				bandwidthPackage.ISP = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].ISP");
				bandwidthPackage.CreationTime = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].CreationTime");
				bandwidthPackage.Status = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].Status");

				List<DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage.DescribeBandwidthPackages_PublicIpAddresse> bandwidthPackage_publicIpAddresses = new List<DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage.DescribeBandwidthPackages_PublicIpAddresse>();
				for (int j = 0; j < _ctx.Length("DescribeBandwidthPackages.BandwidthPackages["+ i +"].PublicIpAddresses.Length"); j++) {
					DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage.DescribeBandwidthPackages_PublicIpAddresse publicIpAddresse = new DescribeBandwidthPackagesResponse.DescribeBandwidthPackages_BandwidthPackage.DescribeBandwidthPackages_PublicIpAddresse();
					publicIpAddresse.AllocationId = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].AllocationId");
					publicIpAddresse.IpAddress = _ctx.StringValue("DescribeBandwidthPackages.BandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].IpAddress");

					bandwidthPackage_publicIpAddresses.Add(publicIpAddresse);
				}
				bandwidthPackage.PublicIpAddresses = bandwidthPackage_publicIpAddresses;

				describeBandwidthPackagesResponse_bandwidthPackages.Add(bandwidthPackage);
			}
			describeBandwidthPackagesResponse.BandwidthPackages = describeBandwidthPackagesResponse_bandwidthPackages;
        
			return describeBandwidthPackagesResponse;
        }
    }
}
