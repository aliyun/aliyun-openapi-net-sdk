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
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.TotalCount = context.LongValue("DescribeInstances.TotalCount");
			describeInstancesResponse.PageNumber = context.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = context.IntegerValue("DescribeInstances.PageSize");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				instance.Status = context.StringValue("DescribeInstances.Instances["+ i +"].Status");
				instance.PayType = context.StringValue("DescribeInstances.Instances["+ i +"].PayType");
				instance.CreatedTime = context.StringValue("DescribeInstances.Instances["+ i +"].CreatedTime");
				instance.ExpireTime = context.StringValue("DescribeInstances.Instances["+ i +"].ExpireTime");
				instance.MajorVersion = context.StringValue("DescribeInstances.Instances["+ i +"].MajorVersion");
				instance.Engine = context.StringValue("DescribeInstances.Instances["+ i +"].Engine");
				instance.IsHa = context.BooleanValue("DescribeInstances.Instances["+ i +"].IsHa");
				instance.NetworkType = context.StringValue("DescribeInstances.Instances["+ i +"].NetworkType");
				instance.VpcId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				instance.VswitchId = context.StringValue("DescribeInstances.Instances["+ i +"].VswitchId");
				instance.MasterInstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].MasterInstanceType");
				instance.MasterNodeCount = context.IntegerValue("DescribeInstances.Instances["+ i +"].MasterNodeCount");
				instance.MasterDiskType = context.StringValue("DescribeInstances.Instances["+ i +"].MasterDiskType");
				instance.MasterDiskSize = context.IntegerValue("DescribeInstances.Instances["+ i +"].MasterDiskSize");
				instance.CoreInstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].CoreInstanceType");
				instance.CoreNodeCount = context.IntegerValue("DescribeInstances.Instances["+ i +"].CoreNodeCount");
				instance.CoreDiskType = context.StringValue("DescribeInstances.Instances["+ i +"].CoreDiskType");
				instance.CoreDiskSize = context.IntegerValue("DescribeInstances.Instances["+ i +"].CoreDiskSize");
				instance.RegionId = context.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.ColdStorageStatus = context.StringValue("DescribeInstances.Instances["+ i +"].ColdStorageStatus");
				instance.BackupStatus = context.StringValue("DescribeInstances.Instances["+ i +"].BackupStatus");
				instance.ClusterType = context.StringValue("DescribeInstances.Instances["+ i +"].ClusterType");
				instance.CreatedTimeUTC = context.StringValue("DescribeInstances.Instances["+ i +"].CreatedTimeUTC");
				instance.ExpireTimeUTC = context.StringValue("DescribeInstances.Instances["+ i +"].ExpireTimeUTC");
				instance.ClusterId = context.StringValue("DescribeInstances.Instances["+ i +"].ClusterId");
				instance.ClusterName = context.StringValue("DescribeInstances.Instances["+ i +"].ClusterName");
				instance.IsDeletionProtection = context.BooleanValue("DescribeInstances.Instances["+ i +"].IsDeletionProtection");

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag> instance_tags = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag();
					tag.Key = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Value");

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
