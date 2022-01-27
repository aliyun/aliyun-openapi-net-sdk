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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDDoSTrafficInfoResponseUnmarshaller
    {
        public static DescribeScdnDDoSTrafficInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDDoSTrafficInfoResponse describeScdnDDoSTrafficInfoResponse = new DescribeScdnDDoSTrafficInfoResponse();

			describeScdnDDoSTrafficInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDDoSTrafficInfoResponse.RequestId = _ctx.StringValue("DescribeScdnDDoSTrafficInfo.RequestId");

			List<string> describeScdnDDoSTrafficInfoResponse_bpsDrops = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDDoSTrafficInfo.BpsDrops.Length"); i++) {
				describeScdnDDoSTrafficInfoResponse_bpsDrops.Add(_ctx.StringValue("DescribeScdnDDoSTrafficInfo.BpsDrops["+ i +"]"));
			}
			describeScdnDDoSTrafficInfoResponse.BpsDrops = describeScdnDDoSTrafficInfoResponse_bpsDrops;

			List<string> describeScdnDDoSTrafficInfoResponse_bpsTotals = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDDoSTrafficInfo.BpsTotals.Length"); i++) {
				describeScdnDDoSTrafficInfoResponse_bpsTotals.Add(_ctx.StringValue("DescribeScdnDDoSTrafficInfo.BpsTotals["+ i +"]"));
			}
			describeScdnDDoSTrafficInfoResponse.BpsTotals = describeScdnDDoSTrafficInfoResponse_bpsTotals;

			List<string> describeScdnDDoSTrafficInfoResponse_ppsTotals = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDDoSTrafficInfo.PpsTotals.Length"); i++) {
				describeScdnDDoSTrafficInfoResponse_ppsTotals.Add(_ctx.StringValue("DescribeScdnDDoSTrafficInfo.PpsTotals["+ i +"]"));
			}
			describeScdnDDoSTrafficInfoResponse.PpsTotals = describeScdnDDoSTrafficInfoResponse_ppsTotals;

			List<string> describeScdnDDoSTrafficInfoResponse_ppsDrops = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDDoSTrafficInfo.PpsDrops.Length"); i++) {
				describeScdnDDoSTrafficInfoResponse_ppsDrops.Add(_ctx.StringValue("DescribeScdnDDoSTrafficInfo.PpsDrops["+ i +"]"));
			}
			describeScdnDDoSTrafficInfoResponse.PpsDrops = describeScdnDDoSTrafficInfoResponse_ppsDrops;

			List<DescribeScdnDDoSTrafficInfoResponse.DescribeScdnDDoSTrafficInfo_TimeScope> describeScdnDDoSTrafficInfoResponse_timeScopes = new List<DescribeScdnDDoSTrafficInfoResponse.DescribeScdnDDoSTrafficInfo_TimeScope>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDDoSTrafficInfo.TimeScopes.Length"); i++) {
				DescribeScdnDDoSTrafficInfoResponse.DescribeScdnDDoSTrafficInfo_TimeScope timeScope = new DescribeScdnDDoSTrafficInfoResponse.DescribeScdnDDoSTrafficInfo_TimeScope();
				timeScope.Interval = _ctx.StringValue("DescribeScdnDDoSTrafficInfo.TimeScopes["+ i +"].Interval");
				timeScope.Start = _ctx.StringValue("DescribeScdnDDoSTrafficInfo.TimeScopes["+ i +"].Start");

				describeScdnDDoSTrafficInfoResponse_timeScopes.Add(timeScope);
			}
			describeScdnDDoSTrafficInfoResponse.TimeScopes = describeScdnDDoSTrafficInfoResponse_timeScopes;
        
			return describeScdnDDoSTrafficInfoResponse;
        }
    }
}
