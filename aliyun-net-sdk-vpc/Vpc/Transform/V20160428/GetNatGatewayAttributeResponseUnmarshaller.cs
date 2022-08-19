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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class GetNatGatewayAttributeResponseUnmarshaller
    {
        public static GetNatGatewayAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNatGatewayAttributeResponse getNatGatewayAttributeResponse = new GetNatGatewayAttributeResponse();

			getNatGatewayAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getNatGatewayAttributeResponse.VpcId = _ctx.StringValue("GetNatGatewayAttribute.VpcId");
			getNatGatewayAttributeResponse.CreationTime = _ctx.StringValue("GetNatGatewayAttribute.CreationTime");
			getNatGatewayAttributeResponse.Status = _ctx.StringValue("GetNatGatewayAttribute.Status");
			getNatGatewayAttributeResponse.NatType = _ctx.StringValue("GetNatGatewayAttribute.NatType");
			getNatGatewayAttributeResponse.NetworkType = _ctx.StringValue("GetNatGatewayAttribute.NetworkType");
			getNatGatewayAttributeResponse.RegionId = _ctx.StringValue("GetNatGatewayAttribute.RegionId");
			getNatGatewayAttributeResponse.EcsMetricEnabled = _ctx.BooleanValue("GetNatGatewayAttribute.EcsMetricEnabled");
			getNatGatewayAttributeResponse.RequestId = _ctx.StringValue("GetNatGatewayAttribute.RequestId");
			getNatGatewayAttributeResponse.Description = _ctx.StringValue("GetNatGatewayAttribute.Description");
			getNatGatewayAttributeResponse.ExpiredTime = _ctx.StringValue("GetNatGatewayAttribute.ExpiredTime");
			getNatGatewayAttributeResponse.ResourceGroupId = _ctx.StringValue("GetNatGatewayAttribute.ResourceGroupId");
			getNatGatewayAttributeResponse.NatGatewayId = _ctx.StringValue("GetNatGatewayAttribute.NatGatewayId");
			getNatGatewayAttributeResponse.BusinessStatus = _ctx.StringValue("GetNatGatewayAttribute.BusinessStatus");
			getNatGatewayAttributeResponse.Name = _ctx.StringValue("GetNatGatewayAttribute.Name");
			getNatGatewayAttributeResponse.PrivateLinkEnabled = _ctx.BooleanValue("GetNatGatewayAttribute.PrivateLinkEnabled");
			getNatGatewayAttributeResponse.PrivateLinkMode = _ctx.StringValue("GetNatGatewayAttribute.PrivateLinkMode");

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_ForwardTable forwardTable = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_ForwardTable();
			forwardTable.ForwardTableId = _ctx.StringValue("GetNatGatewayAttribute.ForwardTable.ForwardTableId");
			forwardTable.ForwardEntryCount = _ctx.IntegerValue("GetNatGatewayAttribute.ForwardTable.ForwardEntryCount");
			getNatGatewayAttributeResponse.ForwardTable = forwardTable;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_SnatTable snatTable = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_SnatTable();
			snatTable.SnatEntryCount = _ctx.IntegerValue("GetNatGatewayAttribute.SnatTable.SnatEntryCount");
			snatTable.SnatTableId = _ctx.StringValue("GetNatGatewayAttribute.SnatTable.SnatTableId");
			getNatGatewayAttributeResponse.SnatTable = snatTable;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_FullNatTable fullNatTable = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_FullNatTable();
			fullNatTable.FullNatEntryCount = _ctx.LongValue("GetNatGatewayAttribute.FullNatTable.FullNatEntryCount");
			fullNatTable.FullNatTableId = _ctx.StringValue("GetNatGatewayAttribute.FullNatTable.FullNatTableId");
			getNatGatewayAttributeResponse.FullNatTable = fullNatTable;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_BillingConfig billingConfig = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_BillingConfig();
			billingConfig.InternetChargeType = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.InternetChargeType");
			billingConfig.AutoPay = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.AutoPay");
			billingConfig.Spec = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.Spec");
			billingConfig.InstanceChargeType = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.InstanceChargeType");
			getNatGatewayAttributeResponse.BillingConfig = billingConfig;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_PrivateInfo privateInfo = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_PrivateInfo();
			privateInfo.MaxBandwidth = _ctx.IntegerValue("GetNatGatewayAttribute.PrivateInfo.MaxBandwidth");
			privateInfo.VswitchId = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.VswitchId");
			privateInfo.PrivateIpAddress = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.PrivateIpAddress");
			privateInfo.IzNo = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.IzNo");
			privateInfo.EniInstanceId = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.EniInstanceId");
			getNatGatewayAttributeResponse.PrivateInfo = privateInfo;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_DeletionProtectionInfo deletionProtectionInfo = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_DeletionProtectionInfo();
			deletionProtectionInfo.Enabled = _ctx.BooleanValue("GetNatGatewayAttribute.DeletionProtectionInfo.Enabled");
			getNatGatewayAttributeResponse.DeletionProtectionInfo = deletionProtectionInfo;

			List<GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem> getNatGatewayAttributeResponse_ipList = new List<GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem>();
			for (int i = 0; i < _ctx.Length("GetNatGatewayAttribute.IpList.Length"); i++) {
				GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem ipListItem = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem();
				ipListItem.UsingStatus = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].UsingStatus");
				ipListItem.IpAddress = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].IpAddress");
				ipListItem.AllocationId = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].AllocationId");

				getNatGatewayAttributeResponse_ipList.Add(ipListItem);
			}
			getNatGatewayAttributeResponse.IpList = getNatGatewayAttributeResponse_ipList;
        
			return getNatGatewayAttributeResponse;
        }
    }
}
