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
    public class GetPersonDetailResponseUnmarshaller
    {
        public static GetPersonDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetPersonDetailResponse getPersonDetailResponse = new GetPersonDetailResponse();

			getPersonDetailResponse.HttpResponse = context.HttpResponse;
			getPersonDetailResponse.Code = context.StringValue("GetPersonDetail.Code");
			getPersonDetailResponse.Message = context.StringValue("GetPersonDetail.Message");
			getPersonDetailResponse.RequestId = context.StringValue("GetPersonDetail.RequestId");

			GetPersonDetailResponse.GetPersonDetail_Data data = new GetPersonDetailResponse.GetPersonDetail_Data();
			data.PicUrl = context.StringValue("GetPersonDetail.Data.PicUrl");
			data.PersonId = context.StringValue("GetPersonDetail.Data.PersonId");

			List<GetPersonDetailResponse.GetPersonDetail_Data.GetPersonDetail_TagListItem> data_tagList = new List<GetPersonDetailResponse.GetPersonDetail_Data.GetPersonDetail_TagListItem>();
			for (int i = 0; i < context.Length("GetPersonDetail.Data.TagList.Length"); i++) {
				GetPersonDetailResponse.GetPersonDetail_Data.GetPersonDetail_TagListItem tagListItem = new GetPersonDetailResponse.GetPersonDetail_Data.GetPersonDetail_TagListItem();
				tagListItem.TagCode = context.StringValue("GetPersonDetail.Data.TagList["+ i +"].TagCode");
				tagListItem.TagName = context.StringValue("GetPersonDetail.Data.TagList["+ i +"].TagName");
				tagListItem.TagValue = context.StringValue("GetPersonDetail.Data.TagList["+ i +"].TagValue");
				tagListItem.TagValueId = context.StringValue("GetPersonDetail.Data.TagList["+ i +"].TagValueId");

				data_tagList.Add(tagListItem);
			}
			data.TagList = data_tagList;
			getPersonDetailResponse.Data = data;
        
			return getPersonDetailResponse;
        }
    }
}
