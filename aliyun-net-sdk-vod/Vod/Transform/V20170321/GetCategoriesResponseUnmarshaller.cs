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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetCategoriesResponseUnmarshaller
    {
        public static GetCategoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCategoriesResponse getCategoriesResponse = new GetCategoriesResponse();

			getCategoriesResponse.HttpResponse = _ctx.HttpResponse;
			getCategoriesResponse.RequestId = _ctx.StringValue("GetCategories.RequestId");
			getCategoriesResponse.SubTotal = _ctx.LongValue("GetCategories.SubTotal");

			GetCategoriesResponse.GetCategories_Category1 category1 = new GetCategoriesResponse.GetCategories_Category1();
			category1.CateId = _ctx.LongValue("GetCategories.Category.CateId");
			category1.CateName = _ctx.StringValue("GetCategories.Category.CateName");
			category1.Level = _ctx.LongValue("GetCategories.Category.Level");
			category1.ParentId = _ctx.LongValue("GetCategories.Category.ParentId");
			category1.Type = _ctx.StringValue("GetCategories.Category.Type");
			getCategoriesResponse.Category1 = category1;

			List<GetCategoriesResponse.GetCategories_Category> getCategoriesResponse_subCategories = new List<GetCategoriesResponse.GetCategories_Category>();
			for (int i = 0; i < _ctx.Length("GetCategories.SubCategories.Length"); i++) {
				GetCategoriesResponse.GetCategories_Category category = new GetCategoriesResponse.GetCategories_Category();
				category.CateId = _ctx.LongValue("GetCategories.SubCategories["+ i +"].CateId");
				category.CateName = _ctx.StringValue("GetCategories.SubCategories["+ i +"].CateName");
				category.Level = _ctx.LongValue("GetCategories.SubCategories["+ i +"].Level");
				category.ParentId = _ctx.LongValue("GetCategories.SubCategories["+ i +"].ParentId");
				category.SubTotal = _ctx.LongValue("GetCategories.SubCategories["+ i +"].SubTotal");
				category.Type = _ctx.StringValue("GetCategories.SubCategories["+ i +"].Type");

				getCategoriesResponse_subCategories.Add(category);
			}
			getCategoriesResponse.SubCategories = getCategoriesResponse_subCategories;
        
			return getCategoriesResponse;
        }
    }
}
