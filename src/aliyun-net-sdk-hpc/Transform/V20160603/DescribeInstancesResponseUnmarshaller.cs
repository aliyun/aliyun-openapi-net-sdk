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
using Aliyun.Acs.HPC.Model.V20160603;
using System.Collections.Generic;

namespace Aliyun.Acs.HPC.Transform.V20160603
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstances.RequestId")
            };
            List<DescribeInstancesResponse.Instance> instances = new List<DescribeInstancesResponse.Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
                DescribeInstancesResponse.Instance instance = new DescribeInstancesResponse.Instance()
                {
                    InstanceId = context.StringValue($"DescribeInstances.Instances[{i}].InstanceId"),
                    InstanceType = context.EnumValue<DescribeInstancesResponse.Instance.InstanceTypeEnum>($"DescribeInstances.Instances[{i}].InstanceType"),
                    PackageId = context.EnumValue<DescribeInstancesResponse.Instance.PackageIdEnum>($"DescribeInstances.Instances[{i}].PackageId"),
                    Status = context.EnumValue<DescribeInstancesResponse.Instance.StatusEnum>($"DescribeInstances.Instances[{i}].Status"),
                    InnerIpAddress = context.StringValue($"DescribeInstances.Instances[{i}].InnerIpAddress"),
                    JumpserverStatus = context.EnumValue<DescribeInstancesResponse.Instance.JumpserverStatusEnum>($"DescribeInstances.Instances[{i}].JumpserverStatus"),
                    JumpserverInnerIpAddress = context.StringValue($"DescribeInstances.Instances[{i}].JumpserverInnerIpAddress"),
                    JumpServerPublicIpAddress = context.StringValue($"DescribeInstances.Instances[{i}].JumpServerPublicIpAddress")
                };
                instances.Add(instance);
			}
			describeInstancesResponse.Instances = instances;
        
			return describeInstancesResponse;
        }
    }
}