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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class SearchFaceResponseUnmarshaller
    {
        public static SearchFaceResponse Unmarshall(UnmarshallerContext context)
        {
			SearchFaceResponse searchFaceResponse = new SearchFaceResponse();

			searchFaceResponse.HttpResponse = context.HttpResponse;
			searchFaceResponse.RequestId = context.StringValue("SearchFace.RequestId");

			SearchFaceResponse.SearchFace_Data data = new SearchFaceResponse.SearchFace_Data();

			List<SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem> data_matchList = new List<SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem>();
			for (int i = 0; i < context.Length("SearchFace.Data.MatchList.Length"); i++) {
				SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem matchListItem = new SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem();

				SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_Location location = new SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_Location();
				location.X = context.IntegerValue("SearchFace.Data.MatchList["+ i +"].Location.X");
				location.Y = context.IntegerValue("SearchFace.Data.MatchList["+ i +"].Location.Y");
				location.Width = context.IntegerValue("SearchFace.Data.MatchList["+ i +"].Location.Width");
				location.Height = context.IntegerValue("SearchFace.Data.MatchList["+ i +"].Location.Height");
				matchListItem.Location = location;

				List<SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_FaceItemsItem> matchListItem_faceItems = new List<SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_FaceItemsItem>();
				for (int j = 0; j < context.Length("SearchFace.Data.MatchList["+ i +"].FaceItems.Length"); j++) {
					SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_FaceItemsItem faceItemsItem = new SearchFaceResponse.SearchFace_Data.SearchFace_MatchListItem.SearchFace_FaceItemsItem();
					faceItemsItem.FaceId = context.StringValue("SearchFace.Data.MatchList["+ i +"].FaceItems["+ j +"].FaceId");
					faceItemsItem.Score = context.FloatValue("SearchFace.Data.MatchList["+ i +"].FaceItems["+ j +"].Score");
					faceItemsItem.ExtraData = context.StringValue("SearchFace.Data.MatchList["+ i +"].FaceItems["+ j +"].ExtraData");
					faceItemsItem.EntityId = context.StringValue("SearchFace.Data.MatchList["+ i +"].FaceItems["+ j +"].EntityId");

					matchListItem_faceItems.Add(faceItemsItem);
				}
				matchListItem.FaceItems = matchListItem_faceItems;

				data_matchList.Add(matchListItem);
			}
			data.MatchList = data_matchList;
			searchFaceResponse.Data = data;
        
			return searchFaceResponse;
        }
    }
}
