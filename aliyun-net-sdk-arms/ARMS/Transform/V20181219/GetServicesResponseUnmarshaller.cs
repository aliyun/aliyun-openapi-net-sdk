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
using Aliyun.Acs.ARMS.Model.V20181219;

namespace Aliyun.Acs.ARMS.Transform.V20181219
{
    public class GetServicesResponseUnmarshaller
    {
        public static GetServicesResponse Unmarshall(UnmarshallerContext context)
        {
			GetServicesResponse getServicesResponse = new GetServicesResponse();

			getServicesResponse.HttpResponse = context.HttpResponse;
			getServicesResponse.RequestId = context.StringValue("GetServices.RequestId");

			GetServicesResponse.GetServices_Data data = new GetServicesResponse.GetServices_Data();

			List<string> data_services = new List<string>();
			for (int i = 0; i < context.Length("GetServices.Data.Services.Length"); i++) {
				data_services.Add(context.StringValue("GetServices.Data.Services["+ i +"]"));
			}
			data.Services = data_services;

			List<GetServicesResponse.GetServices_Data.GetServices_DetailsItem> data_details = new List<GetServicesResponse.GetServices_Data.GetServices_DetailsItem>();
			for (int i = 0; i < context.Length("GetServices.Data.Details.Length"); i++) {
				GetServicesResponse.GetServices_Data.GetServices_DetailsItem detailsItem = new GetServicesResponse.GetServices_Data.GetServices_DetailsItem();
				detailsItem.ServiceName = context.StringValue("GetServices.Data.Details["+ i +"].ServiceName");
				detailsItem.Pid = context.StringValue("GetServices.Data.Details["+ i +"].Pid");
				detailsItem.RegionId = context.StringValue("GetServices.Data.Details["+ i +"].RegionId");

				data_details.Add(detailsItem);
			}
			data.Details = data_details;
			getServicesResponse.Data = data;
        
			return getServicesResponse;
        }
    }
}
