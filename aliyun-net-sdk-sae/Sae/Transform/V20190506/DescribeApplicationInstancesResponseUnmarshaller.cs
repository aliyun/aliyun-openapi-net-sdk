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
        public static DescribeApplicationInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApplicationInstancesResponse describeApplicationInstancesResponse = new DescribeApplicationInstancesResponse();

			describeApplicationInstancesResponse.HttpResponse = context.HttpResponse;
			describeApplicationInstancesResponse.Code = context.StringValue("DescribeApplicationInstances.Code");
			describeApplicationInstancesResponse.Message = context.StringValue("DescribeApplicationInstances.Message");
			describeApplicationInstancesResponse.TraceId = context.StringValue("DescribeApplicationInstances.TraceId");
			describeApplicationInstancesResponse.RequestId = context.StringValue("DescribeApplicationInstances.RequestId");
			describeApplicationInstancesResponse.Success = context.BooleanValue("DescribeApplicationInstances.Success");
			describeApplicationInstancesResponse.ErrorCode = context.StringValue("DescribeApplicationInstances.ErrorCode");

			DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data data = new DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data();
			data.CurrentPage = context.IntegerValue("DescribeApplicationInstances.Data.CurrentPage");
			data.PageSize = context.IntegerValue("DescribeApplicationInstances.Data.PageSize");
			data.TotalSize = context.IntegerValue("DescribeApplicationInstances.Data.TotalSize");

			List<DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance> data_instances = new List<DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeApplicationInstances.Data.Instances.Length"); i++) {
				DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance instance = new DescribeApplicationInstancesResponse.DescribeApplicationInstances_Data.DescribeApplicationInstances_Instance();
				instance.GroupId = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].GroupId");
				instance.InstanceId = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceId");
				instance.InstanceContainerStatus = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerStatus");
				instance.InstanceContainerIp = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerIp");
				instance.CreateTimeStamp = context.LongValue("DescribeApplicationInstances.Data.Instances["+ i +"].CreateTimeStamp");
				instance.GroupId1 = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].GroupId");
				instance.VSwitchId = context.StringValue("DescribeApplicationInstances.Data.Instances["+ i +"].VSwitchId");
				instance.InstanceContainerRestarts = context.LongValue("DescribeApplicationInstances.Data.Instances["+ i +"].InstanceContainerRestarts");

				data_instances.Add(instance);
			}
			data.Instances = data_instances;
			describeApplicationInstancesResponse.Data = data;
        
			return describeApplicationInstancesResponse;
        }
    }
}
