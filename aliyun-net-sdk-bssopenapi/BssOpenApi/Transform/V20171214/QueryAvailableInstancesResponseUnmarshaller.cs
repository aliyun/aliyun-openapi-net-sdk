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
    public class QueryAvailableInstancesResponseUnmarshaller
    {
        public static QueryAvailableInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAvailableInstancesResponse queryAvailableInstancesResponse = new QueryAvailableInstancesResponse();

			queryAvailableInstancesResponse.HttpResponse = _ctx.HttpResponse;
			queryAvailableInstancesResponse.RequestId = _ctx.StringValue("QueryAvailableInstances.RequestId");
			queryAvailableInstancesResponse.Success = _ctx.BooleanValue("QueryAvailableInstances.Success");
			queryAvailableInstancesResponse.Code = _ctx.StringValue("QueryAvailableInstances.Code");
			queryAvailableInstancesResponse.Message = _ctx.StringValue("QueryAvailableInstances.Message");

			QueryAvailableInstancesResponse.QueryAvailableInstances_Data data = new QueryAvailableInstancesResponse.QueryAvailableInstances_Data();
			data.PageNum = _ctx.IntegerValue("QueryAvailableInstances.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryAvailableInstances.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryAvailableInstances.Data.TotalCount");

			List<QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance> data_instanceList = new List<QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance>();
			for (int i = 0; i < _ctx.Length("QueryAvailableInstances.Data.InstanceList.Length"); i++) {
				QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance instance = new QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance();
				instance.OwnerId = _ctx.LongValue("QueryAvailableInstances.Data.InstanceList["+ i +"].OwnerId");
				instance.SellerId = _ctx.LongValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SellerId");
				instance.ProductCode = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ProductCode");
				instance.ProductType = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ProductType");
				instance.SubscriptionType = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SubscriptionType");
				instance.InstanceID = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].InstanceID");
				instance.Region = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Region");
				instance.CreateTime = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].CreateTime");
				instance.EndTime = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].EndTime");
				instance.StopTime = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].StopTime");
				instance.ReleaseTime = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ReleaseTime");
				instance.ExpectedReleaseTime = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ExpectedReleaseTime");
				instance.Status = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Status");
				instance.SubStatus = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SubStatus");
				instance.RenewStatus = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewStatus");
				instance.RenewalDuration = _ctx.IntegerValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewalDuration");
				instance.RenewalDurationUnit = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewalDurationUnit");
				instance.Seller = _ctx.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Seller");

				data_instanceList.Add(instance);
			}
			data.InstanceList = data_instanceList;
			queryAvailableInstancesResponse.Data = data;
        
			return queryAvailableInstancesResponse;
        }
    }
}
