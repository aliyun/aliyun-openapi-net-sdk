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

namespace Aliyun.Acs.AppMallsService.Model.V20180224
{
	public class TaobaoFilmIssueOrderResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private string message;

		private string status;

		private string tbOrderId;

		private string ticketContents;

		private string logsId;

		private string requestId;

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

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMsg
		{
			get
			{
				return subMsg;
			}
			set	
			{
				subMsg = value;
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

		public string TbOrderId
		{
			get
			{
				return tbOrderId;
			}
			set	
			{
				tbOrderId = value;
			}
		}

		public string TicketContents
		{
			get
			{
				return ticketContents;
			}
			set	
			{
				ticketContents = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
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
	}
}
