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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeItemsResponseUnmarshaller
    {
        public static DescribeItemsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeItemsResponse describeItemsResponse = new DescribeItemsResponse();

			describeItemsResponse.HttpResponse = context.HttpResponse;
			describeItemsResponse.ErrorMessage = context.StringValue("DescribeItems.ErrorMessage");
			describeItemsResponse.ErrorCode = context.StringValue("DescribeItems.ErrorCode");
			describeItemsResponse.PageNumber = context.IntegerValue("DescribeItems.PageNumber");
			describeItemsResponse.Message = context.StringValue("DescribeItems.Message");
			describeItemsResponse.PageSize = context.IntegerValue("DescribeItems.PageSize");
			describeItemsResponse.DynamicCode = context.StringValue("DescribeItems.DynamicCode");
			describeItemsResponse.Code = context.StringValue("DescribeItems.Code");
			describeItemsResponse.DynamicMessage = context.StringValue("DescribeItems.DynamicMessage");
			describeItemsResponse.TotalCount = context.IntegerValue("DescribeItems.TotalCount");
			describeItemsResponse.RequestId = context.StringValue("DescribeItems.RequestId");
			describeItemsResponse.Success = context.BooleanValue("DescribeItems.Success");

			List<DescribeItemsResponse.DescribeItems_ItemInfo> describeItemsResponse_items = new List<DescribeItemsResponse.DescribeItems_ItemInfo>();
			for (int i = 0; i < context.Length("DescribeItems.Items.Length"); i++) {
				DescribeItemsResponse.DescribeItems_ItemInfo itemInfo = new DescribeItemsResponse.DescribeItems_ItemInfo();
				itemInfo.CategoryName = context.StringValue("DescribeItems.Items["+ i +"].CategoryName");
				itemInfo.EnergyEfficiency = context.StringValue("DescribeItems.Items["+ i +"].EnergyEfficiency");
				itemInfo.BeSourceCode = context.BooleanValue("DescribeItems.Items["+ i +"].BeSourceCode");
				itemInfo.OptionGroups = context.StringValue("DescribeItems.Items["+ i +"].OptionGroups");
				itemInfo.PromotionEnd = context.StringValue("DescribeItems.Items["+ i +"].PromotionEnd");
				itemInfo.OriginalPrice = context.IntegerValue("DescribeItems.Items["+ i +"].OriginalPrice");
				itemInfo.CustomizeFeatureI = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureI");
				itemInfo.ItemTitle = context.StringValue("DescribeItems.Items["+ i +"].ItemTitle");
				itemInfo.CustomizeFeatureJ = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureJ");
				itemInfo.CustomizeFeatureG = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureG");
				itemInfo.SaleSpec = context.StringValue("DescribeItems.Items["+ i +"].SaleSpec");
				itemInfo.CustomizeFeatureH = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureH");
				itemInfo.CustomizeFeatureE = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureE");
				itemInfo.CustomizeFeatureF = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureF");
				itemInfo.CustomizeFeatureC = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureC");
				itemInfo.CustomizeFeatureD = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureD");
				itemInfo.CustomizeFeatureA = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureA");
				itemInfo.CustomizeFeatureB = context.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureB");
				itemInfo.SkuId = context.StringValue("DescribeItems.Items["+ i +"].SkuId");
				itemInfo.SuggestPrice = context.IntegerValue("DescribeItems.Items["+ i +"].SuggestPrice");
				itemInfo.Rank = context.StringValue("DescribeItems.Items["+ i +"].Rank");
				itemInfo.SourceCode = context.StringValue("DescribeItems.Items["+ i +"].SourceCode");
				itemInfo.StoreId = context.StringValue("DescribeItems.Items["+ i +"].StoreId");
				itemInfo.ProductionPlace = context.StringValue("DescribeItems.Items["+ i +"].ProductionPlace");
				itemInfo.ItemInfoIndex = context.IntegerValue("DescribeItems.Items["+ i +"].ItemInfoIndex");
				itemInfo.PromotionText = context.StringValue("DescribeItems.Items["+ i +"].PromotionText");
				itemInfo.MemberPrice = context.IntegerValue("DescribeItems.Items["+ i +"].MemberPrice");
				itemInfo.PriceUnit = context.StringValue("DescribeItems.Items["+ i +"].PriceUnit");
				itemInfo.ActionPrice = context.IntegerValue("DescribeItems.Items["+ i +"].ActionPrice");
				itemInfo.BrandName = context.StringValue("DescribeItems.Items["+ i +"].BrandName");
				itemInfo.ExtraAttribute = context.StringValue("DescribeItems.Items["+ i +"].ExtraAttribute");
				itemInfo.ForestFirstId = context.StringValue("DescribeItems.Items["+ i +"].ForestFirstId");
				itemInfo.ItemQrCode = context.StringValue("DescribeItems.Items["+ i +"].ItemQrCode");
				itemInfo.ModelNumber = context.StringValue("DescribeItems.Items["+ i +"].ModelNumber");
				itemInfo.ItemShortTitle = context.StringValue("DescribeItems.Items["+ i +"].ItemShortTitle");
				itemInfo.PromotionReason = context.StringValue("DescribeItems.Items["+ i +"].PromotionReason");
				itemInfo.BePromotion = context.BooleanValue("DescribeItems.Items["+ i +"].BePromotion");
				itemInfo.ForestSecondId = context.StringValue("DescribeItems.Items["+ i +"].ForestSecondId");
				itemInfo.ItemBarCode = context.StringValue("DescribeItems.Items["+ i +"].ItemBarCode");
				itemInfo.ItemId = context.LongValue("DescribeItems.Items["+ i +"].ItemId");
				itemInfo.PromotionStart = context.StringValue("DescribeItems.Items["+ i +"].PromotionStart");
				itemInfo.CompanyId = context.StringValue("DescribeItems.Items["+ i +"].CompanyId");

				describeItemsResponse_items.Add(itemInfo);
			}
			describeItemsResponse.Items = describeItemsResponse_items;
        
			return describeItemsResponse;
        }
    }
}
