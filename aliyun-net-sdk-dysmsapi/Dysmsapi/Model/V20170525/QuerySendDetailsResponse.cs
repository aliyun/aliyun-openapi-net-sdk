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

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
	public class QuerySendDetailsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string totalCount;

		private List<QuerySendDetails_SmsSendDetailDTO> smsSendDetailDTOs;

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

		public string TotalCount
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

		public List<QuerySendDetails_SmsSendDetailDTO> SmsSendDetailDTOs
		{
			get
			{
				return smsSendDetailDTOs;
			}
			set	
			{
				smsSendDetailDTOs = value;
			}
		}

		public class QuerySendDetails_SmsSendDetailDTO
		{

			private string phoneNum;

			private long? sendStatus;

			private string errCode;

			private string templateCode;

			private string content;

			private string sendDate;

			private string receiveDate;

			private string outId;

			public string PhoneNum
			{
				get
				{
					return phoneNum;
				}
				set	
				{
					phoneNum = value;
				}
			}

			public long? SendStatus
			{
				get
				{
					return sendStatus;
				}
				set	
				{
					sendStatus = value;
				}
			}

			public string ErrCode
			{
				get
				{
					return errCode;
				}
				set	
				{
					errCode = value;
				}
			}

			public string TemplateCode
			{
				get
				{
					return templateCode;
				}
				set	
				{
					templateCode = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string SendDate
			{
				get
				{
					return sendDate;
				}
				set	
				{
					sendDate = value;
				}
			}

			public string ReceiveDate
			{
				get
				{
					return receiveDate;
				}
				set	
				{
					receiveDate = value;
				}
			}

			public string OutId
			{
				get
				{
					return outId;
				}
				set	
				{
					outId = value;
				}
			}
		}
	}
}
