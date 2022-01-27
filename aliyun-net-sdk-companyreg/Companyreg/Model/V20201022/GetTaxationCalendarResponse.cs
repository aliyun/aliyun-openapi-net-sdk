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
	public class GetTaxationCalendarResponse : AcsResponse
	{

		private string requestId;

		private List<GetTaxationCalendar_CalendarListItem> calendarList;

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

		public List<GetTaxationCalendar_CalendarListItem> CalendarList
		{
			get
			{
				return calendarList;
			}
			set	
			{
				calendarList = value;
			}
		}

		public class GetTaxationCalendar_CalendarListItem
		{

			private string declareEndDate;

			private string declareProgress;

			private string declareStartDate;

			private string period;

			private string userTaxStartDate;

			private string userTaxEndDate;

			private string bookkeepingStartDate;

			private string bookkeepingEndDate;

			private bool? isCanBookkeeping;

			public string DeclareEndDate
			{
				get
				{
					return declareEndDate;
				}
				set	
				{
					declareEndDate = value;
				}
			}

			public string DeclareProgress
			{
				get
				{
					return declareProgress;
				}
				set	
				{
					declareProgress = value;
				}
			}

			public string DeclareStartDate
			{
				get
				{
					return declareStartDate;
				}
				set	
				{
					declareStartDate = value;
				}
			}

			public string Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string UserTaxStartDate
			{
				get
				{
					return userTaxStartDate;
				}
				set	
				{
					userTaxStartDate = value;
				}
			}

			public string UserTaxEndDate
			{
				get
				{
					return userTaxEndDate;
				}
				set	
				{
					userTaxEndDate = value;
				}
			}

			public string BookkeepingStartDate
			{
				get
				{
					return bookkeepingStartDate;
				}
				set	
				{
					bookkeepingStartDate = value;
				}
			}

			public string BookkeepingEndDate
			{
				get
				{
					return bookkeepingEndDate;
				}
				set	
				{
					bookkeepingEndDate = value;
				}
			}

			public bool? IsCanBookkeeping
			{
				get
				{
					return isCanBookkeeping;
				}
				set	
				{
					isCanBookkeeping = value;
				}
			}
		}
	}
}
