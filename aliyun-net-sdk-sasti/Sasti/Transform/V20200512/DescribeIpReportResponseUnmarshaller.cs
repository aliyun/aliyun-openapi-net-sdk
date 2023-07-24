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
    public class DescribeIpReportResponseUnmarshaller
    {
        public static DescribeIpReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpReportResponse describeIpReportResponse = new DescribeIpReportResponse();

			describeIpReportResponse.HttpResponse = _ctx.HttpResponse;
			describeIpReportResponse.Context = _ctx.StringValue("DescribeIpReport.Context");
			describeIpReportResponse.Intelligences = _ctx.StringValue("DescribeIpReport.Intelligences");
			describeIpReportResponse.Whois = _ctx.StringValue("DescribeIpReport.Whois");
			describeIpReportResponse.RequestId = _ctx.StringValue("DescribeIpReport.RequestId");
			describeIpReportResponse.AttackPreferenceTop5 = _ctx.StringValue("DescribeIpReport.AttackPreferenceTop5");
			describeIpReportResponse.Confidence = _ctx.StringValue("DescribeIpReport.Confidence");
			describeIpReportResponse.ThreatTypes = _ctx.StringValue("DescribeIpReport.ThreatTypes");
			describeIpReportResponse.Scenario = _ctx.StringValue("DescribeIpReport.Scenario");
			describeIpReportResponse.Ip = _ctx.StringValue("DescribeIpReport.Ip");
			describeIpReportResponse.ThreatLevel = _ctx.StringValue("DescribeIpReport.ThreatLevel");
			describeIpReportResponse.AttackCntByThreatType = _ctx.StringValue("DescribeIpReport.AttackCntByThreatType");
			describeIpReportResponse.Group = _ctx.StringValue("DescribeIpReport.Group");
        
			return describeIpReportResponse;
        }
    }
}
