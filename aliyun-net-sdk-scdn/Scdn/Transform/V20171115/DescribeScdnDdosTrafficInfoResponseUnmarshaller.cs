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
    public class DescribeScdnDdosTrafficInfoResponseUnmarshaller
    {
        public static DescribeScdnDdosTrafficInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDdosTrafficInfoResponse describeScdnDdosTrafficInfoResponse = new DescribeScdnDdosTrafficInfoResponse();

			describeScdnDdosTrafficInfoResponse.HttpResponse = context.HttpResponse;
			describeScdnDdosTrafficInfoResponse.RequestId = context.StringValue("DescribeScdnDdosTrafficInfo.RequestId");

			List<string> describeScdnDdosTrafficInfoResponse_bpsDrops = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnDdosTrafficInfo.BpsDrops.Length"); i++) {
				describeScdnDdosTrafficInfoResponse_bpsDrops.Add(context.StringValue("DescribeScdnDdosTrafficInfo.BpsDrops["+ i +"]"));
			}
			describeScdnDdosTrafficInfoResponse.BpsDrops = describeScdnDdosTrafficInfoResponse_bpsDrops;

			List<string> describeScdnDdosTrafficInfoResponse_bpsTotals = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnDdosTrafficInfo.BpsTotals.Length"); i++) {
				describeScdnDdosTrafficInfoResponse_bpsTotals.Add(context.StringValue("DescribeScdnDdosTrafficInfo.BpsTotals["+ i +"]"));
			}
			describeScdnDdosTrafficInfoResponse.BpsTotals = describeScdnDdosTrafficInfoResponse_bpsTotals;

			List<string> describeScdnDdosTrafficInfoResponse_ppsTotals = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnDdosTrafficInfo.PpsTotals.Length"); i++) {
				describeScdnDdosTrafficInfoResponse_ppsTotals.Add(context.StringValue("DescribeScdnDdosTrafficInfo.PpsTotals["+ i +"]"));
			}
			describeScdnDdosTrafficInfoResponse.PpsTotals = describeScdnDdosTrafficInfoResponse_ppsTotals;

			List<string> describeScdnDdosTrafficInfoResponse_ppsDrops = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnDdosTrafficInfo.PpsDrops.Length"); i++) {
				describeScdnDdosTrafficInfoResponse_ppsDrops.Add(context.StringValue("DescribeScdnDdosTrafficInfo.PpsDrops["+ i +"]"));
			}
			describeScdnDdosTrafficInfoResponse.PpsDrops = describeScdnDdosTrafficInfoResponse_ppsDrops;

			List<DescribeScdnDdosTrafficInfoResponse.DescribeScdnDdosTrafficInfo_TimeScope> describeScdnDdosTrafficInfoResponse_timeScopes = new List<DescribeScdnDdosTrafficInfoResponse.DescribeScdnDdosTrafficInfo_TimeScope>();
			for (int i = 0; i < context.Length("DescribeScdnDdosTrafficInfo.TimeScopes.Length"); i++) {
				DescribeScdnDdosTrafficInfoResponse.DescribeScdnDdosTrafficInfo_TimeScope timeScope = new DescribeScdnDdosTrafficInfoResponse.DescribeScdnDdosTrafficInfo_TimeScope();
				timeScope.Interval = context.StringValue("DescribeScdnDdosTrafficInfo.TimeScopes["+ i +"].Interval");
				timeScope.Start = context.StringValue("DescribeScdnDdosTrafficInfo.TimeScopes["+ i +"].Start");

				describeScdnDdosTrafficInfoResponse_timeScopes.Add(timeScope);
			}
			describeScdnDdosTrafficInfoResponse.TimeScopes = describeScdnDdosTrafficInfoResponse_timeScopes;
        
			return describeScdnDdosTrafficInfoResponse;
        }
    }
}
