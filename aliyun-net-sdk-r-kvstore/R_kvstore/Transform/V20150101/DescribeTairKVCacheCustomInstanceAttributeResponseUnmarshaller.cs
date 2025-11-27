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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeTairKVCacheCustomInstanceAttributeResponseUnmarshaller
    {
        public static DescribeTairKVCacheCustomInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTairKVCacheCustomInstanceAttributeResponse describeTairKVCacheCustomInstanceAttributeResponse = new DescribeTairKVCacheCustomInstanceAttributeResponse();

			describeTairKVCacheCustomInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeTairKVCacheCustomInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.RequestId");
			describeTairKVCacheCustomInstanceAttributeResponse.VpcId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.VpcId");
			describeTairKVCacheCustomInstanceAttributeResponse.PrivateIp = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.PrivateIp");
			describeTairKVCacheCustomInstanceAttributeResponse.CreateTime = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.CreateTime");
			describeTairKVCacheCustomInstanceAttributeResponse.ChargeType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ChargeType");
			describeTairKVCacheCustomInstanceAttributeResponse.StorageType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.StorageType");
			describeTairKVCacheCustomInstanceAttributeResponse.ArchitectureType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ArchitectureType");
			describeTairKVCacheCustomInstanceAttributeResponse.NetworkType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.NetworkType");
			describeTairKVCacheCustomInstanceAttributeResponse.InstanceName = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.InstanceName");
			describeTairKVCacheCustomInstanceAttributeResponse.ZoneType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ZoneType");
			describeTairKVCacheCustomInstanceAttributeResponse.InstanceClass = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.InstanceClass");
			describeTairKVCacheCustomInstanceAttributeResponse.InstanceId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.InstanceId");
			describeTairKVCacheCustomInstanceAttributeResponse.InstanceType = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.InstanceType");
			describeTairKVCacheCustomInstanceAttributeResponse.RegionId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.RegionId");
			describeTairKVCacheCustomInstanceAttributeResponse.EndTime = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.EndTime");
			describeTairKVCacheCustomInstanceAttributeResponse.VSwitchId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.VSwitchId");
			describeTairKVCacheCustomInstanceAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ResourceGroupId");
			describeTairKVCacheCustomInstanceAttributeResponse.ZoneId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ZoneId");
			describeTairKVCacheCustomInstanceAttributeResponse.InstanceStatus = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.InstanceStatus");
			describeTairKVCacheCustomInstanceAttributeResponse.Storage = _ctx.LongValue("DescribeTairKVCacheCustomInstanceAttribute.Storage");
			describeTairKVCacheCustomInstanceAttributeResponse.IsOrderCompleted = _ctx.BooleanValue("DescribeTairKVCacheCustomInstanceAttribute.IsOrderCompleted");
			describeTairKVCacheCustomInstanceAttributeResponse.ImageId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.ImageId");
			describeTairKVCacheCustomInstanceAttributeResponse.Cpu = _ctx.LongValue("DescribeTairKVCacheCustomInstanceAttribute.Cpu");
			describeTairKVCacheCustomInstanceAttributeResponse.Memory = _ctx.LongValue("DescribeTairKVCacheCustomInstanceAttribute.Memory");
			describeTairKVCacheCustomInstanceAttributeResponse.SecurityGroupId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.SecurityGroupId");
			describeTairKVCacheCustomInstanceAttributeResponse.UseEni = _ctx.BooleanValue("DescribeTairKVCacheCustomInstanceAttribute.UseEni");

			List<DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Tag> describeTairKVCacheCustomInstanceAttributeResponse_tags = new List<DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeTairKVCacheCustomInstanceAttribute.Tags.Length"); i++) {
				DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Tag tag = new DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Tag();
				tag.Key = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.Tags["+ i +"].Value");

				describeTairKVCacheCustomInstanceAttributeResponse_tags.Add(tag);
			}
			describeTairKVCacheCustomInstanceAttributeResponse.Tags = describeTairKVCacheCustomInstanceAttributeResponse_tags;

			List<DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Disk> describeTairKVCacheCustomInstanceAttributeResponse_disks = new List<DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Disk>();
			for (int i = 0; i < _ctx.Length("DescribeTairKVCacheCustomInstanceAttribute.Disks.Length"); i++) {
				DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Disk disk = new DescribeTairKVCacheCustomInstanceAttributeResponse.DescribeTairKVCacheCustomInstanceAttribute_Disk();
				disk.DiskId = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.Disks["+ i +"].DiskId");
				disk.Type = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.Disks["+ i +"].Type");
				disk.Size = _ctx.StringValue("DescribeTairKVCacheCustomInstanceAttribute.Disks["+ i +"].Size");

				describeTairKVCacheCustomInstanceAttributeResponse_disks.Add(disk);
			}
			describeTairKVCacheCustomInstanceAttributeResponse.Disks = describeTairKVCacheCustomInstanceAttributeResponse_disks;
        
			return describeTairKVCacheCustomInstanceAttributeResponse;
        }
    }
}
