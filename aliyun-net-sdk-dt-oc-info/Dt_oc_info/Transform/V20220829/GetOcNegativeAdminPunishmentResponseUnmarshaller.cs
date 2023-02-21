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
    public class GetOcNegativeAdminPunishmentResponseUnmarshaller
    {
        public static GetOcNegativeAdminPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcNegativeAdminPunishmentResponse getOcNegativeAdminPunishmentResponse = new GetOcNegativeAdminPunishmentResponse();

			getOcNegativeAdminPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcNegativeAdminPunishmentResponse.Code = _ctx.StringValue("GetOcNegativeAdminPunishment.Code");
			getOcNegativeAdminPunishmentResponse.Success = _ctx.BooleanValue("GetOcNegativeAdminPunishment.Success");
			getOcNegativeAdminPunishmentResponse.Message = _ctx.StringValue("GetOcNegativeAdminPunishment.Message");
			getOcNegativeAdminPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcNegativeAdminPunishment.TotalNum");
			getOcNegativeAdminPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcNegativeAdminPunishment.PageIndex");
			getOcNegativeAdminPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcNegativeAdminPunishment.PageNum");
			getOcNegativeAdminPunishmentResponse.RequestId = _ctx.StringValue("GetOcNegativeAdminPunishment.RequestId");

			List<GetOcNegativeAdminPunishmentResponse.GetOcNegativeAdminPunishment_DataItem> getOcNegativeAdminPunishmentResponse_data = new List<GetOcNegativeAdminPunishmentResponse.GetOcNegativeAdminPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcNegativeAdminPunishment.Data.Length"); i++) {
				GetOcNegativeAdminPunishmentResponse.GetOcNegativeAdminPunishment_DataItem dataItem = new GetOcNegativeAdminPunishmentResponse.GetOcNegativeAdminPunishment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].EntName");
				dataItem.PunishNum = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].PunishNum");
				dataItem.IllegalType = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].IllegalType");
				dataItem.PunishResult = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].PunishResult");
				dataItem.Department = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].Department");
				dataItem.PunishDate = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].PunishDate");
				dataItem.LawBasis = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].LawBasis");
				dataItem.PublicDate = _ctx.StringValue("GetOcNegativeAdminPunishment.Data["+ i +"].PublicDate");

				getOcNegativeAdminPunishmentResponse_data.Add(dataItem);
			}
			getOcNegativeAdminPunishmentResponse.Data = getOcNegativeAdminPunishmentResponse_data;
        
			return getOcNegativeAdminPunishmentResponse;
        }
    }
}
