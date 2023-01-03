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
				dataItem.RegionId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].RegionId");
				dataItem.VpdId = _ctx.StringValue("ListVpds.Content.Data["+ i +"].VpdId");
				dataItem.Name = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Name");
				dataItem.Cidr = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Cidr");
				dataItem.ServiceCidr = _ctx.StringValue("ListVpds.Content.Data["+ i +"].ServiceCidr");
				dataItem.Status = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Status");
				dataItem.Message = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Message");
				dataItem.Route = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].Route");
				dataItem.NcCount = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].NcCount");
				dataItem.SubnetCount = _ctx.IntegerValue("ListVpds.Content.Data["+ i +"].SubnetCount");
				dataItem.GmtCreate = _ctx.StringValue("ListVpds.Content.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListVpds.Content.Data["+ i +"].GmtModified");
				dataItem.Dependence = _ctx.StringValue("ListVpds.Content.Data["+ i +"].Dependence");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVpdsResponse.Content = content;
        
			return listVpdsResponse;
        }
    }
}
