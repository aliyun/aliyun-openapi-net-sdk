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
    public class GetOcNegativeCustomsPunishmentResponseUnmarshaller
    {
        public static GetOcNegativeCustomsPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcNegativeCustomsPunishmentResponse getOcNegativeCustomsPunishmentResponse = new GetOcNegativeCustomsPunishmentResponse();

			getOcNegativeCustomsPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcNegativeCustomsPunishmentResponse.Code = _ctx.StringValue("GetOcNegativeCustomsPunishment.Code");
			getOcNegativeCustomsPunishmentResponse.Success = _ctx.BooleanValue("GetOcNegativeCustomsPunishment.Success");
			getOcNegativeCustomsPunishmentResponse.Message = _ctx.StringValue("GetOcNegativeCustomsPunishment.Message");
			getOcNegativeCustomsPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcNegativeCustomsPunishment.TotalNum");
			getOcNegativeCustomsPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcNegativeCustomsPunishment.PageIndex");
			getOcNegativeCustomsPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcNegativeCustomsPunishment.PageNum");
			getOcNegativeCustomsPunishmentResponse.RequestId = _ctx.StringValue("GetOcNegativeCustomsPunishment.RequestId");

			List<GetOcNegativeCustomsPunishmentResponse.GetOcNegativeCustomsPunishment_DataItem> getOcNegativeCustomsPunishmentResponse_data = new List<GetOcNegativeCustomsPunishmentResponse.GetOcNegativeCustomsPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcNegativeCustomsPunishment.Data.Length"); i++) {
				GetOcNegativeCustomsPunishmentResponse.GetOcNegativeCustomsPunishment_DataItem dataItem = new GetOcNegativeCustomsPunishmentResponse.GetOcNegativeCustomsPunishment_DataItem();
				dataItem.Basis = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].Basis");
				dataItem.Title = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].Title");
				dataItem.PunishType = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].PunishType");
				dataItem.LegalName = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].LegalName");
				dataItem.Customs = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].Customs");
				dataItem.PunishDate = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].PunishDate");
				dataItem.CustomsNo = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].CustomsNo");
				dataItem.CaseNo = _ctx.StringValue("GetOcNegativeCustomsPunishment.Data["+ i +"].CaseNo");

				getOcNegativeCustomsPunishmentResponse_data.Add(dataItem);
			}
			getOcNegativeCustomsPunishmentResponse.Data = getOcNegativeCustomsPunishmentResponse_data;
        
			return getOcNegativeCustomsPunishmentResponse;
        }
    }
}
