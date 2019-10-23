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
        public static GetAttachedMediaInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetAttachedMediaInfoResponse getAttachedMediaInfoResponse = new GetAttachedMediaInfoResponse();

			getAttachedMediaInfoResponse.HttpResponse = context.HttpResponse;
			getAttachedMediaInfoResponse.RequestId = context.StringValue("GetAttachedMediaInfo.RequestId");

			List<string> getAttachedMediaInfoResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < context.Length("GetAttachedMediaInfo.NonExistMediaIds.Length"); i++) {
				getAttachedMediaInfoResponse_nonExistMediaIds.Add(context.StringValue("GetAttachedMediaInfo.NonExistMediaIds["+ i +"]"));
			}
			getAttachedMediaInfoResponse.NonExistMediaIds = getAttachedMediaInfoResponse_nonExistMediaIds;

			List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia> getAttachedMediaInfoResponse_attachedMediaList = new List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia>();
			for (int i = 0; i < context.Length("GetAttachedMediaInfo.AttachedMediaList.Length"); i++) {
				GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia attachedMedia = new GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia();
				attachedMedia.MediaId = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].MediaId");
				attachedMedia.Title = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Title");
				attachedMedia.Type = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Type");
				attachedMedia.Tags = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Tags");
				attachedMedia.URL = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].URL");
				attachedMedia.Description = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Description");
				attachedMedia.FileSize = context.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].FileSize");
				attachedMedia.StorageLocation = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].StorageLocation");
				attachedMedia.CreationTime = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].CreationTime");
				attachedMedia.ModificationTime = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].ModificationTime");
				attachedMedia.AppId = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].AppId");
				attachedMedia.Status = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Status");
				attachedMedia.OnlineStatus = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].OnlineStatus");
				attachedMedia.Icon = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Icon");
				attachedMedia.RegionId = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].RegionId");

				List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category> attachedMedia_categories = new List<GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category>();
				for (int j = 0; j < context.Length("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories.Length"); j++) {
					GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category category = new GetAttachedMediaInfoResponse.GetAttachedMediaInfo_AttachedMedia.GetAttachedMediaInfo_Category();
					category.CateId = context.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].CateId");
					category.CateName = context.StringValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].CateName");
					category.Level = context.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].Level");
					category.ParentId = context.LongValue("GetAttachedMediaInfo.AttachedMediaList["+ i +"].Categories["+ j +"].ParentId");

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
