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
    public class DescribeCenChildInstanceRouteEntriesResponseUnmarshaller
    {
        public static DescribeCenChildInstanceRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenChildInstanceRouteEntriesResponse describeCenChildInstanceRouteEntriesResponse = new DescribeCenChildInstanceRouteEntriesResponse();

			describeCenChildInstanceRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeCenChildInstanceRouteEntriesResponse.RequestId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.RequestId");
			describeCenChildInstanceRouteEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeCenChildInstanceRouteEntries.PageNumber");
			describeCenChildInstanceRouteEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeCenChildInstanceRouteEntries.TotalCount");
			describeCenChildInstanceRouteEntriesResponse.PageSize = _ctx.IntegerValue("DescribeCenChildInstanceRouteEntries.PageSize");

			List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry> describeCenChildInstanceRouteEntriesResponse_cenRouteEntries = new List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry>();
			for (int i = 0; i < _ctx.Length("DescribeCenChildInstanceRouteEntries.CenRouteEntries.Length"); i++) {
				DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry cenRouteEntry = new DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry();
				cenRouteEntry.DestinationCidrBlock = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].DestinationCidrBlock");
				cenRouteEntry.Type = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Type");
				cenRouteEntry.NextHopInstanceId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].NextHopInstanceId");
				cenRouteEntry.NextHopType = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].NextHopType");
				cenRouteEntry.NextHopRegionId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].NextHopRegionId");
				cenRouteEntry.Status = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Status");
				cenRouteEntry.OperationalMode = _ctx.BooleanValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].OperationalMode");
				cenRouteEntry.PublishStatus = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].PublishStatus");
				cenRouteEntry.RouteTableId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].RouteTableId");

				List<string> cenRouteEntry_asPaths = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].AsPaths.Length"); j++) {
					cenRouteEntry_asPaths.Add(_ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].AsPaths["+ j +"]"));
				}
				cenRouteEntry.AsPaths = cenRouteEntry_asPaths;

				List<string> cenRouteEntry_communities = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Communities.Length"); j++) {
					cenRouteEntry_communities.Add(_ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Communities["+ j +"]"));
				}
				cenRouteEntry.Communities = cenRouteEntry_communities;

				List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_CenRouteMapRecord> cenRouteEntry_cenRouteMapRecords = new List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_CenRouteMapRecord>();
				for (int j = 0; j < _ctx.Length("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords.Length"); j++) {
					DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_CenRouteMapRecord cenRouteMapRecord = new DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_CenRouteMapRecord();
					cenRouteMapRecord.RegionId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords["+ j +"].RegionId");
					cenRouteMapRecord.RouteMapId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].CenRouteMapRecords["+ j +"].RouteMapId");

					cenRouteEntry_cenRouteMapRecords.Add(cenRouteMapRecord);
				}
				cenRouteEntry.CenRouteMapRecords = cenRouteEntry_cenRouteMapRecords;

				List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_Conflict> cenRouteEntry_conflicts = new List<DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_Conflict>();
				for (int j = 0; j < _ctx.Length("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts.Length"); j++) {
					DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_Conflict conflict = new DescribeCenChildInstanceRouteEntriesResponse.DescribeCenChildInstanceRouteEntries_CenRouteEntry.DescribeCenChildInstanceRouteEntries_Conflict();
					conflict.DestinationCidrBlock = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts["+ j +"].DestinationCidrBlock");
					conflict.RegionId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts["+ j +"].RegionId");
					conflict.InstanceId = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts["+ j +"].InstanceId");
					conflict.InstanceType = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts["+ j +"].InstanceType");
					conflict.Status = _ctx.StringValue("DescribeCenChildInstanceRouteEntries.CenRouteEntries["+ i +"].Conflicts["+ j +"].Status");

					cenRouteEntry_conflicts.Add(conflict);
				}
				cenRouteEntry.Conflicts = cenRouteEntry_conflicts;

				describeCenChildInstanceRouteEntriesResponse_cenRouteEntries.Add(cenRouteEntry);
			}
			describeCenChildInstanceRouteEntriesResponse.CenRouteEntries = describeCenChildInstanceRouteEntriesResponse_cenRouteEntries;
        
			return describeCenChildInstanceRouteEntriesResponse;
        }
    }
}
