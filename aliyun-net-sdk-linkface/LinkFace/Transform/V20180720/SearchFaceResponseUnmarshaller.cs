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
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class SearchFaceResponseUnmarshaller
    {
        public static SearchFaceResponse Unmarshall(UnmarshallerContext context)
        {
			SearchFaceResponse searchFaceResponse = new SearchFaceResponse();

			searchFaceResponse.HttpResponse = context.HttpResponse;
			searchFaceResponse.RequestId = context.StringValue("SearchFace.RequestId");
			searchFaceResponse.Code = context.IntegerValue("SearchFace.Code");
			searchFaceResponse.Message = context.StringValue("SearchFace.Message");
			searchFaceResponse.Success = context.BooleanValue("SearchFace.Success");

			SearchFaceResponse.SearchFace_Data data = new SearchFaceResponse.SearchFace_Data();

			List<SearchFaceResponse.SearchFace_Data.SearchFace_TopUserItemItem> data_topUserItem = new List<SearchFaceResponse.SearchFace_Data.SearchFace_TopUserItemItem>();
			for (int i = 0; i < context.Length("SearchFace.Data.TopUserItem.Length"); i++) {
				SearchFaceResponse.SearchFace_Data.SearchFace_TopUserItemItem topUserItemItem = new SearchFaceResponse.SearchFace_Data.SearchFace_TopUserItemItem();
				topUserItemItem.UserId = context.StringValue("SearchFace.Data.TopUserItem["+ i +"].UserId");
				topUserItemItem.Score = context.FloatValue("SearchFace.Data.TopUserItem["+ i +"].Score");

				data_topUserItem.Add(topUserItemItem);
			}
			data.TopUserItem = data_topUserItem;
			searchFaceResponse.Data = data;
        
			return searchFaceResponse;
        }
    }
}