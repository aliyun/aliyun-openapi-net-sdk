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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class DescAccountSummaryResponseUnmarshaller
    {
        public static DescAccountSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescAccountSummaryResponse descAccountSummaryResponse = new DescAccountSummaryResponse();

			descAccountSummaryResponse.HttpResponse = context.HttpResponse;
			descAccountSummaryResponse.RequestId = context.StringValue("DescAccountSummary.RequestId");
			descAccountSummaryResponse.UserStatus = context.IntegerValue("DescAccountSummary.UserStatus");
			descAccountSummaryResponse.QuotaLevel = context.IntegerValue("DescAccountSummary.QuotaLevel");
			descAccountSummaryResponse.MaxQuotaLevel = context.IntegerValue("DescAccountSummary.MaxQuotaLevel");
			descAccountSummaryResponse.DailyQuota = context.IntegerValue("DescAccountSummary.DailyQuota");
			descAccountSummaryResponse.MonthQuota = context.IntegerValue("DescAccountSummary.MonthQuota");
			descAccountSummaryResponse.Tags = context.IntegerValue("DescAccountSummary.Tags");
			descAccountSummaryResponse.Domains = context.IntegerValue("DescAccountSummary.Domains");
			descAccountSummaryResponse.MailAddresses = context.IntegerValue("DescAccountSummary.MailAddresses");
			descAccountSummaryResponse.Receivers = context.IntegerValue("DescAccountSummary.Receivers");
			descAccountSummaryResponse.Templates = context.IntegerValue("DescAccountSummary.Templates");
			descAccountSummaryResponse.DayuStatus = context.IntegerValue("DescAccountSummary.DayuStatus");
			descAccountSummaryResponse.SmsTemplates = context.IntegerValue("DescAccountSummary.SmsTemplates");
			descAccountSummaryResponse.SmsRecord = context.IntegerValue("DescAccountSummary.SmsRecord");
			descAccountSummaryResponse.SmsSign = context.IntegerValue("DescAccountSummary.SmsSign");
			descAccountSummaryResponse.EnableTimes = context.IntegerValue("DescAccountSummary.EnableTimes");
        
			return descAccountSummaryResponse;
        }
    }
}
