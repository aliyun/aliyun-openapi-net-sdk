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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainHttpsDataResponseUnmarshaller
    {
        public static DescribeDomainHttpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainHttpsDataResponse describeDomainHttpsDataResponse = new DescribeDomainHttpsDataResponse();

			describeDomainHttpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainHttpsDataResponse.RequestId = context.StringValue("DescribeDomainHttpsData.RequestId");
			describeDomainHttpsDataResponse.DomainNames = context.StringValue("DescribeDomainHttpsData.DomainNames");
			describeDomainHttpsDataResponse.DataInterval = context.StringValue("DescribeDomainHttpsData.DataInterval");

			List<DescribeDomainHttpsDataResponse.DescribeDomainHttpsData_HttpsStatisticsInfo> describeDomainHttpsDataResponse_httpsStatisticsInfos = new List<DescribeDomainHttpsDataResponse.DescribeDomainHttpsData_HttpsStatisticsInfo>();
			for (int i = 0; i < context.Length("DescribeDomainHttpsData.HttpsStatisticsInfos.Length"); i++) {
				DescribeDomainHttpsDataResponse.DescribeDomainHttpsData_HttpsStatisticsInfo httpsStatisticsInfo = new DescribeDomainHttpsDataResponse.DescribeDomainHttpsData_HttpsStatisticsInfo();
				httpsStatisticsInfo.Time = context.StringValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].Time");
				httpsStatisticsInfo.L1HttpsBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsBps");
				httpsStatisticsInfo.L1HttpsInnerBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsInnerBps");
				httpsStatisticsInfo.L1HttpsOutBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsOutBps");
				httpsStatisticsInfo.L1HttpsQps = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsQps");
				httpsStatisticsInfo.L1HttpsInnerQps = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsInnerQps");
				httpsStatisticsInfo.L1HttpsOutQps = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsOutQps");
				httpsStatisticsInfo.L1HttpsTtraf = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsTtraf");
				httpsStatisticsInfo.HttpsSrcBps = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].HttpsSrcBps");
				httpsStatisticsInfo.HttpsSrcTraf = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].HttpsSrcTraf");
				httpsStatisticsInfo.L1HttpsInnerTraf = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsInnerTraf");
				httpsStatisticsInfo.L1HttpsOutTraf = context.LongValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsOutTraf");
				httpsStatisticsInfo.HttpsByteHitRate = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].HttpsByteHitRate");
				httpsStatisticsInfo.HttpsReqHitRate = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].HttpsReqHitRate");
				httpsStatisticsInfo.L1HttpsHitRate = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsHitRate");
				httpsStatisticsInfo.L1HttpsInner_acc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsInner_acc");
				httpsStatisticsInfo.L1HttpsOut_acc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsOut_acc");
				httpsStatisticsInfo.L1HttpsTacc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1HttpsTacc");
				httpsStatisticsInfo.L1DyHttpsBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsBps");
				httpsStatisticsInfo.L1DyHttpsInnerBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsInnerBps");
				httpsStatisticsInfo.L1DyHttpsOutBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsOutBps");
				httpsStatisticsInfo.L1StHttpsBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsBps");
				httpsStatisticsInfo.L1StHttpsInnerBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsInnerBps");
				httpsStatisticsInfo.L1StHttpsOutBps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsOutBps");
				httpsStatisticsInfo.L1DyHttpsTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsTraf");
				httpsStatisticsInfo.L1DyHttpsInnerTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsInnerTraf");
				httpsStatisticsInfo.L1DyHttpsOutTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsOutTraf");
				httpsStatisticsInfo.L1StHttpsTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsTraf");
				httpsStatisticsInfo.L1StHttpsInnerTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsInnerTraf");
				httpsStatisticsInfo.L1StHttpsOutTraf = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsOutTraf");
				httpsStatisticsInfo.L1DyHttpsQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsQps");
				httpsStatisticsInfo.L1DyHttpsInnerQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsInnerQps");
				httpsStatisticsInfo.L1DyHttpsOutQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsOutQps");
				httpsStatisticsInfo.L1StHttpsQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsQps");
				httpsStatisticsInfo.L1StHttpsInnerQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsInnerQps");
				httpsStatisticsInfo.L1StHttpsOutQps = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsOutQps");
				httpsStatisticsInfo.L1DyHttpsAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsAcc");
				httpsStatisticsInfo.L1DyHttpsInnerAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsInnerAcc");
				httpsStatisticsInfo.L1DyHttpsOutAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1DyHttpsOutAcc");
				httpsStatisticsInfo.L1StHttpsAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsAcc");
				httpsStatisticsInfo.L1StHttpsInnerAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsInnerAcc");
				httpsStatisticsInfo.L1StHttpsOutAcc = context.FloatValue("DescribeDomainHttpsData.HttpsStatisticsInfos["+ i +"].L1StHttpsOutAcc");

				describeDomainHttpsDataResponse_httpsStatisticsInfos.Add(httpsStatisticsInfo);
			}
			describeDomainHttpsDataResponse.HttpsStatisticsInfos = describeDomainHttpsDataResponse_httpsStatisticsInfos;
        
			return describeDomainHttpsDataResponse;
        }
    }
}