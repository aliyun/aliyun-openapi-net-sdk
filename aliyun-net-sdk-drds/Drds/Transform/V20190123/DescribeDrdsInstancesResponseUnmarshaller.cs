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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsInstancesResponseUnmarshaller
    {
        public static DescribeDrdsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsInstancesResponse describeDrdsInstancesResponse = new DescribeDrdsInstancesResponse();

			describeDrdsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsInstancesResponse.RequestId = _ctx.StringValue("DescribeDrdsInstances.RequestId");
			describeDrdsInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDrdsInstances.PageNumber");
			describeDrdsInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDrdsInstances.PageSize");
			describeDrdsInstancesResponse.Total = _ctx.IntegerValue("DescribeDrdsInstances.Total");

			List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance> describeDrdsInstancesResponse_instances = new List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsInstances.Instances.Length"); i++) {
				DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance instance = new DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance();
				instance.DrdsInstanceId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].DrdsInstanceId");
				instance.Type = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Type");
				instance.RegionId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].ZoneId");
				instance.Description = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Description");
				instance.NetworkType = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].NetworkType");
				instance.Status = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Status");
				instance.CreateTime = _ctx.LongValue("DescribeDrdsInstances.Instances["+ i +"].CreateTime");
				instance.Version = _ctx.LongValue("DescribeDrdsInstances.Instances["+ i +"].Version");
				instance.CommodityCode = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].CommodityCode");
				instance.InstRole = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].InstRole");
				instance.InstanceSeries = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].InstanceSeries");
				instance.InstanceSpec = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].InstanceSpec");
				instance.MasterInstanceId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].MasterInstanceId");
				instance.VpcCloudInstanceId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].VpcCloudInstanceId");
				instance.VpcId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].VpcId");
				instance.ExpireDate = _ctx.LongValue("DescribeDrdsInstances.Instances["+ i +"].ExpireDate");
				instance.VersionAction = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].VersionAction");
				instance.Label = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Label");
				instance.MachineType = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].MachineType");
				instance.OrderInstanceId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].OrderInstanceId");
				instance.ResourceGroupId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].ResourceGroupId");
				instance.ProductVersion = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].ProductVersion");

				List<string> instance_readOnlyDBInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDrdsInstances.Instances["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					instance_readOnlyDBInstanceIds.Add(_ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].ReadOnlyDBInstanceIds["+ j +"]"));
				}
				instance.ReadOnlyDBInstanceIds = instance_readOnlyDBInstanceIds;

				List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip> instance_vips = new List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip>();
				for (int j = 0; j < _ctx.Length("DescribeDrdsInstances.Instances["+ i +"].Vips.Length"); j++) {
					DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip vip = new DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip();
					vip.IP = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Vips["+ j +"].IP");
					vip.Port = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Vips["+ j +"].Port");
					vip.Type = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Vips["+ j +"].Type");
					vip.VpcId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Vips["+ j +"].VpcId");
					vip.VswitchId = _ctx.StringValue("DescribeDrdsInstances.Instances["+ i +"].Vips["+ j +"].VswitchId");

					instance_vips.Add(vip);
				}
				instance.Vips = instance_vips;

				describeDrdsInstancesResponse_instances.Add(instance);
			}
			describeDrdsInstancesResponse.Instances = describeDrdsInstancesResponse_instances;
        
			return describeDrdsInstancesResponse;
        }
    }
}
