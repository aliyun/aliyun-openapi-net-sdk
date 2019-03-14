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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowCategoryResponseUnmarshaller
    {
        public static ListFlowCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowCategoryResponse listFlowCategoryResponse = new ListFlowCategoryResponse();

			listFlowCategoryResponse.HttpResponse = context.HttpResponse;
			listFlowCategoryResponse.RequestId = context.StringValue("ListFlowCategory.RequestId");
			listFlowCategoryResponse.PageNumber = context.IntegerValue("ListFlowCategory.PageNumber");
			listFlowCategoryResponse.PageSize = context.IntegerValue("ListFlowCategory.PageSize");
			listFlowCategoryResponse.Total = context.IntegerValue("ListFlowCategory.Total");

			List<ListFlowCategoryResponse.ListFlowCategory_Category> listFlowCategoryResponse_categories = new List<ListFlowCategoryResponse.ListFlowCategory_Category>();
			for (int i = 0; i < context.Length("ListFlowCategory.Categories.Length"); i++) {
				ListFlowCategoryResponse.ListFlowCategory_Category category = new ListFlowCategoryResponse.ListFlowCategory_Category();
				category.Id = context.StringValue("ListFlowCategory.Categories["+ i +"].Id");
				category.GmtCreate = context.LongValue("ListFlowCategory.Categories["+ i +"].GmtCreate");
				category.GmtModified = context.LongValue("ListFlowCategory.Categories["+ i +"].GmtModified");
				category.Name = context.StringValue("ListFlowCategory.Categories["+ i +"].Name");
				category.ParentId = context.StringValue("ListFlowCategory.Categories["+ i +"].ParentId");
				category.Type = context.StringValue("ListFlowCategory.Categories["+ i +"].Type");
				category.CategoryType = context.StringValue("ListFlowCategory.Categories["+ i +"].CategoryType");
				category.ObjectType = context.StringValue("ListFlowCategory.Categories["+ i +"].ObjectType");
				category.ObjectId = context.StringValue("ListFlowCategory.Categories["+ i +"].ObjectId");
				category.ProjectId = context.StringValue("ListFlowCategory.Categories["+ i +"].ProjectId");

				listFlowCategoryResponse_categories.Add(category);
			}
			listFlowCategoryResponse.Categories = listFlowCategoryResponse_categories;
        
			return listFlowCategoryResponse;
        }
    }
}
