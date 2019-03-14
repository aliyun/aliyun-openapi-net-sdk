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
    public class DescribeCenRegionDomainRouteEntriesResponseUnmarshaller
    {
        public static DescribeCenRegionDomainRouteEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenRegionDomainRouteEntriesResponse describeCenRegionDomainRouteEntriesResponse = new DescribeCenRegionDomainRouteEntriesResponse();

			describeCenRegionDomainRouteEntriesResponse.HttpResponse = context.HttpResponse;
			describeCenRegionDomainRouteEntriesResponse.RequestId = context.StringValue("DescribeCenRegionDomainRouteEntries.RequestId");
			describeCenRegionDomainRouteEntriesResponse.PageNumber = context.IntegerValue("DescribeCenRegionDomainRouteEntries.PageNumber");
			describeCenRegionDomainRouteEntriesResponse.TotalCount = context.IntegerValue("DescribeCenRegionDomainRouteEntries.TotalCount");
			describeCenRegionDomainRouteEntriesResponse.PageSize = context.IntegerValue("DescribeCenRegionDomainRouteEntries.PageSize");

			List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry> describeCenRegionDomainRouteEntriesResponse_cenRouteEntries = new List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry>();
			for (int i = 0; i < context.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries.Length"); i++) {
				DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry cenRouteEntry = new DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry();
				cenRouteEntry.DestinationCidrBlock = context.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].DestinationCidrBlock");
				cenRouteEntry.Type = context.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Type");
				cenRouteEntry.NextHopInstanceId = context.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopInstanceId");
				cenRouteEntry.NextHopType = context.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopType");
				cenRouteEntry.NextHopRegionId = context.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopRegionId");

				describeCenRegionDomainRouteEntriesResponse_cenRouteEntries.Add(cenRouteEntry);
			}
			describeCenRegionDomainRouteEntriesResponse.CenRouteEntries = describeCenRegionDomainRouteEntriesResponse_cenRouteEntries;
        
			return describeCenRegionDomainRouteEntriesResponse;
        }
    }
}
