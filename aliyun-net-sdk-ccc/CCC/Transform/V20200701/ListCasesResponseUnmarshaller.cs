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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListCasesResponseUnmarshaller
    {
        public static ListCasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCasesResponse listCasesResponse = new ListCasesResponse();

			listCasesResponse.HttpResponse = _ctx.HttpResponse;
			listCasesResponse.RequestId = _ctx.StringValue("ListCases.RequestId");
			listCasesResponse.Message = _ctx.StringValue("ListCases.Message");
			listCasesResponse.HttpStatusCode = _ctx.LongValue("ListCases.HttpStatusCode");
			listCasesResponse.Code = _ctx.StringValue("ListCases.Code");
			listCasesResponse.Success = _ctx.BooleanValue("ListCases.Success");

			ListCasesResponse.ListCases_Data data = new ListCasesResponse.ListCases_Data();
			data.PageNumber = _ctx.LongValue("ListCases.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListCases.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListCases.Data.TotalCount");

			List<ListCasesResponse.ListCases_Data.ListCases_ListItem> data_list = new List<ListCasesResponse.ListCases_Data.ListCases_ListItem>();
			for (int i = 0; i < _ctx.Length("ListCases.Data.List.Length"); i++) {
				ListCasesResponse.ListCases_Data.ListCases_ListItem listItem = new ListCasesResponse.ListCases_Data.ListCases_ListItem();
				listItem.AbandonType = _ctx.StringValue("ListCases.Data.List["+ i +"].AbandonType");
				listItem.AttemptCount = _ctx.LongValue("ListCases.Data.List["+ i +"].AttemptCount");
				listItem.ExpandInfo = _ctx.StringValue("ListCases.Data.List["+ i +"].ExpandInfo");
				listItem.FailureReason = _ctx.StringValue("ListCases.Data.List["+ i +"].FailureReason");
				listItem.PhoneNumber = _ctx.StringValue("ListCases.Data.List["+ i +"].PhoneNumber");
				listItem.State = _ctx.StringValue("ListCases.Data.List["+ i +"].State");
				listItem.CaseId = _ctx.StringValue("ListCases.Data.List["+ i +"].CaseId");
				listItem.CustomVariables = _ctx.StringValue("ListCases.Data.List["+ i +"].CustomVariables");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listCasesResponse.Data = data;
        
			return listCasesResponse;
        }
    }
}
