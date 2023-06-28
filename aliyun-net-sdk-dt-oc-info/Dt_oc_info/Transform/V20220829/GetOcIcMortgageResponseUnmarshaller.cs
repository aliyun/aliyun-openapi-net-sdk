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
    public class GetOcIcMortgageResponseUnmarshaller
    {
        public static GetOcIcMortgageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcMortgageResponse getOcIcMortgageResponse = new GetOcIcMortgageResponse();

			getOcIcMortgageResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcMortgageResponse.Code = _ctx.StringValue("GetOcIcMortgage.Code");
			getOcIcMortgageResponse.Success = _ctx.BooleanValue("GetOcIcMortgage.Success");
			getOcIcMortgageResponse.Message = _ctx.StringValue("GetOcIcMortgage.Message");
			getOcIcMortgageResponse.TotalNum = _ctx.IntegerValue("GetOcIcMortgage.TotalNum");
			getOcIcMortgageResponse.PageIndex = _ctx.IntegerValue("GetOcIcMortgage.PageIndex");
			getOcIcMortgageResponse.PageNum = _ctx.IntegerValue("GetOcIcMortgage.PageNum");
			getOcIcMortgageResponse.RequestId = _ctx.StringValue("GetOcIcMortgage.RequestId");

			List<GetOcIcMortgageResponse.GetOcIcMortgage_DataItem> getOcIcMortgageResponse_data = new List<GetOcIcMortgageResponse.GetOcIcMortgage_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcMortgage.Data.Length"); i++) {
				GetOcIcMortgageResponse.GetOcIcMortgage_DataItem dataItem = new GetOcIcMortgageResponse.GetOcIcMortgage_DataItem();
				dataItem.OnecompId = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].OnecompId");
				dataItem.Number = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].Number");
				dataItem.RegDate = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].RegDate");
				dataItem.Department = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].Department");
				dataItem.MortgageesName = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].MortgageesName");
				dataItem.IdentifyType = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].IdentifyType");
				dataItem.IdentifyNo = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].IdentifyNo");
				dataItem.DebitType = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].DebitType");
				dataItem.DebitAmount = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].DebitAmount");
				dataItem.DebitPeriod = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].DebitPeriod");
				dataItem.DebitScope = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].DebitScope");
				dataItem.Guarantees = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].Guarantees");
				dataItem.Status = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].Status");
				dataItem.PublicDate = _ctx.StringValue("GetOcIcMortgage.Data["+ i +"].PublicDate");

				getOcIcMortgageResponse_data.Add(dataItem);
			}
			getOcIcMortgageResponse.Data = getOcIcMortgageResponse_data;
        
			return getOcIcMortgageResponse;
        }
    }
}
