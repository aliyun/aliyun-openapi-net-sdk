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
    public class QueryResourcePackageInstancesResponseUnmarshaller
    {
        public static QueryResourcePackageInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryResourcePackageInstancesResponse queryResourcePackageInstancesResponse = new QueryResourcePackageInstancesResponse();

			queryResourcePackageInstancesResponse.HttpResponse = context.HttpResponse;
			queryResourcePackageInstancesResponse.RequestId = context.StringValue("QueryResourcePackageInstances.RequestId");
			queryResourcePackageInstancesResponse.Success = context.BooleanValue("QueryResourcePackageInstances.Success");
			queryResourcePackageInstancesResponse.Code = context.StringValue("QueryResourcePackageInstances.Code");
			queryResourcePackageInstancesResponse.Message = context.StringValue("QueryResourcePackageInstances.Message");
			queryResourcePackageInstancesResponse.Page = context.IntegerValue("QueryResourcePackageInstances.Page");
			queryResourcePackageInstancesResponse.PageSize = context.IntegerValue("QueryResourcePackageInstances.PageSize");
			queryResourcePackageInstancesResponse.Total = context.IntegerValue("QueryResourcePackageInstances.Total");

			QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data data = new QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data();
			data.HostId = context.StringValue("QueryResourcePackageInstances.Data.HostId");
			data.PageNum = context.StringValue("QueryResourcePackageInstances.Data.PageNum");
			data.PageSize = context.StringValue("QueryResourcePackageInstances.Data.PageSize");
			data.TotalCount = context.StringValue("QueryResourcePackageInstances.Data.TotalCount");

			List<QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance> data_instances = new List<QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance>();
			for (int i = 0; i < context.Length("QueryResourcePackageInstances.Data.Instances.Length"); i++) {
				QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance instance = new QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance();
				instance.InstanceId = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].InstanceId");
				instance.Region = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Region");
				instance.TotalAmount = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].TotalAmount");
				instance.TotalAmountUnit = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].TotalAmountUnit");
				instance.RemainingAmount = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].RemainingAmount");
				instance.RemainingAmountUnit = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].RemainingAmountUnit");
				instance.EffectiveTime = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].EffectiveTime");
				instance.ExpiryTime = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].ExpiryTime");
				instance.Remark = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Remark");
				instance.PackageType = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].PackageType");
				instance.Status = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Status");
				instance.DeductType = context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].DeductType");

				List<string> instance_applicableProducts = new List<string>();
				for (int j = 0; j < context.Length("QueryResourcePackageInstances.Data.Instances["+ i +"].ApplicableProducts.Length"); j++) {
					instance_applicableProducts.Add(context.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].ApplicableProducts["+ j +"]"));
				}
				instance.ApplicableProducts = instance_applicableProducts;

				data_instances.Add(instance);
			}
			data.Instances = data_instances;
			queryResourcePackageInstancesResponse.Data = data;
        
			return queryResourcePackageInstancesResponse;
        }
    }
}
