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

namespace Aliyun.Acs.Workorder.Model.V20200326
{
	public class ListTicketsResponse : AcsResponse
	{

		private int? code;

		private bool? success;

		private string message;

		private string requestId;

		private ListTickets_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public ListTickets_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListTickets_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<ListTickets_ListItem> list;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public List<ListTickets_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListTickets_ListItem
			{

				private int? addTime;

				private string ticketStatus;

				private string creatorId;

				private string id;

				private string title;

				public int? AddTime
				{
					get
					{
						return addTime;
					}
					set	
					{
						addTime = value;
					}
				}

				public string TicketStatus
				{
					get
					{
						return ticketStatus;
					}
					set	
					{
						ticketStatus = value;
					}
				}

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}
			}
		}
	}
}
