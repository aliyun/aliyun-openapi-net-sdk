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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GetTagHitsSummaryResponseUnmarshaller
    {
        public static GetTagHitsSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			GetTagHitsSummaryResponse getTagHitsSummaryResponse = new GetTagHitsSummaryResponse();

			getTagHitsSummaryResponse.HttpResponse = context.HttpResponse;
			getTagHitsSummaryResponse.RequestId = context.StringValue("GetTagHitsSummary.RequestId");
			getTagHitsSummaryResponse.Success = context.BooleanValue("GetTagHitsSummary.Success");
			getTagHitsSummaryResponse.Code = context.StringValue("GetTagHitsSummary.Code");
			getTagHitsSummaryResponse.Message = context.StringValue("GetTagHitsSummary.Message");
			getTagHitsSummaryResponse.HttpStatusCode = context.IntegerValue("GetTagHitsSummary.HttpStatusCode");

			List<GetTagHitsSummaryResponse.GetTagHitsSummary_TagHits> getTagHitsSummaryResponse_tagHitsList = new List<GetTagHitsSummaryResponse.GetTagHitsSummary_TagHits>();
			for (int i = 0; i < context.Length("GetTagHitsSummary.TagHitsList.Length"); i++) {
				GetTagHitsSummaryResponse.GetTagHitsSummary_TagHits tagHits = new GetTagHitsSummaryResponse.GetTagHitsSummary_TagHits();
				tagHits.TagName = context.StringValue("GetTagHitsSummary.TagHitsList["+ i +"].TagName");
				tagHits.HitCount = context.IntegerValue("GetTagHitsSummary.TagHitsList["+ i +"].HitCount");
				tagHits.TagGroup = context.StringValue("GetTagHitsSummary.TagHitsList["+ i +"].TagGroup");

				getTagHitsSummaryResponse_tagHitsList.Add(tagHits);
			}
			getTagHitsSummaryResponse.TagHitsList = getTagHitsSummaryResponse_tagHitsList;

			List<GetTagHitsSummaryResponse.GetTagHitsSummary_TagGroup> getTagHitsSummaryResponse_tagGroups = new List<GetTagHitsSummaryResponse.GetTagHitsSummary_TagGroup>();
			for (int i = 0; i < context.Length("GetTagHitsSummary.TagGroups.Length"); i++) {
				GetTagHitsSummaryResponse.GetTagHitsSummary_TagGroup tagGroup = new GetTagHitsSummaryResponse.GetTagHitsSummary_TagGroup();
				tagGroup.Id = context.StringValue("GetTagHitsSummary.TagGroups["+ i +"].Id");
				tagGroup.TagGroupIndex = context.IntegerValue("GetTagHitsSummary.TagGroups["+ i +"].TagGroupIndex");
				tagGroup.ScriptId = context.StringValue("GetTagHitsSummary.TagGroups["+ i +"].ScriptId");
				tagGroup.TagGroup = context.StringValue("GetTagHitsSummary.TagGroups["+ i +"].TagGroup");

				getTagHitsSummaryResponse_tagGroups.Add(tagGroup);
			}
			getTagHitsSummaryResponse.TagGroups = getTagHitsSummaryResponse_tagGroups;
        
			return getTagHitsSummaryResponse;
        }
    }
}
