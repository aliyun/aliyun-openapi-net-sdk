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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSignedEventActionsResponse : AcsResponse
	{

		private string requestId;

		private int? nextPageEventId;

		private int? pageRecordCount;

		private bool? fromBegin;

		private bool? toEnd;

		private List<DescribeSignedEventActions_EventItemsItem> eventItems;

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

		public int? NextPageEventId
		{
			get
			{
				return nextPageEventId;
			}
			set	
			{
				nextPageEventId = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public bool? FromBegin
		{
			get
			{
				return fromBegin;
			}
			set	
			{
				fromBegin = value;
			}
		}

		public bool? ToEnd
		{
			get
			{
				return toEnd;
			}
			set	
			{
				toEnd = value;
			}
		}

		public List<DescribeSignedEventActions_EventItemsItem> EventItems
		{
			get
			{
				return eventItems;
			}
			set	
			{
				eventItems = value;
			}
		}

		public class DescribeSignedEventActions_EventItemsItem
		{

			private int? eventId;

			private string eventContent;

			private string eventSig;

			private string eventRcpt;

			public int? EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
				}
			}

			public string EventContent
			{
				get
				{
					return eventContent;
				}
				set	
				{
					eventContent = value;
				}
			}

			public string EventSig
			{
				get
				{
					return eventSig;
				}
				set	
				{
					eventSig = value;
				}
			}

			public string EventRcpt
			{
				get
				{
					return eventRcpt;
				}
				set	
				{
					eventRcpt = value;
				}
			}
		}
	}
}
