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
    public class DescribeDrdsInstanceResponseUnmarshaller
    {
        public static DescribeDrdsInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsInstanceResponse describeDrdsInstanceResponse = new DescribeDrdsInstanceResponse();

			describeDrdsInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsInstanceResponse.Success = _ctx.BooleanValue("DescribeDrdsInstance.Success");
			describeDrdsInstanceResponse.RequestId = _ctx.StringValue("DescribeDrdsInstance.RequestId");

			DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data data = new DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data();
			data.Type = _ctx.StringValue("DescribeDrdsInstance.Data.Type");
			data.Status = _ctx.StringValue("DescribeDrdsInstance.Data.Status");
			data.CreateTime = _ctx.LongValue("DescribeDrdsInstance.Data.CreateTime");
			data.VersionAction = _ctx.StringValue("DescribeDrdsInstance.Data.VersionAction");
			data.StorageType = _ctx.StringValue("DescribeDrdsInstance.Data.StorageType");
			data.NetworkType = _ctx.StringValue("DescribeDrdsInstance.Data.NetworkType");
			data.Label = _ctx.StringValue("DescribeDrdsInstance.Data.Label");
			data.MysqlVersion = _ctx.IntegerValue("DescribeDrdsInstance.Data.MysqlVersion");
			data.InstanceSpec = _ctx.StringValue("DescribeDrdsInstance.Data.InstanceSpec");
			data.VpcCloudInstanceId = _ctx.StringValue("DescribeDrdsInstance.Data.VpcCloudInstanceId");
			data.Description = _ctx.StringValue("DescribeDrdsInstance.Data.Description");
			data.Version = _ctx.LongValue("DescribeDrdsInstance.Data.Version");
			data.ExpireDate = _ctx.LongValue("DescribeDrdsInstance.Data.ExpireDate");
			data.MasterInstanceId = _ctx.StringValue("DescribeDrdsInstance.Data.MasterInstanceId");
			data.CommodityCode = _ctx.StringValue("DescribeDrdsInstance.Data.CommodityCode");
			data.MachineType = _ctx.StringValue("DescribeDrdsInstance.Data.MachineType");
			data.InstanceSeries = _ctx.StringValue("DescribeDrdsInstance.Data.InstanceSeries");
			data.ProductVersion = _ctx.StringValue("DescribeDrdsInstance.Data.ProductVersion");
			data.RegionId = _ctx.StringValue("DescribeDrdsInstance.Data.RegionId");
			data.ResourceGroupId = _ctx.StringValue("DescribeDrdsInstance.Data.ResourceGroupId");
			data.DrdsInstanceId = _ctx.StringValue("DescribeDrdsInstance.Data.DrdsInstanceId");
			data.ZoneId = _ctx.StringValue("DescribeDrdsInstance.Data.ZoneId");
			data.InstRole = _ctx.StringValue("DescribeDrdsInstance.Data.InstRole");
			data.OrderInstanceId = _ctx.StringValue("DescribeDrdsInstance.Data.OrderInstanceId");

			List<string> data_readOnlyDBInstanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsInstance.Data.ReadOnlyDBInstanceIds.Length"); i++) {
				data_readOnlyDBInstanceIds.Add(_ctx.StringValue("DescribeDrdsInstance.Data.ReadOnlyDBInstanceIds["+ i +"]"));
			}
			data.ReadOnlyDBInstanceIds = data_readOnlyDBInstanceIds;

			List<DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip> data_vips = new List<DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsInstance.Data.Vips.Length"); i++) {
				DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip vip = new DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip();
				vip.Type = _ctx.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].Type");
				vip.VpcId = _ctx.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].VpcId");
				vip.VswitchId = _ctx.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].VswitchId");
				vip.Dns = _ctx.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].Dns");
				vip.Port = _ctx.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].Port");
				vip.ExpireDays = _ctx.LongValue("DescribeDrdsInstance.Data.Vips["+ i +"].ExpireDays");
				vip.RemoveWeight = _ctx.BooleanValue("DescribeDrdsInstance.Data.Vips["+ i +"].RemoveWeight");

				data_vips.Add(vip);
			}
			data.Vips = data_vips;
			describeDrdsInstanceResponse.Data = data;
        
			return describeDrdsInstanceResponse;
        }
    }
}
