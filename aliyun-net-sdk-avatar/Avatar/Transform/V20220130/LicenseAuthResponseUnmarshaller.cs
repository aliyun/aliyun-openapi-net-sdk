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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class LicenseAuthResponseUnmarshaller
    {
        public static LicenseAuthResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LicenseAuthResponse licenseAuthResponse = new LicenseAuthResponse();

			licenseAuthResponse.HttpResponse = _ctx.HttpResponse;
			licenseAuthResponse.RequestId = _ctx.StringValue("LicenseAuth.RequestId");
			licenseAuthResponse.Code = _ctx.StringValue("LicenseAuth.Code");
			licenseAuthResponse.Message = _ctx.StringValue("LicenseAuth.Message");
			licenseAuthResponse.Success = _ctx.BooleanValue("LicenseAuth.Success");

			LicenseAuthResponse.LicenseAuth_Data data = new LicenseAuthResponse.LicenseAuth_Data();
			data.Token = _ctx.StringValue("LicenseAuth.Data.Token");
			licenseAuthResponse.Data = data;
        
			return licenseAuthResponse;
        }
    }
}
