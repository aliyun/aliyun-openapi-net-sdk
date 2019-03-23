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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetServiceExtensionsResponseUnmarshaller
    {
        public static GetServiceExtensionsResponse Unmarshall(UnmarshallerContext context)
        {
            GetServiceExtensionsResponse getServiceExtensionsResponse = new GetServiceExtensionsResponse();

            getServiceExtensionsResponse.HttpResponse = context.HttpResponse;
            getServiceExtensionsResponse.RequestId = context.StringValue("GetServiceExtensions.RequestId");
            getServiceExtensionsResponse.Success = context.BooleanValue("GetServiceExtensions.Success");
            getServiceExtensionsResponse.Code = context.StringValue("GetServiceExtensions.Code");
            getServiceExtensionsResponse.Message = context.StringValue("GetServiceExtensions.Message");
            getServiceExtensionsResponse.HttpStatusCode = context.IntegerValue("GetServiceExtensions.HttpStatusCode");

            List<GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension> getServiceExtensionsResponse_serviceExtensions = new List<GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension>();
            for (int i = 0; i < context.Length("GetServiceExtensions.ServiceExtensions.Length"); i++)
            {
                GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension serviceExtension = new GetServiceExtensionsResponse.GetServiceExtensions_ServiceExtension();
                serviceExtension.Name = context.StringValue("GetServiceExtensions.ServiceExtensions[" + i + "].Name");
                serviceExtension.Number = context.StringValue("GetServiceExtensions.ServiceExtensions[" + i + "].Number");

                getServiceExtensionsResponse_serviceExtensions.Add(serviceExtension);
            }
            getServiceExtensionsResponse.ServiceExtensions = getServiceExtensionsResponse_serviceExtensions;

            return getServiceExtensionsResponse;
        }
    }
}