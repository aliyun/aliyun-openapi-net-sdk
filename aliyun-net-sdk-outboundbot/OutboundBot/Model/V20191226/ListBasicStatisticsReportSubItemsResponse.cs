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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListBasicStatisticsReportSubItemsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems basicStatisticsReportSubItems;

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

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems BasicStatisticsReportSubItems
		{
			get
			{
				return basicStatisticsReportSubItems;
			}
			set	
			{
				basicStatisticsReportSubItems = value;
			}
		}

		public class ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem> list;

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem> List
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

			public class ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem
			{

				private string basicStatisticsReportSubItemName;

				private string _value;

				private int? count;

				private int? percentage;

				private List<ListBasicStatisticsReportSubItems_KeyValuePair> row;

				public string BasicStatisticsReportSubItemName
				{
					get
					{
						return basicStatisticsReportSubItemName;
					}
					set	
					{
						basicStatisticsReportSubItemName = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public int? Percentage
				{
					get
					{
						return percentage;
					}
					set	
					{
						percentage = value;
					}
				}

				public List<ListBasicStatisticsReportSubItems_KeyValuePair> Row
				{
					get
					{
						return row;
					}
					set	
					{
						row = value;
					}
				}

				public class ListBasicStatisticsReportSubItems_KeyValuePair
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
