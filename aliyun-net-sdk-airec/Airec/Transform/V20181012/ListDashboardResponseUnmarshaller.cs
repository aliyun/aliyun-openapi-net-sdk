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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListDashboardResponseUnmarshaller
    {
        public static ListDashboardResponse Unmarshall(UnmarshallerContext context)
        {
			ListDashboardResponse listDashboardResponse = new ListDashboardResponse();

			listDashboardResponse.HttpResponse = context.HttpResponse;
			listDashboardResponse.RequestId = context.StringValue("ListDashboard.RequestId");
			listDashboardResponse.Code = context.StringValue("ListDashboard.Code");
			listDashboardResponse.Message = context.StringValue("ListDashboard.Message");

			ListDashboardResponse.ListDashboard_Result result = new ListDashboardResponse.ListDashboard_Result();
			result.Num = context.IntegerValue("ListDashboard.Result.Num");

			List<ListDashboardResponse.ListDashboard_Result.ListDashboard_ListItem> result_list = new List<ListDashboardResponse.ListDashboard_Result.ListDashboard_ListItem>();
			for (int i = 0; i < context.Length("ListDashboard.Result.List.Length"); i++) {
				ListDashboardResponse.ListDashboard_Result.ListDashboard_ListItem listItem = new ListDashboardResponse.ListDashboard_Result.ListDashboard_ListItem();
				listItem.BizDate = context.LongValue("ListDashboard.Result.List["+ i +"].BizDate");
				listItem.Pv = context.LongValue("ListDashboard.Result.List["+ i +"].Pv");
				listItem.Uv = context.LongValue("ListDashboard.Result.List["+ i +"].Uv");
				listItem.Click = context.LongValue("ListDashboard.Result.List["+ i +"].Click");
				listItem.Ctr = context.FloatValue("ListDashboard.Result.List["+ i +"].Ctr");
				listItem.UvCtr = context.FloatValue("ListDashboard.Result.List["+ i +"].UvCtr");
				listItem.PerUvBhv = context.FloatValue("ListDashboard.Result.List["+ i +"].PerUvBhv");
				listItem.PerUvClick = context.FloatValue("ListDashboard.Result.List["+ i +"].PerUvClick");
				listItem.ClickUser = context.LongValue("ListDashboard.Result.List["+ i +"].ClickUser");
				listItem.ActiveItem = context.LongValue("ListDashboard.Result.List["+ i +"].ActiveItem");
				listItem.TraceId = context.StringValue("ListDashboard.Result.List["+ i +"].TraceId");
				listItem.SceneId = context.StringValue("ListDashboard.Result.List["+ i +"].SceneId");

				result_list.Add(listItem);
			}
			result.List = result_list;
			listDashboardResponse.Result = result;
        
			return listDashboardResponse;
        }
    }
}
