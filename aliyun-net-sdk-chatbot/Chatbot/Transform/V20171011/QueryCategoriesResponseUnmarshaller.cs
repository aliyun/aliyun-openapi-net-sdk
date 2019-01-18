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
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class QueryCategoriesResponseUnmarshaller
    {
        public static QueryCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCategoriesResponse queryCategoriesResponse = new QueryCategoriesResponse();

			queryCategoriesResponse.HttpResponse = context.HttpResponse;
			queryCategoriesResponse.RequestId = context.StringValue("QueryCategories.RequestId");

			List<QueryCategoriesResponse.QueryCategories_Category> queryCategoriesResponse_categories = new List<QueryCategoriesResponse.QueryCategories_Category>();
			for (int i = 0; i < context.Length("QueryCategories.Categories.Length"); i++) {
				QueryCategoriesResponse.QueryCategories_Category category = new QueryCategoriesResponse.QueryCategories_Category();
				category.CategoryId = context.LongValue("QueryCategories.Categories["+ i +"].CategoryId");
				category.ParentCategoryId = context.LongValue("QueryCategories.Categories["+ i +"].ParentCategoryId");
				category.Name = context.StringValue("QueryCategories.Categories["+ i +"].Name");

				List<string> category_childrens = new List<string>();
				for (int j = 0; j < context.Length("QueryCategories.Categories["+ i +"].Childrens.Length"); j++) {
					category_childrens.Add(context.StringValue("QueryCategories.Categories["+ i +"].Childrens["+ j +"]"));
				}
				category.Childrens = category_childrens;

				queryCategoriesResponse_categories.Add(category);
			}
			queryCategoriesResponse.Categories = queryCategoriesResponse_categories;
        
			return queryCategoriesResponse;
        }
    }
}