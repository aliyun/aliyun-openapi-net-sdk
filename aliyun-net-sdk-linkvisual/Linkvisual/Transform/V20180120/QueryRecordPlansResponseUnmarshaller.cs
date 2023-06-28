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
    public class QueryRecordPlansResponseUnmarshaller
    {
        public static QueryRecordPlansResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordPlansResponse queryRecordPlansResponse = new QueryRecordPlansResponse();

			queryRecordPlansResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordPlansResponse.Code = _ctx.StringValue("QueryRecordPlans.Code");
			queryRecordPlansResponse.RequestId = _ctx.StringValue("QueryRecordPlans.RequestId");
			queryRecordPlansResponse.ErrorMessage = _ctx.StringValue("QueryRecordPlans.ErrorMessage");
			queryRecordPlansResponse.Success = _ctx.BooleanValue("QueryRecordPlans.Success");

			QueryRecordPlansResponse.QueryRecordPlans_Data data = new QueryRecordPlansResponse.QueryRecordPlans_Data();
			data.PageSize = _ctx.IntegerValue("QueryRecordPlans.Data.PageSize");
			data.PageCount = _ctx.IntegerValue("QueryRecordPlans.Data.PageCount");
			data.Total = _ctx.IntegerValue("QueryRecordPlans.Data.Total");
			data.Page = _ctx.IntegerValue("QueryRecordPlans.Data.Page");

			List<QueryRecordPlansResponse.QueryRecordPlans_Data.QueryRecordPlans_ListItem> data_list = new List<QueryRecordPlansResponse.QueryRecordPlans_Data.QueryRecordPlans_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryRecordPlans.Data.List.Length"); i++) {
				QueryRecordPlansResponse.QueryRecordPlans_Data.QueryRecordPlans_ListItem listItem = new QueryRecordPlansResponse.QueryRecordPlans_Data.QueryRecordPlans_ListItem();
				listItem.PlanId = _ctx.StringValue("QueryRecordPlans.Data.List["+ i +"].PlanId");
				listItem.Name = _ctx.StringValue("QueryRecordPlans.Data.List["+ i +"].Name");
				listItem.TemplateId = _ctx.StringValue("QueryRecordPlans.Data.List["+ i +"].TemplateId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryRecordPlansResponse.Data = data;
        
			return queryRecordPlansResponse;
        }
    }
}
