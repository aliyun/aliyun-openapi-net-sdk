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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetCategoriesResponseUnmarshaller
    {
        public static GetCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			GetCategoriesResponse getCategoriesResponse = new GetCategoriesResponse();

			getCategoriesResponse.HttpResponse = context.HttpResponse;
			getCategoriesResponse.RequestId = context.StringValue("GetCategories.RequestId");
			getCategoriesResponse.SubTotal = context.LongValue("GetCategories.SubTotal");

			GetCategoriesResponse.GetCategories_Category category = new GetCategoriesResponse.GetCategories_Category();
			category.CateId = context.LongValue("GetCategories.Category.CateId");
			category.CateName = context.StringValue("GetCategories.Category.CateName");
			category.Level = context.LongValue("GetCategories.Category.Level");
			category.ParentId = context.LongValue("GetCategories.Category.ParentId");
			getCategoriesResponse.Category = category;

			List<GetCategoriesResponse.GetCategories_Category> getCategoriesResponse_subCategories = new List<GetCategoriesResponse.GetCategories_Category>();
			for (int i = 0; i < context.Length("GetCategories.SubCategories.Length"); i++) {
				GetCategoriesResponse.GetCategories_Category category1 = new GetCategoriesResponse.GetCategories_Category();
				category1.CateId = context.LongValue("GetCategories.SubCategories["+ i +"].CateId");
				category1.CateName = context.StringValue("GetCategories.SubCategories["+ i +"].CateName");
				category1.Level = context.LongValue("GetCategories.SubCategories["+ i +"].Level");
				category1.ParentId = context.LongValue("GetCategories.SubCategories["+ i +"].ParentId");

				getCategoriesResponse_subCategories.Add(category1);
			}
			getCategoriesResponse.SubCategories = getCategoriesResponse_subCategories;
        
			return getCategoriesResponse;
        }
    }
}
