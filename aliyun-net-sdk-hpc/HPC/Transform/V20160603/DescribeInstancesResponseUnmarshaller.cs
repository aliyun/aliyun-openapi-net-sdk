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
using Aliyun.Acs.HPC.Model.V20160603;

namespace Aliyun.Acs.HPC.Transform.V20160603
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.InstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				instance.PackageId = context.StringValue("DescribeInstances.Instances["+ i +"].PackageId");
				instance.Status = context.StringValue("DescribeInstances.Instances["+ i +"].Status");
				instance.InnerIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].InnerIpAddress");
				instance.JumpserverStatus = context.StringValue("DescribeInstances.Instances["+ i +"].JumpserverStatus");
				instance.JumpserverInnerIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].JumpserverInnerIpAddress");
				instance.JumpServerPublicIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].JumpServerPublicIpAddress");

				describeInstancesResponse_instances.Add(instance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
