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

			List<SearchObjectResponse.SearchObject_DataItem> searchObjectResponse_data = new List<SearchObjectResponse.SearchObject_DataItem>();
			for (int i = 0; i < context.Length("SearchObject.Data.Length"); i++) {
				SearchObjectResponse.SearchObject_DataItem dataItem = new SearchObjectResponse.SearchObject_DataItem();
				dataItem.PageNumber = context.IntegerValue("SearchObject.Data["+ i +"].PageNumber");
				dataItem.PageSize = context.IntegerValue("SearchObject.Data["+ i +"].PageSize");
				dataItem.TotalCount = context.IntegerValue("SearchObject.Data["+ i +"].TotalCount");
				dataItem.TotalPage = context.IntegerValue("SearchObject.Data["+ i +"].TotalPage");

				List<SearchObjectResponse.SearchObject_DataItem.SearchObject_RecordsItem> dataItem_records = new List<SearchObjectResponse.SearchObject_DataItem.SearchObject_RecordsItem>();
				for (int j = 0; j < context.Length("SearchObject.Data["+ i +"].Records.Length"); j++) {
					SearchObjectResponse.SearchObject_DataItem.SearchObject_RecordsItem recordsItem = new SearchObjectResponse.SearchObject_DataItem.SearchObject_RecordsItem();
					recordsItem.BodyShotTime = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].BodyShotTime");
					recordsItem.CompareResult = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].CompareResult");
					recordsItem.DeviceID = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].DeviceID");
					recordsItem.FaceShotTime = context.LongValue("SearchObject.Data["+ i +"].Records["+ j +"].FaceShotTime");
					recordsItem.LeftTopX = context.IntegerValue("SearchObject.Data["+ i +"].Records["+ j +"].LeftTopX");
					recordsItem.LeftTopY = context.IntegerValue("SearchObject.Data["+ i +"].Records["+ j +"].LeftTopY");
					recordsItem.MotorShotTime = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].MotorShotTime");
					recordsItem.PassTime = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].PassTime");
					recordsItem.RightBtmX = context.IntegerValue("SearchObject.Data["+ i +"].Records["+ j +"].RightBtmX");
					recordsItem.RightBtmY = context.IntegerValue("SearchObject.Data["+ i +"].Records["+ j +"].RightBtmY");
					recordsItem.Score = context.FloatValue("SearchObject.Data["+ i +"].Records["+ j +"].Score");
					recordsItem.SourceID = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].SourceID");
					recordsItem.SourceImagePath = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].SourceImagePath");
					recordsItem.SourceImageUrl = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].SourceImageUrl");
					recordsItem.TargetImagePath = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].TargetImagePath");
					recordsItem.TargetImageUrl = context.StringValue("SearchObject.Data["+ i +"].Records["+ j +"].TargetImageUrl");

					dataItem_records.Add(recordsItem);
				}
				dataItem.Records = dataItem_records;

				searchObjectResponse_data.Add(dataItem);
			}
			searchObjectResponse.Data = searchObjectResponse_data;
        
			return searchObjectResponse;
        }
    }
}
