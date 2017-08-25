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
    public class DescribeDomainMonthBillingBpsDataResponseUnmarshaller
    {
        public static DescribeDomainMonthBillingBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainMonthBillingBpsDataResponse describeDomainMonthBillingBpsDataResponse = new DescribeDomainMonthBillingBpsDataResponse();

			describeDomainMonthBillingBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainMonthBillingBpsDataResponse.RequestId = context.StringValue("DescribeDomainMonthBillingBpsData.RequestId");
			describeDomainMonthBillingBpsDataResponse.DomainName = context.StringValue("DescribeDomainMonthBillingBpsData.DomainName");
			describeDomainMonthBillingBpsDataResponse.StartTime = context.StringValue("DescribeDomainMonthBillingBpsData.StartTime");
			describeDomainMonthBillingBpsDataResponse.EndTime = context.StringValue("DescribeDomainMonthBillingBpsData.EndTime");
			describeDomainMonthBillingBpsDataResponse.Bandwidth95Bps = context.FloatValue("DescribeDomainMonthBillingBpsData.Bandwidth95Bps");
			describeDomainMonthBillingBpsDataResponse.DomesticBandwidth95Bps = context.FloatValue("DescribeDomainMonthBillingBpsData.DomesticBandwidth95Bps");
			describeDomainMonthBillingBpsDataResponse.OverseasBandwidth95Bps = context.FloatValue("DescribeDomainMonthBillingBpsData.OverseasBandwidth95Bps");
			describeDomainMonthBillingBpsDataResponse.MonthavgBps = context.FloatValue("DescribeDomainMonthBillingBpsData.MonthavgBps");
			describeDomainMonthBillingBpsDataResponse.DomesticMonthavgBps = context.FloatValue("DescribeDomainMonthBillingBpsData.DomesticMonthavgBps");
			describeDomainMonthBillingBpsDataResponse.OverseasMonthavgBps = context.FloatValue("DescribeDomainMonthBillingBpsData.OverseasMonthavgBps");
			describeDomainMonthBillingBpsDataResponse.Month4thBps = context.FloatValue("DescribeDomainMonthBillingBpsData.Month4thBps");
			describeDomainMonthBillingBpsDataResponse.DomesticMonth4thBps = context.FloatValue("DescribeDomainMonthBillingBpsData.DomesticMonth4thBps");
			describeDomainMonthBillingBpsDataResponse.OverseasMonth4thBps = context.FloatValue("DescribeDomainMonthBillingBpsData.OverseasMonth4thBps");
        
			return describeDomainMonthBillingBpsDataResponse;
        }
    }
}