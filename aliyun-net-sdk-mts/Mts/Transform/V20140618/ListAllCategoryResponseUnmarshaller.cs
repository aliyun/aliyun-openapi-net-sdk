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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListAllCategoryResponseUnmarshaller
    {
        public static ListAllCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			ListAllCategoryResponse listAllCategoryResponse = new ListAllCategoryResponse();

			listAllCategoryResponse.HttpResponse = context.HttpResponse;
			listAllCategoryResponse.RequestId = context.StringValue("ListAllCategory.RequestId");

			List<ListAllCategoryResponse.ListAllCategory_Category> listAllCategoryResponse_categoryList = new List<ListAllCategoryResponse.ListAllCategory_Category>();
			for (int i = 0; i < context.Length("ListAllCategory.CategoryList.Length"); i++) {
				ListAllCategoryResponse.ListAllCategory_Category category = new ListAllCategoryResponse.ListAllCategory_Category();
				category.CateId = context.StringValue("ListAllCategory.CategoryList["+ i +"].CateId");
				category.CateName = context.StringValue("ListAllCategory.CategoryList["+ i +"].CateName");
				category.ParentId = context.StringValue("ListAllCategory.CategoryList["+ i +"].ParentId");
				category.Level = context.StringValue("ListAllCategory.CategoryList["+ i +"].Level");

				listAllCategoryResponse_categoryList.Add(category);
			}
			listAllCategoryResponse.CategoryList = listAllCategoryResponse_categoryList;
        
			return listAllCategoryResponse;
        }
    }
}