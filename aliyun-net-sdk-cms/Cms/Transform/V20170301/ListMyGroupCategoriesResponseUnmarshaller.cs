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
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class ListMyGroupCategoriesResponseUnmarshaller
    {
        public static ListMyGroupCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListMyGroupCategoriesResponse listMyGroupCategoriesResponse = new ListMyGroupCategoriesResponse();

			listMyGroupCategoriesResponse.HttpResponse = context.HttpResponse;
			listMyGroupCategoriesResponse.RequestId = context.StringValue("ListMyGroupCategories.RequestId");
			listMyGroupCategoriesResponse.Success = context.BooleanValue("ListMyGroupCategories.Success");
			listMyGroupCategoriesResponse.ErrorCode = context.IntegerValue("ListMyGroupCategories.ErrorCode");
			listMyGroupCategoriesResponse.ErrorMessage = context.StringValue("ListMyGroupCategories.ErrorMessage");

			ListMyGroupCategoriesResponse.ListMyGroupCategories_Category category = new ListMyGroupCategoriesResponse.ListMyGroupCategories_Category();
			category.GroupId = context.LongValue("ListMyGroupCategories.Category.GroupId");

			List<ListMyGroupCategoriesResponse.ListMyGroupCategories_Category.ListMyGroupCategories_CategoryItem> category_categoryItems = new List<ListMyGroupCategoriesResponse.ListMyGroupCategories_Category.ListMyGroupCategories_CategoryItem>();
			for (int i = 0; i < context.Length("ListMyGroupCategories.Category.CategoryItems.Length"); i++) {
				ListMyGroupCategoriesResponse.ListMyGroupCategories_Category.ListMyGroupCategories_CategoryItem categoryItem = new ListMyGroupCategoriesResponse.ListMyGroupCategories_Category.ListMyGroupCategories_CategoryItem();
				categoryItem.Category = context.StringValue("ListMyGroupCategories.Category.CategoryItems["+ i +"].Category");
				categoryItem.Count = context.IntegerValue("ListMyGroupCategories.Category.CategoryItems["+ i +"].Count");

				category_categoryItems.Add(categoryItem);
			}
			category.CategoryItems = category_categoryItems;
			listMyGroupCategoriesResponse.Category = category;
        
			return listMyGroupCategoriesResponse;
        }
    }
}