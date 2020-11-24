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
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.TotalCount = _ctx.LongValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.Remark = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Remark");
				instance.Status = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Status");
				instance.DebtStatus = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].DebtStatus");
				instance.ExpireTime = _ctx.LongValue("DescribeInstances.Instances["+ i +"].ExpireTime");
				instance.CreateTime = _ctx.LongValue("DescribeInstances.Instances["+ i +"].CreateTime");
				instance.Edition = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Edition");
				instance.Enabled = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Enabled");
				instance.ConnInstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ConnInstanceId");

				describeInstancesResponse_instances.Add(instance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
