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
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.TotalCount = _ctx.LongValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.VpcId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				instance.Status = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Status");
				instance.ModuleId = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].ModuleId");
				instance.VswitchId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VswitchId");
				instance.BackupStatus = _ctx.StringValue("DescribeInstances.Instances["+ i +"].BackupStatus");
				instance.PayType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].PayType");
				instance.CoreDiskType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CoreDiskType");
				instance.MasterNodeCount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].MasterNodeCount");
				instance.NetworkType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkType");
				instance.CreatedTimeUTC = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreatedTimeUTC");
				instance.ParentId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ParentId");
				instance.ExpireTimeUTC = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ExpireTimeUTC");
				instance.InstanceName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				instance.MasterInstanceType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MasterInstanceType");
				instance.CoreInstanceType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CoreInstanceType");
				instance.CreatedTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreatedTime");
				instance.CoreDiskSize = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].CoreDiskSize");
				instance.ClusterId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ClusterId");
				instance.ExpireTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ExpireTime");
				instance.IsHa = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].IsHa");
				instance.InstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.ColdStorageStatus = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ColdStorageStatus");
				instance.IsDeletionProtection = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].IsDeletionProtection");
				instance.RegionId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.MasterDiskSize = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].MasterDiskSize");
				instance.MasterDiskType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MasterDiskType");
				instance.AutoRenewal = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].AutoRenewal");
				instance.ClusterType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ClusterType");
				instance.ResourceGroupId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				instance.ClusterName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ClusterName");
				instance.ZoneId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.Duration = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Duration");
				instance.ModuleStackVersion = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ModuleStackVersion");
				instance.Engine = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Engine");
				instance.MajorVersion = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MajorVersion");
				instance.CoreDiskCount = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CoreDiskCount");
				instance.CoreNodeCount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].CoreNodeCount");

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag> instance_tags = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Value");

					instance_tags.Add(tag);
				}
				instance.Tags = instance_tags;

				describeInstancesResponse_instances.Add(instance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
