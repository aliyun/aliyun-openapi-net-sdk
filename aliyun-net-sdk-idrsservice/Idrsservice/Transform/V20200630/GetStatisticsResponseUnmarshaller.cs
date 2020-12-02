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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetStatisticsResponseUnmarshaller
    {
        public static GetStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStatisticsResponse getStatisticsResponse = new GetStatisticsResponse();

			getStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			getStatisticsResponse.Code = _ctx.StringValue("GetStatistics.Code");
			getStatisticsResponse.Message = _ctx.StringValue("GetStatistics.Message");
			getStatisticsResponse.RequestId = _ctx.StringValue("GetStatistics.RequestId");

			GetStatisticsResponse.GetStatistics_Data data = new GetStatisticsResponse.GetStatistics_Data();

			List<GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem> data_items = new List<GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem>();
			for (int i = 0; i < _ctx.Length("GetStatistics.Data.Items.Length"); i++) {
				GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem itemsItem = new GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem();
				itemsItem.ClientCount = _ctx.LongValue("GetStatistics.Data.Items["+ i +"].ClientCount");
				itemsItem.CloudCount = _ctx.LongValue("GetStatistics.Data.Items["+ i +"].CloudCount");
				itemsItem.DepartmentName = _ctx.StringValue("GetStatistics.Data.Items["+ i +"].DepartmentName");
				itemsItem.Month = _ctx.StringValue("GetStatistics.Data.Items["+ i +"].Month");

				List<GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem.GetStatistics_DetailItem> itemsItem_detail = new List<GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem.GetStatistics_DetailItem>();
				for (int j = 0; j < _ctx.Length("GetStatistics.Data.Items["+ i +"].Detail.Length"); j++) {
					GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem.GetStatistics_DetailItem detailItem = new GetStatisticsResponse.GetStatistics_Data.GetStatistics_ItemsItem.GetStatistics_DetailItem();
					detailItem.ClientCount = _ctx.LongValue("GetStatistics.Data.Items["+ i +"].Detail["+ j +"].ClientCount");
					detailItem.CloudCount = _ctx.LongValue("GetStatistics.Data.Items["+ i +"].Detail["+ j +"].CloudCount");
					detailItem.DepartmentId = _ctx.StringValue("GetStatistics.Data.Items["+ i +"].Detail["+ j +"].DepartmentId");
					detailItem.DepartmentName = _ctx.StringValue("GetStatistics.Data.Items["+ i +"].Detail["+ j +"].DepartmentName");
					detailItem.Month = _ctx.IntegerValue("GetStatistics.Data.Items["+ i +"].Detail["+ j +"].Month");

					itemsItem_detail.Add(detailItem);
				}
				itemsItem.Detail = itemsItem_detail;

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			getStatisticsResponse.Data = data;
        
			return getStatisticsResponse;
        }
    }
}
