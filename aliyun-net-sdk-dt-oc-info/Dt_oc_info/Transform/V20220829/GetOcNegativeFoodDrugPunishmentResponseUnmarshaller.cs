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
    public class GetOcNegativeFoodDrugPunishmentResponseUnmarshaller
    {
        public static GetOcNegativeFoodDrugPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcNegativeFoodDrugPunishmentResponse getOcNegativeFoodDrugPunishmentResponse = new GetOcNegativeFoodDrugPunishmentResponse();

			getOcNegativeFoodDrugPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcNegativeFoodDrugPunishmentResponse.Code = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Code");
			getOcNegativeFoodDrugPunishmentResponse.Success = _ctx.BooleanValue("GetOcNegativeFoodDrugPunishment.Success");
			getOcNegativeFoodDrugPunishmentResponse.Message = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Message");
			getOcNegativeFoodDrugPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcNegativeFoodDrugPunishment.TotalNum");
			getOcNegativeFoodDrugPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcNegativeFoodDrugPunishment.PageIndex");
			getOcNegativeFoodDrugPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcNegativeFoodDrugPunishment.PageNum");
			getOcNegativeFoodDrugPunishmentResponse.RequestId = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.RequestId");

			List<GetOcNegativeFoodDrugPunishmentResponse.GetOcNegativeFoodDrugPunishment_DataItem> getOcNegativeFoodDrugPunishmentResponse_data = new List<GetOcNegativeFoodDrugPunishmentResponse.GetOcNegativeFoodDrugPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcNegativeFoodDrugPunishment.Data.Length"); i++) {
				GetOcNegativeFoodDrugPunishmentResponse.GetOcNegativeFoodDrugPunishment_DataItem dataItem = new GetOcNegativeFoodDrugPunishmentResponse.GetOcNegativeFoodDrugPunishment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].EntName");
				dataItem.PunishNum = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].PunishNum");
				dataItem.IllegalType = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].IllegalType");
				dataItem.PunishResult = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].PunishResult");
				dataItem.Department = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].Department");
				dataItem.PunishDate = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].PunishDate");
				dataItem.LawBasis = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].LawBasis");
				dataItem.PublicDate = _ctx.StringValue("GetOcNegativeFoodDrugPunishment.Data["+ i +"].PublicDate");

				getOcNegativeFoodDrugPunishmentResponse_data.Add(dataItem);
			}
			getOcNegativeFoodDrugPunishmentResponse.Data = getOcNegativeFoodDrugPunishmentResponse_data;
        
			return getOcNegativeFoodDrugPunishmentResponse;
        }
    }
}
