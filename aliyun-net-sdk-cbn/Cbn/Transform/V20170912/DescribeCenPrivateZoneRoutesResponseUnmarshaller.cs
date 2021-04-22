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
    public class DescribeCenPrivateZoneRoutesResponseUnmarshaller
    {
        public static DescribeCenPrivateZoneRoutesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenPrivateZoneRoutesResponse describeCenPrivateZoneRoutesResponse = new DescribeCenPrivateZoneRoutesResponse();

			describeCenPrivateZoneRoutesResponse.HttpResponse = _ctx.HttpResponse;
			describeCenPrivateZoneRoutesResponse.RequestId = _ctx.StringValue("DescribeCenPrivateZoneRoutes.RequestId");
			describeCenPrivateZoneRoutesResponse.CenId = _ctx.StringValue("DescribeCenPrivateZoneRoutes.CenId");
			describeCenPrivateZoneRoutesResponse.PrivateZoneDnsServers = _ctx.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneDnsServers");
			describeCenPrivateZoneRoutesResponse.PageNumber = _ctx.IntegerValue("DescribeCenPrivateZoneRoutes.PageNumber");
			describeCenPrivateZoneRoutesResponse.TotalCount = _ctx.IntegerValue("DescribeCenPrivateZoneRoutes.TotalCount");
			describeCenPrivateZoneRoutesResponse.PageSize = _ctx.IntegerValue("DescribeCenPrivateZoneRoutes.PageSize");

			List<DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo> describeCenPrivateZoneRoutesResponse_privateZoneInfos = new List<DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCenPrivateZoneRoutes.PrivateZoneInfos.Length"); i++) {
				DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo privateZoneInfo = new DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo();
				privateZoneInfo.AccessRegionId = _ctx.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].AccessRegionId");
				privateZoneInfo.HostRegionId = _ctx.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].HostRegionId");
				privateZoneInfo.HostVpcId = _ctx.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].HostVpcId");
				privateZoneInfo.Status = _ctx.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].Status");

				describeCenPrivateZoneRoutesResponse_privateZoneInfos.Add(privateZoneInfo);
			}
			describeCenPrivateZoneRoutesResponse.PrivateZoneInfos = describeCenPrivateZoneRoutesResponse_privateZoneInfos;
        
			return describeCenPrivateZoneRoutesResponse;
        }
    }
}
