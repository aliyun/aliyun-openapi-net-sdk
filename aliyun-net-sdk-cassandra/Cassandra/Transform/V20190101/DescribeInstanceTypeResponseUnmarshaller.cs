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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeInstanceTypeResponseUnmarshaller
    {
        public static DescribeInstanceTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceTypeResponse describeInstanceTypeResponse = new DescribeInstanceTypeResponse();

			describeInstanceTypeResponse.HttpResponse = context.HttpResponse;
			describeInstanceTypeResponse.RequestId = context.StringValue("DescribeInstanceType.RequestId");

			List<DescribeInstanceTypeResponse.DescribeInstanceType_InstanceTypeSpec> describeInstanceTypeResponse_instanceTypeSpecList = new List<DescribeInstanceTypeResponse.DescribeInstanceType_InstanceTypeSpec>();
			for (int i = 0; i < context.Length("DescribeInstanceType.InstanceTypeSpecList.Length"); i++) {
				DescribeInstanceTypeResponse.DescribeInstanceType_InstanceTypeSpec instanceTypeSpec = new DescribeInstanceTypeResponse.DescribeInstanceType_InstanceTypeSpec();
				instanceTypeSpec.InstanceType = context.StringValue("DescribeInstanceType.InstanceTypeSpecList["+ i +"].InstanceType");
				instanceTypeSpec.CpuSize = context.LongValue("DescribeInstanceType.InstanceTypeSpecList["+ i +"].CpuSize");
				instanceTypeSpec.MemSize = context.LongValue("DescribeInstanceType.InstanceTypeSpecList["+ i +"].MemSize");

				describeInstanceTypeResponse_instanceTypeSpecList.Add(instanceTypeSpec);
			}
			describeInstanceTypeResponse.InstanceTypeSpecList = describeInstanceTypeResponse_instanceTypeSpecList;
        
			return describeInstanceTypeResponse;
        }
    }
}
