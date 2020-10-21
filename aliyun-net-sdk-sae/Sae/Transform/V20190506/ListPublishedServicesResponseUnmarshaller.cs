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
        public static ListPublishedServicesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPublishedServicesResponse listPublishedServicesResponse = new ListPublishedServicesResponse();

			listPublishedServicesResponse.HttpResponse = context.HttpResponse;
			listPublishedServicesResponse.Code = context.StringValue("ListPublishedServices.Code");
			listPublishedServicesResponse.Message = context.StringValue("ListPublishedServices.Message");
			listPublishedServicesResponse.RequestId = context.StringValue("ListPublishedServices.RequestId");
			listPublishedServicesResponse.Success = context.BooleanValue("ListPublishedServices.Success");
			listPublishedServicesResponse.ErrorCode = context.StringValue("ListPublishedServices.ErrorCode");
			listPublishedServicesResponse.TraceId = context.StringValue("ListPublishedServices.TraceId");

			List<ListPublishedServicesResponse.ListPublishedServices_DataItem> listPublishedServicesResponse_data = new List<ListPublishedServicesResponse.ListPublishedServices_DataItem>();
			for (int i = 0; i < context.Length("ListPublishedServices.Data.Length"); i++) {
				ListPublishedServicesResponse.ListPublishedServices_DataItem dataItem = new ListPublishedServicesResponse.ListPublishedServices_DataItem();
				dataItem.AppId = context.StringValue("ListPublishedServices.Data["+ i +"].AppId");
				dataItem.Group2Ip = context.StringValue("ListPublishedServices.Data["+ i +"].Group2Ip");
				dataItem.Name = context.StringValue("ListPublishedServices.Data["+ i +"].Name");
				dataItem.Type = context.StringValue("ListPublishedServices.Data["+ i +"].Type");
				dataItem.Version = context.StringValue("ListPublishedServices.Data["+ i +"].Version");

				List<string> dataItem_groups = new List<string>();
				for (int j = 0; j < context.Length("ListPublishedServices.Data["+ i +"].Groups.Length"); j++) {
					dataItem_groups.Add(context.StringValue("ListPublishedServices.Data["+ i +"].Groups["+ j +"]"));
				}
				dataItem.Groups = dataItem_groups;

				List<string> dataItem_ips = new List<string>();
				for (int j = 0; j < context.Length("ListPublishedServices.Data["+ i +"].Ips.Length"); j++) {
					dataItem_ips.Add(context.StringValue("ListPublishedServices.Data["+ i +"].Ips["+ j +"]"));
				}
				dataItem.Ips = dataItem_ips;

				listPublishedServicesResponse_data.Add(dataItem);
			}
			listPublishedServicesResponse.Data = listPublishedServicesResponse_data;
        
			return listPublishedServicesResponse;
        }
    }
}
