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
    public class GetAlbumsByNamesResponseUnmarshaller
    {
        public static GetAlbumsByNamesResponse Unmarshall(UnmarshallerContext context)
        {
			GetAlbumsByNamesResponse getAlbumsByNamesResponse = new GetAlbumsByNamesResponse();

			getAlbumsByNamesResponse.HttpResponse = context.HttpResponse;
			getAlbumsByNamesResponse.Code = context.StringValue("GetAlbumsByNames.Code");
			getAlbumsByNamesResponse.Message = context.StringValue("GetAlbumsByNames.Message");
			getAlbumsByNamesResponse.RequestId = context.StringValue("GetAlbumsByNames.RequestId");
			getAlbumsByNamesResponse.Action = context.StringValue("GetAlbumsByNames.Action");

			List<GetAlbumsByNamesResponse.GetAlbumsByNames_Album> getAlbumsByNamesResponse_albums = new List<GetAlbumsByNamesResponse.GetAlbumsByNames_Album>();
			for (int i = 0; i < context.Length("GetAlbumsByNames.Albums.Length"); i++) {
				GetAlbumsByNamesResponse.GetAlbumsByNames_Album album = new GetAlbumsByNamesResponse.GetAlbumsByNames_Album();
				album.Id = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Id");
				album.IdStr = context.StringValue("GetAlbumsByNames.Albums["+ i +"].IdStr");
				album.Name = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Name");
				album.State = context.StringValue("GetAlbumsByNames.Albums["+ i +"].State");
				album.PhotosCount = context.LongValue("GetAlbumsByNames.Albums["+ i +"].PhotosCount");
				album.Ctime = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Ctime");
				album.Mtime = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Mtime");

				GetAlbumsByNamesResponse.GetAlbumsByNames_Album.GetAlbumsByNames_Cover cover = new GetAlbumsByNamesResponse.GetAlbumsByNames_Album.GetAlbumsByNames_Cover();
				cover.Id = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Cover.Id");
				cover.IdStr = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.IdStr");
				cover.Title = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.Title");
				cover.FileId = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.FileId");
				cover.State = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.State");
				cover.Md5 = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.Md5");
				cover.IsVideo = context.BooleanValue("GetAlbumsByNames.Albums["+ i +"].Cover.IsVideo");
				cover.Remark = context.StringValue("GetAlbumsByNames.Albums["+ i +"].Cover.Remark");
				cover.Width = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Cover.Width");
				cover.Height = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Cover.Height");
				cover.Ctime = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Cover.Ctime");
				cover.Mtime = context.LongValue("GetAlbumsByNames.Albums["+ i +"].Cover.Mtime");
				album.Cover = cover;

				getAlbumsByNamesResponse_albums.Add(album);
			}
			getAlbumsByNamesResponse.Albums = getAlbumsByNamesResponse_albums;
        
			return getAlbumsByNamesResponse;
        }
    }
}
