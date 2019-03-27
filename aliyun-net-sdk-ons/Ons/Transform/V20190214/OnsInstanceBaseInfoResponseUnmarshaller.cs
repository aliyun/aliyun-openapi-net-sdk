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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsInstanceBaseInfoResponseUnmarshaller
    {
        public static OnsInstanceBaseInfoResponse Unmarshall(UnmarshallerContext context)
        {
			OnsInstanceBaseInfoResponse onsInstanceBaseInfoResponse = new OnsInstanceBaseInfoResponse();

			onsInstanceBaseInfoResponse.HttpResponse = context.HttpResponse;
			onsInstanceBaseInfoResponse.RequestId = context.StringValue("OnsInstanceBaseInfo.RequestId");
			onsInstanceBaseInfoResponse.HelpUrl = context.StringValue("OnsInstanceBaseInfo.HelpUrl");

			OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo instanceBaseInfo = new OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo();
			instanceBaseInfo.InstanceId = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceId");
			instanceBaseInfo.InstanceStatus = context.IntegerValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceStatus");
			instanceBaseInfo.ReleaseTime = context.LongValue("OnsInstanceBaseInfo.InstanceBaseInfo.ReleaseTime");
			instanceBaseInfo.InstanceType = context.IntegerValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceType");
			instanceBaseInfo.InstanceName = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceName");
			instanceBaseInfo.IndependentNaming = context.BooleanValue("OnsInstanceBaseInfo.InstanceBaseInfo.IndependentNaming");

			OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo.OnsInstanceBaseInfo_Endpoints endpoints = new OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo.OnsInstanceBaseInfo_Endpoints();
			endpoints.TcpEndpoint = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.TcpEndpoint");
			endpoints.HttpInternetEndpoint = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternetEndpoint");
			endpoints.HttpInternetSecureEndpoint = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternetSecureEndpoint");
			endpoints.HttpInternalEndpoint = context.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternalEndpoint");
			instanceBaseInfo.Endpoints = endpoints;
			onsInstanceBaseInfoResponse.InstanceBaseInfo = instanceBaseInfo;
        
			return onsInstanceBaseInfoResponse;
        }
    }
}
