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
    public class QueryEventRecordPlanDeviceByPlanResponseUnmarshaller
    {
        public static QueryEventRecordPlanDeviceByPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEventRecordPlanDeviceByPlanResponse queryEventRecordPlanDeviceByPlanResponse = new QueryEventRecordPlanDeviceByPlanResponse();

			queryEventRecordPlanDeviceByPlanResponse.HttpResponse = _ctx.HttpResponse;
			queryEventRecordPlanDeviceByPlanResponse.Code = _ctx.StringValue("QueryEventRecordPlanDeviceByPlan.Code");
			queryEventRecordPlanDeviceByPlanResponse.RequestId = _ctx.StringValue("QueryEventRecordPlanDeviceByPlan.RequestId");
			queryEventRecordPlanDeviceByPlanResponse.ErrorMessage = _ctx.StringValue("QueryEventRecordPlanDeviceByPlan.ErrorMessage");
			queryEventRecordPlanDeviceByPlanResponse.Success = _ctx.BooleanValue("QueryEventRecordPlanDeviceByPlan.Success");

			QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data data = new QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data();
			data.PageSize = _ctx.IntegerValue("QueryEventRecordPlanDeviceByPlan.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryEventRecordPlanDeviceByPlan.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryEventRecordPlanDeviceByPlan.Data.PageCount");
			data.Page = _ctx.IntegerValue("QueryEventRecordPlanDeviceByPlan.Data.Page");

			List<QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data.QueryEventRecordPlanDeviceByPlan_ListItem> data_list = new List<QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data.QueryEventRecordPlanDeviceByPlan_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryEventRecordPlanDeviceByPlan.Data.List.Length"); i++) {
				QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data.QueryEventRecordPlanDeviceByPlan_ListItem listItem = new QueryEventRecordPlanDeviceByPlanResponse.QueryEventRecordPlanDeviceByPlan_Data.QueryEventRecordPlanDeviceByPlan_ListItem();
				listItem.StreamType = _ctx.IntegerValue("QueryEventRecordPlanDeviceByPlan.Data.List["+ i +"].StreamType");
				listItem.IotId = _ctx.StringValue("QueryEventRecordPlanDeviceByPlan.Data.List["+ i +"].IotId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryEventRecordPlanDeviceByPlanResponse.Data = data;
        
			return queryEventRecordPlanDeviceByPlanResponse;
        }
    }
}
