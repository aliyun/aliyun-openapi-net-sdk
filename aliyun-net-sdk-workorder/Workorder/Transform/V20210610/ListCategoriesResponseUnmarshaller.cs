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
using Aliyun.Acs.Workorder.Model.V20210610;

namespace Aliyun.Acs.Workorder.Transform.V20210610
{
    public class ListCategoriesResponseUnmarshaller
    {
        public static ListCategoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCategoriesResponse listCategoriesResponse = new ListCategoriesResponse();

			listCategoriesResponse.HttpResponse = _ctx.HttpResponse;
			listCategoriesResponse.Code = _ctx.IntegerValue("ListCategories.Code");
			listCategoriesResponse.RequestId = _ctx.StringValue("ListCategories.RequestId");
			listCategoriesResponse.Message = _ctx.StringValue("ListCategories.Message");
			listCategoriesResponse.Success = _ctx.BooleanValue("ListCategories.Success");

			List<ListCategoriesResponse.ListCategories_DataItem> listCategoriesResponse_data = new List<ListCategoriesResponse.ListCategories_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCategories.Data.Length"); i++) {
				ListCategoriesResponse.ListCategories_DataItem dataItem = new ListCategoriesResponse.ListCategories_DataItem();
				dataItem.CategoryId = _ctx.LongValue("ListCategories.Data["+ i +"].CategoryId");
				dataItem.CategoryName = _ctx.StringValue("ListCategories.Data["+ i +"].CategoryName");

				listCategoriesResponse_data.Add(dataItem);
			}
			listCategoriesResponse.Data = listCategoriesResponse_data;
        
			return listCategoriesResponse;
        }
    }
}
