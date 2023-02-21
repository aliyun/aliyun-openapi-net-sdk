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
    public class GetOcIcBasicResponseUnmarshaller
    {
        public static GetOcIcBasicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcBasicResponse getOcIcBasicResponse = new GetOcIcBasicResponse();

			getOcIcBasicResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcBasicResponse.Code = _ctx.StringValue("GetOcIcBasic.Code");
			getOcIcBasicResponse.Success = _ctx.BooleanValue("GetOcIcBasic.Success");
			getOcIcBasicResponse.Message = _ctx.StringValue("GetOcIcBasic.Message");
			getOcIcBasicResponse.TotalNum = _ctx.IntegerValue("GetOcIcBasic.TotalNum");
			getOcIcBasicResponse.PageIndex = _ctx.IntegerValue("GetOcIcBasic.PageIndex");
			getOcIcBasicResponse.PageNum = _ctx.IntegerValue("GetOcIcBasic.PageNum");
			getOcIcBasicResponse.RequestId = _ctx.StringValue("GetOcIcBasic.RequestId");

			GetOcIcBasicResponse.GetOcIcBasic_Data data = new GetOcIcBasicResponse.GetOcIcBasic_Data();
			data.EntName = _ctx.StringValue("GetOcIcBasic.Data.EntName");
			data.LegalName = _ctx.StringValue("GetOcIcBasic.Data.LegalName");
			data.EsDate = _ctx.StringValue("GetOcIcBasic.Data.EsDate");
			data.EntStatus = _ctx.StringValue("GetOcIcBasic.Data.EntStatus");
			data.RegCap = _ctx.StringValue("GetOcIcBasic.Data.RegCap");
			data.RecCap = _ctx.StringValue("GetOcIcBasic.Data.RecCap");
			data.SocialCreditCode = _ctx.StringValue("GetOcIcBasic.Data.SocialCreditCode");
			data.LicenseNumber = _ctx.StringValue("GetOcIcBasic.Data.LicenseNumber");
			data.OrgNo = _ctx.StringValue("GetOcIcBasic.Data.OrgNo");
			data.TaxNum = _ctx.StringValue("GetOcIcBasic.Data.TaxNum");
			data.EntType = _ctx.StringValue("GetOcIcBasic.Data.EntType");
			data.IndustryNameLv1 = _ctx.StringValue("GetOcIcBasic.Data.IndustryNameLv1");
			data.IndustryNameLv2 = _ctx.StringValue("GetOcIcBasic.Data.IndustryNameLv2");
			data.OpFrom = _ctx.StringValue("GetOcIcBasic.Data.OpFrom");
			data.OpTo = _ctx.StringValue("GetOcIcBasic.Data.OpTo");
			data.StaffNum = _ctx.StringValue("GetOcIcBasic.Data.StaffNum");
			data.InsuredNum = _ctx.StringValue("GetOcIcBasic.Data.InsuredNum");
			data.EntNameEng = _ctx.StringValue("GetOcIcBasic.Data.EntNameEng");
			data.FormerNames = _ctx.StringValue("GetOcIcBasic.Data.FormerNames");
			data.RegOrg = _ctx.StringValue("GetOcIcBasic.Data.RegOrg");
			data.CheckDate = _ctx.StringValue("GetOcIcBasic.Data.CheckDate");
			data.OpScope = _ctx.StringValue("GetOcIcBasic.Data.OpScope");
			data.EntAddress = _ctx.StringValue("GetOcIcBasic.Data.EntAddress");
			data.EntBrief = _ctx.StringValue("GetOcIcBasic.Data.EntBrief");
			data.RegOrgProvince = _ctx.StringValue("GetOcIcBasic.Data.RegOrgProvince");
			data.RegOrgCity = _ctx.StringValue("GetOcIcBasic.Data.RegOrgCity");
			data.RegOrgDistrict = _ctx.StringValue("GetOcIcBasic.Data.RegOrgDistrict");
			getOcIcBasicResponse.Data = data;
        
			return getOcIcBasicResponse;
        }
    }
}
