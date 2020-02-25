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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetOpLogResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<GetOpLog_OpLogDetail> opLogDetails;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public long? TotalCount
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

		public List<GetOpLog_OpLogDetail> OpLogDetails
		{
			get
			{
				return opLogDetails;
			}
			set	
			{
				opLogDetails = value;
			}
		}

		public class GetOpLog_OpLogDetail
		{

			private long? userId;

			private string userNick;

			private string module;

			private string opContent;

			private string opTime;

			private string database;

			private long? orderId;

			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserNick
			{
				get
				{
					return userNick;
				}
				set	
				{
					userNick = value;
				}
			}

			public string Module
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

			public string OpContent
			{
				get
				{
					return opContent;
				}
				set	
				{
					opContent = value;
				}
			}

			public string OpTime
			{
				get
				{
					return opTime;
				}
				set	
				{
					opTime = value;
				}
			}

			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			public long? OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}
		}
	}
}
