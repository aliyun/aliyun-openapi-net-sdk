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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class ListProductsResponseUnmarshaller
    {
        public static ListProductsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProductsResponse listProductsResponse = new ListProductsResponse();

			listProductsResponse.HttpResponse = _ctx.HttpResponse;
			listProductsResponse.TotalCount = _ctx.IntegerValue("ListProducts.TotalCount");
			listProductsResponse.RequestId = _ctx.StringValue("ListProducts.RequestId");
			listProductsResponse.NextToken = _ctx.StringValue("ListProducts.NextToken");
			listProductsResponse.MaxResults = _ctx.IntegerValue("ListProducts.MaxResults");

			List<ListProductsResponse.ListProducts_ProductInfos> listProductsResponse_productInfo = new List<ListProductsResponse.ListProducts_ProductInfos>();
			for (int i = 0; i < _ctx.Length("ListProducts.ProductInfo.Length"); i++) {
				ListProductsResponse.ListProducts_ProductInfos productInfos = new ListProductsResponse.ListProducts_ProductInfos();
				productInfos.SecondCategoryNameEn = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].SecondCategoryNameEn");
				productInfos._Dynamic = _ctx.BooleanValue("ListProducts.ProductInfo["+ i +"].Dynamic");
				productInfos.CommonQuotaSupport = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].CommonQuotaSupport");
				productInfos.ProductName = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].ProductName");
				productInfos.ProductCode = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].ProductCode");
				productInfos.SecondCategoryName = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].SecondCategoryName");
				productInfos.FlowControlSupport = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].FlowControlSupport");
				productInfos.SecondCategoryId = _ctx.LongValue("ListProducts.ProductInfo["+ i +"].SecondCategoryId");
				productInfos.ProductNameEn = _ctx.StringValue("ListProducts.ProductInfo["+ i +"].ProductNameEn");

				listProductsResponse_productInfo.Add(productInfos);
			}
			listProductsResponse.ProductInfo = listProductsResponse_productInfo;
        
			return listProductsResponse;
        }
    }
}
