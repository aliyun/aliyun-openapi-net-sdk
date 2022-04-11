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
    public class GetMediaAuditResultDetailResponseUnmarshaller
    {
        public static GetMediaAuditResultDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMediaAuditResultDetailResponse getMediaAuditResultDetailResponse = new GetMediaAuditResultDetailResponse();

			getMediaAuditResultDetailResponse.HttpResponse = _ctx.HttpResponse;
			getMediaAuditResultDetailResponse.RequestId = _ctx.StringValue("GetMediaAuditResultDetail.RequestId");

			GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail mediaAuditResultDetail = new GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail();
			mediaAuditResultDetail.Total = _ctx.IntegerValue("GetMediaAuditResultDetail.MediaAuditResultDetail.Total");

			List<GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail.GetMediaAuditResultDetail_ListItem> mediaAuditResultDetail_list = new List<GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail.GetMediaAuditResultDetail_ListItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResultDetail.MediaAuditResultDetail.List.Length"); i++) {
				GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail.GetMediaAuditResultDetail_ListItem listItem = new GetMediaAuditResultDetailResponse.GetMediaAuditResultDetail_MediaAuditResultDetail.GetMediaAuditResultDetail_ListItem();
				listItem.TerrorismScore = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].TerrorismScore");
				listItem.AdLabel = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].AdLabel");
				listItem.PornLabel = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].PornLabel");
				listItem.PornScore = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].PornScore");
				listItem.LiveLabel = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].LiveLabel");
				listItem.Url = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].Url");
				listItem.Timestamp = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].Timestamp");
				listItem.AdScore = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].AdScore");
				listItem.LiveScore = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].LiveScore");
				listItem.LogoScore = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].LogoScore");
				listItem.LogoLabel = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].LogoLabel");
				listItem.TerrorismLabel = _ctx.StringValue("GetMediaAuditResultDetail.MediaAuditResultDetail.List["+ i +"].TerrorismLabel");

				mediaAuditResultDetail_list.Add(listItem);
			}
			mediaAuditResultDetail.List = mediaAuditResultDetail_list;
			getMediaAuditResultDetailResponse.MediaAuditResultDetail = mediaAuditResultDetail;
        
			return getMediaAuditResultDetailResponse;
        }
    }
}
