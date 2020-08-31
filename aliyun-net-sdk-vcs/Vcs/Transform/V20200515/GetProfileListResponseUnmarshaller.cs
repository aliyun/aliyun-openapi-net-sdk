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
    public class GetProfileListResponseUnmarshaller
    {
        public static GetProfileListResponse Unmarshall(UnmarshallerContext context)
        {
			GetProfileListResponse getProfileListResponse = new GetProfileListResponse();

			getProfileListResponse.HttpResponse = context.HttpResponse;
			getProfileListResponse.Code = context.StringValue("GetProfileList.Code");
			getProfileListResponse.Message = context.StringValue("GetProfileList.Message");
			getProfileListResponse.RequestId = context.StringValue("GetProfileList.RequestId");

			GetProfileListResponse.GetProfileList_Data data = new GetProfileListResponse.GetProfileList_Data();
			data.PageNumber = context.LongValue("GetProfileList.Data.PageNumber");
			data.PageSize = context.LongValue("GetProfileList.Data.PageSize");
			data.Success = context.BooleanValue("GetProfileList.Data.Success");
			data.Total = context.LongValue("GetProfileList.Data.Total");

			List<GetProfileListResponse.GetProfileList_Data.GetProfileList_RecordsItem> data_records = new List<GetProfileListResponse.GetProfileList_Data.GetProfileList_RecordsItem>();
			for (int i = 0; i < context.Length("GetProfileList.Data.Records.Length"); i++) {
				GetProfileListResponse.GetProfileList_Data.GetProfileList_RecordsItem recordsItem = new GetProfileListResponse.GetProfileList_Data.GetProfileList_RecordsItem();
				recordsItem.SceneType = context.StringValue("GetProfileList.Data.Records["+ i +"].SceneType");
				recordsItem.BizId = context.StringValue("GetProfileList.Data.Records["+ i +"].BizId");
				recordsItem.FaceUrl = context.StringValue("GetProfileList.Data.Records["+ i +"].FaceUrl");
				recordsItem.Gender = context.StringValue("GetProfileList.Data.Records["+ i +"].Gender");
				recordsItem.IdNumber = context.StringValue("GetProfileList.Data.Records["+ i +"].IdNumber");
				recordsItem.IsvSubId = context.StringValue("GetProfileList.Data.Records["+ i +"].IsvSubId");
				recordsItem.SearchMatchingRate = context.StringValue("GetProfileList.Data.Records["+ i +"].SearchMatchingRate");
				recordsItem.PersonId = context.StringValue("GetProfileList.Data.Records["+ i +"].PersonId");
				recordsItem.CatalogId = context.IntegerValue("GetProfileList.Data.Records["+ i +"].CatalogId");
				recordsItem.ProfileId = context.IntegerValue("GetProfileList.Data.Records["+ i +"].ProfileId");
				recordsItem.Name = context.StringValue("GetProfileList.Data.Records["+ i +"].Name");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getProfileListResponse.Data = data;
        
			return getProfileListResponse;
        }
    }
}
