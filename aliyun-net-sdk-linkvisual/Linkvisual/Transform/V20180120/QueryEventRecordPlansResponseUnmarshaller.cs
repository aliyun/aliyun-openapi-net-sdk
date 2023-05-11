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
    public class QueryEventRecordPlansResponseUnmarshaller
    {
        public static QueryEventRecordPlansResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEventRecordPlansResponse queryEventRecordPlansResponse = new QueryEventRecordPlansResponse();

			queryEventRecordPlansResponse.HttpResponse = _ctx.HttpResponse;
			queryEventRecordPlansResponse.Code = _ctx.StringValue("QueryEventRecordPlans.Code");
			queryEventRecordPlansResponse.RequestId = _ctx.StringValue("QueryEventRecordPlans.RequestId");
			queryEventRecordPlansResponse.ErrorMessage = _ctx.StringValue("QueryEventRecordPlans.ErrorMessage");
			queryEventRecordPlansResponse.Success = _ctx.BooleanValue("QueryEventRecordPlans.Success");

			QueryEventRecordPlansResponse.QueryEventRecordPlans_Data data = new QueryEventRecordPlansResponse.QueryEventRecordPlans_Data();
			data.PageSize = _ctx.IntegerValue("QueryEventRecordPlans.Data.PageSize");
			data.PageCount = _ctx.IntegerValue("QueryEventRecordPlans.Data.PageCount");
			data.Total = _ctx.IntegerValue("QueryEventRecordPlans.Data.Total");
			data.Page = _ctx.IntegerValue("QueryEventRecordPlans.Data.Page");

			List<QueryEventRecordPlansResponse.QueryEventRecordPlans_Data.QueryEventRecordPlans_ListItem> data_list = new List<QueryEventRecordPlansResponse.QueryEventRecordPlans_Data.QueryEventRecordPlans_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryEventRecordPlans.Data.List.Length"); i++) {
				QueryEventRecordPlansResponse.QueryEventRecordPlans_Data.QueryEventRecordPlans_ListItem listItem = new QueryEventRecordPlansResponse.QueryEventRecordPlans_Data.QueryEventRecordPlans_ListItem();
				listItem.EventType = _ctx.StringValue("QueryEventRecordPlans.Data.List["+ i +"].EventType");
				listItem.RecordDuration = _ctx.IntegerValue("QueryEventRecordPlans.Data.List["+ i +"].RecordDuration");
				listItem.PreRecordDuration = _ctx.IntegerValue("QueryEventRecordPlans.Data.List["+ i +"].PreRecordDuration");
				listItem.PlanId = _ctx.StringValue("QueryEventRecordPlans.Data.List["+ i +"].PlanId");
				listItem.Name = _ctx.StringValue("QueryEventRecordPlans.Data.List["+ i +"].Name");
				listItem.TemplateId = _ctx.StringValue("QueryEventRecordPlans.Data.List["+ i +"].TemplateId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryEventRecordPlansResponse.Data = data;
        
			return queryEventRecordPlansResponse;
        }
    }
}
