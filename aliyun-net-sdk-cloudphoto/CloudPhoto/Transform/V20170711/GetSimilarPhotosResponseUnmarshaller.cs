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
    public class GetSimilarPhotosResponseUnmarshaller
    {
        public static GetSimilarPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			GetSimilarPhotosResponse getSimilarPhotosResponse = new GetSimilarPhotosResponse();

			getSimilarPhotosResponse.HttpResponse = context.HttpResponse;
			getSimilarPhotosResponse.Code = context.StringValue("GetSimilarPhotos.Code");
			getSimilarPhotosResponse.Message = context.StringValue("GetSimilarPhotos.Message");
			getSimilarPhotosResponse.RequestId = context.StringValue("GetSimilarPhotos.RequestId");
			getSimilarPhotosResponse.Action = context.StringValue("GetSimilarPhotos.Action");

			List<GetSimilarPhotosResponse.GetSimilarPhotos_Photo> getSimilarPhotosResponse_photos = new List<GetSimilarPhotosResponse.GetSimilarPhotos_Photo>();
			for (int i = 0; i < context.Length("GetSimilarPhotos.Photos.Length"); i++) {
				GetSimilarPhotosResponse.GetSimilarPhotos_Photo photo = new GetSimilarPhotosResponse.GetSimilarPhotos_Photo();
				photo.Id = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Id");
				photo.IdStr = context.StringValue("GetSimilarPhotos.Photos["+ i +"].IdStr");
				photo.Title = context.StringValue("GetSimilarPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("GetSimilarPhotos.Photos["+ i +"].FileId");
				photo.Location = context.StringValue("GetSimilarPhotos.Photos["+ i +"].Location");
				photo.State = context.StringValue("GetSimilarPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("GetSimilarPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("GetSimilarPhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("GetSimilarPhotos.Photos["+ i +"].Remark");
				photo.Size = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Size");
				photo.Width = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("GetSimilarPhotos.Photos["+ i +"].TakenAt");
				photo.InactiveTime = context.LongValue("GetSimilarPhotos.Photos["+ i +"].InactiveTime");
				photo.ShareExpireTime = context.LongValue("GetSimilarPhotos.Photos["+ i +"].ShareExpireTime");
				photo.Like = context.LongValue("GetSimilarPhotos.Photos["+ i +"].Like");

				getSimilarPhotosResponse_photos.Add(photo);
			}
			getSimilarPhotosResponse.Photos = getSimilarPhotosResponse_photos;
        
			return getSimilarPhotosResponse;
        }
    }
}
