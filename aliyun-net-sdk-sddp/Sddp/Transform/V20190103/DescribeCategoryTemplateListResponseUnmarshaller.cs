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
    public class DescribeCategoryTemplateListResponseUnmarshaller
    {
        public static DescribeCategoryTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCategoryTemplateListResponse describeCategoryTemplateListResponse = new DescribeCategoryTemplateListResponse();

			describeCategoryTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			describeCategoryTemplateListResponse.CurrentPage = _ctx.IntegerValue("DescribeCategoryTemplateList.CurrentPage");
			describeCategoryTemplateListResponse.RequestId = _ctx.StringValue("DescribeCategoryTemplateList.RequestId");
			describeCategoryTemplateListResponse.PageSize = _ctx.IntegerValue("DescribeCategoryTemplateList.PageSize");
			describeCategoryTemplateListResponse.TotalCount = _ctx.IntegerValue("DescribeCategoryTemplateList.TotalCount");

			List<DescribeCategoryTemplateListResponse.DescribeCategoryTemplateList_Template> describeCategoryTemplateListResponse_items = new List<DescribeCategoryTemplateListResponse.DescribeCategoryTemplateList_Template>();
			for (int i = 0; i < _ctx.Length("DescribeCategoryTemplateList.Items.Length"); i++) {
				DescribeCategoryTemplateListResponse.DescribeCategoryTemplateList_Template template = new DescribeCategoryTemplateListResponse.DescribeCategoryTemplateList_Template();
				template.CurrentRiskLevel = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].CurrentRiskLevel");
				template.Status = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].Status");
				template.Type = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].Type");
				template.SupportEdit = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].SupportEdit");
				template.MaxCategoryLevel = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].MaxCategoryLevel");
				template.Name = _ctx.StringValue("DescribeCategoryTemplateList.Items["+ i +"].Name");
				template.MaxRiskLevel = _ctx.IntegerValue("DescribeCategoryTemplateList.Items["+ i +"].MaxRiskLevel");
				template.Id = _ctx.LongValue("DescribeCategoryTemplateList.Items["+ i +"].Id");
				template.Description = _ctx.StringValue("DescribeCategoryTemplateList.Items["+ i +"].Description");
				template.GmtCreate = _ctx.LongValue("DescribeCategoryTemplateList.Items["+ i +"].GmtCreate");
				template.GmtModified = _ctx.LongValue("DescribeCategoryTemplateList.Items["+ i +"].GmtModified");

				describeCategoryTemplateListResponse_items.Add(template);
			}
			describeCategoryTemplateListResponse.Items = describeCategoryTemplateListResponse_items;
        
			return describeCategoryTemplateListResponse;
        }
    }
}
