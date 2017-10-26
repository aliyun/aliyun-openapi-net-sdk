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
    public class CreatePhotoResponseUnmarshaller
    {
        public static CreatePhotoResponse Unmarshall(UnmarshallerContext context)
        {
			CreatePhotoResponse createPhotoResponse = new CreatePhotoResponse();

			createPhotoResponse.HttpResponse = context.HttpResponse;
			createPhotoResponse.Code = context.StringValue("CreatePhoto.Code");
			createPhotoResponse.Message = context.StringValue("CreatePhoto.Message");
			createPhotoResponse.RequestId = context.StringValue("CreatePhoto.RequestId");
			createPhotoResponse.Action = context.StringValue("CreatePhoto.Action");

			CreatePhotoResponse.CreatePhoto_Photo photo = new CreatePhotoResponse.CreatePhoto_Photo();
			photo.Id = context.LongValue("CreatePhoto.Photo.Id");
			photo.Title = context.StringValue("CreatePhoto.Photo.Title");
			photo.FileId = context.StringValue("CreatePhoto.Photo.FileId");
			photo.State = context.StringValue("CreatePhoto.Photo.State");
			photo.Md5 = context.StringValue("CreatePhoto.Photo.Md5");
			photo.IsVideo = context.BooleanValue("CreatePhoto.Photo.IsVideo");
			photo.Remark = context.StringValue("CreatePhoto.Photo.Remark");
			photo.Width = context.LongValue("CreatePhoto.Photo.Width");
			photo.Height = context.LongValue("CreatePhoto.Photo.Height");
			photo.Ctime = context.LongValue("CreatePhoto.Photo.Ctime");
			photo.Mtime = context.LongValue("CreatePhoto.Photo.Mtime");
			photo.TakenAt = context.LongValue("CreatePhoto.Photo.TakenAt");
			photo.ShareExpireTime = context.LongValue("CreatePhoto.Photo.ShareExpireTime");
			createPhotoResponse.Photo = photo;
        
			return createPhotoResponse;
        }
    }
}