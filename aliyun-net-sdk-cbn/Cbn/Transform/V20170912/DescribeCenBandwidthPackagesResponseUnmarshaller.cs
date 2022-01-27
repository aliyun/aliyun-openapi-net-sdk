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
        public static DescribeCenBandwidthPackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenBandwidthPackagesResponse describeCenBandwidthPackagesResponse = new DescribeCenBandwidthPackagesResponse();

			describeCenBandwidthPackagesResponse.HttpResponse = _ctx.HttpResponse;
			describeCenBandwidthPackagesResponse.PageSize = _ctx.IntegerValue("DescribeCenBandwidthPackages.PageSize");
			describeCenBandwidthPackagesResponse.RequestId = _ctx.StringValue("DescribeCenBandwidthPackages.RequestId");
			describeCenBandwidthPackagesResponse.PageNumber = _ctx.IntegerValue("DescribeCenBandwidthPackages.PageNumber");
			describeCenBandwidthPackagesResponse.TotalCount = _ctx.IntegerValue("DescribeCenBandwidthPackages.TotalCount");

			List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage> describeCenBandwidthPackagesResponse_cenBandwidthPackages = new List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage>();
			for (int i = 0; i < _ctx.Length("DescribeCenBandwidthPackages.CenBandwidthPackages.Length"); i++) {
				DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage cenBandwidthPackage = new DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage();
				cenBandwidthPackage.ReservationActiveTime = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ReservationActiveTime");
				cenBandwidthPackage.Status = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Status");
				cenBandwidthPackage.CreationTime = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CreationTime");
				cenBandwidthPackage.ReservationOrderType = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ReservationOrderType");
				cenBandwidthPackage.BandwidthPackageChargeType = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].BandwidthPackageChargeType");
				cenBandwidthPackage.CenBandwidthPackageId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenBandwidthPackageId");
				cenBandwidthPackage.ReservationInternetChargeType = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ReservationInternetChargeType");
				cenBandwidthPackage.Ratio = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Ratio");
				cenBandwidthPackage.GeographicRegionAId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicRegionAId");
				cenBandwidthPackage.TypeFor95 = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].TypeFor95");
				cenBandwidthPackage.Bandwidth = _ctx.LongValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Bandwidth");
				cenBandwidthPackage.Description = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Description");
				cenBandwidthPackage.ExpiredTime = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ExpiredTime");
				cenBandwidthPackage.ReservationBandwidth = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ReservationBandwidth");
				cenBandwidthPackage.GeographicSpanId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicSpanId");
				cenBandwidthPackage.GeographicRegionBId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].GeographicRegionBId");
				cenBandwidthPackage.ResourceGroupId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].ResourceGroupId");
				cenBandwidthPackage.IsCrossBorder = _ctx.BooleanValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].IsCrossBorder");
				cenBandwidthPackage.BusinessStatus = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].BusinessStatus");
				cenBandwidthPackage.Name = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Name");
				cenBandwidthPackage.HasReservationData = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].HasReservationData");

				List<string> cenBandwidthPackage_cenIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenIds.Length"); j++) {
					cenBandwidthPackage_cenIds.Add(_ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].CenIds["+ j +"]"));
				}
				cenBandwidthPackage.CenIds = cenBandwidthPackage_cenIds;

				List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit> cenBandwidthPackage_orginInterRegionBandwidthLimits = new List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit>();
				for (int j = 0; j < _ctx.Length("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].OrginInterRegionBandwidthLimits.Length"); j++) {
					DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit orginInterRegionBandwidthLimit = new DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_OrginInterRegionBandwidthLimit();
					orginInterRegionBandwidthLimit.BandwidthLimit = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].OrginInterRegionBandwidthLimits["+ j +"].BandwidthLimit");
					orginInterRegionBandwidthLimit.OppositeRegionId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].OrginInterRegionBandwidthLimits["+ j +"].OppositeRegionId");
					orginInterRegionBandwidthLimit.GeographicSpanId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].OrginInterRegionBandwidthLimits["+ j +"].GeographicSpanId");
					orginInterRegionBandwidthLimit.LocalRegionId = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].OrginInterRegionBandwidthLimits["+ j +"].LocalRegionId");

					cenBandwidthPackage_orginInterRegionBandwidthLimits.Add(orginInterRegionBandwidthLimit);
				}
				cenBandwidthPackage.OrginInterRegionBandwidthLimits = cenBandwidthPackage_orginInterRegionBandwidthLimits;

				List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_Tag> cenBandwidthPackage_tags = new List<DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Tags.Length"); j++) {
					DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_Tag tag = new DescribeCenBandwidthPackagesResponse.DescribeCenBandwidthPackages_CenBandwidthPackage.DescribeCenBandwidthPackages_Tag();
					tag.Key = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeCenBandwidthPackages.CenBandwidthPackages["+ i +"].Tags["+ j +"].Value");

					cenBandwidthPackage_tags.Add(tag);
				}
				cenBandwidthPackage.Tags = cenBandwidthPackage_tags;

				describeCenBandwidthPackagesResponse_cenBandwidthPackages.Add(cenBandwidthPackage);
			}
			describeCenBandwidthPackagesResponse.CenBandwidthPackages = describeCenBandwidthPackagesResponse_cenBandwidthPackages;
        
			return describeCenBandwidthPackagesResponse;
        }
    }
}
