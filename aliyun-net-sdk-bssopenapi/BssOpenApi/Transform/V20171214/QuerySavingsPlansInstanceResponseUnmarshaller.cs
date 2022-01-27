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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QuerySavingsPlansInstanceResponseUnmarshaller
    {
        public static QuerySavingsPlansInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySavingsPlansInstanceResponse querySavingsPlansInstanceResponse = new QuerySavingsPlansInstanceResponse();

			querySavingsPlansInstanceResponse.HttpResponse = _ctx.HttpResponse;
			querySavingsPlansInstanceResponse.Code = _ctx.StringValue("QuerySavingsPlansInstance.Code");
			querySavingsPlansInstanceResponse.RequestId = _ctx.StringValue("QuerySavingsPlansInstance.RequestId");
			querySavingsPlansInstanceResponse.Success = _ctx.BooleanValue("QuerySavingsPlansInstance.Success");
			querySavingsPlansInstanceResponse.Message = _ctx.StringValue("QuerySavingsPlansInstance.Message");

			QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data data = new QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data();
			data.PageNum = _ctx.IntegerValue("QuerySavingsPlansInstance.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QuerySavingsPlansInstance.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySavingsPlansInstance.Data.TotalCount");

			List<QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse> data_items = new List<QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse>();
			for (int i = 0; i < _ctx.Length("QuerySavingsPlansInstance.Data.Items.Length"); i++) {
				QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse savingsPlansDetailResponse = new QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse();
				savingsPlansDetailResponse.InstanceId = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].InstanceId");
				savingsPlansDetailResponse.SavingsType = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].SavingsType");
				savingsPlansDetailResponse.InstanceFamily = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].InstanceFamily");
				savingsPlansDetailResponse.Region = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Region");
				savingsPlansDetailResponse.PoolValue = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].PoolValue");
				savingsPlansDetailResponse.Currency = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Currency");
				savingsPlansDetailResponse.Status = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Status");
				savingsPlansDetailResponse.StartTime = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].StartTime");
				savingsPlansDetailResponse.EndTime = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].EndTime");
				savingsPlansDetailResponse.PayMode = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].PayMode");
				savingsPlansDetailResponse.PrepayFee = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].PrepayFee");
				savingsPlansDetailResponse.TotalSave = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].TotalSave");
				savingsPlansDetailResponse.Utilization = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Utilization");
				savingsPlansDetailResponse.AllocationStatus = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].AllocationStatus");

				List<QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse.QuerySavingsPlansInstance_Tag> savingsPlansDetailResponse_tags = new List<QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse.QuerySavingsPlansInstance_Tag>();
				for (int j = 0; j < _ctx.Length("QuerySavingsPlansInstance.Data.Items["+ i +"].Tags.Length"); j++) {
					QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse.QuerySavingsPlansInstance_Tag tag = new QuerySavingsPlansInstanceResponse.QuerySavingsPlansInstance_Data.QuerySavingsPlansInstance_SavingsPlansDetailResponse.QuerySavingsPlansInstance_Tag();
					tag.Key = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("QuerySavingsPlansInstance.Data.Items["+ i +"].Tags["+ j +"].Value");

					savingsPlansDetailResponse_tags.Add(tag);
				}
				savingsPlansDetailResponse.Tags = savingsPlansDetailResponse_tags;

				data_items.Add(savingsPlansDetailResponse);
			}
			data.Items = data_items;
			querySavingsPlansInstanceResponse.Data = data;
        
			return querySavingsPlansInstanceResponse;
        }
    }
}
