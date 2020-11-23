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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class VerifyDeviceResponseUnmarshaller
    {
        public static VerifyDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyDeviceResponse verifyDeviceResponse = new VerifyDeviceResponse();

			verifyDeviceResponse.HttpResponse = _ctx.HttpResponse;
			verifyDeviceResponse.RequestId = _ctx.StringValue("VerifyDevice.RequestId");
			verifyDeviceResponse.Code = _ctx.StringValue("VerifyDevice.Code");
			verifyDeviceResponse.Message = _ctx.StringValue("VerifyDevice.Message");

			VerifyDeviceResponse.VerifyDevice_ResultObject resultObject = new VerifyDeviceResponse.VerifyDevice_ResultObject();
			resultObject.ValidationRetCode = _ctx.StringValue("VerifyDevice.ResultObject.ValidationRetCode");
			resultObject.ProductRetCode = _ctx.StringValue("VerifyDevice.ResultObject.ProductRetCode");
			resultObject.RetCodeSub = _ctx.StringValue("VerifyDevice.ResultObject.RetCodeSub");
			resultObject.RetMessageSub = _ctx.StringValue("VerifyDevice.ResultObject.RetMessageSub");
			resultObject.HasNext = _ctx.StringValue("VerifyDevice.ResultObject.HasNext");
			resultObject.ExtParams = _ctx.StringValue("VerifyDevice.ResultObject.ExtParams");
			verifyDeviceResponse.ResultObject = resultObject;
        
			return verifyDeviceResponse;
        }
    }
}
