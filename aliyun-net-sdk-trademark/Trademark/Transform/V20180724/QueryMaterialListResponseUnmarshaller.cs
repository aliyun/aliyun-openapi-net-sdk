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
    public class QueryMaterialListResponseUnmarshaller
    {
        public static QueryMaterialListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMaterialListResponse queryMaterialListResponse = new QueryMaterialListResponse();

			queryMaterialListResponse.HttpResponse = context.HttpResponse;
			queryMaterialListResponse.RequestId = context.StringValue("QueryMaterialList.RequestId");
			queryMaterialListResponse.TotalItemNum = context.IntegerValue("QueryMaterialList.TotalItemNum");
			queryMaterialListResponse.CurrentPageNum = context.IntegerValue("QueryMaterialList.CurrentPageNum");
			queryMaterialListResponse.PageSize = context.IntegerValue("QueryMaterialList.PageSize");
			queryMaterialListResponse.TotalPageNum = context.IntegerValue("QueryMaterialList.TotalPageNum");

			List<QueryMaterialListResponse.QueryMaterialList_Trademark> queryMaterialListResponse_data = new List<QueryMaterialListResponse.QueryMaterialList_Trademark>();
			for (int i = 0; i < context.Length("QueryMaterialList.Data.Length"); i++) {
				QueryMaterialListResponse.QueryMaterialList_Trademark trademark = new QueryMaterialListResponse.QueryMaterialList_Trademark();
				trademark.Id = context.LongValue("QueryMaterialList.Data["+ i +"].Id");
				trademark.Name = context.StringValue("QueryMaterialList.Data["+ i +"].Name");
				trademark.Type = context.IntegerValue("QueryMaterialList.Data["+ i +"].Type");
				trademark.Region = context.IntegerValue("QueryMaterialList.Data["+ i +"].Region");
				trademark.ContactName = context.StringValue("QueryMaterialList.Data["+ i +"].ContactName");
				trademark.Status = context.IntegerValue("QueryMaterialList.Data["+ i +"].Status");
				trademark.LoaKey = context.StringValue("QueryMaterialList.Data["+ i +"].LoaKey");
				trademark.LoaStatus = context.IntegerValue("QueryMaterialList.Data["+ i +"].LoaStatus");
				trademark.CardNumber = context.StringValue("QueryMaterialList.Data["+ i +"].CardNumber");
				trademark.ValidDate = context.LongValue("QueryMaterialList.Data["+ i +"].ValidDate");
				trademark.PrincipalName = context.IntegerValue("QueryMaterialList.Data["+ i +"].PrincipalName");

				queryMaterialListResponse_data.Add(trademark);
			}
			queryMaterialListResponse.Data = queryMaterialListResponse_data;
        
			return queryMaterialListResponse;
        }
    }
}
