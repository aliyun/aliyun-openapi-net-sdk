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
using Aliyun.Acs.cloudgame.Model.V20200429;

namespace Aliyun.Acs.cloudgame.Transform.V20200429
{
    public class ListGamesResponseUnmarshaller
    {
        public static ListGamesResponse Unmarshall(UnmarshallerContext context)
        {
			ListGamesResponse listGamesResponse = new ListGamesResponse();

			listGamesResponse.HttpResponse = context.HttpResponse;
			listGamesResponse.Count = context.StringValue("ListGames.Count");
			listGamesResponse.PageSize = context.IntegerValue("ListGames.PageSize");
			listGamesResponse.CurrentPage = context.IntegerValue("ListGames.CurrentPage");
			listGamesResponse.RequestId = context.StringValue("ListGames.RequestId");

			List<ListGamesResponse.ListGames_DataListItem> listGamesResponse_dataList = new List<ListGamesResponse.ListGames_DataListItem>();
			for (int i = 0; i < context.Length("ListGames.DataList.Length"); i++) {
				ListGamesResponse.ListGames_DataListItem dataListItem = new ListGamesResponse.ListGames_DataListItem();
				dataListItem.GameId = context.StringValue("ListGames.DataList["+ i +"].GameId");
				dataListItem.GameName = context.StringValue("ListGames.DataList["+ i +"].GameName");
				dataListItem.InstallPath = context.StringValue("ListGames.DataList["+ i +"].InstallPath");
				dataListItem.SavePath = context.StringValue("ListGames.DataList["+ i +"].SavePath");
				dataListItem.Resolution = context.StringValue("ListGames.DataList["+ i +"].Resolution");
				dataListItem.FrameRate = context.StringValue("ListGames.DataList["+ i +"].FrameRate");
				dataListItem.InputType = context.StringValue("ListGames.DataList["+ i +"].InputType");
				dataListItem.Device = context.StringValue("ListGames.DataList["+ i +"].Device");
				dataListItem.Status = context.StringValue("ListGames.DataList["+ i +"].Status");
				dataListItem.CurVersion = context.StringValue("ListGames.DataList["+ i +"].CurVersion");

				listGamesResponse_dataList.Add(dataListItem);
			}
			listGamesResponse.DataList = listGamesResponse_dataList;
        
			return listGamesResponse;
        }
    }
}
