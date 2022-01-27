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
	public class DescribeJobDataParsingTaskProgressResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeJobDataParsingTaskProgress_Progress progress;

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

		public DescribeJobDataParsingTaskProgress_Progress Progress
		{
			get
			{
				return progress;
			}
			set	
			{
				progress = value;
			}
		}

		public class DescribeJobDataParsingTaskProgress_Progress
		{

			private string failErrorCode;

			private string status;

			private int? handledJobCount;

			private int? totalJobCount;

			private string failReason;

			private string feedbackUrl;

			public string FailErrorCode
			{
				get
				{
					return failErrorCode;
				}
				set	
				{
					failErrorCode = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public int? HandledJobCount
			{
				get
				{
					return handledJobCount;
				}
				set	
				{
					handledJobCount = value;
				}
			}

			public int? TotalJobCount
			{
				get
				{
					return totalJobCount;
				}
				set	
				{
					totalJobCount = value;
				}
			}

			public string FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}

			public string FeedbackUrl
			{
				get
				{
					return feedbackUrl;
				}
				set	
				{
					feedbackUrl = value;
				}
			}
		}
	}
}
