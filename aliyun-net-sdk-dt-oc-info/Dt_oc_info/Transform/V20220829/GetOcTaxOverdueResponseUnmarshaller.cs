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
    public class GetOcTaxOverdueResponseUnmarshaller
    {
        public static GetOcTaxOverdueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxOverdueResponse getOcTaxOverdueResponse = new GetOcTaxOverdueResponse();

			getOcTaxOverdueResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxOverdueResponse.Code = _ctx.StringValue("GetOcTaxOverdue.Code");
			getOcTaxOverdueResponse.Success = _ctx.BooleanValue("GetOcTaxOverdue.Success");
			getOcTaxOverdueResponse.Message = _ctx.StringValue("GetOcTaxOverdue.Message");
			getOcTaxOverdueResponse.TotalNum = _ctx.IntegerValue("GetOcTaxOverdue.TotalNum");
			getOcTaxOverdueResponse.PageIndex = _ctx.IntegerValue("GetOcTaxOverdue.PageIndex");
			getOcTaxOverdueResponse.PageNum = _ctx.IntegerValue("GetOcTaxOverdue.PageNum");
			getOcTaxOverdueResponse.RequestId = _ctx.StringValue("GetOcTaxOverdue.RequestId");

			List<GetOcTaxOverdueResponse.GetOcTaxOverdue_DataItem> getOcTaxOverdueResponse_data = new List<GetOcTaxOverdueResponse.GetOcTaxOverdue_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxOverdue.Data.Length"); i++) {
				GetOcTaxOverdueResponse.GetOcTaxOverdue_DataItem dataItem = new GetOcTaxOverdueResponse.GetOcTaxOverdue_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].EntName");
				dataItem.OverdueType = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].OverdueType");
				dataItem.EntAddress = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].EntAddress");
				dataItem.OverdueAmount = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].OverdueAmount");
				dataItem.LegalName = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].LegalName");
				dataItem.TaxpayerType = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].TaxpayerType");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].TaxpayerNum");
				dataItem.Department = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].Department");
				dataItem.CurrOverdueAmount = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].CurrOverdueAmount");
				dataItem.PublishDate = _ctx.StringValue("GetOcTaxOverdue.Data["+ i +"].PublishDate");

				getOcTaxOverdueResponse_data.Add(dataItem);
			}
			getOcTaxOverdueResponse.Data = getOcTaxOverdueResponse_data;
        
			return getOcTaxOverdueResponse;
        }
    }
}
