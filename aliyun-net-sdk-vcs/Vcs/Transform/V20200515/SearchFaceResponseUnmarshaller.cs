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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class SearchFaceResponseUnmarshaller
    {
        public static SearchFaceResponse Unmarshall(UnmarshallerContext context)
        {
			SearchFaceResponse searchFaceResponse = new SearchFaceResponse();

			searchFaceResponse.HttpResponse = context.HttpResponse;
			searchFaceResponse.Code = context.StringValue("SearchFace.Code");
			searchFaceResponse.Message = context.StringValue("SearchFace.Message");
			searchFaceResponse.RequestId = context.StringValue("SearchFace.RequestId");

			SearchFaceResponse.SearchFace_Data data = new SearchFaceResponse.SearchFace_Data();
			data.PageNo = context.IntegerValue("SearchFace.Data.PageNo");
			data.PageSize = context.IntegerValue("SearchFace.Data.PageSize");
			data.TotalCount = context.IntegerValue("SearchFace.Data.TotalCount");
			data.TotalPage = context.IntegerValue("SearchFace.Data.TotalPage");

			List<SearchFaceResponse.SearchFace_Data.SearchFace_Record> data_records = new List<SearchFaceResponse.SearchFace_Data.SearchFace_Record>();
			for (int i = 0; i < context.Length("SearchFace.Data.Records.Length"); i++) {
				SearchFaceResponse.SearchFace_Data.SearchFace_Record record = new SearchFaceResponse.SearchFace_Data.SearchFace_Record();
				record.GbId = context.StringValue("SearchFace.Data.Records["+ i +"].GbId");
				record.ImageUrl = context.StringValue("SearchFace.Data.Records["+ i +"].ImageUrl");
				record.LeftTopX = context.FloatValue("SearchFace.Data.Records["+ i +"].LeftTopX");
				record.LeftTopY = context.FloatValue("SearchFace.Data.Records["+ i +"].LeftTopY");
				record.MatchSuggestion = context.StringValue("SearchFace.Data.Records["+ i +"].MatchSuggestion");
				record.RightBottomX = context.FloatValue("SearchFace.Data.Records["+ i +"].RightBottomX");
				record.RightBottomY = context.FloatValue("SearchFace.Data.Records["+ i +"].RightBottomY");
				record.Score = context.FloatValue("SearchFace.Data.Records["+ i +"].Score");
				record.TargetImageUrl = context.StringValue("SearchFace.Data.Records["+ i +"].TargetImageUrl");
				record.SourceId = context.StringValue("SearchFace.Data.Records["+ i +"].SourceId");

				data_records.Add(record);
			}
			data.Records = data_records;
			searchFaceResponse.Data = data;
        
			return searchFaceResponse;
        }
    }
}
