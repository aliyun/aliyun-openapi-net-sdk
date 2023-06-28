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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class EnableDeviceResponseUnmarshaller
    {
        public static EnableDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EnableDeviceResponse enableDeviceResponse = new EnableDeviceResponse();

			enableDeviceResponse.HttpResponse = _ctx.HttpResponse;
			enableDeviceResponse.Code = _ctx.StringValue("EnableDevice.Code");
			enableDeviceResponse.HttpStatusCode = _ctx.IntegerValue("EnableDevice.HttpStatusCode");
			enableDeviceResponse.Message = _ctx.StringValue("EnableDevice.Message");
			enableDeviceResponse.RequestId = _ctx.StringValue("EnableDevice.RequestId");
			enableDeviceResponse.Success = _ctx.BooleanValue("EnableDevice.Success");
        
			return enableDeviceResponse;
        }
    }
}
