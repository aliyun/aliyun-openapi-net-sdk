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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetFreqBandPlanGroupResponseUnmarshaller
    {
        public static GetFreqBandPlanGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFreqBandPlanGroupResponse getFreqBandPlanGroupResponse = new GetFreqBandPlanGroupResponse();

			getFreqBandPlanGroupResponse.HttpResponse = _ctx.HttpResponse;
			getFreqBandPlanGroupResponse.RequestId = _ctx.StringValue("GetFreqBandPlanGroup.RequestId");
			getFreqBandPlanGroupResponse.Success = _ctx.BooleanValue("GetFreqBandPlanGroup.Success");

			GetFreqBandPlanGroupResponse.GetFreqBandPlanGroup_Data data = new GetFreqBandPlanGroupResponse.GetFreqBandPlanGroup_Data();
			data.GroupId = _ctx.LongValue("GetFreqBandPlanGroup.Data.GroupId");
			data.FrequencyRegionId = _ctx.StringValue("GetFreqBandPlanGroup.Data.FrequencyRegionId");
			data.FrequencyType = _ctx.StringValue("GetFreqBandPlanGroup.Data.FrequencyType");
			data.BeginFrequency = _ctx.LongValue("GetFreqBandPlanGroup.Data.BeginFrequency");
			data.EndFrequency = _ctx.LongValue("GetFreqBandPlanGroup.Data.EndFrequency");
			getFreqBandPlanGroupResponse.Data = data;
        
			return getFreqBandPlanGroupResponse;
        }
    }
}
