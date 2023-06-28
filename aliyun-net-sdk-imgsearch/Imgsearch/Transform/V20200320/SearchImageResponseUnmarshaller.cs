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
using Aliyun.Acs.imgsearch.Model.V20200320;

namespace Aliyun.Acs.imgsearch.Transform.V20200320
{
    public class SearchImageResponseUnmarshaller
    {
        public static SearchImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchImageResponse searchImageResponse = new SearchImageResponse();

			searchImageResponse.HttpResponse = _ctx.HttpResponse;
			searchImageResponse.RequestId = _ctx.StringValue("SearchImage.RequestId");

			SearchImageResponse.SearchImage_Data data = new SearchImageResponse.SearchImage_Data();

			List<SearchImageResponse.SearchImage_Data.SearchImage_MatchListItem> data_matchList = new List<SearchImageResponse.SearchImage_Data.SearchImage_MatchListItem>();
			for (int i = 0; i < _ctx.Length("SearchImage.Data.MatchList.Length"); i++) {
				SearchImageResponse.SearchImage_Data.SearchImage_MatchListItem matchListItem = new SearchImageResponse.SearchImage_Data.SearchImage_MatchListItem();
				matchListItem.ImageUrl = _ctx.StringValue("SearchImage.Data.MatchList["+ i +"].ImageUrl");
				matchListItem.EntityId = _ctx.StringValue("SearchImage.Data.MatchList["+ i +"].EntityId");
				matchListItem.Score = _ctx.FloatValue("SearchImage.Data.MatchList["+ i +"].Score");
				matchListItem.DataId = _ctx.StringValue("SearchImage.Data.MatchList["+ i +"].DataId");
				matchListItem.ExtraData = _ctx.StringValue("SearchImage.Data.MatchList["+ i +"].ExtraData");

				data_matchList.Add(matchListItem);
			}
			data.MatchList = data_matchList;
			searchImageResponse.Data = data;
        
			return searchImageResponse;
        }
    }
}
