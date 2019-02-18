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
using Aliyun.Acs.industry_brain.Model.V20180712;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.industry_brain.Transform.V20180712
{
    public class GetIndustryInfoLineageListResponseUnmarshaller
    {
        public static GetIndustryInfoLineageListResponse Unmarshall(UnmarshallerContext context)
        {
			GetIndustryInfoLineageListResponse getIndustryInfoLineageListResponse = new GetIndustryInfoLineageListResponse();

			getIndustryInfoLineageListResponse.HttpResponse = context.HttpResponse;
			getIndustryInfoLineageListResponse.RequestId = context.StringValue("GetIndustryInfoLineageList.RequestId");

			List<GetIndustryInfoLineageListResponse.GetIndustryInfoLineageList_IndustryInfoListItem> getIndustryInfoLineageListResponse_industryInfoList = new List<GetIndustryInfoLineageListResponse.GetIndustryInfoLineageList_IndustryInfoListItem>();
			for (int i = 0; i < context.Length("GetIndustryInfoLineageList.IndustryInfoList.Length"); i++) {
				GetIndustryInfoLineageListResponse.GetIndustryInfoLineageList_IndustryInfoListItem industryInfoListItem = new GetIndustryInfoLineageListResponse.GetIndustryInfoLineageList_IndustryInfoListItem();
				industryInfoListItem.Id = context.StringValue("GetIndustryInfoLineageList.IndustryInfoList["+ i +"].Id");
				industryInfoListItem.Code = context.StringValue("GetIndustryInfoLineageList.IndustryInfoList["+ i +"].Code");
				industryInfoListItem.Name = context.StringValue("GetIndustryInfoLineageList.IndustryInfoList["+ i +"].Name");
				industryInfoListItem.Level = context.StringValue("GetIndustryInfoLineageList.IndustryInfoList["+ i +"].Level");

				getIndustryInfoLineageListResponse_industryInfoList.Add(industryInfoListItem);
			}
			getIndustryInfoLineageListResponse.IndustryInfoList = getIndustryInfoLineageListResponse_industryInfoList;
        
			return getIndustryInfoLineageListResponse;
        }
    }
}