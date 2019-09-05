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
        public static DescribeProductsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProductsResponse describeProductsResponse = new DescribeProductsResponse();

			describeProductsResponse.HttpResponse = context.HttpResponse;
			describeProductsResponse.RequestId = context.StringValue("DescribeProducts.RequestId");
			describeProductsResponse.PageNumber = context.IntegerValue("DescribeProducts.PageNumber");
			describeProductsResponse.PageSize = context.IntegerValue("DescribeProducts.PageSize");
			describeProductsResponse.TotalCount = context.IntegerValue("DescribeProducts.TotalCount");

			List<DescribeProductsResponse.DescribeProducts_ProductItem> describeProductsResponse_productItems = new List<DescribeProductsResponse.DescribeProducts_ProductItem>();
			for (int i = 0; i < context.Length("DescribeProducts.ProductItems.Length"); i++) {
				DescribeProductsResponse.DescribeProducts_ProductItem productItem = new DescribeProductsResponse.DescribeProducts_ProductItem();
				productItem.Code = context.StringValue("DescribeProducts.ProductItems["+ i +"].Code");
				productItem.Name = context.StringValue("DescribeProducts.ProductItems["+ i +"].Name");
				productItem.CategoryId = context.LongValue("DescribeProducts.ProductItems["+ i +"].CategoryId");
				productItem.SupplierId = context.LongValue("DescribeProducts.ProductItems["+ i +"].SupplierId");
				productItem.SupplierName = context.StringValue("DescribeProducts.ProductItems["+ i +"].SupplierName");
				productItem.ShortDescription = context.StringValue("DescribeProducts.ProductItems["+ i +"].ShortDescription");
				productItem.Tags = context.StringValue("DescribeProducts.ProductItems["+ i +"].Tags");
				productItem.SuggestedPrice = context.StringValue("DescribeProducts.ProductItems["+ i +"].SuggestedPrice");
				productItem.TargetUrl = context.StringValue("DescribeProducts.ProductItems["+ i +"].TargetUrl");
				productItem.ImageUrl = context.StringValue("DescribeProducts.ProductItems["+ i +"].ImageUrl");
				productItem.Score = context.StringValue("DescribeProducts.ProductItems["+ i +"].Score");
				productItem.OperationSystem = context.StringValue("DescribeProducts.ProductItems["+ i +"].OperationSystem");
				productItem.WarrantyDate = context.StringValue("DescribeProducts.ProductItems["+ i +"].WarrantyDate");
				productItem.DeliveryDate = context.StringValue("DescribeProducts.ProductItems["+ i +"].DeliveryDate");
				productItem.DeliveryWay = context.StringValue("DescribeProducts.ProductItems["+ i +"].DeliveryWay");

				describeProductsResponse_productItems.Add(productItem);
			}
			describeProductsResponse.ProductItems = describeProductsResponse_productItems;
        
			return describeProductsResponse;
        }
    }
}
