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
        public static ListConsumedServicesResponse Unmarshall(UnmarshallerContext context)
        {
			ListConsumedServicesResponse listConsumedServicesResponse = new ListConsumedServicesResponse();

			listConsumedServicesResponse.HttpResponse = context.HttpResponse;
			listConsumedServicesResponse.Code = context.StringValue("ListConsumedServices.Code");
			listConsumedServicesResponse.Message = context.StringValue("ListConsumedServices.Message");
			listConsumedServicesResponse.RequestId = context.StringValue("ListConsumedServices.RequestId");
			listConsumedServicesResponse.Success = context.BooleanValue("ListConsumedServices.Success");
			listConsumedServicesResponse.ErrorCode = context.StringValue("ListConsumedServices.ErrorCode");
			listConsumedServicesResponse.TraceId = context.StringValue("ListConsumedServices.TraceId");

			List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices> listConsumedServicesResponse_data = new List<ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices>();
			for (int i = 0; i < context.Length("ListConsumedServices.Data.Length"); i++) {
				ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices listConsumedServices = new ListConsumedServicesResponse.ListConsumedServices_ListConsumedServices();
				listConsumedServices.AppId = context.StringValue("ListConsumedServices.Data["+ i +"].AppId");
				listConsumedServices.Group2Ip = context.StringValue("ListConsumedServices.Data["+ i +"].Group2Ip");
				listConsumedServices.Name = context.StringValue("ListConsumedServices.Data["+ i +"].Name");
				listConsumedServices.Type = context.StringValue("ListConsumedServices.Data["+ i +"].Type");
				listConsumedServices.Version = context.StringValue("ListConsumedServices.Data["+ i +"].Version");

				List<string> listConsumedServices_groups = new List<string>();
				for (int j = 0; j < context.Length("ListConsumedServices.Data["+ i +"].Groups.Length"); j++) {
					listConsumedServices_groups.Add(context.StringValue("ListConsumedServices.Data["+ i +"].Groups["+ j +"]"));
				}
				listConsumedServices.Groups = listConsumedServices_groups;

				List<string> listConsumedServices_ips = new List<string>();
				for (int j = 0; j < context.Length("ListConsumedServices.Data["+ i +"].Ips.Length"); j++) {
					listConsumedServices_ips.Add(context.StringValue("ListConsumedServices.Data["+ i +"].Ips["+ j +"]"));
				}
				listConsumedServices.Ips = listConsumedServices_ips;

				listConsumedServicesResponse_data.Add(listConsumedServices);
			}
			listConsumedServicesResponse.Data = listConsumedServicesResponse_data;
        
			return listConsumedServicesResponse;
        }
    }
}
