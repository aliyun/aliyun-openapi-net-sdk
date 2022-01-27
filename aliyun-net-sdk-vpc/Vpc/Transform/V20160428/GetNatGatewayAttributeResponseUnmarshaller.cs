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
			getNatGatewayAttributeResponse.RequestId = _ctx.StringValue("GetNatGatewayAttribute.RequestId");
			getNatGatewayAttributeResponse.Description = _ctx.StringValue("GetNatGatewayAttribute.Description");
			getNatGatewayAttributeResponse.NatType = _ctx.StringValue("GetNatGatewayAttribute.NatType");
			getNatGatewayAttributeResponse.EcsMetricEnabled = _ctx.BooleanValue("GetNatGatewayAttribute.EcsMetricEnabled");
			getNatGatewayAttributeResponse.VpcId = _ctx.StringValue("GetNatGatewayAttribute.VpcId");
			getNatGatewayAttributeResponse.NatGatewayId = _ctx.StringValue("GetNatGatewayAttribute.NatGatewayId");
			getNatGatewayAttributeResponse.CreationTime = _ctx.StringValue("GetNatGatewayAttribute.CreationTime");
			getNatGatewayAttributeResponse.ExpiredTime = _ctx.StringValue("GetNatGatewayAttribute.ExpiredTime");
			getNatGatewayAttributeResponse.Name = _ctx.StringValue("GetNatGatewayAttribute.Name");
			getNatGatewayAttributeResponse.Status = _ctx.StringValue("GetNatGatewayAttribute.Status");
			getNatGatewayAttributeResponse.BusinessStatus = _ctx.StringValue("GetNatGatewayAttribute.BusinessStatus");
			getNatGatewayAttributeResponse.RegionId = _ctx.StringValue("GetNatGatewayAttribute.RegionId");
			getNatGatewayAttributeResponse.ResourceGroupId = _ctx.StringValue("GetNatGatewayAttribute.ResourceGroupId");

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_ForwardTable forwardTable = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_ForwardTable();
			forwardTable.ForwardTableId = _ctx.StringValue("GetNatGatewayAttribute.ForwardTable.ForwardTableId");
			forwardTable.ForwardEntryCount = _ctx.IntegerValue("GetNatGatewayAttribute.ForwardTable.ForwardEntryCount");
			getNatGatewayAttributeResponse.ForwardTable = forwardTable;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_SnatTable snatTable = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_SnatTable();
			snatTable.SnatTableId = _ctx.StringValue("GetNatGatewayAttribute.SnatTable.SnatTableId");
			snatTable.SnatEntryCount = _ctx.IntegerValue("GetNatGatewayAttribute.SnatTable.SnatEntryCount");
			getNatGatewayAttributeResponse.SnatTable = snatTable;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_BillingConfig billingConfig = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_BillingConfig();
			billingConfig.Spec = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.Spec");
			billingConfig.InternetChargeType = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.InternetChargeType");
			billingConfig.InstanceChargeType = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.InstanceChargeType");
			billingConfig.AutoPay = _ctx.StringValue("GetNatGatewayAttribute.BillingConfig.AutoPay");
			getNatGatewayAttributeResponse.BillingConfig = billingConfig;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_PrivateInfo privateInfo = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_PrivateInfo();
			privateInfo.EniInstanceId = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.EniInstanceId");
			privateInfo.IzNo = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.IzNo");
			privateInfo.MaxBandwidth = _ctx.IntegerValue("GetNatGatewayAttribute.PrivateInfo.MaxBandwidth");
			privateInfo.PrivateIpAddress = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.PrivateIpAddress");
			privateInfo.VswitchId = _ctx.StringValue("GetNatGatewayAttribute.PrivateInfo.VswitchId");
			getNatGatewayAttributeResponse.PrivateInfo = privateInfo;

			GetNatGatewayAttributeResponse.GetNatGatewayAttribute_DeletionProtectionInfo deletionProtectionInfo = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_DeletionProtectionInfo();
			deletionProtectionInfo.Enabled = _ctx.BooleanValue("GetNatGatewayAttribute.DeletionProtectionInfo.Enabled");
			getNatGatewayAttributeResponse.DeletionProtectionInfo = deletionProtectionInfo;

			List<GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem> getNatGatewayAttributeResponse_ipList = new List<GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem>();
			for (int i = 0; i < _ctx.Length("GetNatGatewayAttribute.IpList.Length"); i++) {
				GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem ipListItem = new GetNatGatewayAttributeResponse.GetNatGatewayAttribute_IpListItem();
				ipListItem.IpAddress = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].IpAddress");
				ipListItem.AllocationId = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].AllocationId");
				ipListItem.UsingStatus = _ctx.StringValue("GetNatGatewayAttribute.IpList["+ i +"].UsingStatus");

				getNatGatewayAttributeResponse_ipList.Add(ipListItem);
			}
			getNatGatewayAttributeResponse.IpList = getNatGatewayAttributeResponse_ipList;
        
			return getNatGatewayAttributeResponse;
        }
    }
}
