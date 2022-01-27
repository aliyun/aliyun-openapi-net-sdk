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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class CallDeviceResponseUnmarshaller
    {
        public static CallDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CallDeviceResponse callDeviceResponse = new CallDeviceResponse();

			callDeviceResponse.HttpResponse = _ctx.HttpResponse;
			callDeviceResponse.ErrorCode = _ctx.IntegerValue("CallDevice.ErrorCode");
			callDeviceResponse.Message = _ctx.StringValue("CallDevice.Message");
			callDeviceResponse.Success = _ctx.BooleanValue("CallDevice.Success");
			callDeviceResponse.RequestId = _ctx.StringValue("CallDevice.RequestId");
			callDeviceResponse.MessageId = _ctx.StringValue("CallDevice.MessageId");
        
			return callDeviceResponse;
        }
    }
}
