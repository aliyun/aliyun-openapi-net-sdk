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
    public class ListBookkeepingSubjectBalancesResponseUnmarshaller
    {
        public static ListBookkeepingSubjectBalancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBookkeepingSubjectBalancesResponse listBookkeepingSubjectBalancesResponse = new ListBookkeepingSubjectBalancesResponse();

			listBookkeepingSubjectBalancesResponse.HttpResponse = _ctx.HttpResponse;
			listBookkeepingSubjectBalancesResponse.RequestId = _ctx.StringValue("ListBookkeepingSubjectBalances.RequestId");
			listBookkeepingSubjectBalancesResponse.TotalCount = _ctx.IntegerValue("ListBookkeepingSubjectBalances.TotalCount");
			listBookkeepingSubjectBalancesResponse.PageSize = _ctx.IntegerValue("ListBookkeepingSubjectBalances.PageSize");
			listBookkeepingSubjectBalancesResponse.PageNumber = _ctx.IntegerValue("ListBookkeepingSubjectBalances.PageNumber");
			listBookkeepingSubjectBalancesResponse.Success = _ctx.BooleanValue("ListBookkeepingSubjectBalances.Success");
			listBookkeepingSubjectBalancesResponse.ErrorMsg = _ctx.StringValue("ListBookkeepingSubjectBalances.ErrorMsg");

			List<ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem> listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances = new List<ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem>();
			for (int i = 0; i < _ctx.Length("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances.Length"); i++) {
				ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem bookkeepingSubjectBalancesItem = new ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem();
				bookkeepingSubjectBalancesItem.BizId = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].BizId");
				bookkeepingSubjectBalancesItem.ParentBizId = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].ParentBizId");
				bookkeepingSubjectBalancesItem.ParentSubjectCode = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].ParentSubjectCode");
				bookkeepingSubjectBalancesItem.SubjectCode = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectCode");
				bookkeepingSubjectBalancesItem.SubjectName = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectName");
				bookkeepingSubjectBalancesItem.StartDebitValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].StartDebitValue");
				bookkeepingSubjectBalancesItem.StartCreditValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].StartCreditValue");
				bookkeepingSubjectBalancesItem.CurrentDebitValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].CurrentDebitValue");
				bookkeepingSubjectBalancesItem.CurrentCreditValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].CurrentCreditValue");
				bookkeepingSubjectBalancesItem.EndDebitValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].EndDebitValue");
				bookkeepingSubjectBalancesItem.EndCreditValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].EndCreditValue");
				bookkeepingSubjectBalancesItem.YearDebitValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].YearDebitValue");
				bookkeepingSubjectBalancesItem.YearCreditValue = _ctx.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].YearCreditValue");
				bookkeepingSubjectBalancesItem.SubjectLevel = _ctx.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectLevel");

				listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances.Add(bookkeepingSubjectBalancesItem);
			}
			listBookkeepingSubjectBalancesResponse.BookkeepingSubjectBalances = listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances;
        
			return listBookkeepingSubjectBalancesResponse;
        }
    }
}
