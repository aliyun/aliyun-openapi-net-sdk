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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.BssOpenApi.Model.V20171214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryAvailableInstancesResponseUnmarshaller
    {
        public static QueryAvailableInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAvailableInstancesResponse queryAvailableInstancesResponse = new QueryAvailableInstancesResponse();

			queryAvailableInstancesResponse.HttpResponse = context.HttpResponse;
			queryAvailableInstancesResponse.RequestId = context.StringValue("QueryAvailableInstances.RequestId");
			queryAvailableInstancesResponse.Success = context.BooleanValue("QueryAvailableInstances.Success");
			queryAvailableInstancesResponse.Code = context.StringValue("QueryAvailableInstances.Code");
			queryAvailableInstancesResponse.Message = context.StringValue("QueryAvailableInstances.Message");

			QueryAvailableInstancesResponse.QueryAvailableInstances_Data data = new QueryAvailableInstancesResponse.QueryAvailableInstances_Data();
			data.PageNum = context.IntegerValue("QueryAvailableInstances.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryAvailableInstances.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryAvailableInstances.Data.TotalCount");

			List<QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance> data_instanceList = new List<QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance>();
			for (int i = 0; i < context.Length("QueryAvailableInstances.Data.InstanceList.Length"); i++) {
				QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance instance = new QueryAvailableInstancesResponse.QueryAvailableInstances_Data.QueryAvailableInstances_Instance();
				instance.OwnerId = context.LongValue("QueryAvailableInstances.Data.InstanceList["+ i +"].OwnerId");
				instance.SellerId = context.LongValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SellerId");
				instance.ProductCode = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ProductCode");
				instance.ProductType = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ProductType");
				instance.SubscriptionType = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SubscriptionType");
				instance.InstanceID = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].InstanceID");
				instance.Region = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Region");
				instance.CreateTime = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].CreateTime");
				instance.EndTime = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].EndTime");
				instance.StopTime = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].StopTime");
				instance.ReleaseTime = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ReleaseTime");
				instance.ExpectedReleaseTime = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].ExpectedReleaseTime");
				instance.Status = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Status");
				instance.SubStatus = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].SubStatus");
				instance.RenewStatus = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewStatus");
				instance.RenewalDuration = context.IntegerValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewalDuration");
				instance.RenewalDurationUnit = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].RenewalDurationUnit");
				instance.Seller = context.StringValue("QueryAvailableInstances.Data.InstanceList["+ i +"].Seller");

				data_instanceList.Add(instance);
			}
			data.InstanceList = data_instanceList;
			queryAvailableInstancesResponse.Data = data;
        
			return queryAvailableInstancesResponse;
        }
    }
}