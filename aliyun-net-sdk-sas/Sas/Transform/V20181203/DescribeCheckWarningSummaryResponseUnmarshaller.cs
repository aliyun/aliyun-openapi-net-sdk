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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeCheckWarningSummaryResponseUnmarshaller
    {
        public static DescribeCheckWarningSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCheckWarningSummaryResponse describeCheckWarningSummaryResponse = new DescribeCheckWarningSummaryResponse();

			describeCheckWarningSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeCheckWarningSummaryResponse.CurrentPage = _ctx.IntegerValue("DescribeCheckWarningSummary.CurrentPage");
			describeCheckWarningSummaryResponse.PageSize = _ctx.IntegerValue("DescribeCheckWarningSummary.PageSize");
			describeCheckWarningSummaryResponse.RequestId = _ctx.StringValue("DescribeCheckWarningSummary.RequestId");
			describeCheckWarningSummaryResponse.TotalCount = _ctx.IntegerValue("DescribeCheckWarningSummary.TotalCount");
			describeCheckWarningSummaryResponse.Count = _ctx.IntegerValue("DescribeCheckWarningSummary.Count");

			List<DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary> describeCheckWarningSummaryResponse_warningSummarys = new List<DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary>();
			for (int i = 0; i < _ctx.Length("DescribeCheckWarningSummary.WarningSummarys.Length"); i++) {
				DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary warningSummary = new DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary();
				warningSummary.LowWarningCount = _ctx.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].LowWarningCount");
				warningSummary.CheckCount = _ctx.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].CheckCount");
				warningSummary.MediumWarningCount = _ctx.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].MediumWarningCount");
				warningSummary.LastFoundTime = _ctx.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].LastFoundTime");
				warningSummary.RiskId = _ctx.LongValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].RiskId");
				warningSummary.SubTypeAlias = _ctx.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].SubTypeAlias");
				warningSummary.WarningMachineCount = _ctx.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].WarningMachineCount");
				warningSummary.HighWarningCount = _ctx.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].HighWarningCount");
				warningSummary.TypeAlias = _ctx.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].TypeAlias");
				warningSummary.RiskName = _ctx.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].RiskName");
				warningSummary.Level = _ctx.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].Level");
				warningSummary.CheckExploit = _ctx.BooleanValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].CheckExploit");
				warningSummary.DatabaseRisk = _ctx.BooleanValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].DatabaseRisk");

				describeCheckWarningSummaryResponse_warningSummarys.Add(warningSummary);
			}
			describeCheckWarningSummaryResponse.WarningSummarys = describeCheckWarningSummaryResponse_warningSummarys;
        
			return describeCheckWarningSummaryResponse;
        }
    }
}
