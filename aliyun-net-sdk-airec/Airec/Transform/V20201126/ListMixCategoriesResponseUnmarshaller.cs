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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListMixCategoriesResponseUnmarshaller
    {
        public static ListMixCategoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMixCategoriesResponse listMixCategoriesResponse = new ListMixCategoriesResponse();

			listMixCategoriesResponse.HttpResponse = _ctx.HttpResponse;
			listMixCategoriesResponse.Code = _ctx.StringValue("ListMixCategories.code");
			listMixCategoriesResponse.Message = _ctx.StringValue("ListMixCategories.message");
			listMixCategoriesResponse.RequestId = _ctx.StringValue("ListMixCategories.requestId");

			List<ListMixCategoriesResponse.ListMixCategories_ResultItem> listMixCategoriesResponse_result = new List<ListMixCategoriesResponse.ListMixCategories_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListMixCategories.Result.Length"); i++) {
				ListMixCategoriesResponse.ListMixCategories_ResultItem resultItem = new ListMixCategoriesResponse.ListMixCategories_ResultItem();

				List<string> resultItem_categories = new List<string>();
				for (int j = 0; j < _ctx.Length("ListMixCategories.Result["+ i +"].Categories.Length"); j++) {
					resultItem_categories.Add(_ctx.StringValue("ListMixCategories.Result["+ i +"].Categories["+ j +"]"));
				}
				resultItem.Categories = resultItem_categories;

				listMixCategoriesResponse_result.Add(resultItem);
			}
			listMixCategoriesResponse.Result = listMixCategoriesResponse_result;
        
			return listMixCategoriesResponse;
        }
    }
}
