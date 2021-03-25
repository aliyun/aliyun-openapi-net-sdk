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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeApplicationInstancesResponseUnmarshaller
    {
        public static DescribeApplicationInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationInstancesResponse describeApplicationInstancesResponse = new DescribeApplicationInstancesResponse();

			describeApplicationInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationInstancesResponse.Message = _ctx.StringValue("DescribeApplicationInstances.Message");
			describeApplicationInstancesResponse.RequestId = _ctx.StringValue("DescribeApplicationInstances.RequestId");
			describeApplicationInstancesResponse.TraceId = _ctx.StringValue("DescribeApplicationInstances.TraceId");
			describeApplicationInstancesResponse.ErrorCode = _ctx.StringValue("DescribeApplicationInstances.ErrorCode");
			describeApplicationInstancesResponse.Code = _ctx.StringValue("DescribeApplicationInstances.Code");
			describeApplicationInstancesResponse.Success = _ctx.BooleanValue("DescribeApplicationInstances.Success");

			DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data data = new DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data();
			data.PageSize = _ctx.IntegerValue("DescribeApplicationInstances.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("DescribeApplicationInstances.Data.CurrentPage");
			data.TotalSize = _ctx.IntegerValue("DescribeApplicationInstances.Data.TotalSize");

			List<DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance> data_instances = new List<DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationInstances.Data.Instances.Length"); i++) {
				DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance instance = new DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance();
				instance.InstanceContainerIp = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerIp");
				instance.InstanceHealthStatus = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceHealthStatus");
				instance.InstanceId = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceId");
				instance.VSwitchId = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].VSwitchId");
				instance.ImageUrl = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].ImageUrl");
				instance.InstanceContainerRestarts = _ctx.LongValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerRestarts");
				instance.PackageVersion = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].PackageVersion");
				instance.InstanceContainerStatus = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerStatus");
				instance.CreateTimeStamp = _ctx.LongValue("DescribeApplicationInstances.Data.Instances["+ i +"].CreateTimeStamp");
				instance.GroupId = _ctx.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].GroupId");

				data_instances.Add(instance);
			}
			data.Instances = data_instances;
			describeApplicationInstancesResponse.Data = data;
        
			return describeApplicationInstancesResponse;
        }
    }
}
