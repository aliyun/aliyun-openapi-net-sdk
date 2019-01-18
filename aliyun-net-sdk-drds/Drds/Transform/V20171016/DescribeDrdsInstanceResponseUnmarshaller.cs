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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsInstanceResponseUnmarshaller
    {
        public static DescribeDrdsInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsInstanceResponse describeDrdsInstanceResponse = new DescribeDrdsInstanceResponse();

			describeDrdsInstanceResponse.HttpResponse = context.HttpResponse;
			describeDrdsInstanceResponse.RequestId = context.StringValue("DescribeDrdsInstance.RequestId");
			describeDrdsInstanceResponse.Success = context.BooleanValue("DescribeDrdsInstance.Success");

			DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data data = new DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data();
			data.DrdsInstanceId = context.StringValue("DescribeDrdsInstance.Data.DrdsInstanceId");
			data.Type = context.StringValue("DescribeDrdsInstance.Data.Type");
			data.RegionId = context.StringValue("DescribeDrdsInstance.Data.RegionId");
			data.ZoneId = context.StringValue("DescribeDrdsInstance.Data.ZoneId");
			data.Description = context.StringValue("DescribeDrdsInstance.Data.Description");
			data.NetworkType = context.StringValue("DescribeDrdsInstance.Data.NetworkType");
			data.Status = context.StringValue("DescribeDrdsInstance.Data.Status");
			data.CreateTime = context.LongValue("DescribeDrdsInstance.Data.CreateTime");
			data.Version = context.LongValue("DescribeDrdsInstance.Data.Version");
			data.Specification = context.StringValue("DescribeDrdsInstance.Data.Specification");
			data.VpcCloudInstanceId = context.StringValue("DescribeDrdsInstance.Data.VpcCloudInstanceId");

			List<DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip> data_vips = new List<DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip>();
			for (int i = 0; i < context.Length("DescribeDrdsInstance.Data.Vips.Length"); i++) {
				DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip vip = new DescribeDrdsInstanceResponse.DescribeDrdsInstance_Data.DescribeDrdsInstance_Vip();
				vip.IP = context.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].IP");
				vip.Port = context.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].Port");
				vip.Type = context.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].Type");
				vip.VpcId = context.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].VpcId");
				vip.VswitchId = context.StringValue("DescribeDrdsInstance.Data.Vips["+ i +"].VswitchId");

				data_vips.Add(vip);
			}
			data.Vips = data_vips;
			describeDrdsInstanceResponse.Data = data;
        
			return describeDrdsInstanceResponse;
        }
    }
}