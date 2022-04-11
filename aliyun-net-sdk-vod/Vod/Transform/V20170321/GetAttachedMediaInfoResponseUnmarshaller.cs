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
    public class GetAttachedMediaInfoResponseUnmarshaller
    {
        public static GetAttachedMediaInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAttachedMediaInfoResponse getAttachedMediaInfoResponse = new GetAttachedMediaInfoResponse();

			getAttachedMediaInfoResponse.HttpResponse = _ctx.HttpResponse;
			getAttachedMediaInfoResponse.RequestId = _ctx.StringValue("GetAttachedMediaInfo.RequestId");

			List<string> getAttachedMediaInfoResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetAttachedMediaInfo.NonExistMediaIds.Length"); i++) {
				getAttachedMediaInfoResponse_nonExistMediaIds.Add(_ctx.StringValue("GetAttachedMediaInfo.NonExistMediaIds["+ i +"]"));
			}
			getAttachedMediaInfoResponse.NonExistMediaIds = getAttachedMediaInfoResponse_nonExistMediaIds;

			List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia> getAttachedMediaInfoResponse_attachedMediaList = new List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia>();
			for (int i = 0; i < _ctx.Length("GetAttachedMediaInfo.AttachedMediaList.Length"); i++) {
				GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia attachedMedia = new GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia();
				attachedMedia.Type = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Type");
				attachedMedia.StorageLocation = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].StorageLocation");
				attachedMedia.CreationTime = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].CreationTime");
				attachedMedia.Status = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Status");
				attachedMedia.Icon = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Icon");
				attachedMedia.Tags = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Tags");
				attachedMedia.ModificationTime = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].ModificationTime");
				attachedMedia.MediaId = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].MediaId");
				attachedMedia.RegionId = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].RegionId");
				attachedMedia.Description = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Description");
				attachedMedia.AppId = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].AppId");
				attachedMedia.URL = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].URL");
				attachedMedia.Title = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Title");
				attachedMedia.OnlineStatus = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].OnlineStatus");
				attachedMedia.FileSize = _ctx.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].FileSize");

				List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category> attachedMedia_categories = new List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category>();
				for (int j = 0; j < _ctx.Length("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories.Length"); j++) {
					GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category category = new GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category();
					category.ParentId = _ctx.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].ParentId");
					category.CateName = _ctx.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].CateName");
					category.CateId = _ctx.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].CateId");
					category.Level = _ctx.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].Level");

					attachedMedia_categories.Add(category);
				}
				attachedMedia.Categories = attachedMedia_categories;

				getAttachedMediaInfoResponse_attachedMediaList.Add(attachedMedia);
			}
			getAttachedMediaInfoResponse.AttachedMediaList = getAttachedMediaInfoResponse_attachedMediaList;
        
			return getAttachedMediaInfoResponse;
        }
    }
}
