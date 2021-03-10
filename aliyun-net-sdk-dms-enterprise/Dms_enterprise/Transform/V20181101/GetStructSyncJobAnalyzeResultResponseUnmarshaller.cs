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
			getStructSyncJobAnalyzeResultResponse.ErrorCode = _ctx.StringValue("GetStructSyncJobAnalyzeResult.ErrorCode");
			getStructSyncJobAnalyzeResultResponse.ErrorMessage = _ctx.StringValue("GetStructSyncJobAnalyzeResult.ErrorMessage");
			getStructSyncJobAnalyzeResultResponse.Success = _ctx.BooleanValue("GetStructSyncJobAnalyzeResult.Success");

			GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult structSyncJobAnalyzeResult = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult();

			List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result> structSyncJobAnalyzeResult_resultList = new List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result>();
			for (int i = 0; i < _ctx.Length("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList.Length"); i++) {
				GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result result = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Result();
				result.SourceTableName = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].SourceTableName");
				result.Script = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].Script");
				result.TargetTableName = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.ResultList["+ i +"].TargetTableName");

				structSyncJobAnalyzeResult_resultList.Add(result);
			}
			structSyncJobAnalyzeResult.ResultList = structSyncJobAnalyzeResult_resultList;

			List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary> structSyncJobAnalyzeResult_summaryList = new List<GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary>();
			for (int i = 0; i < _ctx.Length("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList.Length"); i++) {
				GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary summary = new GetStructSyncJobAnalyzeResultResponse.GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult.GetStructSyncJobAnalyzeResult_Summary();
				summary.CompareType = _ctx.StringValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList["+ i +"].CompareType");
				summary.Count = _ctx.LongValue("GetStructSyncJobAnalyzeResult.StructSyncJobAnalyzeResult.SummaryList["+ i +"].Count");

				structSyncJobAnalyzeResult_summaryList.Add(summary);
			}
			structSyncJobAnalyzeResult.SummaryList = structSyncJobAnalyzeResult_summaryList;
			getStructSyncJobAnalyzeResultResponse.StructSyncJobAnalyzeResult = structSyncJobAnalyzeResult;
        
			return getStructSyncJobAnalyzeResultResponse;
        }
    }
}
