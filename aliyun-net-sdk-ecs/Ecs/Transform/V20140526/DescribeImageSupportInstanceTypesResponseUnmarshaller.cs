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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeImageSupportInstanceTypesResponseUnmarshaller
    {
        public static DescribeImageSupportInstanceTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageSupportInstanceTypesResponse describeImageSupportInstanceTypesResponse = new DescribeImageSupportInstanceTypesResponse();

			describeImageSupportInstanceTypesResponse.HttpResponse = context.HttpResponse;
			describeImageSupportInstanceTypesResponse.RequestId = context.StringValue("DescribeImageSupportInstanceTypes.RequestId");
			describeImageSupportInstanceTypesResponse.RegionId = context.StringValue("DescribeImageSupportInstanceTypes.RegionId");
			describeImageSupportInstanceTypesResponse.ImageId = context.StringValue("DescribeImageSupportInstanceTypes.ImageId");

			List<DescribeImageSupportInstanceTypesResponse.InstanceType> instanceTypes = new List<DescribeImageSupportInstanceTypesResponse.InstanceType>();
			for (int i = 0; i < context.Length("DescribeImageSupportInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeImageSupportInstanceTypesResponse.InstanceType instanceType = new DescribeImageSupportInstanceTypesResponse.InstanceType();
				instanceType.InstanceTypeId = context.StringValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceType.CpuCoreCount = context.IntegerValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceType.MemorySize = context.FloatValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceType.InstanceTypeFamily = context.StringValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].InstanceTypeFamily");

				instanceTypes.Add(instanceType);
			}
			describeImageSupportInstanceTypesResponse.InstanceTypes = instanceTypes;
        
			return describeImageSupportInstanceTypesResponse;
        }
    }
}