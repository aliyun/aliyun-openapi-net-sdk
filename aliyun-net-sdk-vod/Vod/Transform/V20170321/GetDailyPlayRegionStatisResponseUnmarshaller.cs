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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetDailyPlayRegionStatisResponseUnmarshaller
    {
        public static GetDailyPlayRegionStatisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDailyPlayRegionStatisResponse getDailyPlayRegionStatisResponse = new GetDailyPlayRegionStatisResponse();

			getDailyPlayRegionStatisResponse.HttpResponse = _ctx.HttpResponse;
			getDailyPlayRegionStatisResponse.RequestId = _ctx.StringValue("GetDailyPlayRegionStatis.RequestId");

			List<string> getDailyPlayRegionStatisResponse_failDates = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDailyPlayRegionStatis.FailDates.Length"); i++) {
				getDailyPlayRegionStatisResponse_failDates.Add(_ctx.StringValue("GetDailyPlayRegionStatis.FailDates["+ i +"]"));
			}
			getDailyPlayRegionStatisResponse.FailDates = getDailyPlayRegionStatisResponse_failDates;

			List<string> getDailyPlayRegionStatisResponse_emptyDates = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDailyPlayRegionStatis.EmptyDates.Length"); i++) {
				getDailyPlayRegionStatisResponse_emptyDates.Add(_ctx.StringValue("GetDailyPlayRegionStatis.EmptyDates["+ i +"]"));
			}
			getDailyPlayRegionStatisResponse.EmptyDates = getDailyPlayRegionStatisResponse_emptyDates;

			List<GetDailyPlayRegionStatisResponse.GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO> getDailyPlayRegionStatisResponse_dailyPlayRegionStatisList = new List<GetDailyPlayRegionStatisResponse.GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO>();
			for (int i = 0; i < _ctx.Length("GetDailyPlayRegionStatis.DailyPlayRegionStatisList.Length"); i++) {
				GetDailyPlayRegionStatisResponse.GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO dailyPlayRegionStatisFileDO = new GetDailyPlayRegionStatisResponse.GetDailyPlayRegionStatis_DailyPlayRegionStatisFileDO();
				dailyPlayRegionStatisFileDO.Date = _ctx.StringValue("GetDailyPlayRegionStatis.DailyPlayRegionStatisList["+ i +"].Date");
				dailyPlayRegionStatisFileDO.FileUrl = _ctx.StringValue("GetDailyPlayRegionStatis.DailyPlayRegionStatisList["+ i +"].FileUrl");

				getDailyPlayRegionStatisResponse_dailyPlayRegionStatisList.Add(dailyPlayRegionStatisFileDO);
			}
			getDailyPlayRegionStatisResponse.DailyPlayRegionStatisList = getDailyPlayRegionStatisResponse_dailyPlayRegionStatisList;
        
			return getDailyPlayRegionStatisResponse;
        }
    }
}
