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
    public class QueryIntentionListResponseUnmarshaller
    {
        public static QueryIntentionListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryIntentionListResponse queryIntentionListResponse = new QueryIntentionListResponse();

			queryIntentionListResponse.HttpResponse = context.HttpResponse;
			queryIntentionListResponse.RequestId = context.StringValue("QueryIntentionList.RequestId");
			queryIntentionListResponse.TotalItemNum = context.IntegerValue("QueryIntentionList.TotalItemNum");
			queryIntentionListResponse.CurrentPageNum = context.IntegerValue("QueryIntentionList.CurrentPageNum");
			queryIntentionListResponse.PageSize = context.IntegerValue("QueryIntentionList.PageSize");
			queryIntentionListResponse.TotalPageNum = context.IntegerValue("QueryIntentionList.TotalPageNum");

			List<QueryIntentionListResponse.QueryIntentionList_Intention> queryIntentionListResponse_data = new List<QueryIntentionListResponse.QueryIntentionList_Intention>();
			for (int i = 0; i < context.Length("QueryIntentionList.Data.Length"); i++) {
				QueryIntentionListResponse.QueryIntentionList_Intention intention = new QueryIntentionListResponse.QueryIntentionList_Intention();
				intention.UserId = context.StringValue("QueryIntentionList.Data["+ i +"].UserId");
				intention.RegisterNumber = context.StringValue("QueryIntentionList.Data["+ i +"].RegisterNumber");
				intention.Classification = context.StringValue("QueryIntentionList.Data["+ i +"].Classification");
				intention.Type = context.IntegerValue("QueryIntentionList.Data["+ i +"].Type");
				intention.BizId = context.StringValue("QueryIntentionList.Data["+ i +"].BizId");
				intention.Description = context.StringValue("QueryIntentionList.Data["+ i +"].Description");
				intention.Status = context.IntegerValue("QueryIntentionList.Data["+ i +"].Status");
				intention.UpdateTime = context.LongValue("QueryIntentionList.Data["+ i +"].UpdateTime");
				intention.CreateTime = context.LongValue("QueryIntentionList.Data["+ i +"].CreateTime");
				intention.Area = context.IntegerValue("QueryIntentionList.Data["+ i +"].Area");

				queryIntentionListResponse_data.Add(intention);
			}
			queryIntentionListResponse.Data = queryIntentionListResponse_data;
        
			return queryIntentionListResponse;
        }
    }
}
