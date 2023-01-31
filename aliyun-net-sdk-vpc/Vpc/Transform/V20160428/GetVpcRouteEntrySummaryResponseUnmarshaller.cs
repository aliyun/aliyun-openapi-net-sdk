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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class GetVpcRouteEntrySummaryResponseUnmarshaller
    {
        public static GetVpcRouteEntrySummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcRouteEntrySummaryResponse getVpcRouteEntrySummaryResponse = new GetVpcRouteEntrySummaryResponse();

			getVpcRouteEntrySummaryResponse.HttpResponse = _ctx.HttpResponse;
			getVpcRouteEntrySummaryResponse.RequestId = _ctx.StringValue("GetVpcRouteEntrySummary.RequestId");

			List<GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem> getVpcRouteEntrySummaryResponse_routeEntrySummarys = new List<GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem>();
			for (int i = 0; i < _ctx.Length("GetVpcRouteEntrySummary.RouteEntrySummarys.Length"); i++) {
				GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem routeEntrySummarysItem = new GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem();
				routeEntrySummarysItem.RouteTableId = _ctx.StringValue("GetVpcRouteEntrySummary.RouteEntrySummarys["+ i +"].RouteTableId");

				List<GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem.GetVpcRouteEntrySummary_EntrySummarysItem> routeEntrySummarysItem_entrySummarys = new List<GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem.GetVpcRouteEntrySummary_EntrySummarysItem>();
				for (int j = 0; j < _ctx.Length("GetVpcRouteEntrySummary.RouteEntrySummarys["+ i +"].EntrySummarys.Length"); j++) {
					GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem.GetVpcRouteEntrySummary_EntrySummarysItem entrySummarysItem = new GetVpcRouteEntrySummaryResponse.GetVpcRouteEntrySummary_RouteEntrySummarysItem.GetVpcRouteEntrySummary_EntrySummarysItem();
					entrySummarysItem.RouteEntryType = _ctx.StringValue("GetVpcRouteEntrySummary.RouteEntrySummarys["+ i +"].EntrySummarys["+ j +"].RouteEntryType");
					entrySummarysItem.Count = _ctx.IntegerValue("GetVpcRouteEntrySummary.RouteEntrySummarys["+ i +"].EntrySummarys["+ j +"].Count");

					routeEntrySummarysItem_entrySummarys.Add(entrySummarysItem);
				}
				routeEntrySummarysItem.EntrySummarys = routeEntrySummarysItem_entrySummarys;

				getVpcRouteEntrySummaryResponse_routeEntrySummarys.Add(routeEntrySummarysItem);
			}
			getVpcRouteEntrySummaryResponse.RouteEntrySummarys = getVpcRouteEntrySummaryResponse_routeEntrySummarys;
        
			return getVpcRouteEntrySummaryResponse;
        }
    }
}
