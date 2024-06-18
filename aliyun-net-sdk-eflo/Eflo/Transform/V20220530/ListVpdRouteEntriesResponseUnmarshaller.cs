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
    public class ListVpdRouteEntriesResponseUnmarshaller
    {
        public static ListVpdRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpdRouteEntriesResponse listVpdRouteEntriesResponse = new ListVpdRouteEntriesResponse();

			listVpdRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listVpdRouteEntriesResponse.Code = _ctx.IntegerValue("ListVpdRouteEntries.Code");
			listVpdRouteEntriesResponse.Message = _ctx.StringValue("ListVpdRouteEntries.Message");
			listVpdRouteEntriesResponse.RequestId = _ctx.StringValue("ListVpdRouteEntries.RequestId");

			ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content content = new ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content();
			content.Total = _ctx.LongValue("ListVpdRouteEntries.Content.Total");

			List<ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content.ListVpdRouteEntries_DataItem> content_data = new List<ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content.ListVpdRouteEntries_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVpdRouteEntries.Content.Data.Length"); i++) {
				ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content.ListVpdRouteEntries_DataItem dataItem = new ListVpdRouteEntriesResponse.ListVpdRouteEntries_Content.ListVpdRouteEntries_DataItem();
				dataItem.VpdId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].VpdId");
				dataItem.TenantId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].TenantId");
				dataItem.ResourceTenantId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].ResourceTenantId");
				dataItem.RegionId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].RegionId");
				dataItem.VpdRouteEntryId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].VpdRouteEntryId");
				dataItem.DestinationCidrBlock = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].DestinationCidrBlock");
				dataItem.NextHopType = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].NextHopType");
				dataItem.NextHopId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].NextHopId");
				dataItem.RouteType = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].RouteType");
				dataItem.Status = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].Status");
				dataItem.GmtModified = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].GmtModified");
				dataItem.ResourceGroupId = _ctx.StringValue("ListVpdRouteEntries.Content.Data["+ i +"].ResourceGroupId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVpdRouteEntriesResponse.Content = content;
        
			return listVpdRouteEntriesResponse;
        }
    }
}
