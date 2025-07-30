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
    public class DescribeTairKVCacheInferInstanceAttributeResponseUnmarshaller
    {
        public static DescribeTairKVCacheInferInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTairKVCacheInferInstanceAttributeResponse describeTairKVCacheInferInstanceAttributeResponse = new DescribeTairKVCacheInferInstanceAttributeResponse();

			describeTairKVCacheInferInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeTairKVCacheInferInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.RequestId");

			List<DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute> describeTairKVCacheInferInstanceAttributeResponse_instances = new List<DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeTairKVCacheInferInstanceAttribute.Instances.Length"); i++) {
				DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.InstanceId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].InstanceId");
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].VSwitchId");
				dBInstanceAttribute.PrivateIp = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].PrivateIp");
				dBInstanceAttribute.ChargeType = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ChargeType");
				dBInstanceAttribute.CreateTime = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].CreateTime");
				dBInstanceAttribute.EndTime = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].EndTime");
				dBInstanceAttribute.ArchitectureType = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ArchitectureType");
				dBInstanceAttribute.NetworkType = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].NetworkType");
				dBInstanceAttribute.InstanceName = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].InstanceName");
				dBInstanceAttribute.InstanceClass = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].InstanceClass");
				dBInstanceAttribute.InstanceType = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].InstanceType");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ZoneId");
				dBInstanceAttribute.ZoneType = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ZoneType");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].RegionId");
				dBInstanceAttribute.Storage = _ctx.LongValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].Storage");
				dBInstanceAttribute.ResourceGroupId = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ResourceGroupId");
				dBInstanceAttribute.InstanceStatus = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].InstanceStatus");
				dBInstanceAttribute.IsOrderCompleted = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].IsOrderCompleted");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ConnectionString");
				dBInstanceAttribute.IsDelete = _ctx.IntegerValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].IsDelete");
				dBInstanceAttribute.Model = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].Model");
				dBInstanceAttribute.ModelServiceNum = _ctx.IntegerValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ModelServiceNum");
				dBInstanceAttribute.ComputeUnitNum = _ctx.IntegerValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].ComputeUnitNum");

				List<DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute.DescribeTairKVCacheInferInstanceAttribute_Tag> dBInstanceAttribute_tags = new List<DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute.DescribeTairKVCacheInferInstanceAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].Tags.Length"); j++) {
					DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute.DescribeTairKVCacheInferInstanceAttribute_Tag tag = new DescribeTairKVCacheInferInstanceAttributeResponse.DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute.DescribeTairKVCacheInferInstanceAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeTairKVCacheInferInstanceAttribute.Instances["+ i +"].Tags["+ j +"].Value");

					dBInstanceAttribute_tags.Add(tag);
				}
				dBInstanceAttribute.Tags = dBInstanceAttribute_tags;

				describeTairKVCacheInferInstanceAttributeResponse_instances.Add(dBInstanceAttribute);
			}
			describeTairKVCacheInferInstanceAttributeResponse.Instances = describeTairKVCacheInferInstanceAttributeResponse_instances;
        
			return describeTairKVCacheInferInstanceAttributeResponse;
        }
    }
}
