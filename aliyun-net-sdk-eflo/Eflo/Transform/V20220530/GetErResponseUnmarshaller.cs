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
    public class GetErResponseUnmarshaller
    {
        public static GetErResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetErResponse getErResponse = new GetErResponse();

			getErResponse.HttpResponse = _ctx.HttpResponse;
			getErResponse.Code = _ctx.IntegerValue("GetEr.Code");
			getErResponse.Message = _ctx.StringValue("GetEr.Message");
			getErResponse.RequestId = _ctx.StringValue("GetEr.RequestId");

			GetErResponse.GetEr_Content content = new GetErResponse.GetEr_Content();
			content.CreateTime = _ctx.StringValue("GetEr.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetEr.Content.GmtModified");
			content.Message = _ctx.StringValue("GetEr.Content.Message");
			content.ErId = _ctx.StringValue("GetEr.Content.ErId");
			content.RegionId = _ctx.StringValue("GetEr.Content.RegionId");
			content.TenantId = _ctx.StringValue("GetEr.Content.TenantId");
			content.Status = _ctx.StringValue("GetEr.Content.Status");
			content.ErName = _ctx.StringValue("GetEr.Content.ErName");
			content.MasterZoneId = _ctx.StringValue("GetEr.Content.MasterZoneId");
			content.Description = _ctx.StringValue("GetEr.Content.Description");
			content.ResourceGroupId = _ctx.StringValue("GetEr.Content.ResourceGroupId");

			List<GetErResponse.GetEr_Content.GetEr_ErAttachment> content_erAttachments = new List<GetErResponse.GetEr_Content.GetEr_ErAttachment>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.ErAttachments.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_ErAttachment erAttachment = new GetErResponse.GetEr_Content.GetEr_ErAttachment();
				erAttachment.CreateTime = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].CreateTime");
				erAttachment.GmtModified = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].GmtModified");
				erAttachment.Message = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].Message");
				erAttachment.Status = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].Status");
				erAttachment.RegionId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].RegionId");
				erAttachment.TenantId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].TenantId");
				erAttachment.ErAttachmentName = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErAttachmentName");
				erAttachment.ErAttachmentId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErAttachmentId");
				erAttachment.ErId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErId");
				erAttachment.InstanceType = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceType");
				erAttachment.InstanceId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceId");
				erAttachment.InstanceName = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceName");
				erAttachment.AutoReceiveAllRoute = _ctx.BooleanValue("GetEr.Content.ErAttachments["+ i +"].AutoReceiveAllRoute");
				erAttachment.Across = _ctx.BooleanValue("GetEr.Content.ErAttachments["+ i +"].Across");
				erAttachment.ResourceTenantId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ResourceTenantId");
				erAttachment.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ResourceGroupId");

				content_erAttachments.Add(erAttachment);
			}
			content.ErAttachments = content_erAttachments;

			List<GetErResponse.GetEr_Content.GetEr_ErRouteMap> content_erRouteMaps = new List<GetErResponse.GetEr_Content.GetEr_ErRouteMap>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.ErRouteMaps.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_ErRouteMap erRouteMap = new GetErResponse.GetEr_Content.GetEr_ErRouteMap();
				erRouteMap.RegionId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].RegionId");
				erRouteMap.TenantId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TenantId");
				erRouteMap.CreateTime = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].CreateTime");
				erRouteMap.GmtModified = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].GmtModified");
				erRouteMap.Message = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Message");
				erRouteMap.Status = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Status");
				erRouteMap.ErRouteMapId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErRouteMapId");
				erRouteMap.ErId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErId");
				erRouteMap.RouteMapNum = _ctx.IntegerValue("GetEr.Content.ErRouteMaps["+ i +"].RouteMapNum");
				erRouteMap.Description = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Description");
				erRouteMap.DestinationCidrBlock = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].DestinationCidrBlock");
				erRouteMap.TransmissionInstanceName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceName");
				erRouteMap.TransmissionInstanceId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceId");
				erRouteMap.TransmissionInstanceType = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceType");
				erRouteMap.ReceptionInstanceName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceName");
				erRouteMap.ReceptionInstanceId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceId");
				erRouteMap.ReceptionInstanceType = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceType");
				erRouteMap.Action = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Action");
				erRouteMap.TransmissionInstanceOwner = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceOwner");
				erRouteMap.ReceptionInstanceOwner = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceOwner");
				erRouteMap.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ResourceGroupId");
				erRouteMap.ErRouteMapName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErRouteMapName");

				content_erRouteMaps.Add(erRouteMap);
			}
			content.ErRouteMaps = content_erRouteMaps;

			List<GetErResponse.GetEr_Content.GetEr_ErRouteEntry> content_erRouteEntrys = new List<GetErResponse.GetEr_Content.GetEr_ErRouteEntry>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.ErRouteEntrys.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_ErRouteEntry erRouteEntry = new GetErResponse.GetEr_Content.GetEr_ErRouteEntry();
				erRouteEntry.ErId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ErId");
				erRouteEntry.TenantId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].TenantId");
				erRouteEntry.ResourceTenantId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ResourceTenantId");
				erRouteEntry.RegionId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].RegionId");
				erRouteEntry.ErRouteEntryId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ErRouteEntryId");
				erRouteEntry.DestinationCidrBlock = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].DestinationCidrBlock");
				erRouteEntry.NextHopType = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].NextHopType");
				erRouteEntry.NextHopId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].NextHopId");
				erRouteEntry.RouteType = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].RouteType");
				erRouteEntry.Status = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].Status");
				erRouteEntry.GmtModified = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].GmtModified");
				erRouteEntry.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ResourceGroupId");

				content_erRouteEntrys.Add(erRouteEntry);
			}
			content.ErRouteEntrys = content_erRouteEntrys;
			getErResponse.Content = content;
        
			return getErResponse;
        }
    }
}
