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
using Aliyun.Acs.Sasti.Model.V20200512;

namespace Aliyun.Acs.Sasti.Transform.V20200512
{
    public class DescribeDomainReportResponseUnmarshaller
    {
        public static DescribeDomainReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainReportResponse describeDomainReportResponse = new DescribeDomainReportResponse();

			describeDomainReportResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainReportResponse.Intelligences = _ctx.StringValue("DescribeDomainReport.Intelligences");
			describeDomainReportResponse.Domain = _ctx.StringValue("DescribeDomainReport.Domain");
			describeDomainReportResponse.SslCert = _ctx.StringValue("DescribeDomainReport.SslCert");
			describeDomainReportResponse.AttackPreferenceTop5 = _ctx.StringValue("DescribeDomainReport.AttackPreferenceTop5");
			describeDomainReportResponse.ThreatTypes = _ctx.StringValue("DescribeDomainReport.ThreatTypes");
			describeDomainReportResponse.Confidence = _ctx.StringValue("DescribeDomainReport.Confidence");
			describeDomainReportResponse.ThreatLevel = _ctx.StringValue("DescribeDomainReport.ThreatLevel");
			describeDomainReportResponse.AttackCntByThreatType = _ctx.StringValue("DescribeDomainReport.AttackCntByThreatType");
			describeDomainReportResponse.Context = _ctx.StringValue("DescribeDomainReport.Context");
			describeDomainReportResponse.Whois = _ctx.StringValue("DescribeDomainReport.Whois");
			describeDomainReportResponse.RequestId = _ctx.StringValue("DescribeDomainReport.RequestId");
			describeDomainReportResponse.Scenario = _ctx.StringValue("DescribeDomainReport.Scenario");
			describeDomainReportResponse.Basic = _ctx.StringValue("DescribeDomainReport.Basic");
			describeDomainReportResponse.Group = _ctx.StringValue("DescribeDomainReport.Group");
        
			return describeDomainReportResponse;
        }
    }
}
