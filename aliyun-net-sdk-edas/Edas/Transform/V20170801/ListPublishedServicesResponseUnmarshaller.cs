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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListPublishedServicesResponseUnmarshaller
    {
        public static ListPublishedServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPublishedServicesResponse listPublishedServicesResponse = new ListPublishedServicesResponse();

			listPublishedServicesResponse.HttpResponse = _ctx.HttpResponse;
			listPublishedServicesResponse.Code = _ctx.IntegerValue("ListPublishedServices.Code");
			listPublishedServicesResponse.Message = _ctx.StringValue("ListPublishedServices.Message");
			listPublishedServicesResponse.RequestId = _ctx.StringValue("ListPublishedServices.RequestId");

			List<ListPublishedServicesResponse.ListPublishedServices_ListPublishedServices> listPublishedServicesResponse_publishedServicesList = new List<ListPublishedServicesResponse.ListPublishedServices_ListPublishedServices>();
			for (int i = 0; i < _ctx.Length("ListPublishedServices.PublishedServicesList.Length"); i++) {
				ListPublishedServicesResponse.ListPublishedServices_ListPublishedServices listPublishedServices = new ListPublishedServicesResponse.ListPublishedServices_ListPublishedServices();
				listPublishedServices.AppId = _ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].AppId");
				listPublishedServices.DockerApplication = _ctx.BooleanValue("ListPublishedServices.PublishedServicesList["+ i +"].DockerApplication");
				listPublishedServices.Group2Ip = _ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Group2Ip");
				listPublishedServices.Name = _ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Name");
				listPublishedServices.Type = _ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Type");
				listPublishedServices.Version = _ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Version");

				List<string> listPublishedServices_groups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPublishedServices.PublishedServicesList["+ i +"].Groups.Length"); j++) {
					listPublishedServices_groups.Add(_ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Groups["+ j +"]"));
				}
				listPublishedServices.Groups = listPublishedServices_groups;

				List<string> listPublishedServices_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPublishedServices.PublishedServicesList["+ i +"].Ips.Length"); j++) {
					listPublishedServices_ips.Add(_ctx.StringValue("ListPublishedServices.PublishedServicesList["+ i +"].Ips["+ j +"]"));
				}
				listPublishedServices.Ips = listPublishedServices_ips;

				listPublishedServicesResponse_publishedServicesList.Add(listPublishedServices);
			}
			listPublishedServicesResponse.PublishedServicesList = listPublishedServicesResponse_publishedServicesList;
        
			return listPublishedServicesResponse;
        }
    }
}
