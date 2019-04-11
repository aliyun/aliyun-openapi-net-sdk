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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetMediaAuditResultTimelineResponseUnmarshaller
    {
        public static GetMediaAuditResultTimelineResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaAuditResultTimelineResponse getMediaAuditResultTimelineResponse = new GetMediaAuditResultTimelineResponse();

			getMediaAuditResultTimelineResponse.HttpResponse = context.HttpResponse;
			getMediaAuditResultTimelineResponse.RequestId = context.StringValue("GetMediaAuditResultTimeline.RequestId");

			GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline mediaAuditResultTimeline = new GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline();

			List<GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_PornItem> mediaAuditResultTimeline_porn = new List<GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_PornItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Porn.Length"); i++) {
				GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_PornItem pornItem = new GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_PornItem();
				pornItem.Label = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Porn["+ i +"].Label");
				pornItem.Score = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Porn["+ i +"].Score");
				pornItem.Timestamp = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Porn["+ i +"].Timestamp");

				mediaAuditResultTimeline_porn.Add(pornItem);
			}
			mediaAuditResultTimeline.Porn = mediaAuditResultTimeline_porn;

			List<GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_TerrorismItem> mediaAuditResultTimeline_terrorism = new List<GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_TerrorismItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Terrorism.Length"); i++) {
				GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_TerrorismItem terrorismItem = new GetMediaAuditResultTimelineResponse.GetMediaAuditResultTimeline_MediaAuditResultTimeline.GetMediaAuditResultTimeline_TerrorismItem();
				terrorismItem.Label = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Terrorism["+ i +"].Label");
				terrorismItem.Score = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Terrorism["+ i +"].Score");
				terrorismItem.Timestamp = context.StringValue("GetMediaAuditResultTimeline.MediaAuditResultTimeline.Terrorism["+ i +"].Timestamp");

				mediaAuditResultTimeline_terrorism.Add(terrorismItem);
			}
			mediaAuditResultTimeline.Terrorism = mediaAuditResultTimeline_terrorism;
			getMediaAuditResultTimelineResponse.MediaAuditResultTimeline = mediaAuditResultTimeline;
        
			return getMediaAuditResultTimelineResponse;
        }
    }
}
