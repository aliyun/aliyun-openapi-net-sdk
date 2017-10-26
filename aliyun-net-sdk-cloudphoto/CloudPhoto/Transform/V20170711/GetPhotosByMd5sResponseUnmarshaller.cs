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
    public class GetPhotosByMd5sResponseUnmarshaller
    {
        public static GetPhotosByMd5sResponse Unmarshall(UnmarshallerContext context)
        {
			GetPhotosByMd5sResponse getPhotosByMd5sResponse = new GetPhotosByMd5sResponse();

			getPhotosByMd5sResponse.HttpResponse = context.HttpResponse;
			getPhotosByMd5sResponse.Code = context.StringValue("GetPhotosByMd5s.Code");
			getPhotosByMd5sResponse.Message = context.StringValue("GetPhotosByMd5s.Message");
			getPhotosByMd5sResponse.RequestId = context.StringValue("GetPhotosByMd5s.RequestId");
			getPhotosByMd5sResponse.Action = context.StringValue("GetPhotosByMd5s.Action");

			List<GetPhotosByMd5sResponse.GetPhotosByMd5s_Photo> getPhotosByMd5sResponse_photos = new List<GetPhotosByMd5sResponse.GetPhotosByMd5s_Photo>();
			for (int i = 0; i < context.Length("GetPhotosByMd5s.Photos.Length"); i++) {
				GetPhotosByMd5sResponse.GetPhotosByMd5s_Photo photo = new GetPhotosByMd5sResponse.GetPhotosByMd5s_Photo();
				photo.Id = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].Id");
				photo.Title = context.StringValue("GetPhotosByMd5s.Photos["+ i +"].Title");
				photo.FileId = context.StringValue("GetPhotosByMd5s.Photos["+ i +"].FileId");
				photo.State = context.StringValue("GetPhotosByMd5s.Photos["+ i +"].State");
				photo.Md5 = context.StringValue("GetPhotosByMd5s.Photos["+ i +"].Md5");
				photo.IsVideo = context.BooleanValue("GetPhotosByMd5s.Photos["+ i +"].IsVideo");
				photo.Remark = context.StringValue("GetPhotosByMd5s.Photos["+ i +"].Remark");
				photo.Width = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].Width");
				photo.Height = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].Height");
				photo.Ctime = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].Ctime");
				photo.Mtime = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].Mtime");
				photo.TakenAt = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].TakenAt");
				photo.ShareExpireTime = context.LongValue("GetPhotosByMd5s.Photos["+ i +"].ShareExpireTime");

				getPhotosByMd5sResponse_photos.Add(photo);
			}
			getPhotosByMd5sResponse.Photos = getPhotosByMd5sResponse_photos;
        
			return getPhotosByMd5sResponse;
        }
    }
}