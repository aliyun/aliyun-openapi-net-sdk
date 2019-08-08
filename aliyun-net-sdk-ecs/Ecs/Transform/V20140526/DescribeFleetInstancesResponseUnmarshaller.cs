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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeFleetInstancesResponseUnmarshaller
    {
        public static DescribeFleetInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFleetInstancesResponse describeFleetInstancesResponse = new DescribeFleetInstancesResponse();

			describeFleetInstancesResponse.HttpResponse = context.HttpResponse;
			describeFleetInstancesResponse.RequestId = context.StringValue("DescribeFleetInstances.RequestId");
			describeFleetInstancesResponse.TotalCount = context.IntegerValue("DescribeFleetInstances.TotalCount");
			describeFleetInstancesResponse.PageNumber = context.IntegerValue("DescribeFleetInstances.PageNumber");
			describeFleetInstancesResponse.PageSize = context.IntegerValue("DescribeFleetInstances.PageSize");

			List<DescribeFleetInstancesResponse.DescribeFleetInstances_Instance> describeFleetInstancesResponse_instances = new List<DescribeFleetInstancesResponse.DescribeFleetInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeFleetInstances.Instances.Length"); i++) {
				DescribeFleetInstancesResponse.DescribeFleetInstances_Instance instance = new DescribeFleetInstancesResponse.DescribeFleetInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeFleetInstances.Instances["+ i +"].InstanceId");
				instance.Status = context.StringValue("DescribeFleetInstances.Instances["+ i +"].Status");
				instance.RegionId = context.StringValue("DescribeFleetInstances.Instances["+ i +"].RegionId");
				instance.IzNo = context.StringValue("DescribeFleetInstances.Instances["+ i +"].IzNo");
				instance.ZoneNo = context.StringValue("DescribeFleetInstances.Instances["+ i +"].ZoneNo");
				instance.Cores = context.IntegerValue("DescribeFleetInstances.Instances["+ i +"].Cores");
				instance.Memory = context.IntegerValue("DescribeFleetInstances.Instances["+ i +"].Memory");
				instance.InstanceType = context.StringValue("DescribeFleetInstances.Instances["+ i +"].InstanceType");
				instance.IsSpot = context.BooleanValue("DescribeFleetInstances.Instances["+ i +"].IsSpot");
				instance.IoOptimized = context.BooleanValue("DescribeFleetInstances.Instances["+ i +"].IoOptimized");
				instance.NetworkType = context.BooleanValue("DescribeFleetInstances.Instances["+ i +"].NetworkType");
				instance.OsType = context.BooleanValue("DescribeFleetInstances.Instances["+ i +"].OsType");
				instance.CreationTime = context.StringValue("DescribeFleetInstances.Instances["+ i +"].CreationTime");

				describeFleetInstancesResponse_instances.Add(instance);
			}
			describeFleetInstancesResponse.Instances = describeFleetInstancesResponse_instances;
        
			return describeFleetInstancesResponse;
        }
    }
}
