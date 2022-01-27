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
				dataItem.DirectoryName = _ctx.StringValue("ListProducts.Data["+ i +"].DirectoryName");
				dataItem.DirectoryId = _ctx.LongValue("ListProducts.Data["+ i +"].DirectoryId");

				List<ListProductsResponse.ListProducts_DataItem.ListProducts_ProductListItem> dataItem_productList = new List<ListProductsResponse.ListProducts_DataItem.ListProducts_ProductListItem>();
				for (int j = 0; j < _ctx.Length("ListProducts.Data["+ i +"].ProductList.Length"); j++) {
					ListProductsResponse.ListProducts_DataItem.ListProducts_ProductListItem productListItem = new ListProductsResponse.ListProducts_DataItem.ListProducts_ProductListItem();
					productListItem.ProductId = _ctx.LongValue("ListProducts.Data["+ i +"].ProductList["+ j +"].ProductId");
					productListItem.ProductName = _ctx.StringValue("ListProducts.Data["+ i +"].ProductList["+ j +"].ProductName");

					dataItem_productList.Add(productListItem);
				}
				dataItem.ProductList = dataItem_productList;

				listProductsResponse_data.Add(dataItem);
			}
			listProductsResponse.Data = listProductsResponse_data;
        
			return listProductsResponse;
        }
    }
}
