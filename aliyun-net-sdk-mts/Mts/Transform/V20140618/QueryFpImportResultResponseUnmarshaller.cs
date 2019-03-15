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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryFpImportResultResponseUnmarshaller
    {
        public static QueryFpImportResultResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFpImportResultResponse queryFpImportResultResponse = new QueryFpImportResultResponse();

			queryFpImportResultResponse.HttpResponse = context.HttpResponse;
			queryFpImportResultResponse.RequestId = context.StringValue("QueryFpImportResult.RequestId");
			queryFpImportResultResponse.LogCount = context.LongValue("QueryFpImportResult.LogCount");

			QueryFpImportResultResponse.QueryFpImportResult_PageInfo pageInfo = new QueryFpImportResultResponse.QueryFpImportResult_PageInfo();
			pageInfo.PageIndex = context.LongValue("QueryFpImportResult.PageInfo.PageIndex");
			pageInfo.PageSize = context.LongValue("QueryFpImportResult.PageInfo.PageSize");
			pageInfo.Total = context.LongValue("QueryFpImportResult.PageInfo.Total");
			queryFpImportResultResponse.PageInfo = pageInfo;

			List<QueryFpImportResultResponse.QueryFpImportResult_FpResultLogInfo> queryFpImportResultResponse_fpResultLogInfoList = new List<QueryFpImportResultResponse.QueryFpImportResult_FpResultLogInfo>();
			for (int i = 0; i < context.Length("QueryFpImportResult.FpResultLogInfoList.Length"); i++) {
				QueryFpImportResultResponse.QueryFpImportResult_FpResultLogInfo fpResultLogInfo = new QueryFpImportResultResponse.QueryFpImportResult_FpResultLogInfo();
				fpResultLogInfo.LogPath = context.StringValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].LogPath");
				fpResultLogInfo.LogName = context.StringValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].LogName");
				fpResultLogInfo.LogStartTime = context.LongValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].LogStartTime");
				fpResultLogInfo.LogEndTime = context.LongValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].LogEndTime");
				fpResultLogInfo.LogSize = context.LongValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].LogSize");
				fpResultLogInfo.CreateTime = context.LongValue("QueryFpImportResult.FpResultLogInfoList["+ i +"].CreateTime");

				queryFpImportResultResponse_fpResultLogInfoList.Add(fpResultLogInfo);
			}
			queryFpImportResultResponse.FpResultLogInfoList = queryFpImportResultResponse_fpResultLogInfoList;
        
			return queryFpImportResultResponse;
        }
    }
}
