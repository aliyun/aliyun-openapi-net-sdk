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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class GetAccountSecurityPracticeReportResponseUnmarshaller
    {
        public static GetAccountSecurityPracticeReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountSecurityPracticeReportResponse getAccountSecurityPracticeReportResponse = new GetAccountSecurityPracticeReportResponse();

			getAccountSecurityPracticeReportResponse.HttpResponse = _ctx.HttpResponse;
			getAccountSecurityPracticeReportResponse.RequestId = _ctx.StringValue("GetAccountSecurityPracticeReport.RequestId");

			GetAccountSecurityPracticeReportResponse.GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo accountSecurityPracticeInfo = new GetAccountSecurityPracticeReportResponse.GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo();
			accountSecurityPracticeInfo.Score = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.Score");

			GetAccountSecurityPracticeReportResponse.GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo.GetAccountSecurityPracticeReport_AccountSecurityPracticeUserInfo accountSecurityPracticeUserInfo = new GetAccountSecurityPracticeReportResponse.GetAccountSecurityPracticeReport_AccountSecurityPracticeInfo.GetAccountSecurityPracticeReport_AccountSecurityPracticeUserInfo();
			accountSecurityPracticeUserInfo.UnusedAkNum = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.UnusedAkNum");
			accountSecurityPracticeUserInfo.SubUserWithUnusedAccessKey = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.SubUserWithUnusedAccessKey");
			accountSecurityPracticeUserInfo.RootWithAccessKey = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.RootWithAccessKey");
			accountSecurityPracticeUserInfo.SubUser = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.SubUser");
			accountSecurityPracticeUserInfo.BindMfa = _ctx.BooleanValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.BindMfa");
			accountSecurityPracticeUserInfo.OldAkNum = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.OldAkNum");
			accountSecurityPracticeUserInfo.SubUserPwdLevel = _ctx.StringValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.SubUserPwdLevel");
			accountSecurityPracticeUserInfo.SubUserWithOldAccessKey = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.SubUserWithOldAccessKey");
			accountSecurityPracticeUserInfo.SubUserBindMfa = _ctx.IntegerValue("GetAccountSecurityPracticeReport.AccountSecurityPracticeInfo.AccountSecurityPracticeUserInfo.SubUserBindMfa");
			accountSecurityPracticeInfo.AccountSecurityPracticeUserInfo = accountSecurityPracticeUserInfo;
			getAccountSecurityPracticeReportResponse.AccountSecurityPracticeInfo = accountSecurityPracticeInfo;
        
			return getAccountSecurityPracticeReportResponse;
        }
    }
}
