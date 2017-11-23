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
    public class ListPhotosResponseUnmarshaller
    {
        public static ListPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListPhotosResponse listPhotosResponse = new ListPhotosResponse();

			listPhotosResponse.HttpResponse = context.HttpResponse;
			listPhotosResponse.Code = context.StringValue("ListPhotos.Code");
			listPhotosResponse.Message = context.StringValue("ListPhotos.Message");
			listPhotosResponse.NextCursor = context.StringValue("ListPhotos.NextCursor");
			listPhotosResponse.TotalCount = context.IntegerValue("ListPhotos.TotalCount");
			listPhotosResponse.RequestId = context.StringValue("ListPhotos.RequestId");
			listPhotosResponse.Action = context.StringValue("ListPhotos.Action");

			List<ListPhotosResponse.ListPhotos_Photo> listPhotosResponse_photos = new List<ListPhotosResponse.ListPhotos_Photo>();
			for (int i = 0; i < context.Length("ListPhotos.Photos.Length"); i++) {
				ListPhotosResponse.ListPhotos_Photo photo = new ListPhotosResponse.ListPhotos_Photo();
				photo.Id = context.LongValue("ListPhotos.Photos["+ i +"].Id");
				photo.Title = context.StringValue("ListPhotos.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("ListPhotos.Photos["+ i +"].FileId");
				photo.State = context.StringValue("ListPhotos.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("ListPhotos.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("ListPhotos.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("ListPhotos.Photos["+ i +"].Remark");
				photo.Width = context.LongValue("ListPhotos.Photos["+ i +"].Width");
				photo.Height = context.LongValue("ListPhotos.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("ListPhotos.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("ListPhotos.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("ListPhotos.Photos["+ i +"].TakenAt");
				photo.InactiveTime = context.LongValue("ListPhotos.Photos["+ i +"].InactiveTime");
				photo.ShareExpireTime = context.LongValue("ListPhotos.Photos["+ i +"].ShareExpireTime");

				listPhotosResponse_photos.Add(photo);
			}
			listPhotosResponse.Photos = listPhotosResponse_photos;
        
			return listPhotosResponse;
        }
    }
}