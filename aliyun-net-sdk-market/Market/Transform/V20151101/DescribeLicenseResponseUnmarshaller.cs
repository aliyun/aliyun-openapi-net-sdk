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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeLicenseResponseUnmarshaller
    {
        public static DescribeLicenseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLicenseResponse describeLicenseResponse = new DescribeLicenseResponse();

			describeLicenseResponse.HttpResponse = _ctx.HttpResponse;
			describeLicenseResponse.RequestId = _ctx.StringValue("DescribeLicense.RequestId");

			DescribeLicenseResponse.DescribeLicense_License license = new DescribeLicenseResponse.DescribeLicense_License();
			license.ActivateTime = _ctx.StringValue("DescribeLicense.License.ActivateTime");
			license.LicenseStatus = _ctx.StringValue("DescribeLicense.License.LicenseStatus");
			license.ProductName = _ctx.StringValue("DescribeLicense.License.ProductName");
			license.ExpiredTime = _ctx.StringValue("DescribeLicense.License.ExpiredTime");
			license.ProductSkuId = _ctx.StringValue("DescribeLicense.License.ProductSkuId");
			license.CreateTime = _ctx.StringValue("DescribeLicense.License.CreateTime");
			license.LicenseCode = _ctx.StringValue("DescribeLicense.License.LicenseCode");
			license.InstanceId = _ctx.StringValue("DescribeLicense.License.InstanceId");
			license.SupplierName = _ctx.StringValue("DescribeLicense.License.SupplierName");
			license.ProductCode = _ctx.StringValue("DescribeLicense.License.ProductCode");

			DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_ExtendInfo extendInfo = new DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_ExtendInfo();
			extendInfo.AliUid = _ctx.LongValue("DescribeLicense.License.ExtendInfo.AliUid");
			extendInfo.AccountQuantity = _ctx.LongValue("DescribeLicense.License.ExtendInfo.AccountQuantity");
			extendInfo.Email = _ctx.StringValue("DescribeLicense.License.ExtendInfo.Email");
			extendInfo.Mobile = _ctx.StringValue("DescribeLicense.License.ExtendInfo.Mobile");
			license.ExtendInfo = extendInfo;

			List<DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_LicenseAttribute> license_extendArray = new List<DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_LicenseAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeLicense.License.ExtendArray.Length"); i++) {
				DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_LicenseAttribute licenseAttribute = new DescribeLicenseResponse.DescribeLicense_License.DescribeLicense_LicenseAttribute();
				licenseAttribute.Code = _ctx.StringValue("DescribeLicense.License.ExtendArray["+ i +"].Code");
				licenseAttribute._Value = _ctx.StringValue("DescribeLicense.License.ExtendArray["+ i +"].Value");

				license_extendArray.Add(licenseAttribute);
			}
			license.ExtendArray = license_extendArray;
			describeLicenseResponse.License = license;
        
			return describeLicenseResponse;
        }
    }
}
