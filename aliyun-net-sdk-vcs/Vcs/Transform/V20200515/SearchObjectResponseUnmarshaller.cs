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
    public class SearchObjectResponseUnmarshaller
    {
        public static SearchObjectResponse Unmarshall(UnmarshallerContext context)
        {
			SearchObjectResponse searchObjectResponse = new SearchObjectResponse();

			searchObjectResponse.HttpResponse = context.HttpResponse;
			searchObjectResponse.Code = context.StringValue("SearchObject.Code");
			searchObjectResponse.Message = context.StringValue("SearchObject.Message");
			searchObjectResponse.RequestId = context.StringValue("SearchObject.RequestId");

			SearchObjectResponse.SearchObject_Data data = new SearchObjectResponse.SearchObject_Data();
			data.PageNumber = context.IntegerValue("SearchObject.Data.PageNumber");
			data.PageSize = context.IntegerValue("SearchObject.Data.PageSize");
			data.TotalCount = context.IntegerValue("SearchObject.Data.TotalCount");
			data.TotalPage = context.IntegerValue("SearchObject.Data.TotalPage");

			List<SearchObjectResponse.SearchObject_Data.SearchObject_RecordsItem> data_records = new List<SearchObjectResponse.SearchObject_Data.SearchObject_RecordsItem>();
			for (int i = 0; i < context.Length("SearchObject.Data.Records.Length"); i++) {
				SearchObjectResponse.SearchObject_Data.SearchObject_RecordsItem recordsItem = new SearchObjectResponse.SearchObject_Data.SearchObject_RecordsItem();
				recordsItem.CompareResult = context.StringValue("SearchObject.Data.Records["+ i +"].CompareResult");
				recordsItem.DeviceID = context.StringValue("SearchObject.Data.Records["+ i +"].DeviceID");
				recordsItem.ShotTime = context.LongValue("SearchObject.Data.Records["+ i +"].ShotTime");
				recordsItem.LeftTopX = context.IntegerValue("SearchObject.Data.Records["+ i +"].LeftTopX");
				recordsItem.LeftTopY = context.IntegerValue("SearchObject.Data.Records["+ i +"].LeftTopY");
				recordsItem.RightBtmX = context.IntegerValue("SearchObject.Data.Records["+ i +"].RightBtmX");
				recordsItem.RightBtmY = context.IntegerValue("SearchObject.Data.Records["+ i +"].RightBtmY");
				recordsItem.Score = context.FloatValue("SearchObject.Data.Records["+ i +"].Score");
				recordsItem.SourceID = context.StringValue("SearchObject.Data.Records["+ i +"].SourceID");
				recordsItem.SourceImagePath = context.StringValue("SearchObject.Data.Records["+ i +"].SourceImagePath");
				recordsItem.SourceImageUrl = context.StringValue("SearchObject.Data.Records["+ i +"].SourceImageUrl");
				recordsItem.TargetImagePath = context.StringValue("SearchObject.Data.Records["+ i +"].TargetImagePath");
				recordsItem.TargetImageUrl = context.StringValue("SearchObject.Data.Records["+ i +"].TargetImageUrl");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			searchObjectResponse.Data = data;
        
			return searchObjectResponse;
        }
    }
}
