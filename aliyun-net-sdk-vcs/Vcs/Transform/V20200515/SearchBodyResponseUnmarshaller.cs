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
    public class SearchBodyResponseUnmarshaller
    {
        public static SearchBodyResponse Unmarshall(UnmarshallerContext context)
        {
			SearchBodyResponse searchBodyResponse = new SearchBodyResponse();

			searchBodyResponse.HttpResponse = context.HttpResponse;
			searchBodyResponse.Code = context.StringValue("SearchBody.Code");
			searchBodyResponse.Message = context.StringValue("SearchBody.Message");
			searchBodyResponse.RequestId = context.StringValue("SearchBody.RequestId");

			SearchBodyResponse.SearchBody_Data data = new SearchBodyResponse.SearchBody_Data();
			data.PageNo = context.IntegerValue("SearchBody.Data.PageNo");
			data.PageSize = context.IntegerValue("SearchBody.Data.PageSize");
			data.TotalCount = context.IntegerValue("SearchBody.Data.TotalCount");
			data.TotalPage = context.IntegerValue("SearchBody.Data.TotalPage");

			List<SearchBodyResponse.SearchBody_Data.SearchBody_Record> data_records = new List<SearchBodyResponse.SearchBody_Data.SearchBody_Record>();
			for (int i = 0; i < context.Length("SearchBody.Data.Records.Length"); i++) {
				SearchBodyResponse.SearchBody_Data.SearchBody_Record record = new SearchBodyResponse.SearchBody_Data.SearchBody_Record();
				record.GbId = context.StringValue("SearchBody.Data.Records["+ i +"].GbId");
				record.ImageUrl = context.StringValue("SearchBody.Data.Records["+ i +"].ImageUrl");
				record.LeftTopX = context.FloatValue("SearchBody.Data.Records["+ i +"].LeftTopX");
				record.LeftTopY = context.FloatValue("SearchBody.Data.Records["+ i +"].LeftTopY");
				record.RightBottomX = context.FloatValue("SearchBody.Data.Records["+ i +"].RightBottomX");
				record.RightBottomY = context.FloatValue("SearchBody.Data.Records["+ i +"].RightBottomY");
				record.Score = context.FloatValue("SearchBody.Data.Records["+ i +"].Score");
				record.TargetImageUrl = context.StringValue("SearchBody.Data.Records["+ i +"].TargetImageUrl");

				data_records.Add(record);
			}
			data.Records = data_records;
			searchBodyResponse.Data = data;
        
			return searchBodyResponse;
        }
    }
}
