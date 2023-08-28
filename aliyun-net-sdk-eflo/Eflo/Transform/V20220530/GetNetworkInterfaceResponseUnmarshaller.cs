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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetNetworkInterfaceResponseUnmarshaller
    {
        public static GetNetworkInterfaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNetworkInterfaceResponse getNetworkInterfaceResponse = new GetNetworkInterfaceResponse();

			getNetworkInterfaceResponse.HttpResponse = _ctx.HttpResponse;
			getNetworkInterfaceResponse.Code = _ctx.IntegerValue("GetNetworkInterface.Code");
			getNetworkInterfaceResponse.Message = _ctx.StringValue("GetNetworkInterface.Message");
			getNetworkInterfaceResponse.RequestId = _ctx.StringValue("GetNetworkInterface.RequestId");

			GetNetworkInterfaceResponse.GetNetworkInterface_Content content = new GetNetworkInterfaceResponse.GetNetworkInterface_Content();
			content.TenantId = _ctx.StringValue("GetNetworkInterface.Content.TenantId");
			content.RegionId = _ctx.StringValue("GetNetworkInterface.Content.RegionId");
			content.NetworkInterfaceId = _ctx.StringValue("GetNetworkInterface.Content.NetworkInterfaceId");
			content.NodeId = _ctx.StringValue("GetNetworkInterface.Content.NodeId");
			content.ZoneId = _ctx.StringValue("GetNetworkInterface.Content.ZoneId");
			content.Ip = _ctx.StringValue("GetNetworkInterface.Content.Ip");
			content.ServiceMac = _ctx.StringValue("GetNetworkInterface.Content.ServiceMac");
			content.Status = _ctx.StringValue("GetNetworkInterface.Content.Status");
			content.Gateway = _ctx.StringValue("GetNetworkInterface.Content.Gateway");
			content.CreateTime = _ctx.StringValue("GetNetworkInterface.Content.CreateTime");
			content.Quota = _ctx.IntegerValue("GetNetworkInterface.Content.Quota");
			content.NcType = _ctx.StringValue("GetNetworkInterface.Content.NcType");
			content.NetworkInterfaceName = _ctx.StringValue("GetNetworkInterface.Content.NetworkInterfaceName");

			List<string> content_ethernet = new List<string>();
			for (int i = 0; i < _ctx.Length("GetNetworkInterface.Content.Ethernet.Length"); i++) {
				content_ethernet.Add(_ctx.StringValue("GetNetworkInterface.Content.Ethernet["+ i +"]"));
			}
			content.Ethernet = content_ethernet;

			GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_VpdBaseInfo vpdBaseInfo = new GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_VpdBaseInfo();
			vpdBaseInfo.VpdId = _ctx.StringValue("GetNetworkInterface.Content.VpdBaseInfo.VpdId");
			vpdBaseInfo.VpdName = _ctx.StringValue("GetNetworkInterface.Content.VpdBaseInfo.VpdName");
			vpdBaseInfo.Cidr = _ctx.StringValue("GetNetworkInterface.Content.VpdBaseInfo.Cidr");
			vpdBaseInfo.CreateTime = _ctx.StringValue("GetNetworkInterface.Content.VpdBaseInfo.CreateTime");
			content.VpdBaseInfo = vpdBaseInfo;

			GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_SubnetBaseInfo subnetBaseInfo = new GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_SubnetBaseInfo();
			subnetBaseInfo.SubnetId = _ctx.StringValue("GetNetworkInterface.Content.SubnetBaseInfo.SubnetId");
			subnetBaseInfo.SubnetName = _ctx.StringValue("GetNetworkInterface.Content.SubnetBaseInfo.SubnetName");
			subnetBaseInfo.Cidr = _ctx.StringValue("GetNetworkInterface.Content.SubnetBaseInfo.Cidr");
			subnetBaseInfo.CreateTime = _ctx.StringValue("GetNetworkInterface.Content.SubnetBaseInfo.CreateTime");
			content.SubnetBaseInfo = subnetBaseInfo;

			List<GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_PrivateIpAddressMacGroupItem> content_privateIpAddressMacGroup = new List<GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_PrivateIpAddressMacGroupItem>();
			for (int i = 0; i < _ctx.Length("GetNetworkInterface.Content.PrivateIpAddressMacGroup.Length"); i++) {
				GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_PrivateIpAddressMacGroupItem privateIpAddressMacGroupItem = new GetNetworkInterfaceResponse.GetNetworkInterface_Content.GetNetworkInterface_PrivateIpAddressMacGroupItem();
				privateIpAddressMacGroupItem.IpName = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].IpName");
				privateIpAddressMacGroupItem.PrivateIpAddress = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].PrivateIpAddress");
				privateIpAddressMacGroupItem.IpAddressMac = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].IpAddressMac");
				privateIpAddressMacGroupItem.Status = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].Status");
				privateIpAddressMacGroupItem.Description = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].Description");
				privateIpAddressMacGroupItem.Message = _ctx.StringValue("GetNetworkInterface.Content.PrivateIpAddressMacGroup["+ i +"].Message");

				content_privateIpAddressMacGroup.Add(privateIpAddressMacGroupItem);
			}
			content.PrivateIpAddressMacGroup = content_privateIpAddressMacGroup;
			getNetworkInterfaceResponse.Content = content;
        
			return getNetworkInterfaceResponse;
        }
    }
}
