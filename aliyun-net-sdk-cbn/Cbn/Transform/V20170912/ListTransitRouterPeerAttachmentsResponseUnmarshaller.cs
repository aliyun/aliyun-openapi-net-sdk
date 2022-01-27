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
			listTransitRouterPeerAttachmentsResponse.NextToken = _ctx.StringValue("ListTransitRouterPeerAttachments.NextToken");
			listTransitRouterPeerAttachmentsResponse.RequestId = _ctx.StringValue("ListTransitRouterPeerAttachments.RequestId");
			listTransitRouterPeerAttachmentsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterPeerAttachments.TotalCount");
			listTransitRouterPeerAttachmentsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterPeerAttachments.MaxResults");

			List<ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment> listTransitRouterPeerAttachmentsResponse_transitRouterAttachments = new List<ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterPeerAttachments.TransitRouterAttachments.Length"); i++) {
				ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment transitRouterAttachment = new ListTransitRouterPeerAttachmentsResponse.ListTransitRouterPeerAttachments_TransitRouterAttachment();
				transitRouterAttachment.CreationTime = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].CreationTime");
				transitRouterAttachment.Status = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].Status");
				transitRouterAttachment.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentId");
				transitRouterAttachment.BandwidthType = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].BandwidthType");
				transitRouterAttachment.CenBandwidthPackageId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].CenBandwidthPackageId");
				transitRouterAttachment.TransitRouterAttachmentDescription = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentDescription");
				transitRouterAttachment.RegionId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].RegionId");
				transitRouterAttachment.PeerTransitRouterId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterId");
				transitRouterAttachment.BandwidthPackageId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].BandwidthPackageId");
				transitRouterAttachment.TransitRouterId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterId");
				transitRouterAttachment.PeerTransitRouterRegionId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterRegionId");
				transitRouterAttachment.ResourceType = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].ResourceType");
				transitRouterAttachment.Bandwidth = _ctx.IntegerValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].Bandwidth");
				transitRouterAttachment.GeographicSpanId = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].GeographicSpanId");
				transitRouterAttachment.PeerTransitRouterOwnerId = _ctx.LongValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].PeerTransitRouterOwnerId");
				transitRouterAttachment.AutoPublishRouteEnabled = _ctx.BooleanValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].AutoPublishRouteEnabled");
				transitRouterAttachment.TransitRouterAttachmentName = _ctx.StringValue("ListTransitRouterPeerAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentName");

				listTransitRouterPeerAttachmentsResponse_transitRouterAttachments.Add(transitRouterAttachment);
			}
			listTransitRouterPeerAttachmentsResponse.TransitRouterAttachments = listTransitRouterPeerAttachmentsResponse_transitRouterAttachments;
        
			return listTransitRouterPeerAttachmentsResponse;
        }
    }
}
