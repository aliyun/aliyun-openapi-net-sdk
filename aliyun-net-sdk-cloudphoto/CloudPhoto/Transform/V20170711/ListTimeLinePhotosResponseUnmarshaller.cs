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
    public class ListTimeLinePhotosResponseUnmarshaller
    {
        public static ListTimeLinePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListTimeLinePhotosResponse listTimeLinePhotosResponse = new ListTimeLinePhotosResponse();

			listTimeLinePhotosResponse.HttpResponse = context.HttpResponse;
			listTimeLinePhotosResponse.Code = context.StringValue("ListTimeLinePhotos.Code");
			listTimeLinePhotosResponse.Message = context.StringValue("ListTimeLinePhotos.Message");
			listTimeLinePhotosResponse.TotalCount = context.IntegerValue("ListTimeLinePhotos.TotalCount");
			listTimeLinePhotosResponse.RequestId = context.StringValue("ListTimeLinePhotos.RequestId");
			listTimeLinePhotosResponse.Action = context.StringValue("ListTimeLinePhotos.Action");

			List<ListTimeLinePhotosResponse.ListTimeLinePhotos_Photo> listTimeLinePhotosResponse_photos = new List<ListTimeLinePhotosResponse.ListTimeLinePhotos_Photo>();
			for (int i = 0; i < context.Length("ListTimeLinePhotos.Photos.Length"); i++) {
				ListTimeLinePhotosResponse.ListTimeLinePhotos_Photo photo = new ListTimeLinePhotosResponse.ListTimeLinePhotos_Photo();
				photo.Id = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Id");
				photo.Title = context.StringValue("ListTimeLinePhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("ListTimeLinePhotos.Photos["+ i +"].FileId");
				photo.State = context.StringValue("ListTimeLinePhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("ListTimeLinePhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("ListTimeLinePhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("ListTimeLinePhotos.Photos["+ i +"].Remark");
				photo.Width = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].TakenAt");
				photo.ShareExpireTime = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].ShareExpireTime");
				photo.Like = context.LongValue("ListTimeLinePhotos.Photos["+ i +"].Like");

				listTimeLinePhotosResponse_photos.Add(photo);
			}
			listTimeLinePhotosResponse.Photos = listTimeLinePhotosResponse_photos;
        
			return listTimeLinePhotosResponse;
        }
    }
}