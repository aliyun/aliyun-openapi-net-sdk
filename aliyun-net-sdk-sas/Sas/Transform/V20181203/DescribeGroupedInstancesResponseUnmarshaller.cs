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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeGroupedInstancesResponseUnmarshaller
    {
        public static DescribeGroupedInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupedInstancesResponse describeGroupedInstancesResponse = new DescribeGroupedInstancesResponse();

			describeGroupedInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupedInstancesResponse.RequestId = _ctx.StringValue("DescribeGroupedInstances.RequestId");

			DescribeGroupedInstancesResponse.DescribeGroupedInstances_PageInfo pageInfo = new DescribeGroupedInstancesResponse.DescribeGroupedInstances_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeGroupedInstances.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeGroupedInstances.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeGroupedInstances.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeGroupedInstances.PageInfo.CurrentPage");
			describeGroupedInstancesResponse.PageInfo = pageInfo;

			List<DescribeGroupedInstancesResponse.DescribeGroupedInstances_Instance> describeGroupedInstancesResponse_instances = new List<DescribeGroupedInstancesResponse.DescribeGroupedInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeGroupedInstances.Instances.Length"); i++) {
				DescribeGroupedInstancesResponse.DescribeGroupedInstances_Instance instance = new DescribeGroupedInstancesResponse.DescribeGroupedInstances_Instance();
				instance.UnProtectedInstanceCount = _ctx.StringValue("DescribeGroupedInstances.Instances["+ i +"].UnProtectedInstanceCount");
				instance.FieldAliasName = _ctx.StringValue("DescribeGroupedInstances.Instances["+ i +"].FieldAliasName");
				instance.GroupFlag = _ctx.IntegerValue("DescribeGroupedInstances.Instances["+ i +"].GroupFlag");
				instance.FieldId = _ctx.LongValue("DescribeGroupedInstances.Instances["+ i +"].FieldId");
				instance.RiskInstanceCount = _ctx.StringValue("DescribeGroupedInstances.Instances["+ i +"].RiskInstanceCount");
				instance.InstanceCount = _ctx.StringValue("DescribeGroupedInstances.Instances["+ i +"].InstanceCount");
				instance.AsapVulInstanceCount = _ctx.LongValue("DescribeGroupedInstances.Instances["+ i +"].AsapVulInstanceCount");

				List<string> instance_groupPath = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeGroupedInstances.Instances["+ i +"].GroupPath.Length"); j++) {
					instance_groupPath.Add(_ctx.StringValue("DescribeGroupedInstances.Instances["+ i +"].GroupPath["+ j +"]"));
				}
				instance.GroupPath = instance_groupPath;

				describeGroupedInstancesResponse_instances.Add(instance);
			}
			describeGroupedInstancesResponse.Instances = describeGroupedInstancesResponse_instances;
        
			return describeGroupedInstancesResponse;
        }
    }
}
