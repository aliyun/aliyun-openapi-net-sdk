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
    public class GetOcTaxGeneralTaxpayerResponseUnmarshaller
    {
        public static GetOcTaxGeneralTaxpayerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxGeneralTaxpayerResponse getOcTaxGeneralTaxpayerResponse = new GetOcTaxGeneralTaxpayerResponse();

			getOcTaxGeneralTaxpayerResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxGeneralTaxpayerResponse.Code = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Code");
			getOcTaxGeneralTaxpayerResponse.Success = _ctx.BooleanValue("GetOcTaxGeneralTaxpayer.Success");
			getOcTaxGeneralTaxpayerResponse.Message = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Message");
			getOcTaxGeneralTaxpayerResponse.TotalNum = _ctx.IntegerValue("GetOcTaxGeneralTaxpayer.TotalNum");
			getOcTaxGeneralTaxpayerResponse.PageIndex = _ctx.IntegerValue("GetOcTaxGeneralTaxpayer.PageIndex");
			getOcTaxGeneralTaxpayerResponse.PageNum = _ctx.IntegerValue("GetOcTaxGeneralTaxpayer.PageNum");
			getOcTaxGeneralTaxpayerResponse.RequestId = _ctx.StringValue("GetOcTaxGeneralTaxpayer.RequestId");

			List<GetOcTaxGeneralTaxpayerResponse.GetOcTaxGeneralTaxpayer_DataItem> getOcTaxGeneralTaxpayerResponse_data = new List<GetOcTaxGeneralTaxpayerResponse.GetOcTaxGeneralTaxpayer_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxGeneralTaxpayer.Data.Length"); i++) {
				GetOcTaxGeneralTaxpayerResponse.GetOcTaxGeneralTaxpayer_DataItem dataItem = new GetOcTaxGeneralTaxpayerResponse.GetOcTaxGeneralTaxpayer_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].EntName");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].TaxpayerNum");
				dataItem.Qualification = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].Qualification");
				dataItem.JudgeDate = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].JudgeDate");
				dataItem.StartDate = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].StartDate");
				dataItem.EndDate = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].EndDate");
				dataItem.Department = _ctx.StringValue("GetOcTaxGeneralTaxpayer.Data["+ i +"].Department");

				getOcTaxGeneralTaxpayerResponse_data.Add(dataItem);
			}
			getOcTaxGeneralTaxpayerResponse.Data = getOcTaxGeneralTaxpayerResponse_data;
        
			return getOcTaxGeneralTaxpayerResponse;
        }
    }
}
