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
    public class GetOcCoreTeamsResponseUnmarshaller
    {
        public static GetOcCoreTeamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcCoreTeamsResponse getOcCoreTeamsResponse = new GetOcCoreTeamsResponse();

			getOcCoreTeamsResponse.HttpResponse = _ctx.HttpResponse;
			getOcCoreTeamsResponse.Code = _ctx.StringValue("GetOcCoreTeams.Code");
			getOcCoreTeamsResponse.Success = _ctx.BooleanValue("GetOcCoreTeams.Success");
			getOcCoreTeamsResponse.Message = _ctx.StringValue("GetOcCoreTeams.Message");
			getOcCoreTeamsResponse.TotalNum = _ctx.IntegerValue("GetOcCoreTeams.TotalNum");
			getOcCoreTeamsResponse.PageIndex = _ctx.IntegerValue("GetOcCoreTeams.PageIndex");
			getOcCoreTeamsResponse.PageNum = _ctx.IntegerValue("GetOcCoreTeams.PageNum");
			getOcCoreTeamsResponse.RequestId = _ctx.StringValue("GetOcCoreTeams.RequestId");

			List<GetOcCoreTeamsResponse.GetOcCoreTeams_DataItem> getOcCoreTeamsResponse_data = new List<GetOcCoreTeamsResponse.GetOcCoreTeams_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcCoreTeams.Data.Length"); i++) {
				GetOcCoreTeamsResponse.GetOcCoreTeams_DataItem dataItem = new GetOcCoreTeamsResponse.GetOcCoreTeams_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcCoreTeams.Data["+ i +"].EntName");
				dataItem.MemberName = _ctx.StringValue("GetOcCoreTeams.Data["+ i +"].MemberName");
				dataItem.MemberPosition = _ctx.StringValue("GetOcCoreTeams.Data["+ i +"].MemberPosition");
				dataItem.MemberIntroduction = _ctx.StringValue("GetOcCoreTeams.Data["+ i +"].MemberIntroduction");

				getOcCoreTeamsResponse_data.Add(dataItem);
			}
			getOcCoreTeamsResponse.Data = getOcCoreTeamsResponse_data;
        
			return getOcCoreTeamsResponse;
        }
    }
}
