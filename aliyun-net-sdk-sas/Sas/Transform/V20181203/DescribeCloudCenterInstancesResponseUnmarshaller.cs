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
    public class DescribeCloudCenterInstancesResponseUnmarshaller
    {
        public static DescribeCloudCenterInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCloudCenterInstancesResponse describeCloudCenterInstancesResponse = new DescribeCloudCenterInstancesResponse();

			describeCloudCenterInstancesResponse.HttpResponse = context.HttpResponse;
			describeCloudCenterInstancesResponse.RequestId = context.StringValue("DescribeCloudCenterInstances.RequestId");
			describeCloudCenterInstancesResponse.Success = context.BooleanValue("DescribeCloudCenterInstances.Success");

			DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo pageInfo = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeCloudCenterInstances.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeCloudCenterInstances.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeCloudCenterInstances.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeCloudCenterInstances.PageInfo.CurrentPage");
			describeCloudCenterInstancesResponse.PageInfo = pageInfo;

			List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance> describeCloudCenterInstancesResponse_instances = new List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeCloudCenterInstances.Instances.Length"); i++) {
				DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance instance = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance();
				instance.InternetIp = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InternetIp");
				instance.Os = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Os");
				instance.InstanceId = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceName");
				instance.RegionName = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionName");
				instance.Ip = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Ip");
				instance.ClientStatus = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClientStatus");
				instance.Region = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Region");
				instance.Uuid = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Uuid");
				instance.IntranetIp = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].IntranetIp");
				instance.AssetType = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AssetType");
				instance.Status = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Status");
				instance.Tag = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Tag");
				instance.VpcInstanceId = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VpcInstanceId");
				instance.OsName = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].OsName");
				instance.Flag = context.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Flag");
				instance.HcStatus = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].HcStatus");
				instance.VulStatus = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VulStatus");
				instance.AlarmStatus = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AlarmStatus");
				instance.RiskStatus = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RiskStatus");
				instance.HealthCheckCount = context.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].HealthCheckCount");
				instance.VulCount = context.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].VulCount");
				instance.SafeEventCount = context.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].SafeEventCount");
				instance.RegionId = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionId");
				instance.GroupId = context.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].GroupId");

				describeCloudCenterInstancesResponse_instances.Add(instance);
			}
			describeCloudCenterInstancesResponse.Instances = describeCloudCenterInstancesResponse_instances;
        
			return describeCloudCenterInstancesResponse;
        }
    }
}
