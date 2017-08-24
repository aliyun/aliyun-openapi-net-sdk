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
    public class CreateAlbumResponseUnmarshaller
    {
        public static CreateAlbumResponse Unmarshall(UnmarshallerContext context)
        {
			CreateAlbumResponse createAlbumResponse = new CreateAlbumResponse();

			createAlbumResponse.HttpResponse = context.HttpResponse;
			createAlbumResponse.Code = context.StringValue("CreateAlbum.Code");
			createAlbumResponse.Message = context.StringValue("CreateAlbum.Message");
			createAlbumResponse.RequestId = context.StringValue("CreateAlbum.RequestId");
			createAlbumResponse.Action = context.StringValue("CreateAlbum.Action");

			CreateAlbumResponse.CreateAlbum_Album album = new CreateAlbumResponse.CreateAlbum_Album();
			album.Id = context.LongValue("CreateAlbum.Album.Id");
			album.Name = context.StringValue("CreateAlbum.Album.Name");
			album.State = context.StringValue("CreateAlbum.Album.State");
			album.Remark = context.StringValue("CreateAlbum.Album.Remark");
			album.PhotosCount = context.LongValue("CreateAlbum.Album.PhotosCount");
			album.Ctime = context.LongValue("CreateAlbum.Album.Ctime");
			album.Mtime = context.LongValue("CreateAlbum.Album.Mtime");

			CreateAlbumResponse.CreateAlbum_Album.CreateAlbum_Cover cover = new CreateAlbumResponse.CreateAlbum_Album.CreateAlbum_Cover();
			cover.Id = context.LongValue("CreateAlbum.Album.Cover.Id");
			cover.Title = context.StringValue("CreateAlbum.Album.Cover.Title");
			cover.FileId = context.StringValue("CreateAlbum.Album.Cover.FileId");
			cover.State = context.StringValue("CreateAlbum.Album.Cover.State");
			cover.Md5 = context.StringValue("CreateAlbum.Album.Cover.Md5");
			cover.IsVideo = context.BooleanValue("CreateAlbum.Album.Cover.IsVideo");
			cover.Width = context.LongValue("CreateAlbum.Album.Cover.Width");
			cover.Height = context.LongValue("CreateAlbum.Album.Cover.Height");
			cover.Ctime = context.LongValue("CreateAlbum.Album.Cover.Ctime");
			cover.Mtime = context.LongValue("CreateAlbum.Album.Cover.Mtime");
			cover.Remark = context.StringValue("CreateAlbum.Album.Cover.Remark");
			album.Cover = cover;
			createAlbumResponse.Album = album;
        
			return createAlbumResponse;
        }
    }
}