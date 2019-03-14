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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListRequiredServiceResponseUnmarshaller
    {
        public static ListRequiredServiceResponse Unmarshall(UnmarshallerContext context)
        {
			ListRequiredServiceResponse listRequiredServiceResponse = new ListRequiredServiceResponse();

			listRequiredServiceResponse.HttpResponse = context.HttpResponse;
			listRequiredServiceResponse.RequestId = context.StringValue("ListRequiredService.RequestId");
			listRequiredServiceResponse.NeedOtherService = context.BooleanValue("ListRequiredService.NeedOtherService");

			List<ListRequiredServiceResponse.ListRequiredService_Service> listRequiredServiceResponse_serviceList = new List<ListRequiredServiceResponse.ListRequiredService_Service>();
			for (int i = 0; i < context.Length("ListRequiredService.ServiceList.Length"); i++) {
				ListRequiredServiceResponse.ListRequiredService_Service service = new ListRequiredServiceResponse.ListRequiredService_Service();
				service.ServiceName = context.StringValue("ListRequiredService.ServiceList["+ i +"].ServiceName");
				service.ServiceDisplayName = context.StringValue("ListRequiredService.ServiceList["+ i +"].ServiceDisplayName");

				listRequiredServiceResponse_serviceList.Add(service);
			}
			listRequiredServiceResponse.ServiceList = listRequiredServiceResponse_serviceList;
        
			return listRequiredServiceResponse;
        }
    }
}
