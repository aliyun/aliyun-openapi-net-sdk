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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryActivityItemsResponseUnmarshaller
    {
        public static QueryActivityItemsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryActivityItemsResponse queryActivityItemsResponse = new QueryActivityItemsResponse();

			queryActivityItemsResponse.HttpResponse = context.HttpResponse;
			queryActivityItemsResponse.Code = context.StringValue("QueryActivityItems.Code");
			queryActivityItemsResponse.Message = context.StringValue("QueryActivityItems.Message");
			queryActivityItemsResponse.RequestId = context.StringValue("QueryActivityItems.RequestId");
			queryActivityItemsResponse.TotalCount = context.LongValue("QueryActivityItems.TotalCount");
			queryActivityItemsResponse.PageNumber = context.LongValue("QueryActivityItems.PageNumber");
			queryActivityItemsResponse.PageSize = context.LongValue("QueryActivityItems.PageSize");

			List<QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel> queryActivityItemsResponse_lmActivityItemModelList = new List<QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel>();
			for (int i = 0; i < context.Length("QueryActivityItems.LmActivityItemModelList.Length"); i++) {
				QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel lmActivityItemModel = new QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel();
				lmActivityItemModel.LmItemId = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].LmItemId");
				lmActivityItemModel.ItemId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].ItemId");
				lmActivityItemModel.ItemTitle = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].ItemTitle");
				lmActivityItemModel.LmActivityId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].LmActivityId");
				lmActivityItemModel.MainPicUrl = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].MainPicUrl");
				lmActivityItemModel.TbSellerId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].TbSellerId");
				lmActivityItemModel.TbShopId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].TbShopId");
				lmActivityItemModel.LmShopId = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].LmShopId");
				lmActivityItemModel.TbShopName = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].TbShopName");
				lmActivityItemModel.ItemActivityQuantity = context.IntegerValue("QueryActivityItems.LmActivityItemModelList["+ i +"].ItemActivityQuantity");
				lmActivityItemModel.SellableQuantity = context.IntegerValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SellableQuantity");
				lmActivityItemModel.ItemActivityStatus = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].ItemActivityStatus");
				lmActivityItemModel.CanSell = context.BooleanValue("QueryActivityItems.LmActivityItemModelList["+ i +"].CanSell");
				lmActivityItemModel.Tips = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].Tips");

				List<QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel.QueryActivityItems_LmActivityItemSkuModel> lmActivityItemModel_skuModelList = new List<QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel.QueryActivityItems_LmActivityItemSkuModel>();
				for (int j = 0; j < context.Length("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList.Length"); j++) {
					QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel.QueryActivityItems_LmActivityItemSkuModel lmActivityItemSkuModel = new QueryActivityItemsResponse.QueryActivityItems_LmActivityItemModel.QueryActivityItems_LmActivityItemSkuModel();
					lmActivityItemSkuModel.BizId = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].BizId");
					lmActivityItemSkuModel.SkuId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].SkuId");
					lmActivityItemSkuModel.SkuTitle = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].SkuTitle");
					lmActivityItemSkuModel.SkuPicUrl = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].SkuPicUrl");
					lmActivityItemSkuModel.ReservedPrice = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].ReservedPrice");
					lmActivityItemSkuModel.ActivityPrice = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].ActivityPrice");
					lmActivityItemSkuModel.ActivityStatus = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].ActivityStatus");
					lmActivityItemSkuModel.Tips = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].Tips");
					lmActivityItemSkuModel.LmItemId = context.StringValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].LmItemId");
					lmActivityItemSkuModel.ItemId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].ItemId");
					lmActivityItemSkuModel.LmActivityId = context.LongValue("QueryActivityItems.LmActivityItemModelList["+ i +"].SkuModelList["+ j +"].LmActivityId");

					lmActivityItemModel_skuModelList.Add(lmActivityItemSkuModel);
				}
				lmActivityItemModel.SkuModelList = lmActivityItemModel_skuModelList;

				queryActivityItemsResponse_lmActivityItemModelList.Add(lmActivityItemModel);
			}
			queryActivityItemsResponse.LmActivityItemModelList = queryActivityItemsResponse_lmActivityItemModelList;
        
			return queryActivityItemsResponse;
        }
    }
}
