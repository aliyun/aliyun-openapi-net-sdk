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
				dataItem.Message = _ctx.StringValue("ListVccs.Content.Data["+ i +"].Message");
				dataItem.CreateTime = _ctx.StringValue("ListVccs.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListVccs.Content.Data["+ i +"].GmtModified");
				dataItem.Rate = _ctx.DoubleValue("ListVccs.Content.Data["+ i +"].Rate");
				dataItem.BandwidthStr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].BandwidthStr");
				dataItem.BgpCidr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].BgpCidr");

				ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_VpdBaseInfo vpdBaseInfo = new ListVccsResponse.ListVccs_Content.ListVccs_DataItem.ListVccs_VpdBaseInfo();
				vpdBaseInfo.VpdId = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.VpdId");
				vpdBaseInfo.Name = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.Name");
				vpdBaseInfo.Cidr = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.Cidr");
				vpdBaseInfo.GmtCreate = _ctx.StringValue("ListVccs.Content.Data["+ i +"].VpdBaseInfo.GmtCreate");
				dataItem.VpdBaseInfo = vpdBaseInfo;

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVccsResponse.Content = content;
        
			return listVccsResponse;
        }
    }
}
