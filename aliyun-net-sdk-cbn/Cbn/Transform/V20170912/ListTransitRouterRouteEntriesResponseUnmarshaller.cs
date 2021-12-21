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
    public class ListTransitRouterRouteEntriesResponseUnmarshaller
    {
        public static ListTransitRouterRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterRouteEntriesResponse listTransitRouterRouteEntriesResponse = new ListTransitRouterRouteEntriesResponse();

			listTransitRouterRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterRouteEntriesResponse.NextToken = _ctx.StringValue("ListTransitRouterRouteEntries.NextToken");
			listTransitRouterRouteEntriesResponse.RequestId = _ctx.StringValue("ListTransitRouterRouteEntries.RequestId");
			listTransitRouterRouteEntriesResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterRouteEntries.TotalCount");
			listTransitRouterRouteEntriesResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterRouteEntries.MaxResults");

			List<ListTransitRouterRouteEntriesResponse.ListTransitRouterRouteEntries_TransitRouterRouteEntry> listTransitRouterRouteEntriesResponse_transitRouterRouteEntries = new List<ListTransitRouterRouteEntriesResponse.ListTransitRouterRouteEntries_TransitRouterRouteEntry>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterRouteEntries.TransitRouterRouteEntries.Length"); i++) {
				ListTransitRouterRouteEntriesResponse.ListTransitRouterRouteEntries_TransitRouterRouteEntry transitRouterRouteEntry = new ListTransitRouterRouteEntriesResponse.ListTransitRouterRouteEntries_TransitRouterRouteEntry();
				transitRouterRouteEntry.TransitRouterRouteEntryId = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryId");
				transitRouterRouteEntry.TransitRouterRouteEntryDestinationCidrBlock = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryDestinationCidrBlock");
				transitRouterRouteEntry.TransitRouterRouteEntryType = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryType");
				transitRouterRouteEntry.CreateTime = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].CreateTime");
				transitRouterRouteEntry.TransitRouterRouteEntryName = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryName");
				transitRouterRouteEntry.TransitRouterRouteEntryStatus = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryStatus");
				transitRouterRouteEntry.TransitRouterRouteEntryNextHopType = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryNextHopType");
				transitRouterRouteEntry.TransitRouterRouteEntryNextHopId = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryNextHopId");
				transitRouterRouteEntry.TransitRouterRouteEntryDescription = _ctx.StringValue("ListTransitRouterRouteEntries.TransitRouterRouteEntries["+ i +"].TransitRouterRouteEntryDescription");

				listTransitRouterRouteEntriesResponse_transitRouterRouteEntries.Add(transitRouterRouteEntry);
			}
			listTransitRouterRouteEntriesResponse.TransitRouterRouteEntries = listTransitRouterRouteEntriesResponse_transitRouterRouteEntries;
        
			return listTransitRouterRouteEntriesResponse;
        }
    }
}
