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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetLicenseInfoResponseUnmarshaller
    {
        public static GetLicenseInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLicenseInfoResponse getLicenseInfoResponse = new GetLicenseInfoResponse();

			getLicenseInfoResponse.HttpResponse = _ctx.HttpResponse;
			getLicenseInfoResponse.RequestId = _ctx.StringValue("GetLicenseInfo.RequestId");
			getLicenseInfoResponse.Success = _ctx.BooleanValue("GetLicenseInfo.Success");

			GetLicenseInfoResponse.GetLicenseInfo_Data data = new GetLicenseInfoResponse.GetLicenseInfo_Data();
			data.CompanyName = _ctx.StringValue("GetLicenseInfo.Data.CompanyName");
			data.CardNum = _ctx.StringValue("GetLicenseInfo.Data.CardNum");
			data.Address = _ctx.StringValue("GetLicenseInfo.Data.Address");
			data.EnterpriseTime = _ctx.StringValue("GetLicenseInfo.Data.EnterpriseTime");
			data.Name = _ctx.StringValue("GetLicenseInfo.Data.Name");
			data.EffectivePeriod = _ctx.StringValue("GetLicenseInfo.Data.EffectivePeriod");
			data.Province = _ctx.StringValue("GetLicenseInfo.Data.Province");
			data.City = _ctx.StringValue("GetLicenseInfo.Data.City");
			getLicenseInfoResponse.Data = data;
        
			return getLicenseInfoResponse;
        }
    }
}
