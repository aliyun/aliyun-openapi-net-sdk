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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListItemsResponseUnmarshaller
    {
        public static ListItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListItemsResponse listItemsResponse = new ListItemsResponse();

			listItemsResponse.HttpResponse = _ctx.HttpResponse;
			listItemsResponse.RequestId = _ctx.StringValue("ListItems.requestId");

			ListItemsResponse.ListItems_Result result = new ListItemsResponse.ListItems_Result();

			ListItemsResponse.ListItems_Result.ListItems_Total total = new ListItemsResponse.ListItems_Result.ListItems_Total();
			total.InstanceRecommendItem = _ctx.LongValue("ListItems.Result.Total.instanceRecommendItem");
			total.QueryCount = _ctx.LongValue("ListItems.Result.Total.queryCount");
			total.SceneRecommendItem = _ctx.LongValue("ListItems.Result.Total.sceneRecommendItem");
			total.SceneWeightItem = _ctx.LongValue("ListItems.Result.Total.sceneWeightItem");
			total.TotalCount = _ctx.LongValue("ListItems.Result.Total.totalCount");
			total.WeightItem = _ctx.LongValue("ListItems.Result.Total.weightItem");
			result.Total = total;

			List<ListItemsResponse.ListItems_Result.ListItems_DetailItem> result_detail = new List<ListItemsResponse.ListItems_Result.ListItems_DetailItem>();
			for (int i = 0; i < _ctx.Length("ListItems.Result.Detail.Length"); i++) {
				ListItemsResponse.ListItems_Result.ListItems_DetailItem detailItem = new ListItemsResponse.ListItems_Result.ListItems_DetailItem();
				detailItem.Author = _ctx.StringValue("ListItems.Result.Detail["+ i +"].author");
				detailItem.BrandId = _ctx.StringValue("ListItems.Result.Detail["+ i +"].brandId");
				detailItem.CategoryPath = _ctx.StringValue("ListItems.Result.Detail["+ i +"].categoryPath");
				detailItem.Channel = _ctx.StringValue("ListItems.Result.Detail["+ i +"].channel");
				detailItem.Duration = _ctx.StringValue("ListItems.Result.Detail["+ i +"].duration");
				detailItem.ExpireTime = _ctx.StringValue("ListItems.Result.Detail["+ i +"].expireTime");
				detailItem.ItemId = _ctx.StringValue("ListItems.Result.Detail["+ i +"].itemId");
				detailItem.ItemType = _ctx.StringValue("ListItems.Result.Detail["+ i +"].itemType");
				detailItem.PubTime = _ctx.StringValue("ListItems.Result.Detail["+ i +"].pubTime");
				detailItem.ShopId = _ctx.StringValue("ListItems.Result.Detail["+ i +"].shopId");
				detailItem.Status = _ctx.StringValue("ListItems.Result.Detail["+ i +"].status");
				detailItem.Title = _ctx.StringValue("ListItems.Result.Detail["+ i +"].title");

				result_detail.Add(detailItem);
			}
			result.Detail = result_detail;
			listItemsResponse.Result = result;
        
			return listItemsResponse;
        }
    }
}
