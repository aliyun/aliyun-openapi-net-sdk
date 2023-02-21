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
    public class GetOcTaxPunishmentResponseUnmarshaller
    {
        public static GetOcTaxPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcTaxPunishmentResponse getOcTaxPunishmentResponse = new GetOcTaxPunishmentResponse();

			getOcTaxPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcTaxPunishmentResponse.Code = _ctx.StringValue("GetOcTaxPunishment.Code");
			getOcTaxPunishmentResponse.Success = _ctx.BooleanValue("GetOcTaxPunishment.Success");
			getOcTaxPunishmentResponse.Message = _ctx.StringValue("GetOcTaxPunishment.Message");
			getOcTaxPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcTaxPunishment.TotalNum");
			getOcTaxPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcTaxPunishment.PageIndex");
			getOcTaxPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcTaxPunishment.PageNum");
			getOcTaxPunishmentResponse.RequestId = _ctx.StringValue("GetOcTaxPunishment.RequestId");

			List<GetOcTaxPunishmentResponse.GetOcTaxPunishment_DataItem> getOcTaxPunishmentResponse_data = new List<GetOcTaxPunishmentResponse.GetOcTaxPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcTaxPunishment.Data.Length"); i++) {
				GetOcTaxPunishmentResponse.GetOcTaxPunishment_DataItem dataItem = new GetOcTaxPunishmentResponse.GetOcTaxPunishment_DataItem();
				dataItem.EventType = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].EventType");
				dataItem.LegalName = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].LegalName");
				dataItem.PunishDate = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].PunishDate");
				dataItem.TaxpayerNum = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].TaxpayerNum");
				dataItem.Department = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].Department");
				dataItem.Title = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].Title");
				dataItem.EventName = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].EventName");
				dataItem.EntName = _ctx.StringValue("GetOcTaxPunishment.Data["+ i +"].EntName");

				getOcTaxPunishmentResponse_data.Add(dataItem);
			}
			getOcTaxPunishmentResponse.Data = getOcTaxPunishmentResponse_data;
        
			return getOcTaxPunishmentResponse;
        }
    }
}
