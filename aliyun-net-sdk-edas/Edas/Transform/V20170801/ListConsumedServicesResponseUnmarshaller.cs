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
    public class ListConsumedServicesResponseUnmarshaller
    {
        public static ListConsumedServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConsumedServicesResponse listConsumedServicesResponse = new ListConsumedServicesResponse();

			listConsumedServicesResponse.HttpResponse = _ctx.HttpResponse;
			listConsumedServicesResponse.Code = _ctx.IntegerValue("ListConsumedServices.Code");
			listConsumedServicesResponse.Message = _ctx.StringValue("ListConsumedServices.Message");
			listConsumedServicesResponse.RequestId = _ctx.StringValue("ListConsumedServices.RequestId");

			List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices> listConsumedServicesResponse_consumedServicesList = new List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices>();
			for (int i = 0; i < _ctx.Length("ListConsumedServices.ConsumedServicesList.Length"); i++) {
				ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices listConsumedServices = new ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices();
				listConsumedServices.AppId = _ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].AppId");
				listConsumedServices.DockerApplication = _ctx.BooleanValue("ListConsumedServices.ConsumedServicesList["+ i +"].DockerApplication");
				listConsumedServices.Group2Ip = _ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Group2Ip");
				listConsumedServices.Name = _ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Name");
				listConsumedServices.Type = _ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Type");
				listConsumedServices.Version = _ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Version");

				List<string> listConsumedServices_groups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListConsumedServices.ConsumedServicesList["+ i +"].Groups.Length"); j++) {
					listConsumedServices_groups.Add(_ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Groups["+ j +"]"));
				}
				listConsumedServices.Groups = listConsumedServices_groups;

				List<string> listConsumedServices_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("ListConsumedServices.ConsumedServicesList["+ i +"].Ips.Length"); j++) {
					listConsumedServices_ips.Add(_ctx.StringValue("ListConsumedServices.ConsumedServicesList["+ i +"].Ips["+ j +"]"));
				}
				listConsumedServices.Ips = listConsumedServices_ips;

				listConsumedServicesResponse_consumedServicesList.Add(listConsumedServices);
			}
			listConsumedServicesResponse.ConsumedServicesList = listConsumedServicesResponse_consumedServicesList;
        
			return listConsumedServicesResponse;
        }
    }
}
