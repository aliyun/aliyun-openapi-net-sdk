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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryRelationListResponseUnmarshaller
    {
        public static QueryRelationListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRelationListResponse queryRelationListResponse = new QueryRelationListResponse();

			queryRelationListResponse.HttpResponse = _ctx.HttpResponse;
			queryRelationListResponse.Code = _ctx.StringValue("QueryRelationList.Code");
			queryRelationListResponse.RequestId = _ctx.StringValue("QueryRelationList.RequestId");
			queryRelationListResponse.Success = _ctx.BooleanValue("QueryRelationList.Success");
			queryRelationListResponse.Message = _ctx.StringValue("QueryRelationList.Message");

			QueryRelationListResponse.QueryRelationList_Data data = new QueryRelationListResponse.QueryRelationList_Data();
			data.PageNum = _ctx.IntegerValue("QueryRelationList.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryRelationList.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryRelationList.Data.TotalCount");

			List<QueryRelationListResponse.QueryRelationList_Data.QueryRelationList_FinancialRelationInfoListItem> data_financialRelationInfoList = new List<QueryRelationListResponse.QueryRelationList_Data.QueryRelationList_FinancialRelationInfoListItem>();
			for (int i = 0; i < _ctx.Length("QueryRelationList.Data.FinancialRelationInfoList.Length"); i++) {
				QueryRelationListResponse.QueryRelationList_Data.QueryRelationList_FinancialRelationInfoListItem financialRelationInfoListItem = new QueryRelationListResponse.QueryRelationList_Data.QueryRelationList_FinancialRelationInfoListItem();
				financialRelationInfoListItem.RelationId = _ctx.LongValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].RelationId");
				financialRelationInfoListItem.AccountType = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].AccountType");
				financialRelationInfoListItem.AccountId = _ctx.LongValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].AccountId");
				financialRelationInfoListItem.AccountName = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].AccountName");
				financialRelationInfoListItem.AccountNickName = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].AccountNickName");
				financialRelationInfoListItem.RelationType = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].RelationType");
				financialRelationInfoListItem.State = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].State");
				financialRelationInfoListItem.SetupTime = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].SetupTime");
				financialRelationInfoListItem.StartTime = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].StartTime");
				financialRelationInfoListItem.EndTime = _ctx.StringValue("QueryRelationList.Data.FinancialRelationInfoList["+ i +"].EndTime");

				data_financialRelationInfoList.Add(financialRelationInfoListItem);
			}
			data.FinancialRelationInfoList = data_financialRelationInfoList;
			queryRelationListResponse.Data = data;
        
			return queryRelationListResponse;
        }
    }
}
