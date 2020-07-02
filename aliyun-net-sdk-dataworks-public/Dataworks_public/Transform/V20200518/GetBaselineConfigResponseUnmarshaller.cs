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
        public static GetBaselineConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetBaselineConfigResponse getBaselineConfigResponse = new GetBaselineConfigResponse();

			getBaselineConfigResponse.HttpResponse = context.HttpResponse;
			getBaselineConfigResponse.Success = context.BooleanValue("GetBaselineConfig.Success");
			getBaselineConfigResponse.ErrorCode = context.StringValue("GetBaselineConfig.ErrorCode");
			getBaselineConfigResponse.ErrorMessage = context.StringValue("GetBaselineConfig.ErrorMessage");
			getBaselineConfigResponse.HttpStatusCode = context.IntegerValue("GetBaselineConfig.HttpStatusCode");
			getBaselineConfigResponse.RequestId = context.StringValue("GetBaselineConfig.RequestId");

			GetBaselineConfigResponse.GetBaselineConfig_Data data = new GetBaselineConfigResponse.GetBaselineConfig_Data();
			data.BaselineId = context.LongValue("GetBaselineConfig.Data.BaselineId");
			data.Priority = context.IntegerValue("GetBaselineConfig.Data.Priority");
			data.BaselineName = context.StringValue("GetBaselineConfig.Data.BaselineName");
			data.Owner = context.StringValue("GetBaselineConfig.Data.Owner");
			data.ProjectId = context.LongValue("GetBaselineConfig.Data.ProjectId");
			data.UseFlag = context.BooleanValue("GetBaselineConfig.Data.UseFlag");
			data.BaselineType = context.StringValue("GetBaselineConfig.Data.BaselineType");
			data.ExpHour = context.IntegerValue("GetBaselineConfig.Data.ExpHour");
			data.ExpMinu = context.IntegerValue("GetBaselineConfig.Data.ExpMinu");
			data.SlaHour = context.IntegerValue("GetBaselineConfig.Data.SlaHour");
			data.SlaMinu = context.IntegerValue("GetBaselineConfig.Data.SlaMinu");
			data.HourExpDetail = context.StringValue("GetBaselineConfig.Data.HourExpDetail");
			data.HourSlaDetail = context.StringValue("GetBaselineConfig.Data.HourSlaDetail");
			data.IsDefault = context.BooleanValue("GetBaselineConfig.Data.IsDefault");
			getBaselineConfigResponse.Data = data;
        
			return getBaselineConfigResponse;
        }
    }
}
