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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class ListCashJournalResponse : AcsResponse
	{

		private string requestId;

		private List<ListCashJournal_CashJournalListItem> cashJournalList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListCashJournal_CashJournalListItem> CashJournalList
		{
			get
			{
				return cashJournalList;
			}
			set	
			{
				cashJournalList = value;
			}
		}

		public class ListCashJournal_CashJournalListItem
		{

			private string bankName;

			private string incomeAmount;

			private string expendAmount;

			public string BankName
			{
				get
				{
					return bankName;
				}
				set	
				{
					bankName = value;
				}
			}

			public string IncomeAmount
			{
				get
				{
					return incomeAmount;
				}
				set	
				{
					incomeAmount = value;
				}
			}

			public string ExpendAmount
			{
				get
				{
					return expendAmount;
				}
				set	
				{
					expendAmount = value;
				}
			}
		}
	}
}
