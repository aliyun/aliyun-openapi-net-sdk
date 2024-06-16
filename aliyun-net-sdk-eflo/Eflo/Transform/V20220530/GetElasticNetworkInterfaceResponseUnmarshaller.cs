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
    public class GetElasticNetworkInterfaceResponseUnmarshaller
    {
        public static GetElasticNetworkInterfaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetElasticNetworkInterfaceResponse getElasticNetworkInterfaceResponse = new GetElasticNetworkInterfaceResponse();

			getElasticNetworkInterfaceResponse.HttpResponse = _ctx.HttpResponse;
			getElasticNetworkInterfaceResponse.Code = _ctx.IntegerValue("GetElasticNetworkInterface.Code");
			getElasticNetworkInterfaceResponse.Message = _ctx.StringValue("GetElasticNetworkInterface.Message");
			getElasticNetworkInterfaceResponse.RequestId = _ctx.StringValue("GetElasticNetworkInterface.RequestId");

			GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content content = new GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content();
			content.RegionId = _ctx.StringValue("GetElasticNetworkInterface.Content.RegionId");
			content.ZoneId = _ctx.StringValue("GetElasticNetworkInterface.Content.ZoneId");
			content.ElasticNetworkInterfaceId = _ctx.StringValue("GetElasticNetworkInterface.Content.ElasticNetworkInterfaceId");
			content.NodeId = _ctx.StringValue("GetElasticNetworkInterface.Content.NodeId");
			content.Status = _ctx.StringValue("GetElasticNetworkInterface.Content.Status");
			content.Ip = _ctx.StringValue("GetElasticNetworkInterface.Content.Ip");
			content.VpcId = _ctx.StringValue("GetElasticNetworkInterface.Content.VpcId");
			content.VSwitchId = _ctx.StringValue("GetElasticNetworkInterface.Content.VSwitchId");
			content.Message = _ctx.StringValue("GetElasticNetworkInterface.Content.Message");
			content.Mac = _ctx.StringValue("GetElasticNetworkInterface.Content.Mac");
			content.Type = _ctx.StringValue("GetElasticNetworkInterface.Content.Type");
			content.Gateway = _ctx.StringValue("GetElasticNetworkInterface.Content.Gateway");
			content.Mask = _ctx.StringValue("GetElasticNetworkInterface.Content.Mask");
			content.CreateTime = _ctx.StringValue("GetElasticNetworkInterface.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetElasticNetworkInterface.Content.GmtModified");
			content.Description = _ctx.StringValue("GetElasticNetworkInterface.Content.Description");
			content.SecurityGroupId = _ctx.StringValue("GetElasticNetworkInterface.Content.SecurityGroupId");

			List<GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content.GetElasticNetworkInterface_PrivateIpAddress> content_privateIpAddresses = new List<GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content.GetElasticNetworkInterface_PrivateIpAddress>();
			for (int i = 0; i < _ctx.Length("GetElasticNetworkInterface.Content.PrivateIpAddresses.Length"); i++) {
				GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content.GetElasticNetworkInterface_PrivateIpAddress privateIpAddress = new GetElasticNetworkInterfaceResponse.GetElasticNetworkInterface_Content.GetElasticNetworkInterface_PrivateIpAddress();
				privateIpAddress.ElasticNetworkInterfaceId = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].ElasticNetworkInterfaceId");
				privateIpAddress.RegionId = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].RegionId");
				privateIpAddress.GmtCreate = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].GmtCreate");
				privateIpAddress.GmtModified = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].GmtModified");
				privateIpAddress.IpName = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].IpName");
				privateIpAddress.PrivateIpAddress = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].PrivateIpAddress");
				privateIpAddress.Status = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].Status");
				privateIpAddress.Description = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].Description");
				privateIpAddress.Message = _ctx.StringValue("GetElasticNetworkInterface.Content.PrivateIpAddresses["+ i +"].Message");

				content_privateIpAddresses.Add(privateIpAddress);
			}
			content.PrivateIpAddresses = content_privateIpAddresses;
			getElasticNetworkInterfaceResponse.Content = content;
        
			return getElasticNetworkInterfaceResponse;
        }
    }
}
