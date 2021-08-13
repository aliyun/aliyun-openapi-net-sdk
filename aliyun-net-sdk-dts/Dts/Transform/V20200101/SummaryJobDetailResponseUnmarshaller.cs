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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class SummaryJobDetailResponseUnmarshaller
    {
        public static SummaryJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SummaryJobDetailResponse summaryJobDetailResponse = new SummaryJobDetailResponse();

			summaryJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			summaryJobDetailResponse.Code = _ctx.StringValue("SummaryJobDetail.Code");
			summaryJobDetailResponse.HttpStatusCode = _ctx.IntegerValue("SummaryJobDetail.HttpStatusCode");
			summaryJobDetailResponse.JobId = _ctx.StringValue("SummaryJobDetail.JobId");
			summaryJobDetailResponse.RequestId = _ctx.StringValue("SummaryJobDetail.RequestId");
			summaryJobDetailResponse.Success = _ctx.BooleanValue("SummaryJobDetail.Success");

			List<SummaryJobDetailResponse.SummaryJobDetail_ProgressSummaryDetail> summaryJobDetailResponse_progressSummaryDetails = new List<SummaryJobDetailResponse.SummaryJobDetail_ProgressSummaryDetail>();
			for (int i = 0; i < _ctx.Length("SummaryJobDetail.ProgressSummaryDetails.Length"); i++) {
				SummaryJobDetailResponse.SummaryJobDetail_ProgressSummaryDetail progressSummaryDetail = new SummaryJobDetailResponse.SummaryJobDetail_ProgressSummaryDetail();
				progressSummaryDetail.Key = _ctx.StringValue("SummaryJobDetail.ProgressSummaryDetails["+ i +"].Key");
				progressSummaryDetail.TotalCount = _ctx.LongValue("SummaryJobDetail.ProgressSummaryDetails["+ i +"].TotalCount");
				progressSummaryDetail.State = _ctx.IntegerValue("SummaryJobDetail.ProgressSummaryDetails["+ i +"].State");

				summaryJobDetailResponse_progressSummaryDetails.Add(progressSummaryDetail);
			}
			summaryJobDetailResponse.ProgressSummaryDetails = summaryJobDetailResponse_progressSummaryDetails;
        
			return summaryJobDetailResponse;
        }
    }
}
