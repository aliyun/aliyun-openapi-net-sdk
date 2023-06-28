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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIcAdminLicenseResponseUnmarshaller
    {
        public static GetOcIcAdminLicenseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcAdminLicenseResponse getOcIcAdminLicenseResponse = new GetOcIcAdminLicenseResponse();

			getOcIcAdminLicenseResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcAdminLicenseResponse.Code = _ctx.StringValue("GetOcIcAdminLicense.Code");
			getOcIcAdminLicenseResponse.Success = _ctx.BooleanValue("GetOcIcAdminLicense.Success");
			getOcIcAdminLicenseResponse.Message = _ctx.StringValue("GetOcIcAdminLicense.Message");
			getOcIcAdminLicenseResponse.TotalNum = _ctx.IntegerValue("GetOcIcAdminLicense.TotalNum");
			getOcIcAdminLicenseResponse.PageIndex = _ctx.IntegerValue("GetOcIcAdminLicense.PageIndex");
			getOcIcAdminLicenseResponse.PageNum = _ctx.IntegerValue("GetOcIcAdminLicense.PageNum");
			getOcIcAdminLicenseResponse.RequestId = _ctx.StringValue("GetOcIcAdminLicense.RequestId");

			List<GetOcIcAdminLicenseResponse.GetOcIcAdminLicense_DataItem> getOcIcAdminLicenseResponse_data = new List<GetOcIcAdminLicenseResponse.GetOcIcAdminLicense_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcAdminLicense.Data.Length"); i++) {
				GetOcIcAdminLicenseResponse.GetOcIcAdminLicense_DataItem dataItem = new GetOcIcAdminLicenseResponse.GetOcIcAdminLicense_DataItem();
				dataItem.LicenseNo = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].LicenseNo");
				dataItem.LicenseName = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].LicenseName");
				dataItem.Department = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].Department");
				dataItem.StartDate = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].StartDate");
				dataItem.EndDate = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].EndDate");
				dataItem.Content = _ctx.StringValue("GetOcIcAdminLicense.Data["+ i +"].Content");

				getOcIcAdminLicenseResponse_data.Add(dataItem);
			}
			getOcIcAdminLicenseResponse.Data = getOcIcAdminLicenseResponse_data;
        
			return getOcIcAdminLicenseResponse;
        }
    }
}
