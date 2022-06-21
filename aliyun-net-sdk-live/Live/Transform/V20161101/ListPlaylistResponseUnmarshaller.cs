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
    public class ListPlaylistResponseUnmarshaller
    {
        public static ListPlaylistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPlaylistResponse listPlaylistResponse = new ListPlaylistResponse();

			listPlaylistResponse.HttpResponse = _ctx.HttpResponse;
			listPlaylistResponse.RequestId = _ctx.StringValue("ListPlaylist.RequestId");
			listPlaylistResponse.Total = _ctx.IntegerValue("ListPlaylist.Total");

			List<ListPlaylistResponse.ListPlaylist_ProgramInfo> listPlaylistResponse_programList = new List<ListPlaylistResponse.ListPlaylist_ProgramInfo>();
			for (int i = 0; i < _ctx.Length("ListPlaylist.ProgramList.Length"); i++) {
				ListPlaylistResponse.ListPlaylist_ProgramInfo programInfo = new ListPlaylistResponse.ListPlaylist_ProgramInfo();
				programInfo.ProgramId = _ctx.StringValue("ListPlaylist.ProgramList["+ i +"].ProgramId");
				programInfo.ProgramName = _ctx.StringValue("ListPlaylist.ProgramList["+ i +"].ProgramName");
				programInfo.CasterId = _ctx.StringValue("ListPlaylist.ProgramList["+ i +"].CasterId");
				programInfo.DomainName = _ctx.StringValue("ListPlaylist.ProgramList["+ i +"].DomainName");
				programInfo.RepeatNumber = _ctx.IntegerValue("ListPlaylist.ProgramList["+ i +"].RepeatNumber");
				programInfo.Status = _ctx.IntegerValue("ListPlaylist.ProgramList["+ i +"].Status");

				listPlaylistResponse_programList.Add(programInfo);
			}
			listPlaylistResponse.ProgramList = listPlaylistResponse_programList;
        
			return listPlaylistResponse;
        }
    }
}
