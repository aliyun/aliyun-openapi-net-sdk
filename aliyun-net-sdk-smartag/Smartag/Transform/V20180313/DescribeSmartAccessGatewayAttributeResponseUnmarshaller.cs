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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSmartAccessGatewayAttributeResponseUnmarshaller
    {
        public static DescribeSmartAccessGatewayAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSmartAccessGatewayAttributeResponse describeSmartAccessGatewayAttributeResponse = new DescribeSmartAccessGatewayAttributeResponse();

			describeSmartAccessGatewayAttributeResponse.HttpResponse = context.HttpResponse;
			describeSmartAccessGatewayAttributeResponse.RequestId = context.StringValue("DescribeSmartAccessGatewayAttribute.RequestId");
			describeSmartAccessGatewayAttributeResponse.SmartAGId = context.StringValue("DescribeSmartAccessGatewayAttribute.SmartAGId");
			describeSmartAccessGatewayAttributeResponse.Name = context.StringValue("DescribeSmartAccessGatewayAttribute.Name");
			describeSmartAccessGatewayAttributeResponse.City = context.StringValue("DescribeSmartAccessGatewayAttribute.City");
			describeSmartAccessGatewayAttributeResponse.MaxBandwidth = context.StringValue("DescribeSmartAccessGatewayAttribute.MaxBandwidth");
			describeSmartAccessGatewayAttributeResponse.Status = context.StringValue("DescribeSmartAccessGatewayAttribute.Status");
			describeSmartAccessGatewayAttributeResponse.CidrBlock = context.StringValue("DescribeSmartAccessGatewayAttribute.CidrBlock");
			describeSmartAccessGatewayAttributeResponse.AssociatedCcnId = context.StringValue("DescribeSmartAccessGatewayAttribute.AssociatedCcnId");
			describeSmartAccessGatewayAttributeResponse.AssociatedCcnName = context.StringValue("DescribeSmartAccessGatewayAttribute.AssociatedCcnName");
			describeSmartAccessGatewayAttributeResponse.Description = context.StringValue("DescribeSmartAccessGatewayAttribute.Description");
			describeSmartAccessGatewayAttributeResponse.CreateTime = context.LongValue("DescribeSmartAccessGatewayAttribute.CreateTime");
			describeSmartAccessGatewayAttributeResponse.EndTime = context.LongValue("DescribeSmartAccessGatewayAttribute.EndTime");
			describeSmartAccessGatewayAttributeResponse.InstanceType = context.StringValue("DescribeSmartAccessGatewayAttribute.InstanceType");
			describeSmartAccessGatewayAttributeResponse.SerialNumber = context.StringValue("DescribeSmartAccessGatewayAttribute.SerialNumber");
			describeSmartAccessGatewayAttributeResponse.SecurityLockThreshold = context.IntegerValue("DescribeSmartAccessGatewayAttribute.SecurityLockThreshold");
			describeSmartAccessGatewayAttributeResponse.DataPlan = context.LongValue("DescribeSmartAccessGatewayAttribute.DataPlan");
			describeSmartAccessGatewayAttributeResponse.UserCount = context.IntegerValue("DescribeSmartAccessGatewayAttribute.UserCount");
			describeSmartAccessGatewayAttributeResponse.RoutingStrategy = context.StringValue("DescribeSmartAccessGatewayAttribute.RoutingStrategy");
			describeSmartAccessGatewayAttributeResponse.IpsecStatus = context.StringValue("DescribeSmartAccessGatewayAttribute.IpsecStatus");
			describeSmartAccessGatewayAttributeResponse.VpnStatus = context.StringValue("DescribeSmartAccessGatewayAttribute.VpnStatus");
			describeSmartAccessGatewayAttributeResponse.TrafficMasterSn = context.StringValue("DescribeSmartAccessGatewayAttribute.TrafficMasterSn");
			describeSmartAccessGatewayAttributeResponse.BoxControllerIp = context.StringValue("DescribeSmartAccessGatewayAttribute.BoxControllerIp");
			describeSmartAccessGatewayAttributeResponse.BackupBoxControllerIp = context.StringValue("DescribeSmartAccessGatewayAttribute.BackupBoxControllerIp");
			describeSmartAccessGatewayAttributeResponse.UpBandwidthWan = context.IntegerValue("DescribeSmartAccessGatewayAttribute.UpBandwidthWan");
			describeSmartAccessGatewayAttributeResponse.UpBandwidth4G = context.IntegerValue("DescribeSmartAccessGatewayAttribute.UpBandwidth4G");
			describeSmartAccessGatewayAttributeResponse.EnableOptimization = context.BooleanValue("DescribeSmartAccessGatewayAttribute.EnableOptimization");
			describeSmartAccessGatewayAttributeResponse.OptimizationType = context.BooleanValue("DescribeSmartAccessGatewayAttribute.OptimizationType");
			describeSmartAccessGatewayAttributeResponse.ResourceGroupId = context.StringValue("DescribeSmartAccessGatewayAttribute.ResourceGroupId");

			List<string> describeSmartAccessGatewayAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayAttribute.AclIds.Length"); i++) {
				describeSmartAccessGatewayAttributeResponse_aclIds.Add(context.StringValue("DescribeSmartAccessGatewayAttribute.AclIds["+ i +"]"));
			}
			describeSmartAccessGatewayAttributeResponse.AclIds = describeSmartAccessGatewayAttributeResponse_aclIds;

			List<string> describeSmartAccessGatewayAttributeResponse_qosIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayAttribute.QosIds.Length"); i++) {
				describeSmartAccessGatewayAttributeResponse_qosIds.Add(context.StringValue("DescribeSmartAccessGatewayAttribute.QosIds["+ i +"]"));
			}
			describeSmartAccessGatewayAttributeResponse.QosIds = describeSmartAccessGatewayAttributeResponse_qosIds;

			List<string> describeSmartAccessGatewayAttributeResponse_flowLogIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayAttribute.FlowLogIds.Length"); i++) {
				describeSmartAccessGatewayAttributeResponse_flowLogIds.Add(context.StringValue("DescribeSmartAccessGatewayAttribute.FlowLogIds["+ i +"]"));
			}
			describeSmartAccessGatewayAttributeResponse.FlowLogIds = describeSmartAccessGatewayAttributeResponse_flowLogIds;

			List<DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Link> describeSmartAccessGatewayAttributeResponse_links = new List<DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Link>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayAttribute.Links.Length"); i++) {
				DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Link link = new DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Link();
				link.InstanceId = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].InstanceId");
				link.Type = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].Type");
				link.Status = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].Status");
				link.EndTime = context.LongValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].EndTime");
				link.Bandwidth = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].Bandwidth");
				link.RelateInstanceId = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].RelateInstanceId");
				link.RelateInstanceRegionId = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].RelateInstanceRegionId");
				link.CommodityType = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].CommodityType");
				link.HealthCheckTargetIp = context.StringValue("DescribeSmartAccessGatewayAttribute.Links["+ i +"].HealthCheckTargetIp");

				describeSmartAccessGatewayAttributeResponse_links.Add(link);
			}
			describeSmartAccessGatewayAttributeResponse.Links = describeSmartAccessGatewayAttributeResponse_links;

			List<DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Device> describeSmartAccessGatewayAttributeResponse_devices = new List<DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Device>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayAttribute.Devices.Length"); i++) {
				DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Device device = new DescribeSmartAccessGatewayAttributeResponse.DescribeSmartAccessGatewayAttribute_Device();
				device.SerialNumber = context.StringValue("DescribeSmartAccessGatewayAttribute.Devices["+ i +"].SerialNumber");
				device.HcState = context.StringValue("DescribeSmartAccessGatewayAttribute.Devices["+ i +"].HcState");
				device.HaState = context.StringValue("DescribeSmartAccessGatewayAttribute.Devices["+ i +"].HaState");
				device.SoftwareVersion = context.LongValue("DescribeSmartAccessGatewayAttribute.Devices["+ i +"].SoftwareVersion");
				device.MonitorVersion = context.StringValue("DescribeSmartAccessGatewayAttribute.Devices["+ i +"].MonitorVersion");

				describeSmartAccessGatewayAttributeResponse_devices.Add(device);
			}
			describeSmartAccessGatewayAttributeResponse.Devices = describeSmartAccessGatewayAttributeResponse_devices;
        
			return describeSmartAccessGatewayAttributeResponse;
        }
    }
}
