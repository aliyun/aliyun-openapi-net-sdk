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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class DescribeInstanceTypesResponseUnmarshaller
    {
        public static DescribeInstanceTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceTypesResponse describeInstanceTypesResponse = new DescribeInstanceTypesResponse();

			describeInstanceTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceTypesResponse.RequestId = _ctx.StringValue("DescribeInstanceTypes.RequestId");

			List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceTypesItem> describeInstanceTypesResponse_instanceTypes = new List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceTypesItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceTypesItem instanceTypesItem = new DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceTypesItem();
				instanceTypesItem.InstanceTypeId = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceTypesItem.CpuCoreCount = _ctx.FloatValue("DescribeInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceTypesItem.MemorySize = _ctx.FloatValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceTypesItem.InstanceTypeDescription = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeDescription");

				describeInstanceTypesResponse_instanceTypes.Add(instanceTypesItem);
			}
			describeInstanceTypesResponse.InstanceTypes = describeInstanceTypesResponse_instanceTypes;
        
			return describeInstanceTypesResponse;
        }
    }
}
