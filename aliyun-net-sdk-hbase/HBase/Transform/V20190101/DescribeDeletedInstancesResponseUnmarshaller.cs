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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeDeletedInstancesResponseUnmarshaller
    {
        public static DescribeDeletedInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeletedInstancesResponse describeDeletedInstancesResponse = new DescribeDeletedInstancesResponse();

			describeDeletedInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDeletedInstancesResponse.RequestId = _ctx.StringValue("DescribeDeletedInstances.RequestId");
			describeDeletedInstancesResponse.TotalCount = _ctx.LongValue("DescribeDeletedInstances.TotalCount");
			describeDeletedInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDeletedInstances.PageNumber");
			describeDeletedInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDeletedInstances.PageSize");

			List<DescribeDeletedInstancesResponse.DescribeDeletedInstances_Instance> describeDeletedInstancesResponse_instances = new List<DescribeDeletedInstancesResponse.DescribeDeletedInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeDeletedInstances.Instances.Length"); i++) {
				DescribeDeletedInstancesResponse.DescribeDeletedInstances_Instance instance = new DescribeDeletedInstancesResponse.DescribeDeletedInstances_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].InstanceName");
				instance.Status = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].Status");
				instance.MajorVersion = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].MajorVersion");
				instance.Engine = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].Engine");
				instance.RegionId = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].ZoneId");
				instance.CreatedTime = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].CreatedTime");
				instance.DeleteTime = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].DeleteTime");
				instance.ClusterType = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].ClusterType");
				instance.ModuleStackVersion = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].ModuleStackVersion");
				instance.ParentId = _ctx.StringValue("DescribeDeletedInstances.Instances["+ i +"].ParentId");

				describeDeletedInstancesResponse_instances.Add(instance);
			}
			describeDeletedInstancesResponse.Instances = describeDeletedInstancesResponse_instances;
        
			return describeDeletedInstancesResponse;
        }
    }
}
