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
    public class GetOcCompetitorsResponseUnmarshaller
    {
        public static GetOcCompetitorsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcCompetitorsResponse getOcCompetitorsResponse = new GetOcCompetitorsResponse();

			getOcCompetitorsResponse.HttpResponse = _ctx.HttpResponse;
			getOcCompetitorsResponse.Code = _ctx.StringValue("GetOcCompetitors.Code");
			getOcCompetitorsResponse.Success = _ctx.BooleanValue("GetOcCompetitors.Success");
			getOcCompetitorsResponse.Message = _ctx.StringValue("GetOcCompetitors.Message");
			getOcCompetitorsResponse.TotalNum = _ctx.IntegerValue("GetOcCompetitors.TotalNum");
			getOcCompetitorsResponse.PageIndex = _ctx.IntegerValue("GetOcCompetitors.PageIndex");
			getOcCompetitorsResponse.PageNum = _ctx.IntegerValue("GetOcCompetitors.PageNum");
			getOcCompetitorsResponse.RequestId = _ctx.StringValue("GetOcCompetitors.RequestId");

			List<GetOcCompetitorsResponse.GetOcCompetitors_DataItem> getOcCompetitorsResponse_data = new List<GetOcCompetitorsResponse.GetOcCompetitors_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcCompetitors.Data.Length"); i++) {
				GetOcCompetitorsResponse.GetOcCompetitors_DataItem dataItem = new GetOcCompetitorsResponse.GetOcCompetitors_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].EntName");
				dataItem.CompetitionProductName = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionProductName");
				dataItem.CompetitionEntName = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionEntName");
				dataItem.CompetitionWebsite = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionWebsite");
				dataItem.CompetitionTag = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionTag");
				dataItem.CompetitionLogoUrl = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionLogoUrl");
				dataItem.CompetitionIntroduction = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionIntroduction");
				dataItem.CompetitionBrandIntroduction = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionBrandIntroduction");
				dataItem.CompetitionEntFinTurn = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionEntFinTurn");
				dataItem.CompetitionEntAddress = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionEntAddress");
				dataItem.CompetitionEntEsDate = _ctx.StringValue("GetOcCompetitors.Data["+ i +"].CompetitionEntEsDate");

				getOcCompetitorsResponse_data.Add(dataItem);
			}
			getOcCompetitorsResponse.Data = getOcCompetitorsResponse_data;
        
			return getOcCompetitorsResponse;
        }
    }
}
