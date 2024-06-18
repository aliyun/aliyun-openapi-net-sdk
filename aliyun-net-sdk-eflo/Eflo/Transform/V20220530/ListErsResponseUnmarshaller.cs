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
    public class ListErsResponseUnmarshaller
    {
        public static ListErsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListErsResponse listErsResponse = new ListErsResponse();

			listErsResponse.HttpResponse = _ctx.HttpResponse;
			listErsResponse.Code = _ctx.IntegerValue("ListErs.Code");
			listErsResponse.Message = _ctx.StringValue("ListErs.Message");
			listErsResponse.RequestId = _ctx.StringValue("ListErs.RequestId");

			ListErsResponse.ListErs_Content content = new ListErsResponse.ListErs_Content();
			content.Total = _ctx.LongValue("ListErs.Content.Total");

			List<ListErsResponse.ListErs_Content.ListErs_DataItem> content_data = new List<ListErsResponse.ListErs_Content.ListErs_DataItem>();
			for (int i = 0; i < _ctx.Length("ListErs.Content.Data.Length"); i++) {
				ListErsResponse.ListErs_Content.ListErs_DataItem dataItem = new ListErsResponse.ListErs_Content.ListErs_DataItem();
				dataItem.CreateTime = _ctx.StringValue("ListErs.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListErs.Content.Data["+ i +"].GmtModified");
				dataItem.Message = _ctx.StringValue("ListErs.Content.Data["+ i +"].Message");
				dataItem.ErId = _ctx.StringValue("ListErs.Content.Data["+ i +"].ErId");
				dataItem.RegionId = _ctx.StringValue("ListErs.Content.Data["+ i +"].RegionId");
				dataItem.TenantId = _ctx.StringValue("ListErs.Content.Data["+ i +"].TenantId");
				dataItem.Status = _ctx.StringValue("ListErs.Content.Data["+ i +"].Status");
				dataItem.ErName = _ctx.StringValue("ListErs.Content.Data["+ i +"].ErName");
				dataItem.MasterZoneId = _ctx.StringValue("ListErs.Content.Data["+ i +"].MasterZoneId");
				dataItem.Description = _ctx.StringValue("ListErs.Content.Data["+ i +"].Description");
				dataItem.Connections = _ctx.LongValue("ListErs.Content.Data["+ i +"].Connections");
				dataItem.RouteMaps = _ctx.LongValue("ListErs.Content.Data["+ i +"].RouteMaps");
				dataItem.ResourceGroupId = _ctx.StringValue("ListErs.Content.Data["+ i +"].ResourceGroupId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listErsResponse.Content = content;
        
			return listErsResponse;
        }
    }
}
