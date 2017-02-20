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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceTypesResponseUnmarshaller
    {
        public static DescribeInstanceTypesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstanceTypesResponse describeInstanceTypesResponse = new DescribeInstanceTypesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstanceTypes.RequestId")
            };
            List<DescribeInstanceTypesResponse.InstanceType> instanceTypes = new List<DescribeInstanceTypesResponse.InstanceType>();
			for (int i = 0; i < context.Length("DescribeInstanceTypes.InstanceTypes.Length"); i++) {
                DescribeInstanceTypesResponse.InstanceType instanceType = new DescribeInstanceTypesResponse.InstanceType()
                {
                    InstanceTypeId = context.StringValue($"DescribeInstanceTypes.InstanceTypes[{i}].InstanceTypeId"),
                    CpuCoreCount = context.IntegerValue($"DescribeInstanceTypes.InstanceTypes[{i}].CpuCoreCount"),
                    MemorySize = context.FloatValue($"DescribeInstanceTypes.InstanceTypes[{i}].MemorySize"),
                    InstanceTypeFamily = context.StringValue($"DescribeInstanceTypes.InstanceTypes[{i}].InstanceTypeFamily")
                };
                instanceTypes.Add(instanceType);
			}
			describeInstanceTypesResponse.InstanceTypes = instanceTypes;
        
			return describeInstanceTypesResponse;
        }
    }
}