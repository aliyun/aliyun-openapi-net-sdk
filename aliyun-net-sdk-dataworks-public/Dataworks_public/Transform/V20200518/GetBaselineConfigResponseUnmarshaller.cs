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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetBaselineConfigResponseUnmarshaller
    {
        public static GetBaselineConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBaselineConfigResponse getBaselineConfigResponse = new GetBaselineConfigResponse();

			getBaselineConfigResponse.HttpResponse = _ctx.HttpResponse;
			getBaselineConfigResponse.HttpStatusCode = _ctx.IntegerValue("GetBaselineConfig.HttpStatusCode");
			getBaselineConfigResponse.RequestId = _ctx.StringValue("GetBaselineConfig.RequestId");
			getBaselineConfigResponse.ErrorMessage = _ctx.StringValue("GetBaselineConfig.ErrorMessage");
			getBaselineConfigResponse.ErrorCode = _ctx.StringValue("GetBaselineConfig.ErrorCode");
			getBaselineConfigResponse.Success = _ctx.BooleanValue("GetBaselineConfig.Success");

			GetBaselineConfigResponse.GetBaselineConfig_Data data = new GetBaselineConfigResponse.GetBaselineConfig_Data();
			data.HourSlaDetail = _ctx.StringValue("GetBaselineConfig.Data.HourSlaDetail");
			data.IsDefault = _ctx.BooleanValue("GetBaselineConfig.Data.IsDefault");
			data.Owner = _ctx.StringValue("GetBaselineConfig.Data.Owner");
			data.ProjectId = _ctx.LongValue("GetBaselineConfig.Data.ProjectId");
			data.Priority = _ctx.IntegerValue("GetBaselineConfig.Data.Priority");
			data.SlaMinu = _ctx.IntegerValue("GetBaselineConfig.Data.SlaMinu");
			data.SlaHour = _ctx.IntegerValue("GetBaselineConfig.Data.SlaHour");
			data.BaselineId = _ctx.LongValue("GetBaselineConfig.Data.BaselineId");
			data.BaselineName = _ctx.StringValue("GetBaselineConfig.Data.BaselineName");
			data.HourExpDetail = _ctx.StringValue("GetBaselineConfig.Data.HourExpDetail");
			data.UseFlag = _ctx.BooleanValue("GetBaselineConfig.Data.UseFlag");
			data.ExpHour = _ctx.IntegerValue("GetBaselineConfig.Data.ExpHour");
			data.BaselineType = _ctx.StringValue("GetBaselineConfig.Data.BaselineType");
			data.ExpMinu = _ctx.IntegerValue("GetBaselineConfig.Data.ExpMinu");
			getBaselineConfigResponse.Data = data;
        
			return getBaselineConfigResponse;
        }
    }
}
