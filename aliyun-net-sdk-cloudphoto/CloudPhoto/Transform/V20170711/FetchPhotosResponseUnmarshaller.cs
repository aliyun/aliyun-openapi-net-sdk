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
    public class FetchPhotosResponseUnmarshaller
    {
        public static FetchPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			FetchPhotosResponse fetchPhotosResponse = new FetchPhotosResponse();

			fetchPhotosResponse.HttpResponse = context.HttpResponse;
			fetchPhotosResponse.Code = context.StringValue("FetchPhotos.Code");
			fetchPhotosResponse.Message = context.StringValue("FetchPhotos.Message");
			fetchPhotosResponse.TotalCount = context.IntegerValue("FetchPhotos.TotalCount");
			fetchPhotosResponse.RequestId = context.StringValue("FetchPhotos.RequestId");
			fetchPhotosResponse.Action = context.StringValue("FetchPhotos.Action");

			List<FetchPhotosResponse.FetchPhotos_Photo> fetchPhotosResponse_photos = new List<FetchPhotosResponse.FetchPhotos_Photo>();
			for (int i = 0; i < context.Length("FetchPhotos.Photos.Length"); i++) {
				FetchPhotosResponse.FetchPhotos_Photo photo = new FetchPhotosResponse.FetchPhotos_Photo();
				photo.Id = context.LongValue("FetchPhotos.Photos["+ i +"].Id");
				photo.IdStr = context.StringValue("FetchPhotos.Photos["+ i +"].IdStr");
				photo.Title = context.StringValue("FetchPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("FetchPhotos.Photos["+ i +"].FileId");
				photo.Location = context.StringValue("FetchPhotos.Photos["+ i +"].Location");
				photo.State = context.StringValue("FetchPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("FetchPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("FetchPhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("FetchPhotos.Photos["+ i +"].Remark");
				photo.Size = context.LongValue("FetchPhotos.Photos["+ i +"].Size");
				photo.Width = context.LongValue("FetchPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("FetchPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("FetchPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("FetchPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("FetchPhotos.Photos["+ i +"].TakenAt");
				photo.InactiveTime = context.LongValue("FetchPhotos.Photos["+ i +"].InactiveTime");
				photo.ShareExpireTime = context.LongValue("FetchPhotos.Photos["+ i +"].ShareExpireTime");

				fetchPhotosResponse_photos.Add(photo);
			}
			fetchPhotosResponse.Photos = fetchPhotosResponse_photos;
        
			return fetchPhotosResponse;
        }
    }
}