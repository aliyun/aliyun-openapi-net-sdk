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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeItemsResponseUnmarshaller
    {
        public static DescribeItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeItemsResponse describeItemsResponse = new DescribeItemsResponse();

			describeItemsResponse.HttpResponse = _ctx.HttpResponse;
			describeItemsResponse.ErrorMessage = _ctx.StringValue("DescribeItems.ErrorMessage");
			describeItemsResponse.ErrorCode = _ctx.StringValue("DescribeItems.ErrorCode");
			describeItemsResponse.PageNumber = _ctx.IntegerValue("DescribeItems.PageNumber");
			describeItemsResponse.Message = _ctx.StringValue("DescribeItems.Message");
			describeItemsResponse.PageSize = _ctx.IntegerValue("DescribeItems.PageSize");
			describeItemsResponse.DynamicCode = _ctx.StringValue("DescribeItems.DynamicCode");
			describeItemsResponse.Code = _ctx.StringValue("DescribeItems.Code");
			describeItemsResponse.DynamicMessage = _ctx.StringValue("DescribeItems.DynamicMessage");
			describeItemsResponse.TotalCount = _ctx.IntegerValue("DescribeItems.TotalCount");
			describeItemsResponse.RequestId = _ctx.StringValue("DescribeItems.RequestId");
			describeItemsResponse.Success = _ctx.BooleanValue("DescribeItems.Success");
			describeItemsResponse.TemplateSceneId = _ctx.StringValue("DescribeItems.TemplateSceneId");

			List<DescribeItemsResponse.DescribeItems_ItemInfo> describeItemsResponse_items = new List<DescribeItemsResponse.DescribeItems_ItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeItems.Items.Length"); i++) {
				DescribeItemsResponse.DescribeItems_ItemInfo itemInfo = new DescribeItemsResponse.DescribeItems_ItemInfo();
				itemInfo.CategoryName = _ctx.StringValue("DescribeItems.Items["+ i +"].CategoryName");
				itemInfo.EnergyEfficiency = _ctx.StringValue("DescribeItems.Items["+ i +"].EnergyEfficiency");
				itemInfo.CustomizeFeatureO = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureO");
				itemInfo.Manufacturer = _ctx.StringValue("DescribeItems.Items["+ i +"].Manufacturer");
				itemInfo.CustomizeFeatureM = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureM");
				itemInfo.CustomizeFeatureN = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureN");
				itemInfo.CustomizeFeatureK = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureK");
				itemInfo.CustomizeFeatureL = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureL");
				itemInfo.PromotionEnd = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionEnd");
				itemInfo.OriginalPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].OriginalPrice");
				itemInfo.CustomizeFeatureI = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureI");
				itemInfo.ItemTitle = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemTitle");
				itemInfo.CustomizeFeatureJ = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureJ");
				itemInfo.CustomizeFeatureG = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureG");
				itemInfo.SaleSpec = _ctx.StringValue("DescribeItems.Items["+ i +"].SaleSpec");
				itemInfo.CustomizeFeatureH = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureH");
				itemInfo.CustomizeFeatureE = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureE");
				itemInfo.CustomizeFeatureF = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureF");
				itemInfo.CustomizeFeatureC = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureC");
				itemInfo.CustomizeFeatureD = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureD");
				itemInfo.CustomizeFeatureA = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureA");
				itemInfo.CustomizeFeatureB = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureB");
				itemInfo.TaxFee = _ctx.StringValue("DescribeItems.Items["+ i +"].TaxFee");
				itemInfo.PromotionText = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionText");
				itemInfo.MemberPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].MemberPrice");
				itemInfo.SupplierName = _ctx.StringValue("DescribeItems.Items["+ i +"].SupplierName");
				itemInfo.ForestFirstId = _ctx.StringValue("DescribeItems.Items["+ i +"].ForestFirstId");
				itemInfo.ModelNumber = _ctx.StringValue("DescribeItems.Items["+ i +"].ModelNumber");
				itemInfo.ItemShortTitle = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemShortTitle");
				itemInfo.Material = _ctx.StringValue("DescribeItems.Items["+ i +"].Material");
				itemInfo.BePromotion = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BePromotion");
				itemInfo.ForestSecondId = _ctx.StringValue("DescribeItems.Items["+ i +"].ForestSecondId");
				itemInfo.BeSourceCode = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BeSourceCode");
				itemInfo.SalesPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].SalesPrice");
				itemInfo.ItemPicUrl = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemPicUrl");
				itemInfo.SkuId = _ctx.StringValue("DescribeItems.Items["+ i +"].SkuId");
				itemInfo.SuggestPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].SuggestPrice");
				itemInfo.Rank = _ctx.StringValue("DescribeItems.Items["+ i +"].Rank");
				itemInfo.SourceCode = _ctx.StringValue("DescribeItems.Items["+ i +"].SourceCode");
				itemInfo.ProductionPlace = _ctx.StringValue("DescribeItems.Items["+ i +"].ProductionPlace");
				itemInfo.ItemInfoIndex = _ctx.IntegerValue("DescribeItems.Items["+ i +"].ItemInfoIndex");
				itemInfo.InventoryStatus = _ctx.StringValue("DescribeItems.Items["+ i +"].InventoryStatus");
				itemInfo.PriceUnit = _ctx.StringValue("DescribeItems.Items["+ i +"].PriceUnit");
				itemInfo.ActionPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].ActionPrice");
				itemInfo.BrandName = _ctx.StringValue("DescribeItems.Items["+ i +"].BrandName");
				itemInfo.ItemQrCode = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemQrCode");
				itemInfo.PromotionReason = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionReason");
				itemInfo.ItemBarCode = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemBarCode");
				itemInfo.ItemId = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemId");
				itemInfo.PromotionStart = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionStart");
				itemInfo.GmtCreate = _ctx.StringValue("DescribeItems.Items["+ i +"].GmtCreate");
				itemInfo.GmtModified = _ctx.StringValue("DescribeItems.Items["+ i +"].GmtModified");
				itemInfo.BeMember = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BeMember");

				describeItemsResponse_items.Add(itemInfo);
			}
			describeItemsResponse.Items = describeItemsResponse_items;
        
			return describeItemsResponse;
        }
    }
}
