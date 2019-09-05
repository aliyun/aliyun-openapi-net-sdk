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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class QueryMarketCategoriesResponseUnmarshaller
    {
        public static QueryMarketCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMarketCategoriesResponse queryMarketCategoriesResponse = new QueryMarketCategoriesResponse();

			queryMarketCategoriesResponse.HttpResponse = context.HttpResponse;
			queryMarketCategoriesResponse.PageNumber = context.IntegerValue("QueryMarketCategories.PageNumber");
			queryMarketCategoriesResponse.PageSize = context.IntegerValue("QueryMarketCategories.PageSize");
			queryMarketCategoriesResponse.TotalCount = context.IntegerValue("QueryMarketCategories.TotalCount");
			queryMarketCategoriesResponse.RequestId = context.StringValue("QueryMarketCategories.RequestId");

			List<QueryMarketCategoriesResponse.QueryMarketCategories_Category> queryMarketCategoriesResponse_categories = new List<QueryMarketCategoriesResponse.QueryMarketCategories_Category>();
			for (int i = 0; i < context.Length("QueryMarketCategories.Categories.Length"); i++) {
				QueryMarketCategoriesResponse.QueryMarketCategories_Category category = new QueryMarketCategoriesResponse.QueryMarketCategories_Category();
				category.Id = context.LongValue("QueryMarketCategories.Categories["+ i +"].Id");
				category.CategoryCode = context.StringValue("QueryMarketCategories.Categories["+ i +"].CategoryCode");
				category.CategoryName = context.StringValue("QueryMarketCategories.Categories["+ i +"].CategoryName");

				List<QueryMarketCategoriesResponse.QueryMarketCategories_Category.QueryMarketCategories_ChildCategory> category_childCategories = new List<QueryMarketCategoriesResponse.QueryMarketCategories_Category.QueryMarketCategories_ChildCategory>();
				for (int j = 0; j < context.Length("QueryMarketCategories.Categories["+ i +"].ChildCategories.Length"); j++) {
					QueryMarketCategoriesResponse.QueryMarketCategories_Category.QueryMarketCategories_ChildCategory childCategory = new QueryMarketCategoriesResponse.QueryMarketCategories_Category.QueryMarketCategories_ChildCategory();
					childCategory.Id = context.LongValue("QueryMarketCategories.Categories["+ i +"].ChildCategories["+ j +"].Id");
					childCategory.CategoryCode = context.StringValue("QueryMarketCategories.Categories["+ i +"].ChildCategories["+ j +"].CategoryCode");
					childCategory.CategoryName = context.StringValue("QueryMarketCategories.Categories["+ i +"].ChildCategories["+ j +"].CategoryName");

					category_childCategories.Add(childCategory);
				}
				category.ChildCategories = category_childCategories;

				queryMarketCategoriesResponse_categories.Add(category);
			}
			queryMarketCategoriesResponse.Categories = queryMarketCategoriesResponse_categories;
        
			return queryMarketCategoriesResponse;
        }
    }
}
