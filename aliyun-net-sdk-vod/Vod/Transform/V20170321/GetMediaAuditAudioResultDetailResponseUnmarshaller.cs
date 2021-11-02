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
    public class GetMediaAuditAudioResultDetailResponseUnmarshaller
    {
        public static GetMediaAuditAudioResultDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMediaAuditAudioResultDetailResponse getMediaAuditAudioResultDetailResponse = new GetMediaAuditAudioResultDetailResponse();

			getMediaAuditAudioResultDetailResponse.HttpResponse = _ctx.HttpResponse;
			getMediaAuditAudioResultDetailResponse.RequestId = _ctx.StringValue("GetMediaAuditAudioResultDetail.RequestId");

			GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail mediaAuditAudioResultDetail = new GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail();
			mediaAuditAudioResultDetail.Total = _ctx.IntegerValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.Total");
			mediaAuditAudioResultDetail.PageTotal = _ctx.IntegerValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.PageTotal");

			List<GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail.GetMediaAuditAudioResultDetail_ListItem> mediaAuditAudioResultDetail_list = new List<GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail.GetMediaAuditAudioResultDetail_ListItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.List.Length"); i++) {
				GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail.GetMediaAuditAudioResultDetail_ListItem listItem = new GetMediaAuditAudioResultDetailResponse.GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail.GetMediaAuditAudioResultDetail_ListItem();
				listItem.StartTime = _ctx.LongValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.List["+ i +"].StartTime");
				listItem.EndTime = _ctx.LongValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.List["+ i +"].EndTime");
				listItem.Text = _ctx.StringValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.List["+ i +"].Text");
				listItem.Label = _ctx.StringValue("GetMediaAuditAudioResultDetail.MediaAuditAudioResultDetail.List["+ i +"].Label");

				mediaAuditAudioResultDetail_list.Add(listItem);
			}
			mediaAuditAudioResultDetail.List = mediaAuditAudioResultDetail_list;
			getMediaAuditAudioResultDetailResponse.MediaAuditAudioResultDetail = mediaAuditAudioResultDetail;
        
			return getMediaAuditAudioResultDetailResponse;
        }
    }
}
