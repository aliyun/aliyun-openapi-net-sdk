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
    public class GetOcNegativeQualityPunishmentResponseUnmarshaller
    {
        public static GetOcNegativeQualityPunishmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcNegativeQualityPunishmentResponse getOcNegativeQualityPunishmentResponse = new GetOcNegativeQualityPunishmentResponse();

			getOcNegativeQualityPunishmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcNegativeQualityPunishmentResponse.Code = _ctx.StringValue("GetOcNegativeQualityPunishment.Code");
			getOcNegativeQualityPunishmentResponse.Success = _ctx.BooleanValue("GetOcNegativeQualityPunishment.Success");
			getOcNegativeQualityPunishmentResponse.Message = _ctx.StringValue("GetOcNegativeQualityPunishment.Message");
			getOcNegativeQualityPunishmentResponse.TotalNum = _ctx.IntegerValue("GetOcNegativeQualityPunishment.TotalNum");
			getOcNegativeQualityPunishmentResponse.PageIndex = _ctx.IntegerValue("GetOcNegativeQualityPunishment.PageIndex");
			getOcNegativeQualityPunishmentResponse.PageNum = _ctx.IntegerValue("GetOcNegativeQualityPunishment.PageNum");
			getOcNegativeQualityPunishmentResponse.RequestId = _ctx.StringValue("GetOcNegativeQualityPunishment.RequestId");

			List<GetOcNegativeQualityPunishmentResponse.GetOcNegativeQualityPunishment_DataItem> getOcNegativeQualityPunishmentResponse_data = new List<GetOcNegativeQualityPunishmentResponse.GetOcNegativeQualityPunishment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcNegativeQualityPunishment.Data.Length"); i++) {
				GetOcNegativeQualityPunishmentResponse.GetOcNegativeQualityPunishment_DataItem dataItem = new GetOcNegativeQualityPunishmentResponse.GetOcNegativeQualityPunishment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].EntName");
				dataItem.Title = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].Title");
				dataItem.EventDate = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].EventDate");
				dataItem.Department = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].Department");
				dataItem.PubDate = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].PubDate");
				dataItem.EventResult = _ctx.StringValue("GetOcNegativeQualityPunishment.Data["+ i +"].EventResult");

				getOcNegativeQualityPunishmentResponse_data.Add(dataItem);
			}
			getOcNegativeQualityPunishmentResponse.Data = getOcNegativeQualityPunishmentResponse_data;
        
			return getOcNegativeQualityPunishmentResponse;
        }
    }
}
