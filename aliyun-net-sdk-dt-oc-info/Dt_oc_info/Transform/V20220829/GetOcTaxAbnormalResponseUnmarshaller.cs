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
    public class GetOcTaxAbnormalResponseUnmarshaller
    {
        public static GetOcTaxAbnormalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxAbnormalResponse getOcTaxAbnormalResponse = new GetOcTaxAbnormalResponse();

			getOcTaxAbnormalResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxAbnormalResponse.Code = _ctx.StringValue("GetOcTaxAbnormal.Code");
			getOcTaxAbnormalResponse.Success = _ctx.BooleanValue("GetOcTaxAbnormal.Success");
			getOcTaxAbnormalResponse.Message = _ctx.StringValue("GetOcTaxAbnormal.Message");
			getOcTaxAbnormalResponse.TotalNum = _ctx.IntegerValue("GetOcTaxAbnormal.TotalNum");
			getOcTaxAbnormalResponse.PageIndex = _ctx.IntegerValue("GetOcTaxAbnormal.PageIndex");
			getOcTaxAbnormalResponse.PageNum = _ctx.IntegerValue("GetOcTaxAbnormal.PageNum");
			getOcTaxAbnormalResponse.RequestId = _ctx.StringValue("GetOcTaxAbnormal.RequestId");

			List<GetOcTaxAbnormalResponse.GetOcTaxAbnormal_DataItem> getOcTaxAbnormalResponse_data = new List<GetOcTaxAbnormalResponse.GetOcTaxAbnormal_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxAbnormal.Data.Length"); i++) {
				GetOcTaxAbnormalResponse.GetOcTaxAbnormal_DataItem dataItem = new GetOcTaxAbnormalResponse.GetOcTaxAbnormal_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].EntName");
				dataItem.LegalName = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].LegalName");
				dataItem.CardNum = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].CardNum");
				dataItem.CardType = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].CardType");
				dataItem.JudgeDate = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].JudgeDate");
				dataItem.JudgeDepartment = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].JudgeDepartment");
				dataItem.JudgeReason = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].JudgeReason");
				dataItem.OverdueType = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].OverdueType");
				dataItem.OverdueAmount = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].OverdueAmount");
				dataItem.Status = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].Status");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxAbnormal.Data["+ i +"].TaxpayerNum");

				getOcTaxAbnormalResponse_data.Add(dataItem);
			}
			getOcTaxAbnormalResponse.Data = getOcTaxAbnormalResponse_data;
        
			return getOcTaxAbnormalResponse;
        }
    }
}
