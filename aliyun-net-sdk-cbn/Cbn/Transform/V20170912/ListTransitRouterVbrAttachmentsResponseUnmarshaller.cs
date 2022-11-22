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
    public class ListTransitRouterVbrAttachmentsResponseUnmarshaller
    {
        public static ListTransitRouterVbrAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterVbrAttachmentsResponse listTransitRouterVbrAttachmentsResponse = new ListTransitRouterVbrAttachmentsResponse();

			listTransitRouterVbrAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterVbrAttachmentsResponse.NextToken = _ctx.StringValue("ListTransitRouterVbrAttachments.NextToken");
			listTransitRouterVbrAttachmentsResponse.RequestId = _ctx.StringValue("ListTransitRouterVbrAttachments.RequestId");
			listTransitRouterVbrAttachmentsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterVbrAttachments.TotalCount");
			listTransitRouterVbrAttachmentsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterVbrAttachments.MaxResults");

			List<ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment> listTransitRouterVbrAttachmentsResponse_transitRouterAttachments = new List<ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterVbrAttachments.TransitRouterAttachments.Length"); i++) {
				ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment transitRouterAttachment = new ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment();
				transitRouterAttachment.CreationTime = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].CreationTime");
				transitRouterAttachment.Status = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].Status");
				transitRouterAttachment.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentId");
				transitRouterAttachment.TransitRouterId = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].TransitRouterId");
				transitRouterAttachment.ResourceType = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].ResourceType");
				transitRouterAttachment.VbrRegionId = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].VbrRegionId");
				transitRouterAttachment.TransitRouterAttachmentDescription = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentDescription");
				transitRouterAttachment.VbrOwnerId = _ctx.LongValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].VbrOwnerId");
				transitRouterAttachment.AutoPublishRouteEnabled = _ctx.BooleanValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].AutoPublishRouteEnabled");
				transitRouterAttachment.VbrId = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].VbrId");
				transitRouterAttachment.TransitRouterAttachmentName = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].TransitRouterAttachmentName");

				List<ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment.ListTransitRouterVbrAttachments_Tag> transitRouterAttachment_tags = new List<ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment.ListTransitRouterVbrAttachments_Tag>();
				for (int j = 0; j < _ctx.Length("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].Tags.Length"); j++) {
					ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment.ListTransitRouterVbrAttachments_Tag tag = new ListTransitRouterVbrAttachmentsResponse.ListTransitRouterVbrAttachments_TransitRouterAttachment.ListTransitRouterVbrAttachments_Tag();
					tag.Key = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListTransitRouterVbrAttachments.TransitRouterAttachments["+ i +"].Tags["+ j +"].Value");

					transitRouterAttachment_tags.Add(tag);
				}
				transitRouterAttachment.Tags = transitRouterAttachment_tags;

				listTransitRouterVbrAttachmentsResponse_transitRouterAttachments.Add(transitRouterAttachment);
			}
			listTransitRouterVbrAttachmentsResponse.TransitRouterAttachments = listTransitRouterVbrAttachmentsResponse_transitRouterAttachments;
        
			return listTransitRouterVbrAttachmentsResponse;
        }
    }
}
