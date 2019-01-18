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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeCommonBandwidthPackagesResponseUnmarshaller
    {
        public static DescribeCommonBandwidthPackagesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCommonBandwidthPackagesResponse describeCommonBandwidthPackagesResponse = new DescribeCommonBandwidthPackagesResponse();

			describeCommonBandwidthPackagesResponse.HttpResponse = context.HttpResponse;
			describeCommonBandwidthPackagesResponse.RequestId = context.StringValue("DescribeCommonBandwidthPackages.RequestId");
			describeCommonBandwidthPackagesResponse.TotalCount = context.IntegerValue("DescribeCommonBandwidthPackages.TotalCount");
			describeCommonBandwidthPackagesResponse.PageNumber = context.IntegerValue("DescribeCommonBandwidthPackages.PageNumber");
			describeCommonBandwidthPackagesResponse.PageSize = context.IntegerValue("DescribeCommonBandwidthPackages.PageSize");

			List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage> describeCommonBandwidthPackagesResponse_commonBandwidthPackages = new List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage>();
			for (int i = 0; i < context.Length("DescribeCommonBandwidthPackages.CommonBandwidthPackages.Length"); i++) {
				DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage commonBandwidthPackage = new DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage();
				commonBandwidthPackage.BandwidthPackageId = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].BandwidthPackageId");
				commonBandwidthPackage.RegionId = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].RegionId");
				commonBandwidthPackage.Name = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Name");
				commonBandwidthPackage.Description = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Description");
				commonBandwidthPackage.Bandwidth = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Bandwidth");
				commonBandwidthPackage.InstanceChargeType = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].InstanceChargeType");
				commonBandwidthPackage.InternetChargeType = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].InternetChargeType");
				commonBandwidthPackage.BusinessStatus = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].BusinessStatus");
				commonBandwidthPackage.CreationTime = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].CreationTime");
				commonBandwidthPackage.ExpiredTime = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].ExpiredTime");
				commonBandwidthPackage.Status = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Status");
				commonBandwidthPackage.Ratio = context.IntegerValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].Ratio");

				List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse> commonBandwidthPackage_publicIpAddresses = new List<DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse>();
				for (int j = 0; j < context.Length("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses.Length"); j++) {
					DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse publicIpAddresse = new DescribeCommonBandwidthPackagesResponse.DescribeCommonBandwidthPackages_CommonBandwidthPackage.DescribeCommonBandwidthPackages_PublicIpAddresse();
					publicIpAddresse.AllocationId = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].AllocationId");
					publicIpAddresse.IpAddress = context.StringValue("DescribeCommonBandwidthPackages.CommonBandwidthPackages["+ i +"].PublicIpAddresses["+ j +"].IpAddress");

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