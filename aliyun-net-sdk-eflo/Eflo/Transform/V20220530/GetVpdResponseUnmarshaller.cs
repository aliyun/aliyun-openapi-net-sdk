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
    public class GetVpdResponseUnmarshaller
    {
        public static GetVpdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpdResponse getVpdResponse = new GetVpdResponse();

			getVpdResponse.HttpResponse = _ctx.HttpResponse;
			getVpdResponse.Code = _ctx.IntegerValue("GetVpd.Code");
			getVpdResponse.Message = _ctx.StringValue("GetVpd.Message");
			getVpdResponse.RequestId = _ctx.StringValue("GetVpd.RequestId");

			GetVpdResponse.GetVpd_Content content = new GetVpdResponse.GetVpd_Content();
			content.RegionId = _ctx.StringValue("GetVpd.Content.RegionId");
			content.VpdId = _ctx.StringValue("GetVpd.Content.VpdId");
			content.VpdName = _ctx.StringValue("GetVpd.Content.VpdName");
			content.Cidr = _ctx.StringValue("GetVpd.Content.Cidr");
			content.ServiceCidr = _ctx.StringValue("GetVpd.Content.ServiceCidr");
			content.Status = _ctx.StringValue("GetVpd.Content.Status");
			content.Message = _ctx.StringValue("GetVpd.Content.Message");
			content.NcCount = _ctx.IntegerValue("GetVpd.Content.NcCount");
			content.NetworkInterfaceCount = _ctx.IntegerValue("GetVpd.Content.NetworkInterfaceCount");
			content.SubnetCount = _ctx.LongValue("GetVpd.Content.SubnetCount");
			content.CreateTime = _ctx.StringValue("GetVpd.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetVpd.Content.GmtModified");
			content.TenantId = _ctx.StringValue("GetVpd.Content.TenantId");
			content.AttachErStatus = _ctx.BooleanValue("GetVpd.Content.AttachErStatus");
			content.ResourceGroupId = _ctx.StringValue("GetVpd.Content.ResourceGroupId");
			content.Quota = _ctx.IntegerValue("GetVpd.Content.Quota");
			content.PrivateIpCount = _ctx.LongValue("GetVpd.Content.PrivateIpCount");

			List<string> content_secondaryCidrBlocks = new List<string>();
			for (int i = 0; i < _ctx.Length("GetVpd.Content.SecondaryCidrBlocks.Length"); i++) {
				content_secondaryCidrBlocks.Add(_ctx.StringValue("GetVpd.Content.SecondaryCidrBlocks["+ i +"]"));
			}
			content.SecondaryCidrBlocks = content_secondaryCidrBlocks;

			List<GetVpdResponse.GetVpd_Content.GetVpd_ErInfo> content_erInfos = new List<GetVpdResponse.GetVpd_Content.GetVpd_ErInfo>();
			for (int i = 0; i < _ctx.Length("GetVpd.Content.ErInfos.Length"); i++) {
				GetVpdResponse.GetVpd_Content.GetVpd_ErInfo erInfo = new GetVpdResponse.GetVpd_Content.GetVpd_ErInfo();
				erInfo.CreateTime = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].CreateTime");
				erInfo.GmtModified = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].GmtModified");
				erInfo.Message = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].Message");
				erInfo.ErId = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].ErId");
				erInfo.RegionId = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].RegionId");
				erInfo.TenantId = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].TenantId");
				erInfo.Status = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].Status");
				erInfo.ErName = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].ErName");
				erInfo.MasterZoneId = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].MasterZoneId");
				erInfo.Description = _ctx.StringValue("GetVpd.Content.ErInfos["+ i +"].Description");
				erInfo.Connections = _ctx.LongValue("GetVpd.Content.ErInfos["+ i +"].Connections");
				erInfo.RouteMaps = _ctx.LongValue("GetVpd.Content.ErInfos["+ i +"].RouteMaps");

				content_erInfos.Add(erInfo);
			}
			content.ErInfos = content_erInfos;

			List<GetVpdResponse.GetVpd_Content.GetVpd_Tag> content_tags = new List<GetVpdResponse.GetVpd_Content.GetVpd_Tag>();
			for (int i = 0; i < _ctx.Length("GetVpd.Content.Tags.Length"); i++) {
				GetVpdResponse.GetVpd_Content.GetVpd_Tag tag = new GetVpdResponse.GetVpd_Content.GetVpd_Tag();
				tag.TagKey = _ctx.StringValue("GetVpd.Content.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("GetVpd.Content.Tags["+ i +"].TagValue");

				content_tags.Add(tag);
			}
			content.Tags = content_tags;
			getVpdResponse.Content = content;
        
			return getVpdResponse;
        }
    }
}
