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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryAppTasksResponseUnmarshaller
    {
        public static QueryAppTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAppTasksResponse queryAppTasksResponse = new QueryAppTasksResponse();

			queryAppTasksResponse.HttpResponse = _ctx.HttpResponse;
			queryAppTasksResponse.RequestId = _ctx.StringValue("QueryAppTasks.RequestId");
			queryAppTasksResponse.Code = _ctx.IntegerValue("QueryAppTasks.Code");
			queryAppTasksResponse.Success = _ctx.BooleanValue("QueryAppTasks.Success");

			QueryAppTasksResponse.QueryAppTasks_Data data = new QueryAppTasksResponse.QueryAppTasks_Data();
			data.Count = _ctx.IntegerValue("QueryAppTasks.Data.Count");

			List<QueryAppTasksResponse.QueryAppTasks_Data.QueryAppTasks_ListItem> data_list = new List<QueryAppTasksResponse.QueryAppTasks_Data.QueryAppTasks_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryAppTasks.Data.List.Length"); i++) {
				QueryAppTasksResponse.QueryAppTasks_Data.QueryAppTasks_ListItem listItem = new QueryAppTasksResponse.QueryAppTasks_Data.QueryAppTasks_ListItem();
				listItem.Id = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].Id");
				listItem.Name = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].Name");
				listItem.OpenScene = _ctx.IntegerValue("QueryAppTasks.Data.List["+ i +"].OpenScene");
				listItem.AllContentStatus = _ctx.IntegerValue("QueryAppTasks.Data.List["+ i +"].AllContentStatus");
				listItem.PopularizePosition = _ctx.IntegerValue("QueryAppTasks.Data.List["+ i +"].PopularizePosition");
				listItem.PriceType = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].PriceType");
				listItem.ContentIds = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].ContentIds");
				listItem.BrandUserId = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].BrandUserId");
				listItem.ProxyUserId = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].ProxyUserId");
				listItem.AccountNo = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].AccountNo");
				listItem.Quota = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].Quota");
				listItem.QuotaDay = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].QuotaDay");
				listItem.Balance = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].Balance");
				listItem.BalanceDay = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].BalanceDay");
				listItem.StartTime = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].StartTime");
				listItem.EndTime = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].EndTime");
				listItem.Status = _ctx.IntegerValue("QueryAppTasks.Data.List["+ i +"].Status");
				listItem.ChargeCost = _ctx.LongValue("QueryAppTasks.Data.List["+ i +"].ChargeCost");
				listItem.Priority = _ctx.IntegerValue("QueryAppTasks.Data.List["+ i +"].Priority");
				listItem.TimeSchema = _ctx.StringValue("QueryAppTasks.Data.List["+ i +"].TimeSchema");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryAppTasksResponse.Data = data;
        
			return queryAppTasksResponse;
        }
    }
}
