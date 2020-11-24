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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeInstanceIdsResponseUnmarshaller
    {
        public static DescribeInstanceIdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceIdsResponse describeInstanceIdsResponse = new DescribeInstanceIdsResponse();

			describeInstanceIdsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceIdsResponse.RequestId = _ctx.StringValue("DescribeInstanceIds.RequestId");

			List<DescribeInstanceIdsResponse.DescribeInstanceIds_Instance> describeInstanceIdsResponse_instanceIds = new List<DescribeInstanceIdsResponse.DescribeInstanceIds_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceIds.InstanceIds.Length"); i++) {
				DescribeInstanceIdsResponse.DescribeInstanceIds_Instance instance = new DescribeInstanceIdsResponse.DescribeInstanceIds_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeInstanceIds.InstanceIds["+ i +"].InstanceId");
				instance.Remark = _ctx.StringValue("DescribeInstanceIds.InstanceIds["+ i +"].Remark");
				instance.Edition = _ctx.IntegerValue("DescribeInstanceIds.InstanceIds["+ i +"].Edition");

				describeInstanceIdsResponse_instanceIds.Add(instance);
			}
			describeInstanceIdsResponse.InstanceIds = describeInstanceIdsResponse_instanceIds;
        
			return describeInstanceIdsResponse;
        }
    }
}
