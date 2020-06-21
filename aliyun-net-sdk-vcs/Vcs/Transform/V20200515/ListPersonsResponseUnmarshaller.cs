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
    public class ListPersonsResponseUnmarshaller
    {
        public static ListPersonsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersonsResponse listPersonsResponse = new ListPersonsResponse();

			listPersonsResponse.HttpResponse = context.HttpResponse;
			listPersonsResponse.Code = context.StringValue("ListPersons.Code");
			listPersonsResponse.Message = context.StringValue("ListPersons.Message");
			listPersonsResponse.RequestId = context.StringValue("ListPersons.RequestId");

			ListPersonsResponse.ListPersons_Data data = new ListPersonsResponse.ListPersons_Data();
			data.PageNo = context.StringValue("ListPersons.Data.PageNo");
			data.PageSize = context.StringValue("ListPersons.Data.PageSize");
			data.TotalCount = context.StringValue("ListPersons.Data.TotalCount");
			data.TotalPage = context.StringValue("ListPersons.Data.TotalPage");

			List<ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem> data_records = new List<ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem>();
			for (int i = 0; i < context.Length("ListPersons.Data.Records.Length"); i++) {
				ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem recordsItem = new ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem();
				recordsItem.FirstAppearTime = context.StringValue("ListPersons.Data.Records["+ i +"].FirstAppearTime");
				recordsItem.PersonId = context.StringValue("ListPersons.Data.Records["+ i +"].PersonId");
				recordsItem.PicUrl = context.StringValue("ListPersons.Data.Records["+ i +"].PicUrl");

				List<ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem.ListPersons_TagListItem> recordsItem_tagList = new List<ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem.ListPersons_TagListItem>();
				for (int j = 0; j < context.Length("ListPersons.Data.Records["+ i +"].TagList.Length"); j++) {
					ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem.ListPersons_TagListItem tagListItem = new ListPersonsResponse.ListPersons_Data.ListPersons_RecordsItem.ListPersons_TagListItem();
					tagListItem.TagCode = context.StringValue("ListPersons.Data.Records["+ i +"].TagList["+ j +"].TagCode");
					tagListItem.TagName = context.StringValue("ListPersons.Data.Records["+ i +"].TagList["+ j +"].TagName");
					tagListItem.TagValue = context.StringValue("ListPersons.Data.Records["+ i +"].TagList["+ j +"].TagValue");
					tagListItem.TagValueId = context.StringValue("ListPersons.Data.Records["+ i +"].TagList["+ j +"].TagValueId");

					recordsItem_tagList.Add(tagListItem);
				}
				recordsItem.TagList = recordsItem_tagList;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listPersonsResponse.Data = data;
        
			return listPersonsResponse;
        }
    }
}
