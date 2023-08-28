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
    public class ListVccsResponseUnmarshaller
    {
        public static ListVccsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVccsResponse listVccsResponse = new ListVccsResponse();

			listVccsResponse.HttpResponse = _ctx.HttpResponse;
			listVccsResponse.Code = _ctx.IntegerValue("ListVccs.Code");
			listVccsResponse.Message = _ctx.StringValue("ListVccs.Message");
			listVccsResponse.RequestId = _ctx.StringValue("ListVccs.RequestId");

			ListVccsResponse.ListVccs_Content content = new ListVccsResponse.ListVccs_Content();
			content.Total = _ctx.LongValue("ListVccs.Content.Total");

			List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem> content_data = new List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVccs.Content.Data.Length"); i++) {
				ListVccsResponse.ListVccs_Content.ListVccs_DataItem dataItem = new ListVccsResponse.ListVccs_Content.ListVccs_DataItem();
				dataItem.TenantId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].TenantId");
				dataItem.RegionId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].RegionId");
				dataItem.ZoneId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ZoneId");
				dataItem.VccId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VccId");
				dataItem.VpdId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdId");
				dataItem.VpcId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpcId");
				dataItem.CenId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CenId");
				dataItem.VccName = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VccName");
				dataItem.AccessPointId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].AccessPointId");
				dataItem.LineOperator = _ctx.StringValue("ListVccs.Content.Data["+ i +"].LineOperator");
				dataItem.Spec = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Spec");
				dataItem.PortType = _ctx.StringValue("ListVccs.Content.Data["+ i +"].PortType");
				dataItem.Status = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Status");
				dataItem.CurrentNode = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CurrentNode");
				dataItem.Message = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Message");
				dataItem.CreateTime = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListVccs.Content.Data["+ i +"].GmtModified");
				dataItem.TaskId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].TaskId");
				dataItem.Rate = _ctx.DoubleValue("ListVccs.Content.Data["+ i +"].Rate");
				dataItem.BandwidthStr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].BandwidthStr");
				dataItem.CommodityCode = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CommodityCode");
				dataItem.BgpCidr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].BgpCidr");
				dataItem.ExpirationDate = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ExpirationDate");
				dataItem.ResourceGroupId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ResourceGroupId");
				dataItem.ConnectionType = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ConnectionType");
				dataItem.CenOwnerId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CenOwnerId");

				ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_VpdBaseInfo vpdBaseInfo = new ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_VpdBaseInfo();
				vpdBaseInfo.VpdId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.VpdId");
				vpdBaseInfo.VpdName = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.VpdName");
				vpdBaseInfo.Cidr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.Cidr");
				vpdBaseInfo.CreateTime = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.CreateTime");
				dataItem.VpdBaseInfo = vpdBaseInfo;

				List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_ErInfo> dataItem_erInfos = new List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_ErInfo>();
				for (int j = 0; j < _ctx.Length("ListVccs.Content.Data["+ i +"].ErInfos.Length"); j++) {
					ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_ErInfo erInfo = new ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_ErInfo();
					erInfo.CreateTime = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].CreateTime");
					erInfo.GmtModified = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].GmtModified");
					erInfo.Message = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].Message");
					erInfo.ErId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].ErId");
					erInfo.RegionId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].RegionId");
					erInfo.TenantId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].TenantId");
					erInfo.Status = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].Status");
					erInfo.ErName = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].ErName");
					erInfo.MasterZoneId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].MasterZoneId");
					erInfo.Description = _ctx.StringValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].Description");
					erInfo.Connections = _ctx.LongValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].Connections");
					erInfo.RouteMaps = _ctx.LongValue("ListVccs.Content.Data["+ i +"].ErInfos["+ j +"].RouteMaps");

					dataItem_erInfos.Add(erInfo);
				}
				dataItem.ErInfos = dataItem_erInfos;

				List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_Tag> dataItem_tags = new List<ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_Tag>();
				for (int j = 0; j < _ctx.Length("ListVccs.Content.Data["+ i +"].Tags.Length"); j++) {
					ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_Tag tag = new ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_Tag();
					tag.TagKey = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Tags["+ j +"].TagValue");

					dataItem_tags.Add(tag);
				}
				dataItem.Tags = dataItem_tags;

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVccsResponse.Content = content;
        
			return listVccsResponse;
        }
    }
}
