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
using System.Collections.Generic;
using Aliyun.Acs.Cdn.Model.V20141111;
using Aliyun.Acs.Core.Transform;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainHttpsDataResponseUnmarshaller
    {
        public static DescribeDomainHttpsDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainHttpsDataResponse describeDomainHttpsDataResponse = new DescribeDomainHttpsDataResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainHttpsData.RequestId"),
                DataInterval = context.StringValue("DescribeDomainHttpsData.DataInterval"),
                DomainNames = context.StringValue("DescribeDomainHttpsData.DomainNames")
            };


            List<DescribeDomainHttpsDataResponse.HttpsStatisticsInfo> httpsData = new List<DescribeDomainHttpsDataResponse.HttpsStatisticsInfo>();
            for (int i = 0; i < context.Length("DescribeDomainHttpsData.HttpsData.Length"); i++)
            {
                DescribeDomainHttpsDataResponse.HttpsStatisticsInfo httpsStatisticsInfo = new DescribeDomainHttpsDataResponse.HttpsStatisticsInfo
                {
                    HttpsByteHitRate = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].HttpsByteHitRate"),
                    HttpsReqHitRate = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].HttpsReqHitRate"),
                    HttpsSrcBps = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].HttpsSrcBps"),
                    HttpsSrcTraf = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].HttpsSrcTraf"),
                    L1HttpsBps = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsBps"),
                    L1HttpsHitRate = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsHitRate"),
                    L1HttpsInnerBps = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsInnerBps"),
                    L1HttpsInnerQps = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsInnerQps"),
                    L1HttpsInnerTraf = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsInnerTraf"),
                    L1HttpsInnerAcc = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsInner_acc"),
                    L1HttpsOutBps = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsOutBps"),
                    L1HttpsOutQps = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsOutQps"),
                    L1HttpsOutTraf = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsOutTraf"),
                    L1HttpsOutAcc = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsOut_acc"),
                    L1HttpsQps = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsQps"),
                    L1HttpsTacc = context.FloatValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsTacc"),
                    L1HttpsTtraf = context.LongValue($"DescribeDomainHttpsData.HttpsData[{i}].L1HttpsTtraf"),
                    Time = context.StringValue($"DescribeDomainHttpsData.HttpsData[{i}].Time")
                };

                httpsData.Add(httpsStatisticsInfo);
            }
            describeDomainHttpsDataResponse.HttpsStatisticsInfos = httpsData;

            return describeDomainHttpsDataResponse;
        }
    }
}
