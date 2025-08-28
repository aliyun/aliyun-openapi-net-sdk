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
    public class DescribeTairKVCacheInferInstancesResponseUnmarshaller
    {
        public static DescribeTairKVCacheInferInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTairKVCacheInferInstancesResponse describeTairKVCacheInferInstancesResponse = new DescribeTairKVCacheInferInstancesResponse();

			describeTairKVCacheInferInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeTairKVCacheInferInstancesResponse.RequestId = _ctx.StringValue("DescribeTairKVCacheInferInstances.RequestId");
			describeTairKVCacheInferInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.PageNumber");
			describeTairKVCacheInferInstancesResponse.PageSize = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.PageSize");
			describeTairKVCacheInferInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.TotalCount");

			List<DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO> describeTairKVCacheInferInstancesResponse_instances = new List<DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO>();
			for (int i = 0; i < _ctx.Length("DescribeTairKVCacheInferInstances.Instances.Length"); i++) {
				DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO tairInferInstanceDTO = new DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO();
				tairInferInstanceDTO.VpcId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].VpcId");
				tairInferInstanceDTO.CreateTime = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].CreateTime");
				tairInferInstanceDTO.ChargeType = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].ChargeType");
				tairInferInstanceDTO.NetworkType = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].NetworkType");
				tairInferInstanceDTO.InstanceName = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].InstanceName");
				tairInferInstanceDTO.InstanceClass = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].InstanceClass");
				tairInferInstanceDTO.DestroyTime = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].DestroyTime");
				tairInferInstanceDTO.InstanceId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].InstanceId");
				tairInferInstanceDTO.InstanceType = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].InstanceType");
				tairInferInstanceDTO.RegionId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].RegionId");
				tairInferInstanceDTO.EndTime = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].EndTime");
				tairInferInstanceDTO.VSwitchId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].VSwitchId");
				tairInferInstanceDTO.ResourceGroupId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].ResourceGroupId");
				tairInferInstanceDTO.ZoneId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].ZoneId");
				tairInferInstanceDTO.InstanceStatus = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].InstanceStatus");
				tairInferInstanceDTO.PrivateIp = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].PrivateIp");
				tairInferInstanceDTO.Capacity = _ctx.LongValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].Capacity");
				tairInferInstanceDTO.Model = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].Model");
				tairInferInstanceDTO.ModelServiceNum = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].ModelServiceNum");
				tairInferInstanceDTO.ComputeUnitNum = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].ComputeUnitNum");
				tairInferInstanceDTO.VNodeName = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].VNodeName");
				tairInferInstanceDTO.AckId = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].AckId");
				tairInferInstanceDTO.VNodeCount = _ctx.IntegerValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].VNodeCount");

				List<DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO.DescribeTairKVCacheInferInstances_Tag> tairInferInstanceDTO_tags = new List<DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO.DescribeTairKVCacheInferInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeTairKVCacheInferInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO.DescribeTairKVCacheInferInstances_Tag tag = new DescribeTairKVCacheInferInstancesResponse.DescribeTairKVCacheInferInstances_TairInferInstanceDTO.DescribeTairKVCacheInferInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeTairKVCacheInferInstances.Instances["+ i +"].Tags["+ j +"].Value");

					tairInferInstanceDTO_tags.Add(tag);
				}
				tairInferInstanceDTO.Tags = tairInferInstanceDTO_tags;

				describeTairKVCacheInferInstancesResponse_instances.Add(tairInferInstanceDTO);
			}
			describeTairKVCacheInferInstancesResponse.Instances = describeTairKVCacheInferInstancesResponse_instances;
        
			return describeTairKVCacheInferInstancesResponse;
        }
    }
}
