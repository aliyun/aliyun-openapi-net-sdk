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
using Aliyun.Acs.Workorder.Model.V20210510;

namespace Aliyun.Acs.Workorder.Transform.V20210510
{
    public class ListProductsResponseUnmarshaller
    {
        public static ListProductsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProductsResponse listProductsResponse = new ListProductsResponse();

			listProductsResponse.HttpResponse = _ctx.HttpResponse;
			listProductsResponse.Code = _ctx.IntegerValue("ListProducts.Code");
			listProductsResponse.RequestId = _ctx.StringValue("ListProducts.RequestId");
			listProductsResponse.Message = _ctx.StringValue("ListProducts.Message");
			listProductsResponse.Success = _ctx.BooleanValue("ListProducts.Success");

			List<ListProductsResponse.ListProducts_DataItem> listProductsResponse_data = new List<ListProductsResponse.ListProducts_DataItem>();
			for (int i = 0; i < _ctx.Length("ListProducts.Data.Length"); i++) {
				ListProductsResponse.ListProducts_DataItem dataItem = new ListProductsResponse.ListProducts_DataItem();
				dataItem.TopCategoryName = _ctx.StringValue("ListProducts.Data["+ i +"].TopCategoryName");
				dataItem.TopCategoryId = _ctx.LongValue("ListProducts.Data["+ i +"].TopCategoryId");
				dataItem.OrderNumber = _ctx.IntegerValue("ListProducts.Data["+ i +"].OrderNumber");

				List<ListProductsResponse.ListProducts_DataItem.ListProducts_RootsItem> dataItem_roots = new List<ListProductsResponse.ListProducts_DataItem.ListProducts_RootsItem>();
				for (int j = 0; j < _ctx.Length("ListProducts.Data["+ i +"].Roots.Length"); j++) {
					ListProductsResponse.ListProducts_DataItem.ListProducts_RootsItem rootsItem = new ListProductsResponse.ListProducts_DataItem.ListProducts_RootsItem();
					rootsItem.CategoryId = _ctx.LongValue("ListProducts.Data["+ i +"].Roots["+ j +"].CategoryId");
					rootsItem.CategoryName = _ctx.StringValue("ListProducts.Data["+ i +"].Roots["+ j +"].CategoryName");

					dataItem_roots.Add(rootsItem);
				}
				dataItem.Roots = dataItem_roots;

				listProductsResponse_data.Add(dataItem);
			}
			listProductsResponse.Data = listProductsResponse_data;
        
			return listProductsResponse;
        }
    }
}
