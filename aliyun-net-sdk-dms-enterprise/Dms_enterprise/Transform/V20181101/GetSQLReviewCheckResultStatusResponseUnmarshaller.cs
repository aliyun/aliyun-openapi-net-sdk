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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetSQLReviewCheckResultStatusResponseUnmarshaller
    {
        public static GetSQLReviewCheckResultStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSQLReviewCheckResultStatusResponse getSQLReviewCheckResultStatusResponse = new GetSQLReviewCheckResultStatusResponse();

			getSQLReviewCheckResultStatusResponse.HttpResponse = _ctx.HttpResponse;
			getSQLReviewCheckResultStatusResponse.RequestId = _ctx.StringValue("GetSQLReviewCheckResultStatus.RequestId");
			getSQLReviewCheckResultStatusResponse.ErrorCode = _ctx.StringValue("GetSQLReviewCheckResultStatus.ErrorCode");
			getSQLReviewCheckResultStatusResponse.ErrorMessage = _ctx.StringValue("GetSQLReviewCheckResultStatus.ErrorMessage");
			getSQLReviewCheckResultStatusResponse.Success = _ctx.BooleanValue("GetSQLReviewCheckResultStatus.Success");

			GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus checkResultStatus = new GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus();
			checkResultStatus.TotalSQLCount = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.TotalSQLCount");
			checkResultStatus.CheckedCount = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckedCount");

			GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus.GetSQLReviewCheckResultStatus_CheckStatusResult checkStatusResult = new GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus.GetSQLReviewCheckResultStatus_CheckStatusResult();
			checkStatusResult._New = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.New");
			checkStatusResult.Unknown = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.Unknown");
			checkStatusResult.CheckNotPass = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.CheckNotPass");
			checkStatusResult.CheckPass = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.CheckPass");
			checkStatusResult.ForcePass = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.ForcePass");
			checkStatusResult.ForceNotPass = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.CheckStatusResult.ForceNotPass");
			checkResultStatus.CheckStatusResult = checkStatusResult;

			GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus.GetSQLReviewCheckResultStatus_SQLReviewResult sQLReviewResult = new GetSQLReviewCheckResultStatusResponse.GetSQLReviewCheckResultStatus_CheckResultStatus.GetSQLReviewCheckResultStatus_SQLReviewResult();
			sQLReviewResult.MustImprove = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.MustImprove");
			sQLReviewResult.PotentialIssue = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.PotentialIssue");
			sQLReviewResult.SuggestImprove = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.SuggestImprove");
			sQLReviewResult.UseDmsToolkit = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.UseDmsToolkit");
			sQLReviewResult.UseDmsDmlUnlock = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.UseDmsDmlUnlock");
			sQLReviewResult.TableIndexSuggest = _ctx.LongValue("GetSQLReviewCheckResultStatus.CheckResultStatus.SQLReviewResult.TableIndexSuggest");
			checkResultStatus.SQLReviewResult = sQLReviewResult;
			getSQLReviewCheckResultStatusResponse.CheckResultStatus = checkResultStatus;
        
			return getSQLReviewCheckResultStatusResponse;
        }
    }
}
