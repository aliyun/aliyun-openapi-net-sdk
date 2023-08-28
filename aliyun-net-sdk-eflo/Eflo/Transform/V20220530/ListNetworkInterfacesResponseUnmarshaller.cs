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
    public class ListNetworkInterfacesResponseUnmarshaller
    {
        public static ListNetworkInterfacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNetworkInterfacesResponse listNetworkInterfacesResponse = new ListNetworkInterfacesResponse();

			listNetworkInterfacesResponse.HttpResponse = _ctx.HttpResponse;
			listNetworkInterfacesResponse.Code = _ctx.IntegerValue("ListNetworkInterfaces.Code");
			listNetworkInterfacesResponse.Message = _ctx.StringValue("ListNetworkInterfaces.Message");
			listNetworkInterfacesResponse.RequestId = _ctx.StringValue("ListNetworkInterfaces.RequestId");

			ListNetworkInterfacesResponse.ListNetworkInterfaces_Content content = new ListNetworkInterfacesResponse.ListNetworkInterfaces_Content();
			content.Total = _ctx.LongValue("ListNetworkInterfaces.Content.Total");

			List<ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem> content_data = new List<ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem>();
			for (int i = 0; i < _ctx.Length("ListNetworkInterfaces.Content.Data.Length"); i++) {
				ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem dataItem = new ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem();
				dataItem.TenantId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].TenantId");
				dataItem.RegionId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].RegionId");
				dataItem.NetworkInterfaceId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].NetworkInterfaceId");
				dataItem.NodeId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].NodeId");
				dataItem.ZoneId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].ZoneId");
				dataItem.Ip = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].Ip");
				dataItem.ServiceMac = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].ServiceMac");
				dataItem.Status = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].Status");
				dataItem.Gateway = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].Gateway");
				dataItem.CreateTime = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].CreateTime");
				dataItem.Quota = _ctx.IntegerValue("ListNetworkInterfaces.Content.Data["+ i +"].Quota");
				dataItem.NcType = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].NcType");
				dataItem.NetworkInterfaceName = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].NetworkInterfaceName");

				List<string> dataItem_ethernet = new List<string>();
				for (int j = 0; j < _ctx.Length("ListNetworkInterfaces.Content.Data["+ i +"].Ethernet.Length"); j++) {
					dataItem_ethernet.Add(_ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].Ethernet["+ j +"]"));
				}
				dataItem.Ethernet = dataItem_ethernet;

				ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_VpdBaseInfo vpdBaseInfo = new ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_VpdBaseInfo();
				vpdBaseInfo.VpdId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].VpdBaseInfo.VpdId");
				vpdBaseInfo.VpdName = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].VpdBaseInfo.VpdName");
				vpdBaseInfo.Cidr = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].VpdBaseInfo.Cidr");
				vpdBaseInfo.CreateTime = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].VpdBaseInfo.CreateTime");
				dataItem.VpdBaseInfo = vpdBaseInfo;

				ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_SubnetBaseInfo subnetBaseInfo = new ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_SubnetBaseInfo();
				subnetBaseInfo.SubnetId = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].SubnetBaseInfo.SubnetId");
				subnetBaseInfo.SubnetName = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].SubnetBaseInfo.SubnetName");
				subnetBaseInfo.Cidr = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].SubnetBaseInfo.Cidr");
				subnetBaseInfo.CreateTime = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].SubnetBaseInfo.CreateTime");
				dataItem.SubnetBaseInfo = subnetBaseInfo;

				List<ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_PrivateIpAddressMacGroupItem> dataItem_privateIpAddressMacGroup = new List<ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_PrivateIpAddressMacGroupItem>();
				for (int j = 0; j < _ctx.Length("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup.Length"); j++) {
					ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_PrivateIpAddressMacGroupItem privateIpAddressMacGroupItem = new ListNetworkInterfacesResponse.ListNetworkInterfaces_Content.ListNetworkInterfaces_DataItem.ListNetworkInterfaces_PrivateIpAddressMacGroupItem();
					privateIpAddressMacGroupItem.IpName = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].IpName");
					privateIpAddressMacGroupItem.PrivateIpAddress = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].PrivateIpAddress");
					privateIpAddressMacGroupItem.IpAddressMac = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].IpAddressMac");
					privateIpAddressMacGroupItem.Status = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].Status");
					privateIpAddressMacGroupItem.Description = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].Description");
					privateIpAddressMacGroupItem.Message = _ctx.StringValue("ListNetworkInterfaces.Content.Data["+ i +"].PrivateIpAddressMacGroup["+ j +"].Message");

					dataItem_privateIpAddressMacGroup.Add(privateIpAddressMacGroupItem);
				}
				dataItem.PrivateIpAddressMacGroup = dataItem_privateIpAddressMacGroup;

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listNetworkInterfacesResponse.Content = content;
        
			return listNetworkInterfacesResponse;
        }
    }
}
