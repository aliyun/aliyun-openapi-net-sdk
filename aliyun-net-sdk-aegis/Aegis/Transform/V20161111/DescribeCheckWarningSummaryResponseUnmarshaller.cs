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
    public class DescribeCheckWarningSummaryResponseUnmarshaller
    {
        public static DescribeCheckWarningSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCheckWarningSummaryResponse describeCheckWarningSummaryResponse = new DescribeCheckWarningSummaryResponse();

			describeCheckWarningSummaryResponse.HttpResponse = context.HttpResponse;
			describeCheckWarningSummaryResponse.RequestId = context.StringValue("DescribeCheckWarningSummary.RequestId");
			describeCheckWarningSummaryResponse.Count = context.IntegerValue("DescribeCheckWarningSummary.Count");
			describeCheckWarningSummaryResponse.PageSize = context.IntegerValue("DescribeCheckWarningSummary.PageSize");
			describeCheckWarningSummaryResponse.TotalCount = context.IntegerValue("DescribeCheckWarningSummary.TotalCount");
			describeCheckWarningSummaryResponse.CurrentPage = context.IntegerValue("DescribeCheckWarningSummary.CurrentPage");

			List<DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary> describeCheckWarningSummaryResponse_warningSummarys = new List<DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary>();
			for (int i = 0; i < context.Length("DescribeCheckWarningSummary.WarningSummarys.Length"); i++) {
				DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary warningSummary = new DescribeCheckWarningSummaryResponse.DescribeCheckWarningSummary_WarningSummary();
				warningSummary.RiskId = context.LongValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].RiskId");
				warningSummary.RiskName = context.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].RiskName");
				warningSummary.TypeAlias = context.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].TypeAlias");
				warningSummary.SubTypeAlias = context.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].SubTypeAlias");
				warningSummary.LastFoundTime = context.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].LastFoundTime");
				warningSummary.Level = context.StringValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].Level");
				warningSummary.CheckCount = context.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].CheckCount");
				warningSummary.HighWarningCount = context.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].HighWarningCount");
				warningSummary.MediumWarningCount = context.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].MediumWarningCount");
				warningSummary.LowWarningCount = context.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].LowWarningCount");
				warningSummary.WarningMachineCount = context.IntegerValue("DescribeCheckWarningSummary.WarningSummarys["+ i +"].WarningMachineCount");

				describeCheckWarningSummaryResponse_warningSummarys.Add(warningSummary);
			}
			describeCheckWarningSummaryResponse.WarningSummarys = describeCheckWarningSummaryResponse_warningSummarys;
        
			return describeCheckWarningSummaryResponse;
        }
    }
}
