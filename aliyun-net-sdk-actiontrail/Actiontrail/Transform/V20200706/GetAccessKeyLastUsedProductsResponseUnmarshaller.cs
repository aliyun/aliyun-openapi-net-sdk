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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class GetAccessKeyLastUsedProductsResponseUnmarshaller
    {
        public static GetAccessKeyLastUsedProductsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccessKeyLastUsedProductsResponse getAccessKeyLastUsedProductsResponse = new GetAccessKeyLastUsedProductsResponse();

			getAccessKeyLastUsedProductsResponse.HttpResponse = _ctx.HttpResponse;
			getAccessKeyLastUsedProductsResponse.RequestId = _ctx.StringValue("GetAccessKeyLastUsedProducts.RequestId");

			List<GetAccessKeyLastUsedProductsResponse.GetAccessKeyLastUsedProducts_ProductsItem> getAccessKeyLastUsedProductsResponse_products = new List<GetAccessKeyLastUsedProductsResponse.GetAccessKeyLastUsedProducts_ProductsItem>();
			for (int i = 0; i < _ctx.Length("GetAccessKeyLastUsedProducts.Products.Length"); i++) {
				GetAccessKeyLastUsedProductsResponse.GetAccessKeyLastUsedProducts_ProductsItem productsItem = new GetAccessKeyLastUsedProductsResponse.GetAccessKeyLastUsedProducts_ProductsItem();
				productsItem.UsedTimestamp = _ctx.LongValue("GetAccessKeyLastUsedProducts.Products["+ i +"].UsedTimestamp");
				productsItem.Detail = _ctx.StringValue("GetAccessKeyLastUsedProducts.Products["+ i +"].Detail");
				productsItem.Source = _ctx.StringValue("GetAccessKeyLastUsedProducts.Products["+ i +"].Source");
				productsItem.ServiceName = _ctx.StringValue("GetAccessKeyLastUsedProducts.Products["+ i +"].ServiceName");
				productsItem.ServiceNameCn = _ctx.StringValue("GetAccessKeyLastUsedProducts.Products["+ i +"].ServiceNameCn");
				productsItem.ServiceNameEn = _ctx.StringValue("GetAccessKeyLastUsedProducts.Products["+ i +"].ServiceNameEn");

				getAccessKeyLastUsedProductsResponse_products.Add(productsItem);
			}
			getAccessKeyLastUsedProductsResponse.Products = getAccessKeyLastUsedProductsResponse_products;
        
			return getAccessKeyLastUsedProductsResponse;
        }
    }
}
