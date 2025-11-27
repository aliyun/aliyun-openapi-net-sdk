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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class GetVerificationInfoResponseUnmarshaller
    {
        public static GetVerificationInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVerificationInfoResponse getVerificationInfoResponse = new GetVerificationInfoResponse();

			getVerificationInfoResponse.HttpResponse = _ctx.HttpResponse;
			getVerificationInfoResponse.RequestId = _ctx.StringValue("GetVerificationInfo.RequestId");

			GetVerificationInfoResponse.GetVerificationInfo_SecurityPhoneDevice securityPhoneDevice = new GetVerificationInfoResponse.GetVerificationInfo_SecurityPhoneDevice();
			securityPhoneDevice.AreaCode = _ctx.StringValue("GetVerificationInfo.SecurityPhoneDevice.AreaCode");
			securityPhoneDevice.PhoneNumber = _ctx.StringValue("GetVerificationInfo.SecurityPhoneDevice.PhoneNumber");
			securityPhoneDevice.Status = _ctx.StringValue("GetVerificationInfo.SecurityPhoneDevice.Status");
			getVerificationInfoResponse.SecurityPhoneDevice = securityPhoneDevice;

			GetVerificationInfoResponse.GetVerificationInfo_SecurityEmailDevice securityEmailDevice = new GetVerificationInfoResponse.GetVerificationInfo_SecurityEmailDevice();
			securityEmailDevice.Email = _ctx.StringValue("GetVerificationInfo.SecurityEmailDevice.Email");
			securityEmailDevice.Status = _ctx.StringValue("GetVerificationInfo.SecurityEmailDevice.Status");
			getVerificationInfoResponse.SecurityEmailDevice = securityEmailDevice;
        
			return getVerificationInfoResponse;
        }
    }
}
