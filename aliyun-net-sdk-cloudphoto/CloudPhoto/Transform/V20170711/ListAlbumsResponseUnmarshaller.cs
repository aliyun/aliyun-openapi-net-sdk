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
    public class ListAlbumsResponseUnmarshaller
    {
        public static ListAlbumsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlbumsResponse listAlbumsResponse = new ListAlbumsResponse();

			listAlbumsResponse.HttpResponse = context.HttpResponse;
			listAlbumsResponse.Code = context.StringValue("ListAlbums.Code");
			listAlbumsResponse.Message = context.StringValue("ListAlbums.Message");
			listAlbumsResponse.NextCursor = context.StringValue("ListAlbums.NextCursor");
			listAlbumsResponse.TotalCount = context.IntegerValue("ListAlbums.TotalCount");
			listAlbumsResponse.RequestId = context.StringValue("ListAlbums.RequestId");
			listAlbumsResponse.Action = context.StringValue("ListAlbums.Action");

			List<ListAlbumsResponse.ListAlbums_Album> listAlbumsResponse_albums = new List<ListAlbumsResponse.ListAlbums_Album>();
			for (int i = 0; i < context.Length("ListAlbums.Albums.Length"); i++) {
				ListAlbumsResponse.ListAlbums_Album album = new ListAlbumsResponse.ListAlbums_Album();
				album.Id = context.LongValue("ListAlbums.Albums["+ i +"].Id");
				album.IdStr = context.StringValue("ListAlbums.Albums["+ i +"].IdStr");
				album.Name = context.StringValue("ListAlbums.Albums["+ i +"].Name");
				album.State = context.StringValue("ListAlbums.Albums["+ i +"].State");
				album.PhotosCount = context.LongValue("ListAlbums.Albums["+ i +"].PhotosCount");
				album.Ctime = context.LongValue("ListAlbums.Albums["+ i +"].Ctime");
				album.Mtime = context.LongValue("ListAlbums.Albums["+ i +"].Mtime");

				ListAlbumsResponse.ListAlbums_Album.ListAlbums_Cover cover = new ListAlbumsResponse.ListAlbums_Album.ListAlbums_Cover();
				cover.Id = context.LongValue("ListAlbums.Albums["+ i +"].Cover.Id");
				cover.IdStr = context.StringValue("ListAlbums.Albums["+ i +"].Cover.IdStr");
				cover.Title = context.StringValue("ListAlbums.Albums["+ i +"].Cover.Title");
				cover.FileId = context.StringValue("ListAlbums.Albums["+ i +"].Cover.FileId");
				cover.State = context.StringValue("ListAlbums.Albums["+ i +"].Cover.State");
				cover.Md5 = context.StringValue("ListAlbums.Albums["+ i +"].Cover.Md5");
				cover.IsVideo = context.BooleanValue("ListAlbums.Albums["+ i +"].Cover.IsVideo");
				cover.Remark = context.StringValue("ListAlbums.Albums["+ i +"].Cover.Remark");
				cover.Width = context.LongValue("ListAlbums.Albums["+ i +"].Cover.Width");
				cover.Height = context.LongValue("ListAlbums.Albums["+ i +"].Cover.Height");
				cover.Ctime = context.LongValue("ListAlbums.Albums["+ i +"].Cover.Ctime");
				cover.Mtime = context.LongValue("ListAlbums.Albums["+ i +"].Cover.Mtime");
				album.Cover = cover;

				listAlbumsResponse_albums.Add(album);
			}
			listAlbumsResponse.Albums = listAlbumsResponse_albums;
        
			return listAlbumsResponse;
        }
    }
}