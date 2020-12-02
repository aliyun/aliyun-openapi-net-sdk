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
    public class DescribeTagHitsSummaryResponseUnmarshaller
    {
        public static DescribeTagHitsSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagHitsSummaryResponse describeTagHitsSummaryResponse = new DescribeTagHitsSummaryResponse();

			describeTagHitsSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeTagHitsSummaryResponse.Code = _ctx.StringValue("DescribeTagHitsSummary.Code");
			describeTagHitsSummaryResponse.HttpStatusCode = _ctx.IntegerValue("DescribeTagHitsSummary.HttpStatusCode");
			describeTagHitsSummaryResponse.Message = _ctx.StringValue("DescribeTagHitsSummary.Message");
			describeTagHitsSummaryResponse.RequestId = _ctx.StringValue("DescribeTagHitsSummary.RequestId");
			describeTagHitsSummaryResponse.Success = _ctx.BooleanValue("DescribeTagHitsSummary.Success");

			List<DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagGroup> describeTagHitsSummaryResponse_tagGroups = new List<DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagGroup>();
			for (int i = 0; i < _ctx.Length("DescribeTagHitsSummary.TagGroups.Length"); i++) {
				DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagGroup tagGroup = new DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagGroup();
				tagGroup.Id = _ctx.StringValue("DescribeTagHitsSummary.TagGroups["+ i +"].Id");
				tagGroup.ScriptId = _ctx.StringValue("DescribeTagHitsSummary.TagGroups["+ i +"].ScriptId");
				tagGroup.TagGroup = _ctx.StringValue("DescribeTagHitsSummary.TagGroups["+ i +"].TagGroup");
				tagGroup.TagGroupIndex = _ctx.IntegerValue("DescribeTagHitsSummary.TagGroups["+ i +"].TagGroupIndex");

				describeTagHitsSummaryResponse_tagGroups.Add(tagGroup);
			}
			describeTagHitsSummaryResponse.TagGroups = describeTagHitsSummaryResponse_tagGroups;

			List<DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagHits> describeTagHitsSummaryResponse_tagHitsList = new List<DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagHits>();
			for (int i = 0; i < _ctx.Length("DescribeTagHitsSummary.TagHitsList.Length"); i++) {
				DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagHits tagHits = new DescribeTagHitsSummaryResponse.DescribeTagHitsSummary_TagHits();
				tagHits.HitCount = _ctx.IntegerValue("DescribeTagHitsSummary.TagHitsList["+ i +"].HitCount");
				tagHits.TagGroup = _ctx.StringValue("DescribeTagHitsSummary.TagHitsList["+ i +"].TagGroup");
				tagHits.TagName = _ctx.StringValue("DescribeTagHitsSummary.TagHitsList["+ i +"].TagName");

				describeTagHitsSummaryResponse_tagHitsList.Add(tagHits);
			}
			describeTagHitsSummaryResponse.TagHitsList = describeTagHitsSummaryResponse_tagHitsList;
        
			return describeTagHitsSummaryResponse;
        }
    }
}
