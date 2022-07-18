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
			describeItemsResponse.TemplateSceneId = _ctx.StringValue("DescribeItems.TemplateSceneId");
			describeItemsResponse.ErrorMessage = _ctx.StringValue("DescribeItems.ErrorMessage");
			describeItemsResponse.Success = _ctx.BooleanValue("DescribeItems.Success");
			describeItemsResponse.Message = _ctx.StringValue("DescribeItems.Message");
			describeItemsResponse.DynamicMessage = _ctx.StringValue("DescribeItems.DynamicMessage");
			describeItemsResponse.TotalCount = _ctx.IntegerValue("DescribeItems.TotalCount");
			describeItemsResponse.DynamicCode = _ctx.StringValue("DescribeItems.DynamicCode");
			describeItemsResponse.RequestId = _ctx.StringValue("DescribeItems.RequestId");
			describeItemsResponse.ErrorCode = _ctx.StringValue("DescribeItems.ErrorCode");
			describeItemsResponse.Code = _ctx.StringValue("DescribeItems.Code");
			describeItemsResponse.PageNumber = _ctx.IntegerValue("DescribeItems.PageNumber");
			describeItemsResponse.PageSize = _ctx.IntegerValue("DescribeItems.PageSize");

			List<DescribeItemsResponse.DescribeItems_ItemInfo> describeItemsResponse_items = new List<DescribeItemsResponse.DescribeItems_ItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeItems.Items.Length"); i++) {
				DescribeItemsResponse.DescribeItems_ItemInfo itemInfo = new DescribeItemsResponse.DescribeItems_ItemInfo();
				itemInfo.ActionPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].ActionPrice");
				itemInfo.ItemTitle = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemTitle");
				itemInfo.BrandName = _ctx.StringValue("DescribeItems.Items["+ i +"].BrandName");
				itemInfo.SourceCode = _ctx.StringValue("DescribeItems.Items["+ i +"].SourceCode");
				itemInfo.PriceUnit = _ctx.StringValue("DescribeItems.Items["+ i +"].PriceUnit");
				itemInfo.ForestFirstId = _ctx.StringValue("DescribeItems.Items["+ i +"].ForestFirstId");
				itemInfo.CustomizeFeatureF = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureF");
				itemInfo.CustomizeFeatureA = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureA");
				itemInfo.CustomizeFeatureK = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureK");
				itemInfo.TemplateSceneId = _ctx.StringValue("DescribeItems.Items["+ i +"].TemplateSceneId");
				itemInfo.CustomizeFeatureD = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureD");
				itemInfo.MemberPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].MemberPrice");
				itemInfo.PromotionStart = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionStart");
				itemInfo.ModelNumber = _ctx.StringValue("DescribeItems.Items["+ i +"].ModelNumber");
				itemInfo.CategoryName = _ctx.StringValue("DescribeItems.Items["+ i +"].CategoryName");
				itemInfo.CustomizeFeatureE = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureE");
				itemInfo.SuggestPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].SuggestPrice");
				itemInfo.SaleSpec = _ctx.StringValue("DescribeItems.Items["+ i +"].SaleSpec");
				itemInfo.PromotionText = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionText");
				itemInfo.Rank = _ctx.StringValue("DescribeItems.Items["+ i +"].Rank");
				itemInfo.PromotionReason = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionReason");
				itemInfo.CustomizeFeatureG = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureG");
				itemInfo.SalesPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].SalesPrice");
				itemInfo.CustomizeFeatureH = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureH");
				itemInfo.OriginalPrice = _ctx.IntegerValue("DescribeItems.Items["+ i +"].OriginalPrice");
				itemInfo.GmtModified = _ctx.StringValue("DescribeItems.Items["+ i +"].GmtModified");
				itemInfo.CustomizeFeatureI = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureI");
				itemInfo.ProductionPlace = _ctx.StringValue("DescribeItems.Items["+ i +"].ProductionPlace");
				itemInfo.CustomizeFeatureB = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureB");
				itemInfo.ItemShortTitle = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemShortTitle");
				itemInfo.CustomizeFeatureN = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureN");
				itemInfo.BeMember = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BeMember");
				itemInfo.TaxFee = _ctx.StringValue("DescribeItems.Items["+ i +"].TaxFee");
				itemInfo.InventoryStatus = _ctx.StringValue("DescribeItems.Items["+ i +"].InventoryStatus");
				itemInfo.SupplierName = _ctx.StringValue("DescribeItems.Items["+ i +"].SupplierName");
				itemInfo.ItemPicUrl = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemPicUrl");
				itemInfo.EnergyEfficiency = _ctx.StringValue("DescribeItems.Items["+ i +"].EnergyEfficiency");
				itemInfo.CustomizeFeatureL = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureL");
				itemInfo.CustomizeFeatureC = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureC");
				itemInfo.ItemId = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemId");
				itemInfo.Manufacturer = _ctx.StringValue("DescribeItems.Items["+ i +"].Manufacturer");
				itemInfo.Material = _ctx.StringValue("DescribeItems.Items["+ i +"].Material");
				itemInfo.CustomizeFeatureO = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureO");
				itemInfo.CustomizeFeatureP = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureP");
				itemInfo.CustomizeFeatureQ = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureQ");
				itemInfo.CustomizeFeatureR = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureR");
				itemInfo.CustomizeFeatureS = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureS");
				itemInfo.CustomizeFeatureT = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureT");
				itemInfo.CustomizeFeatureU = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureU");
				itemInfo.CustomizeFeatureV = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureV");
				itemInfo.CustomizeFeatureW = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureW");
				itemInfo.CustomizeFeatureX = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureX");
				itemInfo.CustomizeFeatureY = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureY");
				itemInfo.CustomizeFeatureZ = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureZ");
				itemInfo.CustomizeFeatureJ = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureJ");
				itemInfo.GmtCreate = _ctx.StringValue("DescribeItems.Items["+ i +"].GmtCreate");
				itemInfo.CustomizeFeatureM = _ctx.StringValue("DescribeItems.Items["+ i +"].CustomizeFeatureM");
				itemInfo.BePromotion = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BePromotion");
				itemInfo.SkuId = _ctx.StringValue("DescribeItems.Items["+ i +"].SkuId");
				itemInfo.BeSourceCode = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BeSourceCode");
				itemInfo.ForestSecondId = _ctx.StringValue("DescribeItems.Items["+ i +"].ForestSecondId");
				itemInfo.ItemQrCode = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemQrCode");
				itemInfo.ItemInfoIndex = _ctx.IntegerValue("DescribeItems.Items["+ i +"].ItemInfoIndex");
				itemInfo.PromotionEnd = _ctx.StringValue("DescribeItems.Items["+ i +"].PromotionEnd");
				itemInfo.ItemBarCode = _ctx.StringValue("DescribeItems.Items["+ i +"].ItemBarCode");
				itemInfo.BeClearance = _ctx.BooleanValue("DescribeItems.Items["+ i +"].BeClearance");

				describeItemsResponse_items.Add(itemInfo);
			}
			describeItemsResponse.Items = describeItemsResponse_items;
        
			return describeItemsResponse;
        }
    }
}
