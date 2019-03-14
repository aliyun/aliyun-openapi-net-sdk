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
    public class ListDependedServiceResponseUnmarshaller
    {
        public static ListDependedServiceResponse Unmarshall(UnmarshallerContext context)
        {
			ListDependedServiceResponse listDependedServiceResponse = new ListDependedServiceResponse();

			listDependedServiceResponse.HttpResponse = context.HttpResponse;
			listDependedServiceResponse.RequestId = context.StringValue("ListDependedService.RequestId");
			listDependedServiceResponse.ExistServices = context.BooleanValue("ListDependedService.ExistServices");

			List<ListDependedServiceResponse.ListDependedService_Service> listDependedServiceResponse_serviceList = new List<ListDependedServiceResponse.ListDependedService_Service>();
			for (int i = 0; i < context.Length("ListDependedService.ServiceList.Length"); i++) {
				ListDependedServiceResponse.ListDependedService_Service service = new ListDependedServiceResponse.ListDependedService_Service();
				service.ServiceName = context.StringValue("ListDependedService.ServiceList["+ i +"].ServiceName");
				service.ServiceDisplayName = context.StringValue("ListDependedService.ServiceList["+ i +"].ServiceDisplayName");

				listDependedServiceResponse_serviceList.Add(service);
			}
			listDependedServiceResponse.ServiceList = listDependedServiceResponse_serviceList;
        
			return listDependedServiceResponse;
        }
    }
}
