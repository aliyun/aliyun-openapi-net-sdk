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
    public class ListVpdsResponseUnmarshaller
    {
        public static ListVpdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpdsResponse listVpdsResponse = new ListVpdsResponse();

			listVpdsResponse.HttpResponse = _ctx.HttpResponse;
			listVpdsResponse.Code = _ctx.IntegerValue("ListVpds.Code");
			listVpdsResponse.Message = _ctx.StringValue("ListVpds.Message");
			listVpdsResponse.RequestId = _ctx.StringValue("ListVpds.RequestId");

			ListVpdsResponse.ListVpds_Content content = new ListVpdsResponse.ListVpds_Content();
			content.Total = _ctx.LongValue("ListVpds.Content.Total");

			List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem> content_data = new List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVpds.Content.Data.Length"); i++) {
				ListVpdsResponse.ListVpds_Content.ListVpds_DataItem dataItem = new ListVpdsResponse.ListVpds_Content.ListVpds_DataItem();
				dataItem.TenantId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].TenantId");
				dataItem.RegionId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].RegionId");
				dataItem.VpdId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].VpdId");
				dataItem.VpdName = _ctx.StringValue("ListVpds.Content.Data["+ i +"].VpdName");
				dataItem.Cidr = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Cidr");
				dataItem.ServiceCidr = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ServiceCidr");
				dataItem.Status = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Status");
				dataItem.Message = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Message");
				dataItem.NcCount = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].NcCount");
				dataItem.NetworkInterfaceCount = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].NetworkInterfaceCount");
				dataItem.SubnetCount = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].SubnetCount");
				dataItem.CreateTime = _ctx.StringValue("ListVpds.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListVpds.Content.Data["+ i +"].GmtModified");
				dataItem.Dependence = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Dependence");
				dataItem.ResourceGroupId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ResourceGroupId");

				List<string> dataItem_secondaryCidrBlocks = new List<string>();
				for (int j = 0; j < _ctx.Length("ListVpds.Content.Data["+ i +"].SecondaryCidrBlocks.Length"); j++) {
					dataItem_secondaryCidrBlocks.Add(_ctx.StringValue("ListVpds.Content.Data["+ i +"].SecondaryCidrBlocks["+ j +"]"));
				}
				dataItem.SecondaryCidrBlocks = dataItem_secondaryCidrBlocks;

				List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_ErInfo> dataItem_erInfos = new List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_ErInfo>();
				for (int j = 0; j < _ctx.Length("ListVpds.Content.Data["+ i +"].ErInfos.Length"); j++) {
					ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_ErInfo erInfo = new ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_ErInfo();
					erInfo.CreateTime = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].CreateTime");
					erInfo.GmtModified = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].GmtModified");
					erInfo.Message = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].Message");
					erInfo.ErId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].ErId");
					erInfo.RegionId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].RegionId");
					erInfo.TenantId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].TenantId");
					erInfo.Status = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].Status");
					erInfo.ErName = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].ErName");
					erInfo.MasterZoneId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].MasterZoneId");
					erInfo.Description = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].Description");
					erInfo.Connections = _ctx.LongValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].Connections");
					erInfo.RouteMaps = _ctx.LongValue("ListVpds.Content.Data["+ i +"].ErInfos["+ j +"].RouteMaps");

					dataItem_erInfos.Add(erInfo);
				}
				dataItem.ErInfos = dataItem_erInfos;

				List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_Tag> dataItem_tags = new List<ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_Tag>();
				for (int j = 0; j < _ctx.Length("ListVpds.Content.Data["+ i +"].Tags.Length"); j++) {
					ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_Tag tag = new ListVpdsResponse.ListVpds_Content.ListVpds_DataItem.ListVpds_Tag();
					tag.TagKey = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Tags["+ j +"].TagValue");

					dataItem_tags.Add(tag);
				}
				dataItem.Tags = dataItem_tags;

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVpdsResponse.Content = content;
        
			return listVpdsResponse;
        }
    }
}
