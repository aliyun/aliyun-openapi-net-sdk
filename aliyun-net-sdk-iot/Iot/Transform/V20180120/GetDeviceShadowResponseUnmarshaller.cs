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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetDeviceShadowResponseUnmarshaller
    {
        public static GetDeviceShadowResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeviceShadowResponse getDeviceShadowResponse = new GetDeviceShadowResponse();

			getDeviceShadowResponse.HttpResponse = context.HttpResponse;
			getDeviceShadowResponse.RequestId = context.StringValue("GetDeviceShadow.RequestId");
			getDeviceShadowResponse.Success = context.BooleanValue("GetDeviceShadow.Success");
			getDeviceShadowResponse.Code = context.StringValue("GetDeviceShadow.Code");
			getDeviceShadowResponse.ErrorMessage = context.StringValue("GetDeviceShadow.ErrorMessage");
			getDeviceShadowResponse.ShadowMessage = context.StringValue("GetDeviceShadow.ShadowMessage");
        
			return getDeviceShadowResponse;
        }
    }
}
