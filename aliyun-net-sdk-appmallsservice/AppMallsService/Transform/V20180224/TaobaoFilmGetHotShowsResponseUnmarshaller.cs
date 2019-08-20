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
using Aliyun.Acs.AppMallsService.Model.V20180224;

namespace Aliyun.Acs.AppMallsService.Transform.V20180224
{
    public class TaobaoFilmGetHotShowsResponseUnmarshaller
    {
        public static TaobaoFilmGetHotShowsResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetHotShowsResponse taobaoFilmGetHotShowsResponse = new TaobaoFilmGetHotShowsResponse();

			taobaoFilmGetHotShowsResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetHotShowsResponse.ErrorCode = context.StringValue("TaobaoFilmGetHotShows.ErrorCode");
			taobaoFilmGetHotShowsResponse.Msg = context.StringValue("TaobaoFilmGetHotShows.Msg");
			taobaoFilmGetHotShowsResponse.SubCode = context.StringValue("TaobaoFilmGetHotShows.SubCode");
			taobaoFilmGetHotShowsResponse.SubMsg = context.StringValue("TaobaoFilmGetHotShows.SubMsg");
			taobaoFilmGetHotShowsResponse.LogsId = context.StringValue("TaobaoFilmGetHotShows.LogsId");
			taobaoFilmGetHotShowsResponse.RequestId = context.StringValue("TaobaoFilmGetHotShows.RequestId");

			List<TaobaoFilmGetHotShowsResponse.TaobaoFilmGetHotShows_ShowsItem> taobaoFilmGetHotShowsResponse_shows = new List<TaobaoFilmGetHotShowsResponse.TaobaoFilmGetHotShows_ShowsItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetHotShows.Shows.Length"); i++) {
				TaobaoFilmGetHotShowsResponse.TaobaoFilmGetHotShows_ShowsItem showsItem = new TaobaoFilmGetHotShowsResponse.TaobaoFilmGetHotShows_ShowsItem();
				showsItem.BackgroundPicture = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].BackgroundPicture");
				showsItem.Country = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Country");
				showsItem.Description = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Description");
				showsItem.Director = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Director");
				showsItem.Duration = context.LongValue("TaobaoFilmGetHotShows.Shows["+ i +"].Duration");
				showsItem.Highlight = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Highlight");
				showsItem.Id = context.LongValue("TaobaoFilmGetHotShows.Shows["+ i +"].Id");
				showsItem.Language = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Language");
				showsItem.LeadingRole = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].LeadingRole");
				showsItem.OpenDay = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].OpenDay");
				showsItem.OpenTime = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].OpenTime");
				showsItem.Poster = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Poster");
				showsItem.Remark = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Remark");
				showsItem.ShowMark = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].ShowMark");
				showsItem.ShowName = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].ShowName");
				showsItem.ShowNameEn = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].ShowNameEn");
				showsItem.Type = context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].Type");

				List<string> showsItem_showVersionList = new List<string>();
				for (int j = 0; j < context.Length("TaobaoFilmGetHotShows.Shows["+ i +"].ShowVersionList.Length"); j++) {
					showsItem_showVersionList.Add(context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].ShowVersionList["+ j +"]"));
				}
				showsItem.ShowVersionList = showsItem_showVersionList;

				List<string> showsItem_trailerList = new List<string>();
				for (int j = 0; j < context.Length("TaobaoFilmGetHotShows.Shows["+ i +"].TrailerList.Length"); j++) {
					showsItem_trailerList.Add(context.StringValue("TaobaoFilmGetHotShows.Shows["+ i +"].TrailerList["+ j +"]"));
				}
				showsItem.TrailerList = showsItem_trailerList;

				taobaoFilmGetHotShowsResponse_shows.Add(showsItem);
			}
			taobaoFilmGetHotShowsResponse.Shows = taobaoFilmGetHotShowsResponse_shows;
        
			return taobaoFilmGetHotShowsResponse;
        }
    }
}
