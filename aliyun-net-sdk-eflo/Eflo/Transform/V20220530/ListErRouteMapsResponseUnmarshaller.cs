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
    public class ListErRouteMapsResponseUnmarshaller
    {
        public static ListErRouteMapsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListErRouteMapsResponse listErRouteMapsResponse = new ListErRouteMapsResponse();

			listErRouteMapsResponse.HttpResponse = _ctx.HttpResponse;
			listErRouteMapsResponse.Code = _ctx.IntegerValue("ListErRouteMaps.Code");
			listErRouteMapsResponse.Message = _ctx.StringValue("ListErRouteMaps.Message");
			listErRouteMapsResponse.RequestId = _ctx.StringValue("ListErRouteMaps.RequestId");

			ListErRouteMapsResponse.ListErRouteMaps_Content content = new ListErRouteMapsResponse.ListErRouteMaps_Content();
			content.Total = _ctx.LongValue("ListErRouteMaps.Content.Total");

			List<ListErRouteMapsResponse.ListErRouteMaps_Content.ListErRouteMaps_DataItem> content_data = new List<ListErRouteMapsResponse.ListErRouteMaps_Content.ListErRouteMaps_DataItem>();
			for (int i = 0; i < _ctx.Length("ListErRouteMaps.Content.Data.Length"); i++) {
				ListErRouteMapsResponse.ListErRouteMaps_Content.ListErRouteMaps_DataItem dataItem = new ListErRouteMapsResponse.ListErRouteMaps_Content.ListErRouteMaps_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].RegionId");
				dataItem.TenantId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].TenantId");
				dataItem.CreateTime = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].GmtModified");
				dataItem.Message = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].Message");
				dataItem.Status = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].Status");
				dataItem.ErRouteMapId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ErRouteMapId");
				dataItem.ErId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ErId");
				dataItem.RouteMapNum = _ctx.IntegerValue("ListErRouteMaps.Content.Data["+ i +"].RouteMapNum");
				dataItem.Description = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].Description");
				dataItem.DestinationCidrBlock = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].DestinationCidrBlock");
				dataItem.TransmissionInstanceName = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].TransmissionInstanceName");
				dataItem.TransmissionInstanceId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].TransmissionInstanceId");
				dataItem.TransmissionInstanceType = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].TransmissionInstanceType");
				dataItem.ReceptionInstanceName = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ReceptionInstanceName");
				dataItem.ReceptionInstanceId = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ReceptionInstanceId");
				dataItem.ReceptionInstanceType = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ReceptionInstanceType");
				dataItem.Action = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].Action");
				dataItem.TransmissionInstanceOwner = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].TransmissionInstanceOwner");
				dataItem.ReceptionInstanceOwner = _ctx.StringValue("ListErRouteMaps.Content.Data["+ i +"].ReceptionInstanceOwner");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listErRouteMapsResponse.Content = content;
        
			return listErRouteMapsResponse;
        }
    }
}
