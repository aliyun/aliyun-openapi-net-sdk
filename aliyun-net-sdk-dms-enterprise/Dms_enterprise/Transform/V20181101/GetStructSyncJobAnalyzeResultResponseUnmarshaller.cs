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
    public class GetStructSyncJobAnalyzeResultResponseUnmarshaller
    {
        public static GetStructSyncJobAnalyzeResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStructSyncJobAnalyzeResultResponse getStructSyncJobAnalyzeResultResponse = new GetStructSyncJobAnalyzeResultResponse();

			getStructSyncJobAnalyzeResultResponse.HttpResponse = _ctx.HttpResponse;
			getStructSyncJobAnalyzeResultResponse.RequestId = _ctx.StringValue("GetStructSyncJobAnalyzeResult.RequestId");
			getStructSyncJobAnalyzeResultResponse.Success = _ctx.BooleanValue("GetStructSyncJobAnalyzeResult.Success");
			getStructSyncJobAnalyzeResultResponse.ErrorMessage = _ctx.StringValue("GetStructSyncJobAnalyzeResult.ErrorMessage");
			getStructSyncJobAnalyzeResultResponse.ErrorCode = _ctx.StringValue("GetStructSyncJobAnalyzeResult.ErrorCode");

			GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult structSyncJobAnalyzeResult = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult();

			List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary> structSyncJobAnalyzeResult_summaryList = new List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary>();
			for (int i = 0; i < _ctx.Length("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList.Length"); i++) {
				GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary summary = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary();
				summary.CompareType = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList["+ i +"].CompareType");
				summary.Count = _ctx.LongValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList["+ i +"].Count");

				structSyncJobAnalyzeResult_summaryList.Add(summary);
			}
			structSyncJobAnalyzeResult.SummaryList = structSyncJobAnalyzeResult_summaryList;

			List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result> structSyncJobAnalyzeResult_resultList = new List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result>();
			for (int i = 0; i < _ctx.Length("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList.Length"); i++) {
				GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result result = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result();
				result.SourceTableName = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].SourceTableName");
				result.TargetTableName = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].TargetTableName");
				result.Script = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].Script");

				structSyncJobAnalyzeResult_resultList.Add(result);
			}
			structSyncJobAnalyzeResult.ResultList = structSyncJobAnalyzeResult_resultList;
			getStructSyncJobAnalyzeResultResponse.StructSyncJobAnalyzeResult = structSyncJobAnalyzeResult;
        
			return getStructSyncJobAnalyzeResultResponse;
        }
    }
}
