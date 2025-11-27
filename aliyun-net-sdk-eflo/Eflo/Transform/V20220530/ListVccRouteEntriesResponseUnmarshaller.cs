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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class ListVccRouteEntriesResponseUnmarshaller
    {
        public static ListVccRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVccRouteEntriesResponse listVccRouteEntriesResponse = new ListVccRouteEntriesResponse();

			listVccRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listVccRouteEntriesResponse.Code = _ctx.IntegerValue("ListVccRouteEntries.Code");
			listVccRouteEntriesResponse.Message = _ctx.StringValue("ListVccRouteEntries.Message");
			listVccRouteEntriesResponse.RequestId = _ctx.StringValue("ListVccRouteEntries.RequestId");

			ListVccRouteEntriesResponse.ListVccRouteEntries_Content content = new ListVccRouteEntriesResponse.ListVccRouteEntries_Content();
			content.Total = _ctx.LongValue("ListVccRouteEntries.Content.Total");

			List<ListVccRouteEntriesResponse.ListVccRouteEntries_Content.ListVccRouteEntries_DataItem> content_data = new List<ListVccRouteEntriesResponse.ListVccRouteEntries_Content.ListVccRouteEntries_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVccRouteEntries.Content.Data.Length"); i++) {
				ListVccRouteEntriesResponse.ListVccRouteEntries_Content.ListVccRouteEntries_DataItem dataItem = new ListVccRouteEntriesResponse.ListVccRouteEntries_Content.ListVccRouteEntries_DataItem();
				dataItem.VccId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].VccId");
				dataItem.TenantId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].TenantId");
				dataItem.ResourceTenantId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].ResourceTenantId");
				dataItem.RegionId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].RegionId");
				dataItem.VccRouteEntryId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].VccRouteEntryId");
				dataItem.DestinationCidrBlock = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].DestinationCidrBlock");
				dataItem.NextHopType = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].NextHopType");
				dataItem.NextHopId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].NextHopId");
				dataItem.RouteType = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].RouteType");
				dataItem.Status = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].Status");
				dataItem.GmtModified = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].GmtModified");
				dataItem.Message = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].Message");
				dataItem.ResourceGroupId = _ctx.StringValue("ListVccRouteEntries.Content.Data["+ i +"].ResourceGroupId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVccRouteEntriesResponse.Content = content;
        
			return listVccRouteEntriesResponse;
        }
    }
}
