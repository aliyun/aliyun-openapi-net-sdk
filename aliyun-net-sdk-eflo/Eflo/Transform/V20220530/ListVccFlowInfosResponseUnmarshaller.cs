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
    public class ListVccFlowInfosResponseUnmarshaller
    {
        public static ListVccFlowInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVccFlowInfosResponse listVccFlowInfosResponse = new ListVccFlowInfosResponse();

			listVccFlowInfosResponse.HttpResponse = _ctx.HttpResponse;
			listVccFlowInfosResponse.Code = _ctx.IntegerValue("ListVccFlowInfos.Code");
			listVccFlowInfosResponse.Message = _ctx.StringValue("ListVccFlowInfos.Message");
			listVccFlowInfosResponse.RequestId = _ctx.StringValue("ListVccFlowInfos.RequestId");

			ListVccFlowInfosResponse.ListVccFlowInfos_Content content = new ListVccFlowInfosResponse.ListVccFlowInfos_Content();
			content.Total = _ctx.LongValue("ListVccFlowInfos.Content.Total");

			List<ListVccFlowInfosResponse.ListVccFlowInfos_Content.ListVccFlowInfos_DataItem> content_data = new List<ListVccFlowInfosResponse.ListVccFlowInfos_Content.ListVccFlowInfos_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVccFlowInfos.Content.Data.Length"); i++) {
				ListVccFlowInfosResponse.ListVccFlowInfos_Content.ListVccFlowInfos_DataItem dataItem = new ListVccFlowInfosResponse.ListVccFlowInfos_Content.ListVccFlowInfos_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListVccFlowInfos.Content.Data["+ i +"].RegionId");
				dataItem.VccId = _ctx.StringValue("ListVccFlowInfos.Content.Data["+ i +"].VccId");
				dataItem.MetricName = _ctx.StringValue("ListVccFlowInfos.Content.Data["+ i +"].MetricName");
				dataItem.Direction = _ctx.StringValue("ListVccFlowInfos.Content.Data["+ i +"].Direction");
				dataItem.Timestamp = _ctx.LongValue("ListVccFlowInfos.Content.Data["+ i +"].Timestamp");
				dataItem._Value = _ctx.DoubleValue("ListVccFlowInfos.Content.Data["+ i +"].Value");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVccFlowInfosResponse.Content = content;
        
			return listVccFlowInfosResponse;
        }
    }
}
