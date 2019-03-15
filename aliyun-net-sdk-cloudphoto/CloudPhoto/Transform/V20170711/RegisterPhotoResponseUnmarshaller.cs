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
    public class RegisterPhotoResponseUnmarshaller
    {
        public static RegisterPhotoResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterPhotoResponse registerPhotoResponse = new RegisterPhotoResponse();

			registerPhotoResponse.HttpResponse = context.HttpResponse;
			registerPhotoResponse.Code = context.StringValue("RegisterPhoto.Code");
			registerPhotoResponse.Message = context.StringValue("RegisterPhoto.Message");
			registerPhotoResponse.RequestId = context.StringValue("RegisterPhoto.RequestId");
			registerPhotoResponse.Action = context.StringValue("RegisterPhoto.Action");

			RegisterPhotoResponse.RegisterPhoto_Photo photo = new RegisterPhotoResponse.RegisterPhoto_Photo();
			photo.Id = context.LongValue("RegisterPhoto.Photo.Id");
			photo.IdStr = context.StringValue("RegisterPhoto.Photo.IdStr");
			photo.Title = context.StringValue("RegisterPhoto.Photo.Title");
			photo.Location = context.StringValue("RegisterPhoto.Photo.Location");
			photo.FileId = context.StringValue("RegisterPhoto.Photo.FileId");
			photo.State = context.StringValue("RegisterPhoto.Photo.State");
			photo.Md5 = context.StringValue("RegisterPhoto.Photo.Md5");
			photo.IsVideo = context.BooleanValue("RegisterPhoto.Photo.IsVideo");
			photo.Size = context.LongValue("RegisterPhoto.Photo.Size");
			photo.Remark = context.StringValue("RegisterPhoto.Photo.Remark");
			photo.Width = context.LongValue("RegisterPhoto.Photo.Width");
			photo.Height = context.LongValue("RegisterPhoto.Photo.Height");
			photo.Ctime = context.LongValue("RegisterPhoto.Photo.Ctime");
			photo.Mtime = context.LongValue("RegisterPhoto.Photo.Mtime");
			photo.TakenAt = context.LongValue("RegisterPhoto.Photo.TakenAt");
			photo.ShareExpireTime = context.LongValue("RegisterPhoto.Photo.ShareExpireTime");
			registerPhotoResponse.Photo = photo;
        
			return registerPhotoResponse;
        }
    }
}
