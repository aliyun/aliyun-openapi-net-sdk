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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class GetQuotaApplicationApprovalResponse : AcsResponse
	{

		private string requestId;

		private int? httpStatusCode;

		private string dynamicCode;

		private string dynamicMessage;

		private string errorMsg;

		private string errorCode;

		private bool? success;

		private bool? allowRetry;

		private List<string> errorArgs;

		private GetQuotaApplicationApproval_Module module;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public bool? AllowRetry
		{
			get
			{
				return allowRetry;
			}
			set	
			{
				allowRetry = value;
			}
		}

		public List<string> ErrorArgs
		{
			get
			{
				return errorArgs;
			}
			set	
			{
				errorArgs = value;
			}
		}

		public GetQuotaApplicationApproval_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class GetQuotaApplicationApproval_Module
		{

			private int? approvalHours;

			private bool? supportReminder;

			private string unsupportReminderReason;

			private int? reminderIntervalHours;

			public int? ApprovalHours
			{
				get
				{
					return approvalHours;
				}
				set	
				{
					approvalHours = value;
				}
			}

			public bool? SupportReminder
			{
				get
				{
					return supportReminder;
				}
				set	
				{
					supportReminder = value;
				}
			}

			public string UnsupportReminderReason
			{
				get
				{
					return unsupportReminderReason;
				}
				set	
				{
					unsupportReminderReason = value;
				}
			}

			public int? ReminderIntervalHours
			{
				get
				{
					return reminderIntervalHours;
				}
				set	
				{
					reminderIntervalHours = value;
				}
			}
		}
	}
}
