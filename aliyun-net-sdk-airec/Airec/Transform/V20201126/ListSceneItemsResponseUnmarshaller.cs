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
    public class ListSceneItemsResponseUnmarshaller
    {
        public static ListSceneItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSceneItemsResponse listSceneItemsResponse = new ListSceneItemsResponse();

			listSceneItemsResponse.HttpResponse = _ctx.HttpResponse;
			listSceneItemsResponse.RequestId = _ctx.StringValue("ListSceneItems.requestId");
			listSceneItemsResponse.Code = _ctx.StringValue("ListSceneItems.code");
			listSceneItemsResponse.Message = _ctx.StringValue("ListSceneItems.message");

			ListSceneItemsResponse.ListSceneItems_Result result = new ListSceneItemsResponse.ListSceneItems_Result();

			ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_Total total = new ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_Total();
			total.InstanceRecommendItem = _ctx.LongValue("ListSceneItems.Result.Total.instanceRecommendItem");
			total.SceneRecommendItem = _ctx.LongValue("ListSceneItems.Result.Total.sceneRecommendItem");
			total.SceneWeightItem = _ctx.LongValue("ListSceneItems.Result.Total.sceneWeightItem");
			total.TotalCount = _ctx.LongValue("ListSceneItems.Result.Total.totalCount");
			total.WeightItem = _ctx.LongValue("ListSceneItems.Result.Total.weightItem");
			result.Total = total;

			List<ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_DetailItem> result_detail = new List<ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_DetailItem>();
			for (int i = 0; i < _ctx.Length("ListSceneItems.Result.Detail.Length"); i++) {
				ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_DetailItem detailItem = new ListSceneItemsResponse.ListSceneItems_Result.ListSceneItems_DetailItem();
				detailItem.Author = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].author");
				detailItem.BrandId = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].brandId");
				detailItem.CategoryPath = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].categoryPath");
				detailItem.Channel = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].channel");
				detailItem.Duration = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].duration");
				detailItem.ExpireTime = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].expireTime");
				detailItem.ItemId = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].itemId");
				detailItem.ItemType = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].itemType");
				detailItem.PubTime = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].pubTime");
				detailItem.ShopId = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].shopId");
				detailItem.Status = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].status");
				detailItem.Title = _ctx.StringValue("ListSceneItems.Result.Detail["+ i +"].title");

				result_detail.Add(detailItem);
			}
			result.Detail = result_detail;
			listSceneItemsResponse.Result = result;
        
			return listSceneItemsResponse;
        }
    }
}
