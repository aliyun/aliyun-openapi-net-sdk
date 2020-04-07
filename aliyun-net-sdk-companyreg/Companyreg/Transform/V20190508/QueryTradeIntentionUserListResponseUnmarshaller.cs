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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class QueryTradeIntentionUserListResponseUnmarshaller
    {
        public static QueryTradeIntentionUserListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeIntentionUserListResponse queryTradeIntentionUserListResponse = new QueryTradeIntentionUserListResponse();

			queryTradeIntentionUserListResponse.HttpResponse = context.HttpResponse;
			queryTradeIntentionUserListResponse.RequestId = context.StringValue("QueryTradeIntentionUserList.RequestId");
			queryTradeIntentionUserListResponse.TotalItemNum = context.IntegerValue("QueryTradeIntentionUserList.TotalItemNum");
			queryTradeIntentionUserListResponse.CurrentPageNum = context.IntegerValue("QueryTradeIntentionUserList.CurrentPageNum");
			queryTradeIntentionUserListResponse.PageSize = context.IntegerValue("QueryTradeIntentionUserList.PageSize");
			queryTradeIntentionUserListResponse.TotalPageNum = context.IntegerValue("QueryTradeIntentionUserList.TotalPageNum");

			List<QueryTradeIntentionUserListResponse.QueryTradeIntentionUserList_Trademark> queryTradeIntentionUserListResponse_data = new List<QueryTradeIntentionUserListResponse.QueryTradeIntentionUserList_Trademark>();
			for (int i = 0; i < context.Length("QueryTradeIntentionUserList.Data.Length"); i++) {
				QueryTradeIntentionUserListResponse.QueryTradeIntentionUserList_Trademark trademark = new QueryTradeIntentionUserListResponse.QueryTradeIntentionUserList_Trademark();
				trademark.RegisterNumber = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].RegisterNumber");
				trademark.Classification = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].Classification");
				trademark.Mobile = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].Mobile");
				trademark.UserName = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].UserName");
				trademark.BizId = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].BizId");
				trademark.Description = context.StringValue("QueryTradeIntentionUserList.Data["+ i +"].Description");
				trademark.Status = context.IntegerValue("QueryTradeIntentionUserList.Data["+ i +"].Status");
				trademark.Area = context.IntegerValue("QueryTradeIntentionUserList.Data["+ i +"].Area");
				trademark.Type = context.IntegerValue("QueryTradeIntentionUserList.Data["+ i +"].Type");
				trademark.CreateTime = context.LongValue("QueryTradeIntentionUserList.Data["+ i +"].CreateTime");
				trademark.UpdateTime = context.LongValue("QueryTradeIntentionUserList.Data["+ i +"].UpdateTime");

				queryTradeIntentionUserListResponse_data.Add(trademark);
			}
			queryTradeIntentionUserListResponse.Data = queryTradeIntentionUserListResponse_data;
        
			return queryTradeIntentionUserListResponse;
        }
    }
}
