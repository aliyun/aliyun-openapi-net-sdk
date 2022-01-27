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
    public class DescribeGroupedContainerInstancesResponseUnmarshaller
    {
        public static DescribeGroupedContainerInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupedContainerInstancesResponse describeGroupedContainerInstancesResponse = new DescribeGroupedContainerInstancesResponse();

			describeGroupedContainerInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupedContainerInstancesResponse.RequestId = _ctx.StringValue("DescribeGroupedContainerInstances.RequestId");

			DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_PageInfo pageInfo = new DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeGroupedContainerInstances.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeGroupedContainerInstances.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeGroupedContainerInstances.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeGroupedContainerInstances.PageInfo.CurrentPage");
			describeGroupedContainerInstancesResponse.PageInfo = pageInfo;

			List<DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_GroupedContainerInstance> describeGroupedContainerInstancesResponse_groupedContainerInstanceList = new List<DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_GroupedContainerInstance>();
			for (int i = 0; i < _ctx.Length("DescribeGroupedContainerInstances.GroupedContainerInstanceList.Length"); i++) {
				DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_GroupedContainerInstance groupedContainerInstance = new DescribeGroupedContainerInstancesResponse.DescribeGroupedContainerInstances_GroupedContainerInstance();
				groupedContainerInstance.InstanceCount = _ctx.IntegerValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].InstanceCount");
				groupedContainerInstance.RiskInstanceCount = _ctx.IntegerValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].RiskInstanceCount");
				groupedContainerInstance.ClusterId = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].ClusterId");
				groupedContainerInstance.RiskStatus = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].RiskStatus");
				groupedContainerInstance.VulCount = _ctx.IntegerValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].VulCount");
				groupedContainerInstance.AlarmCount = _ctx.IntegerValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].AlarmCount");
				groupedContainerInstance.Pod = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].Pod");
				groupedContainerInstance.PodIp = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].PodIp");
				groupedContainerInstance.InstanceId = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].InstanceId");
				groupedContainerInstance.HostIp = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].HostIp");
				groupedContainerInstance.ClusterName = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].ClusterName");
				groupedContainerInstance.CreateTime = _ctx.LongValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].CreateTime");
				groupedContainerInstance.AppName = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].AppName");
				groupedContainerInstance.ClusterType = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].ClusterType");
				groupedContainerInstance.CusterState = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].CusterState");
				groupedContainerInstance.RegionId = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].RegionId");
				groupedContainerInstance._Namespace = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].Namespace");
				groupedContainerInstance.RiskLevel = _ctx.StringValue("DescribeGroupedContainerInstances.GroupedContainerInstanceList["+ i +"].RiskLevel");

				describeGroupedContainerInstancesResponse_groupedContainerInstanceList.Add(groupedContainerInstance);
			}
			describeGroupedContainerInstancesResponse.GroupedContainerInstanceList = describeGroupedContainerInstancesResponse_groupedContainerInstanceList;
        
			return describeGroupedContainerInstancesResponse;
        }
    }
}
