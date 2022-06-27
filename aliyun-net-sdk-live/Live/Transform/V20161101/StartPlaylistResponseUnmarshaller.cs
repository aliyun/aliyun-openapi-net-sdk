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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class StartPlaylistResponseUnmarshaller
    {
        public static StartPlaylistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartPlaylistResponse startPlaylistResponse = new StartPlaylistResponse();

			startPlaylistResponse.HttpResponse = _ctx.HttpResponse;
			startPlaylistResponse.RequestId = _ctx.StringValue("StartPlaylist.RequestId");
			startPlaylistResponse.ProgramId = _ctx.StringValue("StartPlaylist.ProgramId");

			StartPlaylistResponse.StartPlaylist_StreamInfo streamInfo = new StartPlaylistResponse.StartPlaylist_StreamInfo();
			streamInfo.DomainName = _ctx.StringValue("StartPlaylist.StreamInfo.DomainName");
			streamInfo.AppName = _ctx.StringValue("StartPlaylist.StreamInfo.AppName");
			streamInfo.StreamName = _ctx.StringValue("StartPlaylist.StreamInfo.StreamName");

			List<StartPlaylistResponse.StartPlaylist_StreamInfo.StartPlaylist_Stream> streamInfo_streams = new List<StartPlaylistResponse.StartPlaylist_StreamInfo.StartPlaylist_Stream>();
			for (int i = 0; i < _ctx.Length("StartPlaylist.StreamInfo.Streams.Length"); i++) {
				StartPlaylistResponse.StartPlaylist_StreamInfo.StartPlaylist_Stream stream = new StartPlaylistResponse.StartPlaylist_StreamInfo.StartPlaylist_Stream();
				stream.PullFlvUrl = _ctx.StringValue("StartPlaylist.StreamInfo.Streams["+ i +"].PullFlvUrl");
				stream.PullRtmpUrl = _ctx.StringValue("StartPlaylist.StreamInfo.Streams["+ i +"].PullRtmpUrl");
				stream.PullM3U8Url = _ctx.StringValue("StartPlaylist.StreamInfo.Streams["+ i +"].PullM3U8Url");
				stream.Quality = _ctx.StringValue("StartPlaylist.StreamInfo.Streams["+ i +"].Quality");

				streamInfo_streams.Add(stream);
			}
			streamInfo.Streams = streamInfo_streams;
			startPlaylistResponse.StreamInfo = streamInfo;
        
			return startPlaylistResponse;
        }
    }
}
