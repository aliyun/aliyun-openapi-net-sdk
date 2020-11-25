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
    public class DescribeImageSupportInstanceTypesResponseUnmarshaller
    {
        public static DescribeImageSupportInstanceTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageSupportInstanceTypesResponse describeImageSupportInstanceTypesResponse = new DescribeImageSupportInstanceTypesResponse();

			describeImageSupportInstanceTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeImageSupportInstanceTypesResponse.RequestId = _ctx.StringValue("DescribeImageSupportInstanceTypes.RequestId");
			describeImageSupportInstanceTypesResponse.RegionId = _ctx.StringValue("DescribeImageSupportInstanceTypes.RegionId");
			describeImageSupportInstanceTypesResponse.ImageId = _ctx.StringValue("DescribeImageSupportInstanceTypes.ImageId");

			List<DescribeImageSupportInstanceTypesResponse.DescribeImageSupportInstanceTypes_InstanceType> describeImageSupportInstanceTypesResponse_instanceTypes = new List<DescribeImageSupportInstanceTypesResponse.DescribeImageSupportInstanceTypes_InstanceType>();
			for (int i = 0; i < _ctx.Length("DescribeImageSupportInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeImageSupportInstanceTypesResponse.DescribeImageSupportInstanceTypes_InstanceType instanceType = new DescribeImageSupportInstanceTypesResponse.DescribeImageSupportInstanceTypes_InstanceType();
				instanceType.InstanceTypeId = _ctx.StringValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceType.CpuCoreCount = _ctx.IntegerValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceType.MemorySize = _ctx.FloatValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceType.InstanceTypeFamily = _ctx.StringValue("DescribeImageSupportInstanceTypes.InstanceTypes["+ i +"].InstanceTypeFamily");

				describeImageSupportInstanceTypesResponse_instanceTypes.Add(instanceType);
			}
			describeImageSupportInstanceTypesResponse.InstanceTypes = describeImageSupportInstanceTypesResponse_instanceTypes;
        
			return describeImageSupportInstanceTypesResponse;
        }
    }
}
