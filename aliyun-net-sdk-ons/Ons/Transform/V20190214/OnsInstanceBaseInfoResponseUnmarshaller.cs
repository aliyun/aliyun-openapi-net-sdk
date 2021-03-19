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
        public static OnsInstanceBaseInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsInstanceBaseInfoResponse onsInstanceBaseInfoResponse = new OnsInstanceBaseInfoResponse();

			onsInstanceBaseInfoResponse.HttpResponse = _ctx.HttpResponse;
			onsInstanceBaseInfoResponse.RequestId = _ctx.StringValue("OnsInstanceBaseInfo.RequestId");
			onsInstanceBaseInfoResponse.HelpUrl = _ctx.StringValue("OnsInstanceBaseInfo.HelpUrl");

			OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo instanceBaseInfo = new OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo();
			instanceBaseInfo.InstanceId = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceId");
			instanceBaseInfo.InstanceStatus = _ctx.IntegerValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceStatus");
			instanceBaseInfo.ReleaseTime = _ctx.LongValue("OnsInstanceBaseInfo.InstanceBaseInfo.ReleaseTime");
			instanceBaseInfo.InstanceType = _ctx.IntegerValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceType");
			instanceBaseInfo.InstanceName = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.InstanceName");
			instanceBaseInfo.IndependentNaming = _ctx.BooleanValue("OnsInstanceBaseInfo.InstanceBaseInfo.IndependentNaming");
			instanceBaseInfo.Remark = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Remark");
			instanceBaseInfo.TopicCapacity = _ctx.IntegerValue("OnsInstanceBaseInfo.InstanceBaseInfo.TopicCapacity");
			instanceBaseInfo.MaxTps = _ctx.LongValue("OnsInstanceBaseInfo.InstanceBaseInfo.MaxTps");

			OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo.OnsInstanceBaseInfo_Endpoints endpoints = new OnsInstanceBaseInfoResponse.OnsInstanceBaseInfo_InstanceBaseInfo.OnsInstanceBaseInfo_Endpoints();
			endpoints.TcpEndpoint = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.TcpEndpoint");
			endpoints.HttpInternetEndpoint = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternetEndpoint");
			endpoints.HttpInternetSecureEndpoint = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternetSecureEndpoint");
			endpoints.HttpInternalEndpoint = _ctx.StringValue("OnsInstanceBaseInfo.InstanceBaseInfo.Endpoints.HttpInternalEndpoint");
			instanceBaseInfo.Endpoints = endpoints;
			onsInstanceBaseInfoResponse.InstanceBaseInfo = instanceBaseInfo;
        
			return onsInstanceBaseInfoResponse;
        }
    }
}
