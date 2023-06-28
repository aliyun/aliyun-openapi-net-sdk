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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryRecordPlanDeviceByPlanResponseUnmarshaller
    {
        public static QueryRecordPlanDeviceByPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordPlanDeviceByPlanResponse queryRecordPlanDeviceByPlanResponse = new QueryRecordPlanDeviceByPlanResponse();

			queryRecordPlanDeviceByPlanResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordPlanDeviceByPlanResponse.Code = _ctx.StringValue("QueryRecordPlanDeviceByPlan.Code");
			queryRecordPlanDeviceByPlanResponse.RequestId = _ctx.StringValue("QueryRecordPlanDeviceByPlan.RequestId");
			queryRecordPlanDeviceByPlanResponse.ErrorMessage = _ctx.StringValue("QueryRecordPlanDeviceByPlan.ErrorMessage");
			queryRecordPlanDeviceByPlanResponse.Success = _ctx.BooleanValue("QueryRecordPlanDeviceByPlan.Success");

			QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data data = new QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data();
			data.PageSize = _ctx.IntegerValue("QueryRecordPlanDeviceByPlan.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryRecordPlanDeviceByPlan.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryRecordPlanDeviceByPlan.Data.PageCount");
			data.Page = _ctx.IntegerValue("QueryRecordPlanDeviceByPlan.Data.Page");

			List<QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data.QueryRecordPlanDeviceByPlan_ListItem> data_list = new List<QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data.QueryRecordPlanDeviceByPlan_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryRecordPlanDeviceByPlan.Data.List.Length"); i++) {
				QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data.QueryRecordPlanDeviceByPlan_ListItem listItem = new QueryRecordPlanDeviceByPlanResponse.QueryRecordPlanDeviceByPlan_Data.QueryRecordPlanDeviceByPlan_ListItem();
				listItem.StreamType = _ctx.IntegerValue("QueryRecordPlanDeviceByPlan.Data.List["+ i +"].StreamType");
				listItem.IotId = _ctx.StringValue("QueryRecordPlanDeviceByPlan.Data.List["+ i +"].IotId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryRecordPlanDeviceByPlanResponse.Data = data;
        
			return queryRecordPlanDeviceByPlanResponse;
        }
    }
}
