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
    public class DescribeScdnCcQpsInfoResponseUnmarshaller
    {
        public static DescribeScdnCcQpsInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnCcQpsInfoResponse describeScdnCcQpsInfoResponse = new DescribeScdnCcQpsInfoResponse();

			describeScdnCcQpsInfoResponse.HttpResponse = context.HttpResponse;
			describeScdnCcQpsInfoResponse.RequestId = context.StringValue("DescribeScdnCcQpsInfo.RequestId");

			List<string> describeScdnCcQpsInfoResponse_totals = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnCcQpsInfo.Totals.Length"); i++) {
				describeScdnCcQpsInfoResponse_totals.Add(context.StringValue("DescribeScdnCcQpsInfo.Totals["+ i +"]"));
			}
			describeScdnCcQpsInfoResponse.Totals = describeScdnCcQpsInfoResponse_totals;

			List<string> describeScdnCcQpsInfoResponse_attacks = new List<string>();
			for (int i = 0; i < context.Length("DescribeScdnCcQpsInfo.Attacks.Length"); i++) {
				describeScdnCcQpsInfoResponse_attacks.Add(context.StringValue("DescribeScdnCcQpsInfo.Attacks["+ i +"]"));
			}
			describeScdnCcQpsInfoResponse.Attacks = describeScdnCcQpsInfoResponse_attacks;

			List<DescribeScdnCcQpsInfoResponse.DescribeScdnCcQpsInfo_TimeScope> describeScdnCcQpsInfoResponse_timeScopes = new List<DescribeScdnCcQpsInfoResponse.DescribeScdnCcQpsInfo_TimeScope>();
			for (int i = 0; i < context.Length("DescribeScdnCcQpsInfo.TimeScopes.Length"); i++) {
				DescribeScdnCcQpsInfoResponse.DescribeScdnCcQpsInfo_TimeScope timeScope = new DescribeScdnCcQpsInfoResponse.DescribeScdnCcQpsInfo_TimeScope();
				timeScope.Interval = context.StringValue("DescribeScdnCcQpsInfo.TimeScopes["+ i +"].Interval");
				timeScope.Start = context.StringValue("DescribeScdnCcQpsInfo.TimeScopes["+ i +"].Start");

				describeScdnCcQpsInfoResponse_timeScopes.Add(timeScope);
			}
			describeScdnCcQpsInfoResponse.TimeScopes = describeScdnCcQpsInfoResponse_timeScopes;
        
			return describeScdnCcQpsInfoResponse;
        }
    }
}
