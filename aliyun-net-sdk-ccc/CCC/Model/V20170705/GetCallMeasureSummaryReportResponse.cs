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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetCallMeasureSummaryReportResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GetCallMeasureSummaryReport_SummaryReport summaryReport;

		private GetCallMeasureSummaryReport_NumberReports numberReports;

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

		public GetCallMeasureSummaryReport_SummaryReport SummaryReport
		{
			get
			{
				return summaryReport;
			}
			set	
			{
				summaryReport = value;
			}
		}

		public GetCallMeasureSummaryReport_NumberReports NumberReports
		{
			get
			{
				return numberReports;
			}
			set	
			{
				numberReports = value;
			}
		}

		public class GetCallMeasureSummaryReport_SummaryReport
		{

			private int? year;

			private int? month;

			private int? day;

			private long? inboundCount;

			private long? outboundCount;

			private long? outboundDurationByMinute;

			private long? inboundDurationByMinute;

			public int? Year
			{
				get
				{
					return year;
				}
				set	
				{
					year = value;
				}
			}

			public int? Month
			{
				get
				{
					return month;
				}
				set	
				{
					month = value;
				}
			}

			public int? Day
			{
				get
				{
					return day;
				}
				set	
				{
					day = value;
				}
			}

			public long? InboundCount
			{
				get
				{
					return inboundCount;
				}
				set	
				{
					inboundCount = value;
				}
			}

			public long? OutboundCount
			{
				get
				{
					return outboundCount;
				}
				set	
				{
					outboundCount = value;
				}
			}

			public long? OutboundDurationByMinute
			{
				get
				{
					return outboundDurationByMinute;
				}
				set	
				{
					outboundDurationByMinute = value;
				}
			}

			public long? InboundDurationByMinute
			{
				get
				{
					return inboundDurationByMinute;
				}
				set	
				{
					inboundDurationByMinute = value;
				}
			}
		}

		public class GetCallMeasureSummaryReport_NumberReports
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<GetCallMeasureSummaryReport_NumberReport> list;

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

			public List<GetCallMeasureSummaryReport_NumberReport> List
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

			public class GetCallMeasureSummaryReport_NumberReport
			{

				private string number;

				private int? year;

				private int? month;

				private int? day;

				private long? inboundCount;

				private long? outboundCount;

				private long? outboundDurationByMinute;

				private long? inboundDurationByMinute;

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public int? Year
				{
					get
					{
						return year;
					}
					set	
					{
						year = value;
					}
				}

				public int? Month
				{
					get
					{
						return month;
					}
					set	
					{
						month = value;
					}
				}

				public int? Day
				{
					get
					{
						return day;
					}
					set	
					{
						day = value;
					}
				}

				public long? InboundCount
				{
					get
					{
						return inboundCount;
					}
					set	
					{
						inboundCount = value;
					}
				}

				public long? OutboundCount
				{
					get
					{
						return outboundCount;
					}
					set	
					{
						outboundCount = value;
					}
				}

				public long? OutboundDurationByMinute
				{
					get
					{
						return outboundDurationByMinute;
					}
					set	
					{
						outboundDurationByMinute = value;
					}
				}

				public long? InboundDurationByMinute
				{
					get
					{
						return inboundDurationByMinute;
					}
					set	
					{
						inboundDurationByMinute = value;
					}
				}
			}
		}
	}
}
