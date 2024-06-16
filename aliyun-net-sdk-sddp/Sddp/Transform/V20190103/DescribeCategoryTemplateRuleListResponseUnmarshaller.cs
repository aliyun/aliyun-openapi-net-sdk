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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeCategoryTemplateRuleListResponseUnmarshaller
    {
        public static DescribeCategoryTemplateRuleListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCategoryTemplateRuleListResponse describeCategoryTemplateRuleListResponse = new DescribeCategoryTemplateRuleListResponse();

			describeCategoryTemplateRuleListResponse.HttpResponse = _ctx.HttpResponse;
			describeCategoryTemplateRuleListResponse.CurrentPage = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.CurrentPage");
			describeCategoryTemplateRuleListResponse.RequestId = _ctx.StringValue("DescribeCategoryTemplateRuleList.RequestId");
			describeCategoryTemplateRuleListResponse.PageSize = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.PageSize");
			describeCategoryTemplateRuleListResponse.TotalCount = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.TotalCount");

			List<DescribeCategoryTemplateRuleListResponse.DescribeCategoryTemplateRuleList_DataLimit> describeCategoryTemplateRuleListResponse_items = new List<DescribeCategoryTemplateRuleListResponse.DescribeCategoryTemplateRuleList_DataLimit>();
			for (int i = 0; i < _ctx.Length("DescribeCategoryTemplateRuleList.Items.Length"); i++) {
				DescribeCategoryTemplateRuleListResponse.DescribeCategoryTemplateRuleList_DataLimit dataLimit = new DescribeCategoryTemplateRuleListResponse.DescribeCategoryTemplateRuleList_DataLimit();
				dataLimit.Status = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.Items["+ i +"].Status");
				dataLimit.IdentificationScope = _ctx.StringValue("DescribeCategoryTemplateRuleList.Items["+ i +"].IdentificationScope");
				dataLimit.RiskLevelId = _ctx.LongValue("DescribeCategoryTemplateRuleList.Items["+ i +"].RiskLevelId");
				dataLimit.ParentCategoryId = _ctx.LongValue("DescribeCategoryTemplateRuleList.Items["+ i +"].ParentCategoryId");
				dataLimit.Description = _ctx.StringValue("DescribeCategoryTemplateRuleList.Items["+ i +"].Description");
				dataLimit.CustomType = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.Items["+ i +"].CustomType");
				dataLimit.IdentificationRuleIds = _ctx.StringValue("DescribeCategoryTemplateRuleList.Items["+ i +"].IdentificationRuleIds");
				dataLimit.Name = _ctx.StringValue("DescribeCategoryTemplateRuleList.Items["+ i +"].Name");
				dataLimit.OrderNum = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.Items["+ i +"].OrderNum");
				dataLimit.TemplateId = _ctx.LongValue("DescribeCategoryTemplateRuleList.Items["+ i +"].TemplateId");
				dataLimit.Id = _ctx.LongValue("DescribeCategoryTemplateRuleList.Items["+ i +"].Id");
				dataLimit.CategoryLevel = _ctx.IntegerValue("DescribeCategoryTemplateRuleList.Items["+ i +"].CategoryLevel");
				dataLimit.ParentModelId = _ctx.LongValue("DescribeCategoryTemplateRuleList.Items["+ i +"].ParentModelId");

				describeCategoryTemplateRuleListResponse_items.Add(dataLimit);
			}
			describeCategoryTemplateRuleListResponse.Items = describeCategoryTemplateRuleListResponse_items;
        
			return describeCategoryTemplateRuleListResponse;
        }
    }
}
