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
    public class ListTransitRouterVpnAttachmentsResponseUnmarshaller
    {
        public static ListTransitRouterVpnAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterVpnAttachmentsResponse listTransitRouterVpnAttachmentsResponse = new ListTransitRouterVpnAttachmentsResponse();

			listTransitRouterVpnAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterVpnAttachmentsResponse.NextToken = _ctx.StringValue("ListTransitRouterVpnAttachments.NextToken");
			listTransitRouterVpnAttachmentsResponse.RequestId = _ctx.StringValue("ListTransitRouterVpnAttachments.RequestId");
			listTransitRouterVpnAttachmentsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterVpnAttachments.TotalCount");
			listTransitRouterVpnAttachmentsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterVpnAttachments.MaxResults");

			List<ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment> listTransitRouterVpnAttachmentsResponse_transitRouterAttachments = new List<ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterVpnAttachments.TransitRouterAttachments.Length"); i++) {
				ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment transitRouterAttachment = new ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment();
				transitRouterAttachment.CreationTime = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].CreationTime");
				transitRouterAttachment.Status = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].Status");
				transitRouterAttachment.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentId");
				transitRouterAttachment.TransitRouterId = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].TransitRouterId");
				transitRouterAttachment.ResourceType = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].ResourceType");
				transitRouterAttachment.VpnOwnerId = _ctx.LongValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].VpnOwnerId");
				transitRouterAttachment.VpnId = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].VpnId");
				transitRouterAttachment.TransitRouterAttachmentDescription = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentDescription");
				transitRouterAttachment.VpnRegionId = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].VpnRegionId");
				transitRouterAttachment.AutoPublishRouteEnabled = _ctx.BooleanValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].AutoPublishRouteEnabled");
				transitRouterAttachment.TransitRouterAttachmentName = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentName");

				List<ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment.ListTransitRouterVpnAttachments_ZoneMapping> transitRouterAttachment_zones = new List<ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment.ListTransitRouterVpnAttachments_ZoneMapping>();
				for (int j = 0; j < _ctx.Length("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].Zones.Length"); j++) {
					ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment.ListTransitRouterVpnAttachments_ZoneMapping zoneMapping = new ListTransitRouterVpnAttachmentsResponse.ListTransitRouterVpnAttachments_TransitRouterAttachment.ListTransitRouterVpnAttachments_ZoneMapping();
					zoneMapping.ZoneId = _ctx.StringValue("ListTransitRouterVpnAttachments.TransitRouterAttachments["+ i +"].Zones["+ j +"].ZoneId");

					transitRouterAttachment_zones.Add(zoneMapping);
				}
				transitRouterAttachment.Zones = transitRouterAttachment_zones;

				listTransitRouterVpnAttachmentsResponse_transitRouterAttachments.Add(transitRouterAttachment);
			}
			listTransitRouterVpnAttachmentsResponse.TransitRouterAttachments = listTransitRouterVpnAttachmentsResponse_transitRouterAttachments;
        
			return listTransitRouterVpnAttachmentsResponse;
        }
    }
}
