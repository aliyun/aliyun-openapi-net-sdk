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
    public class GetOcTaxIllegalResponseUnmarshaller
    {
        public static GetOcTaxIllegalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxIllegalResponse getOcTaxIllegalResponse = new GetOcTaxIllegalResponse();

			getOcTaxIllegalResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxIllegalResponse.Code = _ctx.StringValue("GetOcTaxIllegal.Code");
			getOcTaxIllegalResponse.Success = _ctx.BooleanValue("GetOcTaxIllegal.Success");
			getOcTaxIllegalResponse.Message = _ctx.StringValue("GetOcTaxIllegal.Message");
			getOcTaxIllegalResponse.TotalNum = _ctx.IntegerValue("GetOcTaxIllegal.TotalNum");
			getOcTaxIllegalResponse.PageIndex = _ctx.IntegerValue("GetOcTaxIllegal.PageIndex");
			getOcTaxIllegalResponse.PageNum = _ctx.IntegerValue("GetOcTaxIllegal.PageNum");
			getOcTaxIllegalResponse.RequestId = _ctx.StringValue("GetOcTaxIllegal.RequestId");

			List<GetOcTaxIllegalResponse.GetOcTaxIllegal_DataItem> getOcTaxIllegalResponse_data = new List<GetOcTaxIllegalResponse.GetOcTaxIllegal_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxIllegal.Data.Length"); i++) {
				GetOcTaxIllegalResponse.GetOcTaxIllegal_DataItem dataItem = new GetOcTaxIllegalResponse.GetOcTaxIllegal_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].EntName");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].TaxpayerNum");
				dataItem.OrgCode = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].OrgCode");
				dataItem.EntAddress = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].EntAddress");
				dataItem.CaseType = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].CaseType");
				dataItem.IllegalTruth = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].IllegalTruth");
				dataItem.PublishDate = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].PublishDate");
				dataItem.LawBasis = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].LawBasis");
				dataItem.Department = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].Department");
				dataItem.LegalName = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].LegalName");
				dataItem.LegalSex = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].LegalSex");
				dataItem.LegalCardType = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].LegalCardType");
				dataItem.LegalCardNum = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].LegalCardNum");
				dataItem.FinancialName = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].FinancialName");
				dataItem.FinancialSex = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].FinancialSex");
				dataItem.FinancialCardType = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].FinancialCardType");
				dataItem.FinancialCardNum = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].FinancialCardNum");
				dataItem.AgencyEnt = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].AgencyEnt");
				dataItem.AgencyName = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].AgencyName");
				dataItem.AgencySex = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].AgencySex");
				dataItem.AgencyCardType = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].AgencyCardType");
				dataItem.AgencyCardNum = _ctx.StringValue("GetOcTaxIllegal.Data["+ i +"].AgencyCardNum");

				getOcTaxIllegalResponse_data.Add(dataItem);
			}
			getOcTaxIllegalResponse.Data = getOcTaxIllegalResponse_data;
        
			return getOcTaxIllegalResponse;
        }
    }
}
