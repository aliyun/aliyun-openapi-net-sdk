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
    public class DescribesummaryResponseUnmarshaller
    {
        public static DescribesummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribesummaryResponse describesummaryResponse = new DescribesummaryResponse();

			describesummaryResponse.HttpResponse = context.HttpResponse;
			describesummaryResponse.RequestId = context.StringValue("Describesummary.RequestId");
			describesummaryResponse.Count = context.IntegerValue("Describesummary.Count");
			describesummaryResponse.PageSize = context.IntegerValue("Describesummary.PageSize");
			describesummaryResponse.TotalCount = context.IntegerValue("Describesummary.TotalCount");
			describesummaryResponse.CurrentPage = context.IntegerValue("Describesummary.CurrentPage");

			List<DescribesummaryResponse.Describesummary_WarningSummary> describesummaryResponse_warningSummarys = new List<DescribesummaryResponse.Describesummary_WarningSummary>();
			for (int i = 0; i < context.Length("Describesummary.WarningSummarys.Length"); i++) {
				DescribesummaryResponse.Describesummary_WarningSummary warningSummary = new DescribesummaryResponse.Describesummary_WarningSummary();
				warningSummary.RiskId = context.LongValue("Describesummary.WarningSummarys["+ i +"].RiskId");
				warningSummary.RiskName = context.StringValue("Describesummary.WarningSummarys["+ i +"].RiskName");
				warningSummary.Level = context.StringValue("Describesummary.WarningSummarys["+ i +"].Level");
				warningSummary.TypeAlias = context.StringValue("Describesummary.WarningSummarys["+ i +"].TypeAlias");
				warningSummary.SubTypeAlias = context.StringValue("Describesummary.WarningSummarys["+ i +"].SubTypeAlias");
				warningSummary.LastFoundTime = context.StringValue("Describesummary.WarningSummarys["+ i +"].LastFoundTime");
				warningSummary.PendingCount = context.IntegerValue("Describesummary.WarningSummarys["+ i +"].PendingCount");
				warningSummary.TotalCount = context.IntegerValue("Describesummary.WarningSummarys["+ i +"].TotalCount");
				warningSummary.RiskDetail = context.StringValue("Describesummary.WarningSummarys["+ i +"].RiskDetail");

				describesummaryResponse_warningSummarys.Add(warningSummary);
			}
			describesummaryResponse.WarningSummarys = describesummaryResponse_warningSummarys;
        
			return describesummaryResponse;
        }
    }
}
