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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class ListCashJournalResponseUnmarshaller
    {
        public static ListCashJournalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCashJournalResponse listCashJournalResponse = new ListCashJournalResponse();

			listCashJournalResponse.HttpResponse = _ctx.HttpResponse;
			listCashJournalResponse.RequestId = _ctx.StringValue("ListCashJournal.RequestId");

			List<ListCashJournalResponse.ListCashJournal_CashJournalListItem> listCashJournalResponse_cashJournalList = new List<ListCashJournalResponse.ListCashJournal_CashJournalListItem>();
			for (int i = 0; i < _ctx.Length("ListCashJournal.CashJournalList.Length"); i++) {
				ListCashJournalResponse.ListCashJournal_CashJournalListItem cashJournalListItem = new ListCashJournalResponse.ListCashJournal_CashJournalListItem();
				cashJournalListItem.BankName = _ctx.StringValue("ListCashJournal.CashJournalList["+ i +"].BankName");
				cashJournalListItem.IncomeAmount = _ctx.StringValue("ListCashJournal.CashJournalList["+ i +"].IncomeAmount");
				cashJournalListItem.ExpendAmount = _ctx.StringValue("ListCashJournal.CashJournalList["+ i +"].ExpendAmount");

				listCashJournalResponse_cashJournalList.Add(cashJournalListItem);
			}
			listCashJournalResponse.CashJournalList = listCashJournalResponse_cashJournalList;
        
			return listCashJournalResponse;
        }
    }
}
