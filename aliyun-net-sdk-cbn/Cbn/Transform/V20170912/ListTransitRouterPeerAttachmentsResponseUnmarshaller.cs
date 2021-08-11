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
    public class ListTransitRouterPeerAttachmentsResponseUnmarshaller
    {
        public static ListTransitRouterPeerAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterPeerAttachmentsResponse listTransitRouterPeerAttachmentsResponse = new ListTransitRouterPeerAttachmentsResponse();

			listTransitRouterPeerAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterPeerAttachmentsResponse.RequestId = _ctx.StringValue("ListTransitRouterPeerAttachments.RequestId");
			listTransitRouterPeerAttachmentsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterPeerAttachments.TotalCount");
			listTransitRouterPeerAttachmentsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterPeerAttachments.MaxResults");
			listTransitRouterPeerAttachmentsResponse.NextToken = _ctx.StringValue("ListTransitRouterPeerAttachments.NextToken");

			List<ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment> listTransitRouterPeerAttachmentsResponse_transitRouterAttachments = new List<ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterPeerAttachments.TransitRouterAttachments.Length"); i++) {
				ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment transitRouterAttachment = new ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment();
				transitRouterAttachment.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentId");
				transitRouterAttachment.PeerTransitRouterRegionId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterRegionId");
				transitRouterAttachment.PeerTransitRouterOwnerId = _ctx.LongValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterOwnerId");
				transitRouterAttachment.PeerTransitRouterId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterId");
				transitRouterAttachment.TransitRouterAttachmentName = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentName");
				transitRouterAttachment.ResourceType = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].ResourceType");
				transitRouterAttachment.Status = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].Status");
				transitRouterAttachment.TransitRouterAttachmentDescription = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentDescription");
				transitRouterAttachment.CreationTime = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].CreationTime");
				transitRouterAttachment.AutoPublishRouteEnabled = _ctx.BooleanValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].AutoPublishRouteEnabled");
				transitRouterAttachment.TransitRouterId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterId");
				transitRouterAttachment.Bandwidth = _ctx.IntegerValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].Bandwidth");
				transitRouterAttachment.BandwidthPackageId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].BandwidthPackageId");
				transitRouterAttachment.RegionId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].RegionId");
				transitRouterAttachment.GeographicSpanId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].GeographicSpanId");
				transitRouterAttachment.CenBandwidthPackageId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].CenBandwidthPackageId");

				listTransitRouterPeerAttachmentsResponse_transitRouterAttachments.Add(transitRouterAttachment);
			}
			listTransitRouterPeerAttachmentsResponse.TransitRouterAttachments = listTransitRouterPeerAttachmentsResponse_transitRouterAttachments;
        
			return listTransitRouterPeerAttachmentsResponse;
        }
    }
}
