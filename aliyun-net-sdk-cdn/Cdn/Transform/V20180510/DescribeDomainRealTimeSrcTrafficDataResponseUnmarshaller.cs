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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainRealTimeSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainRealTimeSrcTrafficDataResponse describeDomainRealTimeSrcTrafficDataResponse = new DescribeDomainRealTimeSrcTrafficDataResponse();

            describeDomainRealTimeSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
            describeDomainRealTimeSrcTrafficDataResponse.RequestId = context.StringValue("DescribeDomainRealTimeSrcTrafficData.RequestId");
            describeDomainRealTimeSrcTrafficDataResponse.DomainName = context.StringValue("DescribeDomainRealTimeSrcTrafficData.DomainName");
            describeDomainRealTimeSrcTrafficDataResponse.StartTime = context.StringValue("DescribeDomainRealTimeSrcTrafficData.StartTime");
            describeDomainRealTimeSrcTrafficDataResponse.EndTime = context.StringValue("DescribeDomainRealTimeSrcTrafficData.EndTime");
            describeDomainRealTimeSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeDomainRealTimeSrcTrafficData.DataInterval");

            List<DescribeDomainRealTimeSrcTrafficDataResponse.DescribeDomainRealTimeSrcTrafficData_DataModule> describeDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval = new List<DescribeDomainRealTimeSrcTrafficDataResponse.DescribeDomainRealTimeSrcTrafficData_DataModule>();
            for (int i = 0; i < context.Length("DescribeDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval.Length"); i++)
            {
                DescribeDomainRealTimeSrcTrafficDataResponse.DescribeDomainRealTimeSrcTrafficData_DataModule dataModule = new DescribeDomainRealTimeSrcTrafficDataResponse.DescribeDomainRealTimeSrcTrafficData_DataModule();
                dataModule.TimeStamp = context.StringValue("DescribeDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval[" + i + "].TimeStamp");
                dataModule._Value = context.StringValue("DescribeDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval[" + i + "].Value");

                describeDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval.Add(dataModule);
            }
            describeDomainRealTimeSrcTrafficDataResponse.RealTimeSrcTrafficDataPerInterval = describeDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval;

            return describeDomainRealTimeSrcTrafficDataResponse;
        }
    }
}
