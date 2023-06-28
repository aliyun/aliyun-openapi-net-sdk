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
    public class GetOcListedCompanyResponseUnmarshaller
    {
        public static GetOcListedCompanyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcListedCompanyResponse getOcListedCompanyResponse = new GetOcListedCompanyResponse();

			getOcListedCompanyResponse.HttpResponse = _ctx.HttpResponse;
			getOcListedCompanyResponse.Code = _ctx.StringValue("GetOcListedCompany.Code");
			getOcListedCompanyResponse.Success = _ctx.BooleanValue("GetOcListedCompany.Success");
			getOcListedCompanyResponse.Message = _ctx.StringValue("GetOcListedCompany.Message");
			getOcListedCompanyResponse.TotalNum = _ctx.IntegerValue("GetOcListedCompany.TotalNum");
			getOcListedCompanyResponse.PageIndex = _ctx.IntegerValue("GetOcListedCompany.PageIndex");
			getOcListedCompanyResponse.PageNum = _ctx.IntegerValue("GetOcListedCompany.PageNum");
			getOcListedCompanyResponse.RequestId = _ctx.StringValue("GetOcListedCompany.RequestId");

			List<GetOcListedCompanyResponse.GetOcListedCompany_DataItem> getOcListedCompanyResponse_data = new List<GetOcListedCompanyResponse.GetOcListedCompany_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcListedCompany.Data.Length"); i++) {
				GetOcListedCompanyResponse.GetOcListedCompany_DataItem dataItem = new GetOcListedCompanyResponse.GetOcListedCompany_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].EntName");
				dataItem.EntNameEng = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].EntNameEng");
				dataItem.SecuritiesCode = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].SecuritiesCode");
				dataItem.SecuritiesName = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].SecuritiesName");
				dataItem.SecuritiesMarket = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].SecuritiesMarket");
				dataItem.ListDate = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].ListDate");
				dataItem.TotalShares = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].TotalShares");
				dataItem.TotalFlowShares = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].TotalFlowShares");
				dataItem.CirculationMarketValue = _ctx.StringValue("GetOcListedCompany.Data["+ i +"].CirculationMarketValue");

				getOcListedCompanyResponse_data.Add(dataItem);
			}
			getOcListedCompanyResponse.Data = getOcListedCompanyResponse_data;
        
			return getOcListedCompanyResponse;
        }
    }
}
