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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeProductsResponseUnmarshaller
    {
        public static DescribeProductsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProductsResponse describeProductsResponse = new DescribeProductsResponse();

			describeProductsResponse.HttpResponse = _ctx.HttpResponse;
			describeProductsResponse.RequestId = _ctx.StringValue("DescribeProducts.RequestId");
			describeProductsResponse.PageNumber = _ctx.IntegerValue("DescribeProducts.PageNumber");
			describeProductsResponse.PageSize = _ctx.IntegerValue("DescribeProducts.PageSize");
			describeProductsResponse.TotalCount = _ctx.IntegerValue("DescribeProducts.TotalCount");

			List<DescribeProductsResponse.DescribeProducts_ProductItem> describeProductsResponse_productItems = new List<DescribeProductsResponse.DescribeProducts_ProductItem>();
			for (int i = 0; i < _ctx.Length("DescribeProducts.ProductItems.Length"); i++) {
				DescribeProductsResponse.DescribeProducts_ProductItem productItem = new DescribeProductsResponse.DescribeProducts_ProductItem();
				productItem.PriceInfo = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].PriceInfo");
				productItem.DeliveryWay = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].DeliveryWay");
				productItem.ImageUrl = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].ImageUrl");
				productItem.WarrantyDate = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].WarrantyDate");
				productItem.Tags = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].Tags");
				productItem.Score = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].Score");
				productItem.SupplierId = _ctx.LongValue("DescribeProducts.ProductItems["+ i +"].SupplierId");
				productItem.OperationSystem = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].OperationSystem");
				productItem.ShortDescription = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].ShortDescription");
				productItem.DeliveryDate = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].DeliveryDate");
				productItem.TargetUrl = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].TargetUrl");
				productItem.Code = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].Code");
				productItem.CategoryId = _ctx.LongValue("DescribeProducts.ProductItems["+ i +"].CategoryId");
				productItem.Name = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].Name");
				productItem.SuggestedPrice = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].SuggestedPrice");
				productItem.SupplierName = _ctx.StringValue("DescribeProducts.ProductItems["+ i +"].SupplierName");

				describeProductsResponse_productItems.Add(productItem);
			}
			describeProductsResponse.ProductItems = describeProductsResponse_productItems;
        
			return describeProductsResponse;
        }
    }
}
