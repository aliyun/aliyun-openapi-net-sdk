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
    public class GetSubnetResponseUnmarshaller
    {
        public static GetSubnetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubnetResponse getSubnetResponse = new GetSubnetResponse();

			getSubnetResponse.HttpResponse = _ctx.HttpResponse;
			getSubnetResponse.Code = _ctx.IntegerValue("GetSubnet.Code");
			getSubnetResponse.Message = _ctx.StringValue("GetSubnet.Message");
			getSubnetResponse.RequestId = _ctx.StringValue("GetSubnet.RequestId");

			GetSubnetResponse.GetSubnet_Content content = new GetSubnetResponse.GetSubnet_Content();
			content.CreateTime = _ctx.StringValue("GetSubnet.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetSubnet.Content.GmtModified");
			content.TenantId = _ctx.StringValue("GetSubnet.Content.TenantId");
			content.RegionId = _ctx.StringValue("GetSubnet.Content.RegionId");
			content.ZoneId = _ctx.StringValue("GetSubnet.Content.ZoneId");
			content.SubnetId = _ctx.StringValue("GetSubnet.Content.SubnetId");
			content.SubnetName = _ctx.StringValue("GetSubnet.Content.SubnetName");
			content.Cidr = _ctx.StringValue("GetSubnet.Content.Cidr");
			content.VpdId = _ctx.StringValue("GetSubnet.Content.VpdId");
			content.Type = _ctx.StringValue("GetSubnet.Content.Type");
			content.Status = _ctx.StringValue("GetSubnet.Content.Status");
			content.Message = _ctx.StringValue("GetSubnet.Content.Message");
			content.NcCount = _ctx.IntegerValue("GetSubnet.Content.NcCount");
			content.NetworkInterfaceCount = _ctx.IntegerValue("GetSubnet.Content.NetworkInterfaceCount");
			content.LbCount = _ctx.LongValue("GetSubnet.Content.LbCount");
			content.ResourceGroupId = _ctx.StringValue("GetSubnet.Content.ResourceGroupId");
			content.PrivateIpCount = _ctx.LongValue("GetSubnet.Content.PrivateIpCount");
			content.AvailableIps = _ctx.IntegerValue("GetSubnet.Content.AvailableIps");

			GetSubnetResponse.GetSubnet_Content.GetSubnet_VpdBaseInfo vpdBaseInfo = new GetSubnetResponse.GetSubnet_Content.GetSubnet_VpdBaseInfo();
			vpdBaseInfo.VpdId = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.VpdId");
			vpdBaseInfo.VpdName = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.VpdName");
			vpdBaseInfo.Cidr = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.Cidr");
			vpdBaseInfo.CreateTime = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.CreateTime");
			content.VpdBaseInfo = vpdBaseInfo;

			List<GetSubnetResponse.GetSubnet_Content.GetSubnet_Tag> content_tags = new List<GetSubnetResponse.GetSubnet_Content.GetSubnet_Tag>();
			for (int i = 0; i < _ctx.Length("GetSubnet.Content.Tags.Length"); i++) {
				GetSubnetResponse.GetSubnet_Content.GetSubnet_Tag tag = new GetSubnetResponse.GetSubnet_Content.GetSubnet_Tag();
				tag.TagKey = _ctx.StringValue("GetSubnet.Content.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("GetSubnet.Content.Tags["+ i +"].TagValue");

				content_tags.Add(tag);
			}
			content.Tags = content_tags;
			getSubnetResponse.Content = content;
        
			return getSubnetResponse;
        }
    }
}
