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
    public class GetOcNegativeEnvironmentPunishmentResponseUnmarshaller
    {
        public static GetOcNegativeEnvironmentPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcNegativeEnvironmentPunishmentResponse getOcNegativeEnvironmentPunishmentResponse = new GetOcNegativeEnvironmentPunishmentResponse();

			getOcNegativeEnvironmentPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcNegativeEnvironmentPunishmentResponse.Code = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Code");
			getOcNegativeEnvironmentPunishmentResponse.Success = _ctx.BooleanValue("GetOcNegativeEnvironmentPunishment.Success");
			getOcNegativeEnvironmentPunishmentResponse.Message = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Message");
			getOcNegativeEnvironmentPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcNegativeEnvironmentPunishment.TotalNum");
			getOcNegativeEnvironmentPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcNegativeEnvironmentPunishment.PageIndex");
			getOcNegativeEnvironmentPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcNegativeEnvironmentPunishment.PageNum");
			getOcNegativeEnvironmentPunishmentResponse.RequestId = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.RequestId");

			List<GetOcNegativeEnvironmentPunishmentResponse.GetOcNegativeEnvironmentPunishment_DataItem> getOcNegativeEnvironmentPunishmentResponse_data = new List<GetOcNegativeEnvironmentPunishmentResponse.GetOcNegativeEnvironmentPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcNegativeEnvironmentPunishment.Data.Length"); i++) {
				GetOcNegativeEnvironmentPunishmentResponse.GetOcNegativeEnvironmentPunishment_DataItem dataItem = new GetOcNegativeEnvironmentPunishmentResponse.GetOcNegativeEnvironmentPunishment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].EntName");
				dataItem.PunishNum = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishNum");
				dataItem.PunishLaw = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishLaw");
				dataItem.PunishBasis = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishBasis");
				dataItem.PunishRes = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishRes");
				dataItem.Department = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].Department");
				dataItem.PunishDate = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishDate");
				dataItem.ExecStatus = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].ExecStatus");
				dataItem.PunishContent = _ctx.StringValue("GetOcNegativeEnvironmentPunishment.Data["+ i +"].PunishContent");

				getOcNegativeEnvironmentPunishmentResponse_data.Add(dataItem);
			}
			getOcNegativeEnvironmentPunishmentResponse.Data = getOcNegativeEnvironmentPunishmentResponse_data;
        
			return getOcNegativeEnvironmentPunishmentResponse;
        }
    }
}
