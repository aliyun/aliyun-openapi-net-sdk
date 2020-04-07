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
        public static ListBookkeepingSubjectBalancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListBookkeepingSubjectBalancesResponse listBookkeepingSubjectBalancesResponse = new ListBookkeepingSubjectBalancesResponse();

			listBookkeepingSubjectBalancesResponse.HttpResponse = context.HttpResponse;
			listBookkeepingSubjectBalancesResponse.RequestId = context.StringValue("ListBookkeepingSubjectBalances.RequestId");
			listBookkeepingSubjectBalancesResponse.TotalCount = context.IntegerValue("ListBookkeepingSubjectBalances.TotalCount");
			listBookkeepingSubjectBalancesResponse.PageSize = context.IntegerValue("ListBookkeepingSubjectBalances.PageSize");
			listBookkeepingSubjectBalancesResponse.PageNumber = context.IntegerValue("ListBookkeepingSubjectBalances.PageNumber");
			listBookkeepingSubjectBalancesResponse.Success = context.BooleanValue("ListBookkeepingSubjectBalances.Success");
			listBookkeepingSubjectBalancesResponse.ErrorMsg = context.StringValue("ListBookkeepingSubjectBalances.ErrorMsg");

			List<ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem> listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances = new List<ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem>();
			for (int i = 0; i < context.Length("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances.Length"); i++) {
				ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem bookkeepingSubjectBalancesItem = new ListBookkeepingSubjectBalancesResponse.ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem();
				bookkeepingSubjectBalancesItem.BizId = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].BizId");
				bookkeepingSubjectBalancesItem.ParentBizId = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].ParentBizId");
				bookkeepingSubjectBalancesItem.ParentSubjectCode = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].ParentSubjectCode");
				bookkeepingSubjectBalancesItem.SubjectCode = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectCode");
				bookkeepingSubjectBalancesItem.SubjectName = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectName");
				bookkeepingSubjectBalancesItem.StartDebitValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].StartDebitValue");
				bookkeepingSubjectBalancesItem.StartCreditValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].StartCreditValue");
				bookkeepingSubjectBalancesItem.CurrentDebitValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].CurrentDebitValue");
				bookkeepingSubjectBalancesItem.CurrentCreditValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].CurrentCreditValue");
				bookkeepingSubjectBalancesItem.EndDebitValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].EndDebitValue");
				bookkeepingSubjectBalancesItem.EndCreditValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].EndCreditValue");
				bookkeepingSubjectBalancesItem.YearDebitValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].YearDebitValue");
				bookkeepingSubjectBalancesItem.YearCreditValue = context.FloatValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].YearCreditValue");
				bookkeepingSubjectBalancesItem.SubjectLevel = context.StringValue("ListBookkeepingSubjectBalances.BookkeepingSubjectBalances["+ i +"].SubjectLevel");

				listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances.Add(bookkeepingSubjectBalancesItem);
			}
			listBookkeepingSubjectBalancesResponse.BookkeepingSubjectBalances = listBookkeepingSubjectBalancesResponse_bookkeepingSubjectBalances;
        
			return listBookkeepingSubjectBalancesResponse;
        }
    }
}
