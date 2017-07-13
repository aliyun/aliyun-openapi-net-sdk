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
    public class AddCategoryResponseUnmarshaller
    {
        public static AddCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			AddCategoryResponse addCategoryResponse = new AddCategoryResponse();

			addCategoryResponse.HttpResponse = context.HttpResponse;
			addCategoryResponse.RequestId = context.StringValue("AddCategory.RequestId");

			AddCategoryResponse.AddCategory_Category category = new AddCategoryResponse.AddCategory_Category();
			category.CateId = context.LongValue("AddCategory.Category.CateId");
			category.CateName = context.StringValue("AddCategory.Category.CateName");
			category.ParentId = context.LongValue("AddCategory.Category.ParentId");
			category.Level = context.LongValue("AddCategory.Category.Level");
			addCategoryResponse.Category = category;
        
			return addCategoryResponse;
        }
    }
}