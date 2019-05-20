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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTrademarkMonitorResultsResponseUnmarshaller
    {
        public static QueryTrademarkMonitorResultsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTrademarkMonitorResultsResponse queryTrademarkMonitorResultsResponse = new QueryTrademarkMonitorResultsResponse();

			queryTrademarkMonitorResultsResponse.HttpResponse = context.HttpResponse;
			queryTrademarkMonitorResultsResponse.RequestId = context.StringValue("QueryTrademarkMonitorResults.RequestId");
			queryTrademarkMonitorResultsResponse.TotalItemNum = context.IntegerValue("QueryTrademarkMonitorResults.TotalItemNum");
			queryTrademarkMonitorResultsResponse.CurrentPageNum = context.IntegerValue("QueryTrademarkMonitorResults.CurrentPageNum");
			queryTrademarkMonitorResultsResponse.PageSize = context.IntegerValue("QueryTrademarkMonitorResults.PageSize");
			queryTrademarkMonitorResultsResponse.TotalPageNum = context.IntegerValue("QueryTrademarkMonitorResults.TotalPageNum");
			queryTrademarkMonitorResultsResponse.PrePage = context.BooleanValue("QueryTrademarkMonitorResults.PrePage");
			queryTrademarkMonitorResultsResponse.NextPage = context.BooleanValue("QueryTrademarkMonitorResults.NextPage");

			List<QueryTrademarkMonitorResultsResponse.QueryTrademarkMonitorResults_TmMonitorResult> queryTrademarkMonitorResultsResponse_data = new List<QueryTrademarkMonitorResultsResponse.QueryTrademarkMonitorResults_TmMonitorResult>();
			for (int i = 0; i < context.Length("QueryTrademarkMonitorResults.Data.Length"); i++) {
				QueryTrademarkMonitorResultsResponse.QueryTrademarkMonitorResults_TmMonitorResult tmMonitorResult = new QueryTrademarkMonitorResultsResponse.QueryTrademarkMonitorResults_TmMonitorResult();
				tmMonitorResult.UserId = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].UserId");
				tmMonitorResult.RuleId = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].RuleId");
				tmMonitorResult.TmUid = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].TmUid");
				tmMonitorResult.DataCreateTime = context.LongValue("QueryTrademarkMonitorResults.Data["+ i +"].DataCreateTime");
				tmMonitorResult.DataUpdateTime = context.LongValue("QueryTrademarkMonitorResults.Data["+ i +"].DataUpdateTime");
				tmMonitorResult.TmName = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].TmName");
				tmMonitorResult.TmImage = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].TmImage");
				tmMonitorResult.Classification = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].Classification");
				tmMonitorResult.RegistrationNumber = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].RegistrationNumber");
				tmMonitorResult.TmProcedureStatusDesc = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].TmProcedureStatusDesc");
				tmMonitorResult.OwnerName = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].OwnerName");
				tmMonitorResult.OwnerEnName = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].OwnerEnName");
				tmMonitorResult.ApplyDate = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].ApplyDate");
				tmMonitorResult.XuzhanEndDate = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].XuzhanEndDate");
				tmMonitorResult.ChesanEndDate = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].ChesanEndDate");
				tmMonitorResult.WuxiaoEndDate = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].WuxiaoEndDate");
				tmMonitorResult.YiyiEndDate = context.StringValue("QueryTrademarkMonitorResults.Data["+ i +"].YiyiEndDate");

				queryTrademarkMonitorResultsResponse_data.Add(tmMonitorResult);
			}
			queryTrademarkMonitorResultsResponse.Data = queryTrademarkMonitorResultsResponse_data;
        
			return queryTrademarkMonitorResultsResponse;
        }
    }
}
