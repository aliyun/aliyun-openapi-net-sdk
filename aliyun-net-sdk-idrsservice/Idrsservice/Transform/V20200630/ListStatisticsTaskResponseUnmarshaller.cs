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
    public class ListStatisticsTaskResponseUnmarshaller
    {
        public static ListStatisticsTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStatisticsTaskResponse listStatisticsTaskResponse = new ListStatisticsTaskResponse();

			listStatisticsTaskResponse.HttpResponse = _ctx.HttpResponse;
			listStatisticsTaskResponse.Code = _ctx.StringValue("ListStatisticsTask.Code");
			listStatisticsTaskResponse.Message = _ctx.StringValue("ListStatisticsTask.Message");
			listStatisticsTaskResponse.RequestId = _ctx.StringValue("ListStatisticsTask.RequestId");

			ListStatisticsTaskResponse.ListStatisticsTask_Data data = new ListStatisticsTaskResponse.ListStatisticsTask_Data();
			data.TotalElements = _ctx.LongValue("ListStatisticsTask.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListStatisticsTask.Data.TotalPages");

			List<ListStatisticsTaskResponse.ListStatisticsTask_Data.ListStatisticsTask_ItemsItem> data_items = new List<ListStatisticsTaskResponse.ListStatisticsTask_Data.ListStatisticsTask_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListStatisticsTask.Data.Items.Length"); i++) {
				ListStatisticsTaskResponse.ListStatisticsTask_Data.ListStatisticsTask_ItemsItem itemsItem = new ListStatisticsTaskResponse.ListStatisticsTask_Data.ListStatisticsTask_ItemsItem();
				itemsItem.CreatedAt = _ctx.StringValue("ListStatisticsTask.Data.Items["+ i +"].CreatedAt");
				itemsItem.FileUrl = _ctx.StringValue("ListStatisticsTask.Data.Items["+ i +"].FileUrl");
				itemsItem.Name = _ctx.StringValue("ListStatisticsTask.Data.Items["+ i +"].Name");
				itemsItem.Status = _ctx.IntegerValue("ListStatisticsTask.Data.Items["+ i +"].Status");

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listStatisticsTaskResponse.Data = data;
        
			return listStatisticsTaskResponse;
        }
    }
}
