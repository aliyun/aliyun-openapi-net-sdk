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
    public class GetPersonListResponseUnmarshaller
    {
        public static GetPersonListResponse Unmarshall(UnmarshallerContext context)
        {
			GetPersonListResponse getPersonListResponse = new GetPersonListResponse();

			getPersonListResponse.HttpResponse = context.HttpResponse;
			getPersonListResponse.Code = context.StringValue("GetPersonList.Code");
			getPersonListResponse.Message = context.StringValue("GetPersonList.Message");
			getPersonListResponse.RequestId = context.StringValue("GetPersonList.RequestId");

			GetPersonListResponse.GetPersonList_Data data = new GetPersonListResponse.GetPersonList_Data();
			data.PageNumber = context.LongValue("GetPersonList.Data.PageNumber");
			data.PageSize = context.LongValue("GetPersonList.Data.PageSize");
			data.TotalCount = context.LongValue("GetPersonList.Data.TotalCount");

			List<GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem> data_records = new List<GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem>();
			for (int i = 0; i < context.Length("GetPersonList.Data.Records.Length"); i++) {
				GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem recordsItem = new GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem();
				recordsItem.FaceUrl = context.StringValue("GetPersonList.Data.Records["+ i +"].FaceUrl");
				recordsItem.FirstShotTime = context.LongValue("GetPersonList.Data.Records["+ i +"].FirstShotTime");
				recordsItem.PersonId = context.StringValue("GetPersonList.Data.Records["+ i +"].PersonId");
				recordsItem.SearchMatchingRate = context.StringValue("GetPersonList.Data.Records["+ i +"].SearchMatchingRate");
				recordsItem.LastShotTime = context.LongValue("GetPersonList.Data.Records["+ i +"].LastShotTime");

				List<GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem.GetPersonList_TagList> recordsItem_propertyTagList = new List<GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem.GetPersonList_TagList>();
				for (int j = 0; j < context.Length("GetPersonList.Data.Records["+ i +"].PropertyTagList.Length"); j++) {
					GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem.GetPersonList_TagList tagList = new GetPersonListResponse.GetPersonList_Data.GetPersonList_RecordsItem.GetPersonList_TagList();
					tagList.Code = context.StringValue("GetPersonList.Data.Records["+ i +"].PropertyTagList["+ j +"].Code");
					tagList.TagCodeName = context.StringValue("GetPersonList.Data.Records["+ i +"].PropertyTagList["+ j +"].TagCodeName");
					tagList.TagName = context.StringValue("GetPersonList.Data.Records["+ i +"].PropertyTagList["+ j +"].TagName");
					tagList._Value = context.StringValue("GetPersonList.Data.Records["+ i +"].PropertyTagList["+ j +"].Value");

					recordsItem_propertyTagList.Add(tagList);
				}
				recordsItem.PropertyTagList = recordsItem_propertyTagList;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getPersonListResponse.Data = data;
        
			return getPersonListResponse;
        }
    }
}
