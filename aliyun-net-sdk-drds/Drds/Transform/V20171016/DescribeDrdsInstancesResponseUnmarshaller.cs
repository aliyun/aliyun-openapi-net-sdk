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
using Aliyun.Acs.Drds.Model.V20171016;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsInstancesResponseUnmarshaller
    {
        public static DescribeDrdsInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsInstancesResponse describeDrdsInstancesResponse = new DescribeDrdsInstancesResponse();

			describeDrdsInstancesResponse.HttpResponse = context.HttpResponse;
			describeDrdsInstancesResponse.RequestId = context.StringValue("DescribeDrdsInstances.RequestId");
			describeDrdsInstancesResponse.Success = context.BooleanValue("DescribeDrdsInstances.Success");

			List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance> describeDrdsInstancesResponse_data = new List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeDrdsInstances.Data.Length"); i++) {
				DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance instance = new DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance();
				instance.DrdsInstanceId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].DrdsInstanceId");
				instance.Type = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Type");
				instance.RegionId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].ZoneId");
				instance.Description = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Description");
				instance.NetworkType = context.StringValue("DescribeDrdsInstances.Data["+ i +"].NetworkType");
				instance.Status = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Status");
				instance.CreateTime = context.LongValue("DescribeDrdsInstances.Data["+ i +"].CreateTime");
				instance.Version = context.LongValue("DescribeDrdsInstances.Data["+ i +"].Version");
				instance.VpcCloudInstanceId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].VpcCloudInstanceId");

				List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip> instance_vips = new List<DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip>();
				for (int j = 0; j < context.Length("DescribeDrdsInstances.Data["+ i +"].Vips.Length"); j++) {
					DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip vip = new DescribeDrdsInstancesResponse.DescribeDrdsInstances_Instance.DescribeDrdsInstances_Vip();
					vip.IP = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Vips["+ j +"].IP");
					vip.Port = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Vips["+ j +"].Port");
					vip.Type = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Vips["+ j +"].Type");
					vip.VpcId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Vips["+ j +"].VpcId");
					vip.VswitchId = context.StringValue("DescribeDrdsInstances.Data["+ i +"].Vips["+ j +"].VswitchId");

					instance_vips.Add(vip);
				}
				instance.Vips = instance_vips;

				describeDrdsInstancesResponse_data.Add(instance);
			}
			describeDrdsInstancesResponse.Data = describeDrdsInstancesResponse_data;
        
			return describeDrdsInstancesResponse;
        }
    }
}
