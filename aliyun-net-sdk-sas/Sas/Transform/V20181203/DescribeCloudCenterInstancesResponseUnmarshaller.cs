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
        public static DescribeCloudCenterInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudCenterInstancesResponse describeCloudCenterInstancesResponse = new DescribeCloudCenterInstancesResponse();

			describeCloudCenterInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudCenterInstancesResponse.Success = _ctx.BooleanValue("DescribeCloudCenterInstances.Success");
			describeCloudCenterInstancesResponse.RequestId = _ctx.StringValue("DescribeCloudCenterInstances.RequestId");

			DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo pageInfo = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.Count");
			describeCloudCenterInstancesResponse.PageInfo = pageInfo;

			List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance> describeCloudCenterInstancesResponse_instances = new List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeCloudCenterInstances.Instances.Length"); i++) {
				DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance instance = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance();
				instance.Status = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Status");
				instance.CpuInfo = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].CpuInfo");
				instance.InternetIp = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InternetIp");
				instance.Kernel = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Kernel");
				instance.Bind = _ctx.BooleanValue("DescribeCloudCenterInstances.Instances["+ i +"].Bind");
				instance.OsName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].OsName");
				instance.Tag = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Tag");
				instance.ClientStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClientStatus");
				instance.Mem = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Mem");
				instance.VpcInstanceId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VpcInstanceId");
				instance.TagId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].TagId");
				instance.Flag = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Flag");
				instance.LastLoginTimestamp = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].LastLoginTimestamp");
				instance.AuthVersion = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].AuthVersion");
				instance.Region = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Region");
				instance.InstanceName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceName");
				instance.PodCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].PodCount");
				instance.VulCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].VulCount");
				instance.HcStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].HcStatus");
				instance.CreatedTime = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].CreatedTime");
				instance.GroupTrace = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].GroupTrace");
				instance.ClusterId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClusterId");
				instance.RiskStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RiskStatus");
				instance.Cores = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Cores");
				instance.VulStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VulStatus");
				instance.AlarmStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AlarmStatus");
				instance.MacListString = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].MacListString");
				instance.Importance = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Importance");
				instance.HealthCheckCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].HealthCheckCount");
				instance.Ip = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Ip");
				instance.Os = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Os");
				instance.AuthModifyTime = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].AuthModifyTime");
				instance.SafeEventCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].SafeEventCount");
				instance.InstanceId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceId");
				instance.AssetType = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AssetType");
				instance.IntranetIp = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].IntranetIp");
				instance.Vendor = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Vendor");
				instance.RegionId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionId");
				instance.Uuid = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Uuid");
				instance.GroupId = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].GroupId");
				instance.RegionName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionName");
				instance.VendorName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VendorName");
				instance.AuthVersionName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AuthVersionName");
				instance.ClusterName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClusterName");
				instance.ExposedStatus = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].ExposedStatus");
				instance.RiskCount = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RiskCount");
				instance.IpListString = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].IpListString");

				describeCloudCenterInstancesResponse_instances.Add(instance);
			}
			describeCloudCenterInstancesResponse.Instances = describeCloudCenterInstancesResponse_instances;
        
			return describeCloudCenterInstancesResponse;
        }
    }
}
