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
        public static QueryResourcePackageInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryResourcePackageInstancesResponse queryResourcePackageInstancesResponse = new QueryResourcePackageInstancesResponse();

			queryResourcePackageInstancesResponse.HttpResponse = _ctx.HttpResponse;
			queryResourcePackageInstancesResponse.RequestId = _ctx.StringValue("QueryResourcePackageInstances.RequestId");
			queryResourcePackageInstancesResponse.Success = _ctx.BooleanValue("QueryResourcePackageInstances.Success");
			queryResourcePackageInstancesResponse.Code = _ctx.StringValue("QueryResourcePackageInstances.Code");
			queryResourcePackageInstancesResponse.Message = _ctx.StringValue("QueryResourcePackageInstances.Message");
			queryResourcePackageInstancesResponse.Page = _ctx.IntegerValue("QueryResourcePackageInstances.Page");
			queryResourcePackageInstancesResponse.PageSize = _ctx.IntegerValue("QueryResourcePackageInstances.PageSize");
			queryResourcePackageInstancesResponse.Total = _ctx.IntegerValue("QueryResourcePackageInstances.Total");

			QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data data = new QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data();
			data.HostId = _ctx.StringValue("QueryResourcePackageInstances.Data.HostId");
			data.PageNum = _ctx.StringValue("QueryResourcePackageInstances.Data.PageNum");
			data.PageSize = _ctx.StringValue("QueryResourcePackageInstances.Data.PageSize");
			data.TotalCount = _ctx.StringValue("QueryResourcePackageInstances.Data.TotalCount");

			List<QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance> data_instances = new List<QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance>();
			for (int i = 0; i < _ctx.Length("QueryResourcePackageInstances.Data.Instances.Length"); i++) {
				QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance instance = new QueryResourcePackageInstancesResponse.QueryResourcePackageInstances_Data.QueryResourcePackageInstances_Instance();
				instance.InstanceId = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].InstanceId");
				instance.Region = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Region");
				instance.TotalAmount = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].TotalAmount");
				instance.TotalAmountUnit = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].TotalAmountUnit");
				instance.RemainingAmount = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].RemainingAmount");
				instance.RemainingAmountUnit = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].RemainingAmountUnit");
				instance.EffectiveTime = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].EffectiveTime");
				instance.ExpiryTime = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].ExpiryTime");
				instance.Remark = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Remark");
				instance.PackageType = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].PackageType");
				instance.Status = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].Status");
				instance.DeductType = _ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].DeductType");

				List<string> instance_applicableProducts = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryResourcePackageInstances.Data.Instances["+ i +"].ApplicableProducts.Length"); j++) {
					instance_applicableProducts.Add(_ctx.StringValue("QueryResourcePackageInstances.Data.Instances["+ i +"].ApplicableProducts["+ j +"]"));
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
