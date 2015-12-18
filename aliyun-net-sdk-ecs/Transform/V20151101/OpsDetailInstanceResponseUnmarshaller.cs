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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDetailInstanceResponseUnmarshaller
    {
        public static OpsDetailInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDetailInstanceResponse opsDetailInstanceResponse = new OpsDetailInstanceResponse();

			opsDetailInstanceResponse.HttpResponse = context.HttpResponse;
			opsDetailInstanceResponse.RequestId = context.StringValue("OpsDetailInstance.RequestId");
			opsDetailInstanceResponse.RegionNo = context.StringValue("OpsDetailInstance.RegionNo");
			opsDetailInstanceResponse.IzNo = context.StringValue("OpsDetailInstance.IzNo");
			opsDetailInstanceResponse.ZoneNo = context.StringValue("OpsDetailInstance.ZoneNo");
			opsDetailInstanceResponse.EcsInstanceId = context.StringValue("OpsDetailInstance.EcsInstanceId");
			opsDetailInstanceResponse.AliUid = context.StringValue("OpsDetailInstance.AliUid");
			opsDetailInstanceResponse.Hostname = context.StringValue("OpsDetailInstance.Hostname");
			opsDetailInstanceResponse.EcsInstanceName = context.StringValue("OpsDetailInstance.EcsInstanceName");
			opsDetailInstanceResponse.Description = context.StringValue("OpsDetailInstance.Description");
			opsDetailInstanceResponse.Status = context.StringValue("OpsDetailInstance.Status");
			opsDetailInstanceResponse.BusinessStatus = context.EnumValue<OpsDetailInstanceResponse.BusinessStatusEnum>("OpsDetailInstance.BusinessStatus");
			opsDetailInstanceResponse.HouyiStatus = context.StringValue("OpsDetailInstance.HouyiStatus");
			opsDetailInstanceResponse.PrivateIpAddress = context.StringValue("OpsDetailInstance.PrivateIpAddress");
			opsDetailInstanceResponse.PublicIpAddress = context.StringValue("OpsDetailInstance.PublicIpAddress");
			opsDetailInstanceResponse.ImageId = context.StringValue("OpsDetailInstance.ImageId");
			opsDetailInstanceResponse.ImageName = context.StringValue("OpsDetailInstance.ImageName");
			opsDetailInstanceResponse.Cores = context.IntegerValue("OpsDetailInstance.Cores");
			opsDetailInstanceResponse.Mem = context.IntegerValue("OpsDetailInstance.Mem");
			opsDetailInstanceResponse.IntranetRx = context.IntegerValue("OpsDetailInstance.IntranetRx");
			opsDetailInstanceResponse.IntranetTx = context.IntegerValue("OpsDetailInstance.IntranetTx");
			opsDetailInstanceResponse.InternetRx = context.IntegerValue("OpsDetailInstance.InternetRx");
			opsDetailInstanceResponse.InternetTx = context.IntegerValue("OpsDetailInstance.InternetTx");
			opsDetailInstanceResponse.SecurityControl = context.StringValue("OpsDetailInstance.SecurityControl");
			opsDetailInstanceResponse.SystemDeviceCategory = context.StringValue("OpsDetailInstance.SystemDeviceCategory");
			opsDetailInstanceResponse.CreatedTime = context.StringValue("OpsDetailInstance.CreatedTime");
			opsDetailInstanceResponse.VpcId = context.StringValue("OpsDetailInstance.VpcId");
			opsDetailInstanceResponse.VswId = context.StringValue("OpsDetailInstance.VswId");
			opsDetailInstanceResponse.NatIp = context.StringValue("OpsDetailInstance.NatIp");
			opsDetailInstanceResponse.Eip = context.StringValue("OpsDetailInstance.Eip");
			opsDetailInstanceResponse.EipId = context.StringValue("OpsDetailInstance.EipId");
			opsDetailInstanceResponse.EipBandwidth = context.IntegerValue("OpsDetailInstance.EipBandwidth");
			opsDetailInstanceResponse.NetWorkType = context.StringValue("OpsDetailInstance.NetWorkType");
			opsDetailInstanceResponse.NetworkValidation = context.BooleanValue("OpsDetailInstance.NetworkValidation");
			opsDetailInstanceResponse.IoOptimized = context.BooleanValue("OpsDetailInstance.IoOptimized");
			opsDetailInstanceResponse.MountAvailable = context.BooleanValue("OpsDetailInstance.MountAvailable");
			opsDetailInstanceResponse.VlanId = context.StringValue("OpsDetailInstance.VlanId");
			opsDetailInstanceResponse.NcId = context.StringValue("OpsDetailInstance.NcId");
			opsDetailInstanceResponse.RackId = context.StringValue("OpsDetailInstance.RackId");

			List<string> groupIds = new List<string>();
			for (int i = 0; i < context.Length("OpsDetailInstance.GroupIds.Length"); i++) {
				groupIds.Add(context.StringValue("OpsDetailInstance.GroupIds["+ i +"]"));
			}
			opsDetailInstanceResponse.GroupIds = groupIds;
        
			return opsDetailInstanceResponse;
        }
    }
}