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
    public class ListFreqBandPlanGroupsResponseUnmarshaller
    {
        public static ListFreqBandPlanGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFreqBandPlanGroupsResponse listFreqBandPlanGroupsResponse = new ListFreqBandPlanGroupsResponse();

			listFreqBandPlanGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listFreqBandPlanGroupsResponse.RequestId = _ctx.StringValue("ListFreqBandPlanGroups.RequestId");
			listFreqBandPlanGroupsResponse.Success = _ctx.BooleanValue("ListFreqBandPlanGroups.Success");

			List<ListFreqBandPlanGroupsResponse.ListFreqBandPlanGroups_Group> listFreqBandPlanGroupsResponse_data = new List<ListFreqBandPlanGroupsResponse.ListFreqBandPlanGroups_Group>();
			for (int i = 0; i < _ctx.Length("ListFreqBandPlanGroups.Data.Length"); i++) {
				ListFreqBandPlanGroupsResponse.ListFreqBandPlanGroups_Group group = new ListFreqBandPlanGroupsResponse.ListFreqBandPlanGroups_Group();
				group.GroupId = _ctx.LongValue("ListFreqBandPlanGroups.Data["+ i +"].GroupId");
				group.FrequencyRegionId = _ctx.StringValue("ListFreqBandPlanGroups.Data["+ i +"].FrequencyRegionId");
				group.FrequencyType = _ctx.StringValue("ListFreqBandPlanGroups.Data["+ i +"].FrequencyType");
				group.BeginFrequency = _ctx.LongValue("ListFreqBandPlanGroups.Data["+ i +"].BeginFrequency");
				group.EndFrequency = _ctx.LongValue("ListFreqBandPlanGroups.Data["+ i +"].EndFrequency");

				listFreqBandPlanGroupsResponse_data.Add(group);
			}
			listFreqBandPlanGroupsResponse.Data = listFreqBandPlanGroupsResponse_data;
        
			return listFreqBandPlanGroupsResponse;
        }
    }
}
