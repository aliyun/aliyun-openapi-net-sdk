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
    public class GetOcIcInvestmentResponseUnmarshaller
    {
        public static GetOcIcInvestmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcInvestmentResponse getOcIcInvestmentResponse = new GetOcIcInvestmentResponse();

			getOcIcInvestmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcInvestmentResponse.Code = _ctx.StringValue("GetOcIcInvestment.Code");
			getOcIcInvestmentResponse.Success = _ctx.BooleanValue("GetOcIcInvestment.Success");
			getOcIcInvestmentResponse.Message = _ctx.StringValue("GetOcIcInvestment.Message");
			getOcIcInvestmentResponse.TotalNum = _ctx.IntegerValue("GetOcIcInvestment.TotalNum");
			getOcIcInvestmentResponse.PageIndex = _ctx.IntegerValue("GetOcIcInvestment.PageIndex");
			getOcIcInvestmentResponse.PageNum = _ctx.IntegerValue("GetOcIcInvestment.PageNum");
			getOcIcInvestmentResponse.RequestId = _ctx.StringValue("GetOcIcInvestment.RequestId");

			List<GetOcIcInvestmentResponse.GetOcIcInvestment_DataItem> getOcIcInvestmentResponse_data = new List<GetOcIcInvestmentResponse.GetOcIcInvestment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcInvestment.Data.Length"); i++) {
				GetOcIcInvestmentResponse.GetOcIcInvestment_DataItem dataItem = new GetOcIcInvestmentResponse.GetOcIcInvestment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].EntName");
				dataItem.InvestName = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestName");
				dataItem.InvestCreditCode = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestCreditCode");
				dataItem.InvestLicenseNo = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestLicenseNo");
				dataItem.InvestEsDate = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestEsDate");
				dataItem.InvestLegalName = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestLegalName");
				dataItem.InvestRegCap = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestRegCap");
				dataItem.InvestStatus = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].InvestStatus");
				dataItem.ShouldCap = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].ShouldCap");
				dataItem.StockPercentage = _ctx.StringValue("GetOcIcInvestment.Data["+ i +"].StockPercentage");

				getOcIcInvestmentResponse_data.Add(dataItem);
			}
			getOcIcInvestmentResponse.Data = getOcIcInvestmentResponse_data;
        
			return getOcIcInvestmentResponse;
        }
    }
}
