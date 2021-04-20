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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetServiceExtensionsResponseUnmarshaller
    {
        public static GetServiceExtensionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceExtensionsResponse getServiceExtensionsResponse = new GetServiceExtensionsResponse();

			getServiceExtensionsResponse.HttpResponse = _ctx.HttpResponse;
			getServiceExtensionsResponse.RequestId = _ctx.StringValue("GetServiceExtensions.RequestId");
			getServiceExtensionsResponse.Success = _ctx.BooleanValue("GetServiceExtensions.Success");
			getServiceExtensionsResponse.Code = _ctx.StringValue("GetServiceExtensions.Code");
			getServiceExtensionsResponse.Message = _ctx.StringValue("GetServiceExtensions.Message");
			getServiceExtensionsResponse.HttpStatusCode = _ctx.IntegerValue("GetServiceExtensions.HttpStatusCode");

			List<GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension> getServiceExtensionsResponse_serviceExtensions = new List<GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension>();
			for (int i = 0; i < _ctx.Length("GetServiceExtensions.ServiceExtensions.Length"); i++) {
				GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension serviceExtension = new GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension();
				serviceExtension.Name = _ctx.StringValue("GetServiceExtensions.ServiceExtensions["+ i +"].Name");
				serviceExtension.Number = _ctx.StringValue("GetServiceExtensions.ServiceExtensions["+ i +"].Number");

				getServiceExtensionsResponse_serviceExtensions.Add(serviceExtension);
			}
			getServiceExtensionsResponse.ServiceExtensions = getServiceExtensionsResponse_serviceExtensions;
        
			return getServiceExtensionsResponse;
        }
    }
}
