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
    public class TaobaoFilmGetSoonShowsResponseUnmarshaller
    {
        public static TaobaoFilmGetSoonShowsResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetSoonShowsResponse taobaoFilmGetSoonShowsResponse = new TaobaoFilmGetSoonShowsResponse();

			taobaoFilmGetSoonShowsResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetSoonShowsResponse.ErrorCode = context.StringValue("TaobaoFilmGetSoonShows.ErrorCode");
			taobaoFilmGetSoonShowsResponse.Msg = context.StringValue("TaobaoFilmGetSoonShows.Msg");
			taobaoFilmGetSoonShowsResponse.SubCode = context.StringValue("TaobaoFilmGetSoonShows.SubCode");
			taobaoFilmGetSoonShowsResponse.SubMsg = context.StringValue("TaobaoFilmGetSoonShows.SubMsg");
			taobaoFilmGetSoonShowsResponse.LogsId = context.StringValue("TaobaoFilmGetSoonShows.LogsId");
			taobaoFilmGetSoonShowsResponse.RequestId = context.StringValue("TaobaoFilmGetSoonShows.RequestId");

			List<TaobaoFilmGetSoonShowsResponse.TaobaoFilmGetSoonShows_ShowsItem> taobaoFilmGetSoonShowsResponse_shows = new List<TaobaoFilmGetSoonShowsResponse.TaobaoFilmGetSoonShows_ShowsItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetSoonShows.Shows.Length"); i++) {
				TaobaoFilmGetSoonShowsResponse.TaobaoFilmGetSoonShows_ShowsItem showsItem = new TaobaoFilmGetSoonShowsResponse.TaobaoFilmGetSoonShows_ShowsItem();
				showsItem.BackgroundPicture = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].BackgroundPicture");
				showsItem.Country = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Country");
				showsItem.Description = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Description");
				showsItem.Director = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Director");
				showsItem.Duration = context.LongValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Duration");
				showsItem.Highlight = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Highlight");
				showsItem.Id = context.LongValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Id");
				showsItem.Language = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Language");
				showsItem.LeadingRole = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].LeadingRole");
				showsItem.OpenDay = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].OpenDay");
				showsItem.OpenTime = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].OpenTime");
				showsItem.Poster = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Poster");
				showsItem.Remark = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Remark");
				showsItem.ShowMark = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].ShowMark");
				showsItem.ShowName = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].ShowName");
				showsItem.ShowNameEn = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].ShowNameEn");
				showsItem.Type = context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].Type");

				List<string> showsItem_showVersionList = new List<string>();
				for (int j = 0; j < context.Length("TaobaoFilmGetSoonShows.Shows["+ i +"].ShowVersionList.Length"); j++) {
					showsItem_showVersionList.Add(context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].ShowVersionList["+ j +"]"));
				}
				showsItem.ShowVersionList = showsItem_showVersionList;

				List<string> showsItem_trailerList = new List<string>();
				for (int j = 0; j < context.Length("TaobaoFilmGetSoonShows.Shows["+ i +"].TrailerList.Length"); j++) {
					showsItem_trailerList.Add(context.StringValue("TaobaoFilmGetSoonShows.Shows["+ i +"].TrailerList["+ j +"]"));
				}
				showsItem.TrailerList = showsItem_trailerList;

				taobaoFilmGetSoonShowsResponse_shows.Add(showsItem);
			}
			taobaoFilmGetSoonShowsResponse.Shows = taobaoFilmGetSoonShowsResponse_shows;
        
			return taobaoFilmGetSoonShowsResponse;
        }
    }
}
