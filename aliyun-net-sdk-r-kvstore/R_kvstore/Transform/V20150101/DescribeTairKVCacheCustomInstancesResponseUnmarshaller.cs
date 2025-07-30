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
    public class DescribeTairKVCacheCustomInstancesResponseUnmarshaller
    {
        public static DescribeTairKVCacheCustomInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTairKVCacheCustomInstancesResponse describeTairKVCacheCustomInstancesResponse = new DescribeTairKVCacheCustomInstancesResponse();

			describeTairKVCacheCustomInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeTairKVCacheCustomInstancesResponse.RequestId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.RequestId");
			describeTairKVCacheCustomInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeTairKVCacheCustomInstances.PageNumber");
			describeTairKVCacheCustomInstancesResponse.PageSize = _ctx.IntegerValue("DescribeTairKVCacheCustomInstances.PageSize");
			describeTairKVCacheCustomInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeTairKVCacheCustomInstances.TotalCount");

			List<DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance> describeTairKVCacheCustomInstancesResponse_instances = new List<DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance>();
			for (int i = 0; i < _ctx.Length("DescribeTairKVCacheCustomInstances.Instances.Length"); i++) {
				DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance kVStoreInstance = new DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance();
				kVStoreInstance.VpcId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].VpcId");
				kVStoreInstance.CreateTime = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].CreateTime");
				kVStoreInstance.ChargeType = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].ChargeType");
				kVStoreInstance.NetworkType = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].NetworkType");
				kVStoreInstance.InstanceName = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].InstanceName");
				kVStoreInstance.InstanceClass = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].InstanceClass");
				kVStoreInstance.DestroyTime = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].DestroyTime");
				kVStoreInstance.InstanceId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].InstanceId");
				kVStoreInstance.InstanceType = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].InstanceType");
				kVStoreInstance.RegionId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].RegionId");
				kVStoreInstance.EndTime = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].EndTime");
				kVStoreInstance.VSwitchId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].VSwitchId");
				kVStoreInstance.ResourceGroupId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].ResourceGroupId");
				kVStoreInstance.ZoneId = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].ZoneId");
				kVStoreInstance.InstanceStatus = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].InstanceStatus");
				kVStoreInstance.Storage = _ctx.LongValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].Storage");
				kVStoreInstance.StorageType = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].StorageType");
				kVStoreInstance.PrivateIp = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].PrivateIp");
				kVStoreInstance.UseEni = _ctx.BooleanValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].UseEni");

				List<DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance.DescribeTairKVCacheCustomInstances_Tag> kVStoreInstance_tags = new List<DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance.DescribeTairKVCacheCustomInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeTairKVCacheCustomInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance.DescribeTairKVCacheCustomInstances_Tag tag = new DescribeTairKVCacheCustomInstancesResponse.DescribeTairKVCacheCustomInstances_KVStoreInstance.DescribeTairKVCacheCustomInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeTairKVCacheCustomInstances.Instances["+ i +"].Tags["+ j +"].Value");

					kVStoreInstance_tags.Add(tag);
				}
				kVStoreInstance.Tags = kVStoreInstance_tags;

				describeTairKVCacheCustomInstancesResponse_instances.Add(kVStoreInstance);
			}
			describeTairKVCacheCustomInstancesResponse.Instances = describeTairKVCacheCustomInstancesResponse_instances;
        
			return describeTairKVCacheCustomInstancesResponse;
        }
    }
}
