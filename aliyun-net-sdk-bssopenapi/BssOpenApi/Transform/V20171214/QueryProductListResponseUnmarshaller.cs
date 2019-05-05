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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryProductListResponseUnmarshaller
    {
        public static QueryProductListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryProductListResponse queryProductListResponse = new QueryProductListResponse();

			queryProductListResponse.HttpResponse = context.HttpResponse;
			queryProductListResponse.RequestId = context.StringValue("QueryProductList.RequestId");
			queryProductListResponse.Success = context.BooleanValue("QueryProductList.Success");
			queryProductListResponse.Code = context.StringValue("QueryProductList.Code");
			queryProductListResponse.Message = context.StringValue("QueryProductList.Message");

			QueryProductListResponse.QueryProductList_Data data = new QueryProductListResponse.QueryProductList_Data();
			data.TotalCount = context.IntegerValue("QueryProductList.Data.TotalCount");
			data.PageNum = context.IntegerValue("QueryProductList.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryProductList.Data.PageSize");

			List<QueryProductListResponse.QueryProductList_Data.QueryProductList_Product> data_productList = new List<QueryProductListResponse.QueryProductList_Data.QueryProductList_Product>();
			for (int i = 0; i < context.Length("QueryProductList.Data.ProductList.Length"); i++) {
				QueryProductListResponse.QueryProductList_Data.QueryProductList_Product product = new QueryProductListResponse.QueryProductList_Data.QueryProductList_Product();
				product.ProductCode = context.StringValue("QueryProductList.Data.ProductList["+ i +"].ProductCode");
				product.ProductName = context.StringValue("QueryProductList.Data.ProductList["+ i +"].ProductName");
				product.ProductType = context.StringValue("QueryProductList.Data.ProductList["+ i +"].ProductType");
				product.SubscriptionType = context.StringValue("QueryProductList.Data.ProductList["+ i +"].SubscriptionType");

				data_productList.Add(product);
			}
			data.ProductList = data_productList;
			queryProductListResponse.Data = data;
        
			return queryProductListResponse;
        }
    }
}
