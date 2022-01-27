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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListPublishedServicesResponseUnmarshaller
    {
        public static ListPublishedServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPublishedServicesResponse listPublishedServicesResponse = new ListPublishedServicesResponse();

			listPublishedServicesResponse.HttpResponse = _ctx.HttpResponse;
			listPublishedServicesResponse.Message = _ctx.StringValue("ListPublishedServices.Message");
			listPublishedServicesResponse.RequestId = _ctx.StringValue("ListPublishedServices.RequestId");
			listPublishedServicesResponse.TraceId = _ctx.StringValue("ListPublishedServices.TraceId");
			listPublishedServicesResponse.ErrorCode = _ctx.StringValue("ListPublishedServices.ErrorCode");
			listPublishedServicesResponse.Code = _ctx.StringValue("ListPublishedServices.Code");
			listPublishedServicesResponse.Success = _ctx.BooleanValue("ListPublishedServices.Success");

			List<ListPublishedServicesResponse.ListPublishedServices_DataItem> listPublishedServicesResponse_data = new List<ListPublishedServicesResponse.ListPublishedServices_DataItem>();
			for (int i = 0; i < _ctx.Length("ListPublishedServices.Data.Length"); i++) {
				ListPublishedServicesResponse.ListPublishedServices_DataItem dataItem = new ListPublishedServicesResponse.ListPublishedServices_DataItem();
				dataItem.Group2Ip = _ctx.StringValue("ListPublishedServices.Data["+ i +"].Group2Ip");
				dataItem.Type = _ctx.StringValue("ListPublishedServices.Data["+ i +"].Type");
				dataItem.AppId = _ctx.StringValue("ListPublishedServices.Data["+ i +"].AppId");
				dataItem.Version = _ctx.StringValue("ListPublishedServices.Data["+ i +"].Version");
				dataItem.Name = _ctx.StringValue("ListPublishedServices.Data["+ i +"].Name");

				List<string> dataItem_groups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPublishedServices.Data["+ i +"].Groups.Length"); j++) {
					dataItem_groups.Add(_ctx.StringValue("ListPublishedServices.Data["+ i +"].Groups["+ j +"]"));
				}
				dataItem.Groups = dataItem_groups;

				List<string> dataItem_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPublishedServices.Data["+ i +"].Ips.Length"); j++) {
					dataItem_ips.Add(_ctx.StringValue("ListPublishedServices.Data["+ i +"].Ips["+ j +"]"));
				}
				dataItem.Ips = dataItem_ips;

				listPublishedServicesResponse_data.Add(dataItem);
			}
			listPublishedServicesResponse.Data = listPublishedServicesResponse_data;
        
			return listPublishedServicesResponse;
        }
    }
}
