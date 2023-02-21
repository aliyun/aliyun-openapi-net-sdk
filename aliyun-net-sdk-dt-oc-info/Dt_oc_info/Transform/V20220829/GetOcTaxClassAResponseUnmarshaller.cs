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
    public class GetOcTaxClassAResponseUnmarshaller
    {
        public static GetOcTaxClassAResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxClassAResponse getOcTaxClassAResponse = new GetOcTaxClassAResponse();

			getOcTaxClassAResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxClassAResponse.Code = _ctx.StringValue("GetOcTaxClassA.Code");
			getOcTaxClassAResponse.Success = _ctx.BooleanValue("GetOcTaxClassA.Success");
			getOcTaxClassAResponse.Message = _ctx.StringValue("GetOcTaxClassA.Message");
			getOcTaxClassAResponse.TotalNum = _ctx.IntegerValue("GetOcTaxClassA.TotalNum");
			getOcTaxClassAResponse.PageIndex = _ctx.IntegerValue("GetOcTaxClassA.PageIndex");
			getOcTaxClassAResponse.PageNum = _ctx.IntegerValue("GetOcTaxClassA.PageNum");
			getOcTaxClassAResponse.RequestId = _ctx.StringValue("GetOcTaxClassA.RequestId");

			List<GetOcTaxClassAResponse.GetOcTaxClassA_DataItem> getOcTaxClassAResponse_data = new List<GetOcTaxClassAResponse.GetOcTaxClassA_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxClassA.Data.Length"); i++) {
				GetOcTaxClassAResponse.GetOcTaxClassA_DataItem dataItem = new GetOcTaxClassAResponse.GetOcTaxClassA_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcTaxClassA.Data["+ i +"].EntName");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxClassA.Data["+ i +"].TaxpayerNum");
				dataItem.Year = _ctx.StringValue("GetOcTaxClassA.Data["+ i +"].Year");
				dataItem.TaxLevel = _ctx.StringValue("GetOcTaxClassA.Data["+ i +"].TaxLevel");

				getOcTaxClassAResponse_data.Add(dataItem);
			}
			getOcTaxClassAResponse.Data = getOcTaxClassAResponse_data;
        
			return getOcTaxClassAResponse;
        }
    }
}
