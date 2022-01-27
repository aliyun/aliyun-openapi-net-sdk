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
    public class ListConsumedServicesResponseUnmarshaller
    {
        public static ListConsumedServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConsumedServicesResponse listConsumedServicesResponse = new ListConsumedServicesResponse();

			listConsumedServicesResponse.HttpResponse = _ctx.HttpResponse;
			listConsumedServicesResponse.Message = _ctx.StringValue("ListConsumedServices.Message");
			listConsumedServicesResponse.RequestId = _ctx.StringValue("ListConsumedServices.RequestId");
			listConsumedServicesResponse.TraceId = _ctx.StringValue("ListConsumedServices.TraceId");
			listConsumedServicesResponse.ErrorCode = _ctx.StringValue("ListConsumedServices.ErrorCode");
			listConsumedServicesResponse.Code = _ctx.StringValue("ListConsumedServices.Code");
			listConsumedServicesResponse.Success = _ctx.BooleanValue("ListConsumedServices.Success");

			List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices> listConsumedServicesResponse_data = new List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices>();
			for (int i = 0; i < _ctx.Length("ListConsumedServices.Data.Length"); i++) {
				ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices listConsumedServices = new ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices();
				listConsumedServices.Group2Ip = _ctx.StringValue("ListConsumedServices.Data["+ i +"].Group2Ip");
				listConsumedServices.Type = _ctx.StringValue("ListConsumedServices.Data["+ i +"].Type");
				listConsumedServices.AppId = _ctx.StringValue("ListConsumedServices.Data["+ i +"].AppId");
				listConsumedServices.Version = _ctx.StringValue("ListConsumedServices.Data["+ i +"].Version");
				listConsumedServices.Name = _ctx.StringValue("ListConsumedServices.Data["+ i +"].Name");

				List<string> listConsumedServices_groups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListConsumedServices.Data["+ i +"].Groups.Length"); j++) {
					listConsumedServices_groups.Add(_ctx.StringValue("ListConsumedServices.Data["+ i +"].Groups["+ j +"]"));
				}
				listConsumedServices.Groups = listConsumedServices_groups;

				List<string> listConsumedServices_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("ListConsumedServices.Data["+ i +"].Ips.Length"); j++) {
					listConsumedServices_ips.Add(_ctx.StringValue("ListConsumedServices.Data["+ i +"].Ips["+ j +"]"));
				}
				listConsumedServices.Ips = listConsumedServices_ips;

				listConsumedServicesResponse_data.Add(listConsumedServices);
			}
			listConsumedServicesResponse.Data = listConsumedServicesResponse_data;
        
			return listConsumedServicesResponse;
        }
    }
}
