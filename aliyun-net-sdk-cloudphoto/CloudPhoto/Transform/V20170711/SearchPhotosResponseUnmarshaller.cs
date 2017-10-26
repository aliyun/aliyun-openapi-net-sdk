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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class SearchPhotosResponseUnmarshaller
    {
        public static SearchPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			SearchPhotosResponse searchPhotosResponse = new SearchPhotosResponse();

			searchPhotosResponse.HttpResponse = context.HttpResponse;
			searchPhotosResponse.Code = context.StringValue("SearchPhotos.Code");
			searchPhotosResponse.Message = context.StringValue("SearchPhotos.Message");
			searchPhotosResponse.TotalCount = context.IntegerValue("SearchPhotos.TotalCount");
			searchPhotosResponse.RequestId = context.StringValue("SearchPhotos.RequestId");
			searchPhotosResponse.Action = context.StringValue("SearchPhotos.Action");

			List<SearchPhotosResponse.SearchPhotos_Photo> searchPhotosResponse_photos = new List<SearchPhotosResponse.SearchPhotos_Photo>();
			for (int i = 0; i < context.Length("SearchPhotos.Photos.Length"); i++) {
				SearchPhotosResponse.SearchPhotos_Photo photo = new SearchPhotosResponse.SearchPhotos_Photo();
				photo.Id = context.LongValue("SearchPhotos.Photos["+ i +"].Id");
				photo.Title = context.StringValue("SearchPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("SearchPhotos.Photos["+ i +"].FileId");
				photo.State = context.StringValue("SearchPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("SearchPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("SearchPhotos.Photos["+ i +"].IsVideo");
				photo.Width = context.LongValue("SearchPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("SearchPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("SearchPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("SearchPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("SearchPhotos.Photos["+ i +"].TakenAt");
				photo.ShareExpireTime = context.LongValue("SearchPhotos.Photos["+ i +"].ShareExpireTime");

				searchPhotosResponse_photos.Add(photo);
			}
			searchPhotosResponse.Photos = searchPhotosResponse_photos;
        
			return searchPhotosResponse;
        }
    }
}