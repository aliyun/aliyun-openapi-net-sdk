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
	public class GenerateBasicStatisticsReportResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GenerateBasicStatisticsReport_BasicStatisticsReport basicStatisticsReport;

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

		public GenerateBasicStatisticsReport_BasicStatisticsReport BasicStatisticsReport
		{
			get
			{
				return basicStatisticsReport;
			}
			set	
			{
				basicStatisticsReport = value;
			}
		}

		public class GenerateBasicStatisticsReport_BasicStatisticsReport
		{

			private List<GenerateBasicStatisticsReport_BasicStatisticsReportItem> items;

			public List<GenerateBasicStatisticsReport_BasicStatisticsReportItem> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class GenerateBasicStatisticsReport_BasicStatisticsReportItem
			{

				private string title;

				private int? totalCount;

				private string graphType;

				private List<GenerateBasicStatisticsReport_BasicStatisticsReportSubItem> subItems;

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

				public string GraphType
				{
					get
					{
						return graphType;
					}
					set	
					{
						graphType = value;
					}
				}

				public List<GenerateBasicStatisticsReport_BasicStatisticsReportSubItem> SubItems
				{
					get
					{
						return subItems;
					}
					set	
					{
						subItems = value;
					}
				}

				public class GenerateBasicStatisticsReport_BasicStatisticsReportSubItem
				{

					private string basicStatisticsReportSubItemName;

					private string _value;

					private int? count;

					private int? percentage;

					private List<GenerateBasicStatisticsReport_KeyValuePair> details;

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

					public List<GenerateBasicStatisticsReport_KeyValuePair> Details
					{
						get
						{
							return details;
						}
						set	
						{
							details = value;
						}
					}

					public class GenerateBasicStatisticsReport_KeyValuePair
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
}
