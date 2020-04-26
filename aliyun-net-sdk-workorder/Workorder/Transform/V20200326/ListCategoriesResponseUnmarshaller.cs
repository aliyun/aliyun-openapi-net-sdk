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
using Aliyun.Acs.Workorder.Model.V20200326;

namespace Aliyun.Acs.Workorder.Transform.V20200326
{
    public class ListCategoriesResponseUnmarshaller
    {
        public static ListCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListCategoriesResponse listCategoriesResponse = new ListCategoriesResponse();

			listCategoriesResponse.HttpResponse = context.HttpResponse;
			listCategoriesResponse.Code = context.IntegerValue("ListCategories.Code");
			listCategoriesResponse.Message = context.StringValue("ListCategories.Message");
			listCategoriesResponse.RequestId = context.StringValue("ListCategories.RequestId");
			listCategoriesResponse.Success = context.BooleanValue("ListCategories.Success");

			ListCategoriesResponse.ListCategories_Data data = new ListCategoriesResponse.ListCategories_Data();

			List<ListCategoriesResponse.ListCategories_Data.ListCategories_ListItem> data_list = new List<ListCategoriesResponse.ListCategories_Data.ListCategories_ListItem>();
			for (int i = 0; i < context.Length("ListCategories.Data.List.Length"); i++) {
				ListCategoriesResponse.ListCategories_Data.ListCategories_ListItem listItem = new ListCategoriesResponse.ListCategories_Data.ListCategories_ListItem();
				listItem.Id = context.IntegerValue("ListCategories.Data.List["+ i +"].Id");
				listItem.Name = context.StringValue("ListCategories.Data.List["+ i +"].Name");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listCategoriesResponse.Data = data;
        
			return listCategoriesResponse;
        }
    }
}
