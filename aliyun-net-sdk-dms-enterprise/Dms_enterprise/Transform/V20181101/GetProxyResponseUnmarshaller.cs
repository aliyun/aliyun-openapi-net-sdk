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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetProxyResponseUnmarshaller
    {
        public static GetProxyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProxyResponse getProxyResponse = new GetProxyResponse();

			getProxyResponse.HttpResponse = _ctx.HttpResponse;
			getProxyResponse.RequestId = _ctx.StringValue("GetProxy.RequestId");
			getProxyResponse.Success = _ctx.BooleanValue("GetProxy.Success");
			getProxyResponse.ErrorMessage = _ctx.StringValue("GetProxy.ErrorMessage");
			getProxyResponse.ErrorCode = _ctx.StringValue("GetProxy.ErrorCode");
			getProxyResponse.ProxyId = _ctx.LongValue("GetProxy.ProxyId");
			getProxyResponse.CreatorId = _ctx.LongValue("GetProxy.CreatorId");
			getProxyResponse.CreatorName = _ctx.StringValue("GetProxy.CreatorName");
			getProxyResponse.InstanceId = _ctx.LongValue("GetProxy.InstanceId");
			getProxyResponse.PrivateEnable = _ctx.BooleanValue("GetProxy.PrivateEnable");
			getProxyResponse.PrivateHost = _ctx.StringValue("GetProxy.PrivateHost");
			getProxyResponse.PublicEnable = _ctx.BooleanValue("GetProxy.PublicEnable");
			getProxyResponse.PublicHost = _ctx.StringValue("GetProxy.PublicHost");
			getProxyResponse.MysqlPort = _ctx.IntegerValue("GetProxy.MysqlPort");
			getProxyResponse.HttpsPort = _ctx.IntegerValue("GetProxy.HttpsPort");
        
			return getProxyResponse;
        }
    }
}
