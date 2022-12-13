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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetServiceInvokeResponseUnmarshaller
    {
        public static GetServiceInvokeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceInvokeResponse getServiceInvokeResponse = new GetServiceInvokeResponse();

			getServiceInvokeResponse.HttpResponse = _ctx.HttpResponse;
			getServiceInvokeResponse.Message = _ctx.StringValue("GetServiceInvoke.Message");
			getServiceInvokeResponse.RequestId = _ctx.StringValue("GetServiceInvoke.RequestId");
			getServiceInvokeResponse.Code = _ctx.StringValue("GetServiceInvoke.Code");

			GetServiceInvokeResponse.GetServiceInvoke_Data data = new GetServiceInvokeResponse.GetServiceInvoke_Data();
			data.UserInvoke = _ctx.StringValue("GetServiceInvoke.Data.UserInvoke");
			getServiceInvokeResponse.Data = data;
        
			return getServiceInvokeResponse;
        }
    }
}
