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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListCategoriesResponseUnmarshaller
    {
        public static ListCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListCategoriesResponse listCategoriesResponse = new ListCategoriesResponse();

			listCategoriesResponse.HttpResponse = context.HttpResponse;
			listCategoriesResponse.RequestId = context.StringValue("ListCategories.RequestId");

			List<ListCategoriesResponse.ListCategories_Category> listCategoriesResponse_categories = new List<ListCategoriesResponse.ListCategories_Category>();
			for (int i = 0; i < context.Length("ListCategories.Categories.Length"); i++) {
				ListCategoriesResponse.ListCategories_Category category = new ListCategoriesResponse.ListCategories_Category();
				category.InstanceId = context.StringValue("ListCategories.Categories["+ i +"].InstanceId");
				category.Name = context.StringValue("ListCategories.Categories["+ i +"].Name");
				category.CategoryId = context.StringValue("ListCategories.Categories["+ i +"].CategoryId");
				category.Level = context.LongValue("ListCategories.Categories["+ i +"].Level");
				category.PreviousSiblingId = context.StringValue("ListCategories.Categories["+ i +"].PreviousSiblingId");
				category.NextSiblingId = context.StringValue("ListCategories.Categories["+ i +"].NextSiblingId");
				category.ParentId = context.StringValue("ListCategories.Categories["+ i +"].ParentId");

				listCategoriesResponse_categories.Add(category);
			}
			listCategoriesResponse.Categories = listCategoriesResponse_categories;
        
			return listCategoriesResponse;
        }
    }
}
