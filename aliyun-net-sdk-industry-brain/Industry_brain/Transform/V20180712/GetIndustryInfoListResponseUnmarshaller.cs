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
    public class GetIndustryInfoListResponseUnmarshaller
    {
        public static GetIndustryInfoListResponse Unmarshall(UnmarshallerContext context)
        {
			GetIndustryInfoListResponse getIndustryInfoListResponse = new GetIndustryInfoListResponse();

			getIndustryInfoListResponse.HttpResponse = context.HttpResponse;
			getIndustryInfoListResponse.RequestId = context.StringValue("GetIndustryInfoList.RequestId");

			List<GetIndustryInfoListResponse.GetIndustryInfoList_IndustryInfoListItem> getIndustryInfoListResponse_industryInfoList = new List<GetIndustryInfoListResponse.GetIndustryInfoList_IndustryInfoListItem>();
			for (int i = 0; i < context.Length("GetIndustryInfoList.IndustryInfoList.Length"); i++) {
				GetIndustryInfoListResponse.GetIndustryInfoList_IndustryInfoListItem industryInfoListItem = new GetIndustryInfoListResponse.GetIndustryInfoList_IndustryInfoListItem();
				industryInfoListItem.Id = context.StringValue("GetIndustryInfoList.IndustryInfoList["+ i +"].Id");
				industryInfoListItem.Code = context.StringValue("GetIndustryInfoList.IndustryInfoList["+ i +"].Code");
				industryInfoListItem.Name = context.StringValue("GetIndustryInfoList.IndustryInfoList["+ i +"].Name");
				industryInfoListItem.Level = context.StringValue("GetIndustryInfoList.IndustryInfoList["+ i +"].Level");

				getIndustryInfoListResponse_industryInfoList.Add(industryInfoListItem);
			}
			getIndustryInfoListResponse.IndustryInfoList = getIndustryInfoListResponse_industryInfoList;
        
			return getIndustryInfoListResponse;
        }
    }
}