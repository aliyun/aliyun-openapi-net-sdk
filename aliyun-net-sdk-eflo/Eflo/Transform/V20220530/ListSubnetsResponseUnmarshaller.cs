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
    public class ListSubnetsResponseUnmarshaller
    {
        public static ListSubnetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSubnetsResponse listSubnetsResponse = new ListSubnetsResponse();

			listSubnetsResponse.HttpResponse = _ctx.HttpResponse;
			listSubnetsResponse.Code = _ctx.IntegerValue("ListSubnets.Code");
			listSubnetsResponse.Message = _ctx.StringValue("ListSubnets.Message");
			listSubnetsResponse.RequestId = _ctx.StringValue("ListSubnets.RequestId");

			ListSubnetsResponse.ListSubnets_Content content = new ListSubnetsResponse.ListSubnets_Content();
			content.Total = _ctx.LongValue("ListSubnets.Content.Total");

			List<ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem> content_data = new List<ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem>();
			for (int i = 0; i < _ctx.Length("ListSubnets.Content.Data.Length"); i++) {
				ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem dataItem = new ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem();
				dataItem.CreateTime = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].GmtModified");
				dataItem.TenantId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].TenantId");
				dataItem.RegionId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].RegionId");
				dataItem.ZoneId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].ZoneId");
				dataItem.Type = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Type");
				dataItem.SubnetId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].SubnetId");
				dataItem.SubnetName = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].SubnetName");
				dataItem.Cidr = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Cidr");
				dataItem.VpdId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].VpdId");
				dataItem.Status = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Status");
				dataItem.Message = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Message");
				dataItem.NcCount = _ctx.IntegerValue("ListSubnets.Content.Data["+ i +"].NcCount");
				dataItem.NetworkInterfaceCount = _ctx.IntegerValue("ListSubnets.Content.Data["+ i +"].NetworkInterfaceCount");
				dataItem.ResourceGroupId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].ResourceGroupId");

				ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_VpdBaseInfo vpdBaseInfo = new ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_VpdBaseInfo();
				vpdBaseInfo.VpdId = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].VpdBaseInfo.VpdId");
				vpdBaseInfo.VpdName = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].VpdBaseInfo.VpdName");
				vpdBaseInfo.Cidr = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].VpdBaseInfo.Cidr");
				vpdBaseInfo.CreateTime = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].VpdBaseInfo.CreateTime");
				dataItem.VpdBaseInfo = vpdBaseInfo;

				List<ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_Tag> dataItem_tags = new List<ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_Tag>();
				for (int j = 0; j < _ctx.Length("ListSubnets.Content.Data["+ i +"].Tags.Length"); j++) {
					ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_Tag tag = new ListSubnetsResponse.ListSubnets_Content.ListSubnets_DataItem.ListSubnets_Tag();
					tag.TagKey = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ListSubnets.Content.Data["+ i +"].Tags["+ j +"].TagValue");

					dataItem_tags.Add(tag);
				}
				dataItem.Tags = dataItem_tags;

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listSubnetsResponse.Content = content;
        
			return listSubnetsResponse;
        }
    }
}
