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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeTotalStatisticsResponseUnmarshaller
    {
        public static DescribeTotalStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTotalStatisticsResponse describeTotalStatisticsResponse = new DescribeTotalStatisticsResponse();

			describeTotalStatisticsResponse.HttpResponse = context.HttpResponse;
			describeTotalStatisticsResponse.RequestId = context.StringValue("DescribeTotalStatistics.RequestId");
			describeTotalStatisticsResponse.VulAsapSum = context.IntegerValue("DescribeTotalStatistics.VulAsapSum");
			describeTotalStatisticsResponse.VulNntfSum = context.IntegerValue("DescribeTotalStatistics.VulNntfSum");
			describeTotalStatisticsResponse.HealthTotal = context.IntegerValue("DescribeTotalStatistics.HealthTotal");
			describeTotalStatisticsResponse.SuspiciousmediumTotal = context.IntegerValue("DescribeTotalStatistics.SuspiciousmediumTotal");
			describeTotalStatisticsResponse.Health = context.IntegerValue("DescribeTotalStatistics.Health");
			describeTotalStatisticsResponse.HealthdealedTotal = context.IntegerValue("DescribeTotalStatistics.HealthdealedTotal");
			describeTotalStatisticsResponse.Trojan = context.IntegerValue("DescribeTotalStatistics.Trojan");
			describeTotalStatisticsResponse.VulLaterSum = context.IntegerValue("DescribeTotalStatistics.VulLaterSum");
			describeTotalStatisticsResponse.Suspicious = context.IntegerValue("DescribeTotalStatistics.Suspicious");
			describeTotalStatisticsResponse.Vul = context.IntegerValue("DescribeTotalStatistics.Vul");
			describeTotalStatisticsResponse.HealthhighTotal = context.IntegerValue("DescribeTotalStatistics.HealthhighTotal");
			describeTotalStatisticsResponse.HealthlowTotal = context.IntegerValue("DescribeTotalStatistics.HealthlowTotal");
			describeTotalStatisticsResponse.HealthseriousTotal = context.IntegerValue("DescribeTotalStatistics.HealthseriousTotal");
			describeTotalStatisticsResponse.VulDealedTotal = context.IntegerValue("DescribeTotalStatistics.VulDealedTotal");
			describeTotalStatisticsResponse.Patch = context.IntegerValue("DescribeTotalStatistics.Patch");
			describeTotalStatisticsResponse.SuspicioushighTotal = context.IntegerValue("DescribeTotalStatistics.SuspicioushighTotal");
			describeTotalStatisticsResponse.SuspiciouslowTotal = context.IntegerValue("DescribeTotalStatistics.SuspiciouslowTotal");
			describeTotalStatisticsResponse.SuspiciousTotal = context.IntegerValue("DescribeTotalStatistics.SuspiciousTotal");
			describeTotalStatisticsResponse.VulTotal = context.IntegerValue("DescribeTotalStatistics.VulTotal");
			describeTotalStatisticsResponse.SuspiciousseriousTotal = context.IntegerValue("DescribeTotalStatistics.SuspiciousseriousTotal");
			describeTotalStatisticsResponse.HealthmediumTotal = context.IntegerValue("DescribeTotalStatistics.HealthmediumTotal");
			describeTotalStatisticsResponse.Online = context.BooleanValue("DescribeTotalStatistics.Online");
			describeTotalStatisticsResponse.SuspiciousdealedTotal = context.IntegerValue("DescribeTotalStatistics.SuspiciousdealedTotal");
			describeTotalStatisticsResponse.Account = context.IntegerValue("DescribeTotalStatistics.Account");
			describeTotalStatisticsResponse.Newsuspicious = context.IntegerValue("DescribeTotalStatistics.Newsuspicious");
        
			return describeTotalStatisticsResponse;
        }
    }
}
