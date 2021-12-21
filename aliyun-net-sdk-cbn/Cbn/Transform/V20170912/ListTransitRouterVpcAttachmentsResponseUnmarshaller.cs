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
    public class ListTransitRouterVpcAttachmentsResponseUnmarshaller
    {
        public static ListTransitRouterVpcAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterVpcAttachmentsResponse listTransitRouterVpcAttachmentsResponse = new ListTransitRouterVpcAttachmentsResponse();

			listTransitRouterVpcAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterVpcAttachmentsResponse.NextToken = _ctx.StringValue("ListTransitRouterVpcAttachments.NextToken");
			listTransitRouterVpcAttachmentsResponse.RequestId = _ctx.StringValue("ListTransitRouterVpcAttachments.RequestId");
			listTransitRouterVpcAttachmentsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterVpcAttachments.TotalCount");
			listTransitRouterVpcAttachmentsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterVpcAttachments.MaxResults");

			List<ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment> listTransitRouterVpcAttachmentsResponse_transitRouterAttachments = new List<ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterVpcAttachments.TransitRouterAttachments.Length"); i++) {
				ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment transitRouterAttachment = new ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment();
				transitRouterAttachment.CreationTime = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].CreationTime");
				transitRouterAttachment.Status = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].Status");
				transitRouterAttachment.VpcId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].VpcId");
				transitRouterAttachment.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentId");
				transitRouterAttachment.TransitRouterId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].TransitRouterId");
				transitRouterAttachment.ResourceType = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].ResourceType");
				transitRouterAttachment.TransitRouterAttachmentDescription = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentDescription");
				transitRouterAttachment.VpcOwnerId = _ctx.LongValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].VpcOwnerId");
				transitRouterAttachment.VpcRegionId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].VpcRegionId");
				transitRouterAttachment.TransitRouterAttachmentName = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentName");

				List<ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment.ListTransitRouterVpcAttachments_ZoneMapping> transitRouterAttachment_zoneMappings = new List<ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment.ListTransitRouterVpcAttachments_ZoneMapping>();
				for (int j = 0; j < _ctx.Length("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].ZoneMappings.Length"); j++) {
					ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment.ListTransitRouterVpcAttachments_ZoneMapping zoneMapping = new ListTransitRouterVpcAttachmentsResponse.ListTransitRouterVpcAttachments_TransitRouterAttachment.ListTransitRouterVpcAttachments_ZoneMapping();
					zoneMapping.ZoneId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].ZoneMappings["+ j +"].ZoneId");
					zoneMapping.VSwitchId = _ctx.StringValue("ListTransitRouterVpcAttachments.TransitRouterAttachments["+ i +"].ZoneMappings["+ j +"].VSwitchId");

					transitRouterAttachment_zoneMappings.Add(zoneMapping);
				}
				transitRouterAttachment.ZoneMappings = transitRouterAttachment_zoneMappings;

				listTransitRouterVpcAttachmentsResponse_transitRouterAttachments.Add(transitRouterAttachment);
			}
			listTransitRouterVpcAttachmentsResponse.TransitRouterAttachments = listTransitRouterVpcAttachmentsResponse_transitRouterAttachments;
        
			return listTransitRouterVpcAttachmentsResponse;
        }
    }
}
