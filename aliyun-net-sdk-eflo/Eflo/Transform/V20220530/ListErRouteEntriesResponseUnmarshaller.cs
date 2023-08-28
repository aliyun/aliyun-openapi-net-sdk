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
    public class ListErRouteEntriesResponseUnmarshaller
    {
        public static ListErRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListErRouteEntriesResponse listErRouteEntriesResponse = new ListErRouteEntriesResponse();

			listErRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listErRouteEntriesResponse.Code = _ctx.IntegerValue("ListErRouteEntries.Code");
			listErRouteEntriesResponse.Message = _ctx.StringValue("ListErRouteEntries.Message");
			listErRouteEntriesResponse.RequestId = _ctx.StringValue("ListErRouteEntries.RequestId");

			ListErRouteEntriesResponse.ListErRouteEntries_Content content = new ListErRouteEntriesResponse.ListErRouteEntries_Content();
			content.Total = _ctx.LongValue("ListErRouteEntries.Content.Total");

			List<ListErRouteEntriesResponse.ListErRouteEntries_Content.ListErRouteEntries_DataItem> content_data = new List<ListErRouteEntriesResponse.ListErRouteEntries_Content.ListErRouteEntries_DataItem>();
			for (int i = 0; i < _ctx.Length("ListErRouteEntries.Content.Data.Length"); i++) {
				ListErRouteEntriesResponse.ListErRouteEntries_Content.ListErRouteEntries_DataItem dataItem = new ListErRouteEntriesResponse.ListErRouteEntries_Content.ListErRouteEntries_DataItem();
				dataItem.ErId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].ErId");
				dataItem.TenantId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].TenantId");
				dataItem.ResourceTenantId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].ResourceTenantId");
				dataItem.RegionId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].RegionId");
				dataItem.ErRouteEntryId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].ErRouteEntryId");
				dataItem.DestinationCidrBlock = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].DestinationCidrBlock");
				dataItem.NextHopType = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].NextHopType");
				dataItem.NextHopId = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].NextHopId");
				dataItem.RouteType = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].RouteType");
				dataItem.Status = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].Status");
				dataItem.GmtModified = _ctx.StringValue("ListErRouteEntries.Content.Data["+ i +"].GmtModified");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listErRouteEntriesResponse.Content = content;
        
			return listErRouteEntriesResponse;
        }
    }
}
