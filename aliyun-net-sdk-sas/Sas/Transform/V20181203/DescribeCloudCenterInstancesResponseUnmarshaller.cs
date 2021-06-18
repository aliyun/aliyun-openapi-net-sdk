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
			describeCloudCenterInstancesResponse.RequestId = _ctx.StringValue("DescribeCloudCenterInstances.RequestId");
			describeCloudCenterInstancesResponse.Success = _ctx.BooleanValue("DescribeCloudCenterInstances.Success");

			DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo pageInfo = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeCloudCenterInstances.PageInfo.CurrentPage");
			describeCloudCenterInstancesResponse.PageInfo = pageInfo;

			List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance> describeCloudCenterInstancesResponse_instances = new List<DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeCloudCenterInstances.Instances.Length"); i++) {
				DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance instance = new DescribeCloudCenterInstancesResponse.DescribeCloudCenterInstances_Instance();
				instance.InternetIp = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InternetIp");
				instance.Os = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Os");
				instance.InstanceId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].InstanceName");
				instance.RegionName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionName");
				instance.Ip = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Ip");
				instance.ClientStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClientStatus");
				instance.Region = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Region");
				instance.Uuid = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Uuid");
				instance.IntranetIp = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].IntranetIp");
				instance.AssetType = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AssetType");
				instance.Status = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Status");
				instance.Tag = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].Tag");
				instance.VpcInstanceId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VpcInstanceId");
				instance.OsName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].OsName");
				instance.Flag = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Flag");
				instance.HcStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].HcStatus");
				instance.VulStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VulStatus");
				instance.AlarmStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].AlarmStatus");
				instance.RiskStatus = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RiskStatus");
				instance.HealthCheckCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].HealthCheckCount");
				instance.VulCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].VulCount");
				instance.SafeEventCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].SafeEventCount");
				instance.RegionId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RegionId");
				instance.GroupId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].GroupId");
				instance.Importance = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Importance");
				instance.ClientVersion = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClientVersion");
				instance.RiskCount = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].RiskCount");
				instance.ClusterId = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClusterId");
				instance.ClusterName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].ClusterName");
				instance.CreatedTime = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].CreatedTime");
				instance.PodCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].PodCount");
				instance.ExposedStatus = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].ExposedStatus");
				instance.AutoSnapshotsLevel = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].AutoSnapshotsLevel");
				instance.ExposedCount = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].ExposedCount");
				instance.Vendor = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Vendor");
				instance.VendorName = _ctx.StringValue("DescribeCloudCenterInstances.Instances["+ i +"].VendorName");
				instance.Cores = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].Cores");
				instance.AuthVersion = _ctx.IntegerValue("DescribeCloudCenterInstances.Instances["+ i +"].AuthVersion");
				instance.Bind = _ctx.BooleanValue("DescribeCloudCenterInstances.Instances["+ i +"].Bind");
				instance.AuthModifyTime = _ctx.LongValue("DescribeCloudCenterInstances.Instances["+ i +"].AuthModifyTime");

				describeCloudCenterInstancesResponse_instances.Add(instance);
			}
			describeCloudCenterInstancesResponse.Instances = describeCloudCenterInstancesResponse_instances;
        
			return describeCloudCenterInstancesResponse;
        }
    }
}
