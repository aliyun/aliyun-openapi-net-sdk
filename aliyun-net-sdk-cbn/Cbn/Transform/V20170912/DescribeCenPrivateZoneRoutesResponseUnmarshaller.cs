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
        public static DescribeCenPrivateZoneRoutesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenPrivateZoneRoutesResponse describeCenPrivateZoneRoutesResponse = new DescribeCenPrivateZoneRoutesResponse();

			describeCenPrivateZoneRoutesResponse.HttpResponse = context.HttpResponse;
			describeCenPrivateZoneRoutesResponse.RequestId = context.StringValue("DescribeCenPrivateZoneRoutes.RequestId");
			describeCenPrivateZoneRoutesResponse.CenId = context.StringValue("DescribeCenPrivateZoneRoutes.CenId");
			describeCenPrivateZoneRoutesResponse.PrivateZoneDnsServers = context.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneDnsServers");
			describeCenPrivateZoneRoutesResponse.PageNumber = context.IntegerValue("DescribeCenPrivateZoneRoutes.PageNumber");
			describeCenPrivateZoneRoutesResponse.TotalCount = context.IntegerValue("DescribeCenPrivateZoneRoutes.TotalCount");
			describeCenPrivateZoneRoutesResponse.PageSize = context.IntegerValue("DescribeCenPrivateZoneRoutes.PageSize");

			List<DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo> describeCenPrivateZoneRoutesResponse_privateZoneInfos = new List<DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo>();
			for (int i = 0; i < context.Length("DescribeCenPrivateZoneRoutes.PrivateZoneInfos.Length"); i++) {
				DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo privateZoneInfo = new DescribeCenPrivateZoneRoutesResponse.DescribeCenPrivateZoneRoutes_PrivateZoneInfo();
				privateZoneInfo.AccessRegionId = context.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].AccessRegionId");
				privateZoneInfo.HostRegionId = context.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].HostRegionId");
				privateZoneInfo.HostVpcId = context.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].HostVpcId");
				privateZoneInfo.Status = context.StringValue("DescribeCenPrivateZoneRoutes.PrivateZoneInfos["+ i +"].Status");

				describeCenPrivateZoneRoutesResponse_privateZoneInfos.Add(privateZoneInfo);
			}
			describeCenPrivateZoneRoutesResponse.PrivateZoneInfos = describeCenPrivateZoneRoutesResponse_privateZoneInfos;
        
			return describeCenPrivateZoneRoutesResponse;
        }
    }
}
