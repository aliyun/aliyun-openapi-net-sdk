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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeInvitationCodeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string dynamicCode;

		private string dynamicMessage;

		private DescribeInvitationCode_Result result;

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

		public int? ErrorCode
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

		public DescribeInvitationCode_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeInvitationCode_Result
		{

			private int? id;

			private string code;

			private string sendTime;

			private long? senderId;

			private string senderBid;

			private string consortiumId;

			private string senderName;

			private bool? accepted;

			private string expireTime;

			private string email;

			private string url;

			public int? Id
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

			public string SendTime
			{
				get
				{
					return sendTime;
				}
				set	
				{
					sendTime = value;
				}
			}

			public long? SenderId
			{
				get
				{
					return senderId;
				}
				set	
				{
					senderId = value;
				}
			}

			public string SenderBid
			{
				get
				{
					return senderBid;
				}
				set	
				{
					senderBid = value;
				}
			}

			public string ConsortiumId
			{
				get
				{
					return consortiumId;
				}
				set	
				{
					consortiumId = value;
				}
			}

			public string SenderName
			{
				get
				{
					return senderName;
				}
				set	
				{
					senderName = value;
				}
			}

			public bool? Accepted
			{
				get
				{
					return accepted;
				}
				set	
				{
					accepted = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}
		}
	}
}