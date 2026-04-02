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
			getErResponse.AccessDeniedDetail = _ctx.StringValue("GetEr.AccessDeniedDetail");

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
				erAttachment.Status = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].Status");
				erAttachment.Message = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].Message");
				erAttachment.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ResourceGroupId");
				erAttachment.InstanceId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceId");
				erAttachment.CreateTime = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].CreateTime");
				erAttachment.GmtModified = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].GmtModified");
				erAttachment.ErId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErId");
				erAttachment.Across = _ctx.BooleanValue("GetEr.Content.ErAttachments["+ i +"].Across");
				erAttachment.InstanceName = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceName");
				erAttachment.TenantId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].TenantId");
				erAttachment.ResourceTenantId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ResourceTenantId");
				erAttachment.AutoReceiveAllRoute = _ctx.BooleanValue("GetEr.Content.ErAttachments["+ i +"].AutoReceiveAllRoute");
				erAttachment.ErAttachmentName = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErAttachmentName");
				erAttachment.ErAttachmentId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].ErAttachmentId");
				erAttachment.RegionId = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].RegionId");
				erAttachment.InstanceType = _ctx.StringValue("GetEr.Content.ErAttachments["+ i +"].InstanceType");

				content_erAttachments.Add(erAttachment);
			}
			content.ErAttachments = content_erAttachments;

			List<GetErResponse.GetEr_Content.GetEr_ErRouteMap> content_erRouteMaps = new List<GetErResponse.GetEr_Content.GetEr_ErRouteMap>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.ErRouteMaps.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_ErRouteMap erRouteMap = new GetErResponse.GetEr_Content.GetEr_ErRouteMap();
				erRouteMap.Status = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Status");
				erRouteMap.TransmissionInstanceType = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceType");
				erRouteMap.Action = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Action");
				erRouteMap.Description = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Description");
				erRouteMap.ReceptionInstanceType = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceType");
				erRouteMap.Message = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].Message");
				erRouteMap.ErRouteMapName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErRouteMapName");
				erRouteMap.ReceptionInstanceId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceId");
				erRouteMap.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ResourceGroupId");
				erRouteMap.CreateTime = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].CreateTime");
				erRouteMap.GmtModified = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].GmtModified");
				erRouteMap.ErId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErId");
				erRouteMap.TransmissionInstanceName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceName");
				erRouteMap.DestinationCidrBlock = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].DestinationCidrBlock");
				erRouteMap.ReceptionInstanceOwner = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceOwner");
				erRouteMap.TenantId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TenantId");
				erRouteMap.ReceptionInstanceName = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ReceptionInstanceName");
				erRouteMap.ErRouteMapId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].ErRouteMapId");
				erRouteMap.TransmissionInstanceOwner = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceOwner");
				erRouteMap.RegionId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].RegionId");
				erRouteMap.TransmissionInstanceId = _ctx.StringValue("GetEr.Content.ErRouteMaps["+ i +"].TransmissionInstanceId");
				erRouteMap.RouteMapNum = _ctx.IntegerValue("GetEr.Content.ErRouteMaps["+ i +"].RouteMapNum");

				content_erRouteMaps.Add(erRouteMap);
			}
			content.ErRouteMaps = content_erRouteMaps;

			List<GetErResponse.GetEr_Content.GetEr_ErRouteEntry> content_erRouteEntrys = new List<GetErResponse.GetEr_Content.GetEr_ErRouteEntry>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.ErRouteEntrys.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_ErRouteEntry erRouteEntry = new GetErResponse.GetEr_Content.GetEr_ErRouteEntry();
				erRouteEntry.Status = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].Status");
				erRouteEntry.NextHopType = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].NextHopType");
				erRouteEntry.TenantId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].TenantId");
				erRouteEntry.ResourceTenantId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ResourceTenantId");
				erRouteEntry.RouteType = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].RouteType");
				erRouteEntry.ErRouteEntryId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ErRouteEntryId");
				erRouteEntry.ResourceGroupId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ResourceGroupId");
				erRouteEntry.NextHopId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].NextHopId");
				erRouteEntry.GmtModified = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].GmtModified");
				erRouteEntry.ErId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].ErId");
				erRouteEntry.RegionId = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].RegionId");
				erRouteEntry.DestinationCidrBlock = _ctx.StringValue("GetEr.Content.ErRouteEntrys["+ i +"].DestinationCidrBlock");

				content_erRouteEntrys.Add(erRouteEntry);
			}
			content.ErRouteEntrys = content_erRouteEntrys;

			List<GetErResponse.GetEr_Content.GetEr_Tag> content_tags = new List<GetErResponse.GetEr_Content.GetEr_Tag>();
			for (int i = 0; i < _ctx.Length("GetEr.Content.Tags.Length"); i++) {
				GetErResponse.GetEr_Content.GetEr_Tag tag = new GetErResponse.GetEr_Content.GetEr_Tag();
				tag.TagKey = _ctx.StringValue("GetEr.Content.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("GetEr.Content.Tags["+ i +"].TagValue");

				content_tags.Add(tag);
			}
			content.Tags = content_tags;
			getErResponse.Content = content;
        
			return getErResponse;
        }
    }
}
