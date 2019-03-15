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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class FetchMomentPhotosResponseUnmarshaller
    {
        public static FetchMomentPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			FetchMomentPhotosResponse fetchMomentPhotosResponse = new FetchMomentPhotosResponse();

			fetchMomentPhotosResponse.HttpResponse = context.HttpResponse;
			fetchMomentPhotosResponse.Code = context.StringValue("FetchMomentPhotos.Code");
			fetchMomentPhotosResponse.Message = context.StringValue("FetchMomentPhotos.Message");
			fetchMomentPhotosResponse.TotalCount = context.IntegerValue("FetchMomentPhotos.TotalCount");
			fetchMomentPhotosResponse.RequestId = context.StringValue("FetchMomentPhotos.RequestId");
			fetchMomentPhotosResponse.Action = context.StringValue("FetchMomentPhotos.Action");

			List<FetchMomentPhotosResponse.FetchMomentPhotos_Photo> fetchMomentPhotosResponse_photos = new List<FetchMomentPhotosResponse.FetchMomentPhotos_Photo>();
			for (int i = 0; i < context.Length("FetchMomentPhotos.Photos.Length"); i++) {
				FetchMomentPhotosResponse.FetchMomentPhotos_Photo photo = new FetchMomentPhotosResponse.FetchMomentPhotos_Photo();
				photo.Id = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Id");
				photo.IdStr = context.StringValue("FetchMomentPhotos.Photos["+ i +"].IdStr");
				photo.Title = context.StringValue("FetchMomentPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("FetchMomentPhotos.Photos["+ i +"].FileId");
				photo.Location = context.StringValue("FetchMomentPhotos.Photos["+ i +"].Location");
				photo.State = context.StringValue("FetchMomentPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("FetchMomentPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("FetchMomentPhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("FetchMomentPhotos.Photos["+ i +"].Remark");
				photo.Size = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Size");
				photo.Width = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("FetchMomentPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("FetchMomentPhotos.Photos["+ i +"].TakenAt");
				photo.InactiveTime = context.LongValue("FetchMomentPhotos.Photos["+ i +"].InactiveTime");
				photo.ShareExpireTime = context.LongValue("FetchMomentPhotos.Photos["+ i +"].ShareExpireTime");

				fetchMomentPhotosResponse_photos.Add(photo);
			}
			fetchMomentPhotosResponse.Photos = fetchMomentPhotosResponse_photos;
        
			return fetchMomentPhotosResponse;
        }
    }
}
