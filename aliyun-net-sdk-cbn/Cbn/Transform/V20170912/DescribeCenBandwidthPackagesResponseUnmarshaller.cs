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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCenBandwidthPackagesResponseUnmarshaller
    {
        public static DescribeCenBandwidthPackagesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenBandwidthPackagesResponse describeCenBandwidthPackagesResponse = new DescribeCenBandwidthPackagesResponse();

			describeCenBandwidthPackagesResponse.HttpResponse = context.HttpResponse;
			describeCenBandwidthPackagesResponse.RequestId = context.StringValue("DescribeCenBandwidthPackages.RequestId");
			describeCenBandwidthPackagesResponse.TotalCount = context.IntegerValue("DescribeCenBandwidthPackages.TotalCount");
			describeCenBandwidthPackagesResponse.PageNumber = context.IntegerValue("DescribeCenBandwidthPackages.PageNumber");
			describeCenBandwidthPackagesResponse.PageSize = context.IntegerValue("DescribeCenBandwidthPackages.PageSize");

			List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage> describeCenBandwidthPackagesResponse_cenBandwidthPackages = new List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage>();
			for (int i = 0; i < context.Length("DescribeCenBandwidthPackages.CenBandwidthPackages.Length"); i++) {
				DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage cenBandwidthPackage = new DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage();
				cenBandwidthPackage.CenBandwidthPackageId = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenBandwidthPackageId");
				cenBandwidthPackage.Name = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Name");
				cenBandwidthPackage.Description = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Description");
				cenBandwidthPackage.Bandwidth = context.LongValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Bandwidth");
				cenBandwidthPackage.BandwidthPackageChargeType = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].BandwidthPackageChargeType");
				cenBandwidthPackage.GeographicRegionAId = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicRegionAId");
				cenBandwidthPackage.GeographicRegionBId = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicRegionBId");
				cenBandwidthPackage.GeographicSpanId = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicSpanId");
				cenBandwidthPackage.BusinessStatus = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].BusinessStatus");
				cenBandwidthPackage.CreationTime = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CreationTime");
				cenBandwidthPackage.ExpiredTime = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ExpiredTime");
				cenBandwidthPackage.Status = context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Status");
				cenBandwidthPackage.IsCrossBorder = context.BooleanValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].IsCrossBorder");

				List<string> cenBandwidthPackage_cenIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenIds.Length"); j++) {
					cenBandwidthPackage_cenIds.Add(context.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenIds["+ j +"]"));
				}
				cenBandwidthPackage.CenIds = cenBandwidthPackage_cenIds;

				describeCenBandwidthPackagesResponse_cenBandwidthPackages.Add(cenBandwidthPackage);
			}
			describeCenBandwidthPackagesResponse.CenBandwidthPackages = describeCenBandwidthPackagesResponse_cenBandwidthPackages;
        
			return describeCenBandwidthPackagesResponse;
        }
    }
}
