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
    public class DescribePlayUserAvgResponseUnmarshaller
    {
        public static DescribePlayUserAvgResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlayUserAvgResponse describePlayUserAvgResponse = new DescribePlayUserAvgResponse();

			describePlayUserAvgResponse.HttpResponse = _ctx.HttpResponse;
			describePlayUserAvgResponse.RequestId = _ctx.StringValue("DescribePlayUserAvg.RequestId");

			List<DescribePlayUserAvgResponse.DescribePlayUserAvg_UserPlayStatisAvg> describePlayUserAvgResponse_userPlayStatisAvgs = new List<DescribePlayUserAvgResponse.DescribePlayUserAvg_UserPlayStatisAvg>();
			for (int i = 0; i < _ctx.Length("DescribePlayUserAvg.UserPlayStatisAvgs.Length"); i++) {
				DescribePlayUserAvgResponse.DescribePlayUserAvg_UserPlayStatisAvg userPlayStatisAvg = new DescribePlayUserAvgResponse.DescribePlayUserAvg_UserPlayStatisAvg();
				userPlayStatisAvg.Date = _ctx.StringValue("DescribePlayUserAvg.UserPlayStatisAvgs["+ i +"].Date");
				userPlayStatisAvg.AvgPlayDuration = _ctx.StringValue("DescribePlayUserAvg.UserPlayStatisAvgs["+ i +"].AvgPlayDuration");
				userPlayStatisAvg.AvgPlayCount = _ctx.StringValue("DescribePlayUserAvg.UserPlayStatisAvgs["+ i +"].AvgPlayCount");

				describePlayUserAvgResponse_userPlayStatisAvgs.Add(userPlayStatisAvg);
			}
			describePlayUserAvgResponse.UserPlayStatisAvgs = describePlayUserAvgResponse_userPlayStatisAvgs;
        
			return describePlayUserAvgResponse;
        }
    }
}
