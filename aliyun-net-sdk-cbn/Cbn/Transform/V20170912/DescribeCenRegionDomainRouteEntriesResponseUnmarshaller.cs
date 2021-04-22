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
        public static DescribeCenRegionDomainRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenRegionDomainRouteEntriesResponse describeCenRegionDomainRouteEntriesResponse = new DescribeCenRegionDomainRouteEntriesResponse();

			describeCenRegionDomainRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeCenRegionDomainRouteEntriesResponse.RequestId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.RequestId");
			describeCenRegionDomainRouteEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeCenRegionDomainRouteEntries.PageNumber");
			describeCenRegionDomainRouteEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeCenRegionDomainRouteEntries.TotalCount");
			describeCenRegionDomainRouteEntriesResponse.PageSize = _ctx.IntegerValue("DescribeCenRegionDomainRouteEntries.PageSize");

			List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry> describeCenRegionDomainRouteEntriesResponse_cenRouteEntries = new List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry>();
			for (int i = 0; i < _ctx.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries.Length"); i++) {
				DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry cenRouteEntry = new DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry();
				cenRouteEntry.DestinationCidrBlock = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].DestinationCidrBlock");
				cenRouteEntry.Type = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Type");
				cenRouteEntry.NextHopInstanceId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopInstanceId");
				cenRouteEntry.NextHopType = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopType");
				cenRouteEntry.NextHopRegionId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].NextHopRegionId");
				cenRouteEntry.Status = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Status");
				cenRouteEntry.ToOtherRegionStatus = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].ToOtherRegionStatus");
				cenRouteEntry.Preference = _ctx.IntegerValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Preference");

				List<string> cenRouteEntry_asPaths = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].AsPaths.Length"); j++) {
					cenRouteEntry_asPaths.Add(_ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].AsPaths["+ j +"]"));
				}
				cenRouteEntry.AsPaths = cenRouteEntry_asPaths;

				List<string> cenRouteEntry_communities = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Communities.Length"); j++) {
					cenRouteEntry_communities.Add(_ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].Communities["+ j +"]"));
				}
				cenRouteEntry.Communities = cenRouteEntry_communities;

				List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenRouteMapRecord> cenRouteEntry_cenRouteMapRecords = new List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenRouteMapRecord>();
				for (int j = 0; j < _ctx.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords.Length"); j++) {
					DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenRouteMapRecord cenRouteMapRecord = new DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenRouteMapRecord();
					cenRouteMapRecord.RegionId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords["+ j +"].RegionId");
					cenRouteMapRecord.RouteMapId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords["+ j +"].RouteMapId");

					cenRouteEntry_cenRouteMapRecords.Add(cenRouteMapRecord);
				}
				cenRouteEntry.CenRouteMapRecords = cenRouteEntry_cenRouteMapRecords;

				List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenOutRouteMapRecord> cenRouteEntry_cenOutRouteMapRecords = new List<DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenOutRouteMapRecord>();
				for (int j = 0; j < _ctx.Length("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenOutRouteMapRecords.Length"); j++) {
					DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenOutRouteMapRecord cenOutRouteMapRecord = new DescribeCenRegionDomainRouteEntriesResponse.DescribeCenRegionDomainRouteEntries_CenRouteEntry.DescribeCenRegionDomainRouteEntries_CenOutRouteMapRecord();
					cenOutRouteMapRecord.RegionId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenOutRouteMapRecords["+ j +"].RegionId");
					cenOutRouteMapRecord.RouteMapId = _ctx.StringValue("DescribeCenRegionDomainRouteEntries.CenRouteEntries["+ i +"].CenOutRouteMapRecords["+ j +"].RouteMapId");

					cenRouteEntry_cenOutRouteMapRecords.Add(cenOutRouteMapRecord);
				}
				cenRouteEntry.CenOutRouteMapRecords = cenRouteEntry_cenOutRouteMapRecords;

				describeCenRegionDomainRouteEntriesResponse_cenRouteEntries.Add(cenRouteEntry);
			}
			describeCenRegionDomainRouteEntriesResponse.CenRouteEntries = describeCenRegionDomainRouteEntriesResponse_cenRouteEntries;
        
			return describeCenRegionDomainRouteEntriesResponse;
        }
    }
}
