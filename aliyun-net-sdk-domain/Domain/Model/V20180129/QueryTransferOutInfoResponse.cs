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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryTransferOutInfoResponse : AcsResponse
	{

		private string requestId;

		private int? status;

		private string email;

		private string transferAuthorizationCodeSendDate;

		private string expirationDate;

		private string pendingRequestDate;

		private string resultCode;

		private string resultMsg;

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

		public int? Status
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

		public string TransferAuthorizationCodeSendDate
		{
			get
			{
				return transferAuthorizationCodeSendDate;
			}
			set	
			{
				transferAuthorizationCodeSendDate = value;
			}
		}

		public string ExpirationDate
		{
			get
			{
				return expirationDate;
			}
			set	
			{
				expirationDate = value;
			}
		}

		public string PendingRequestDate
		{
			get
			{
				return pendingRequestDate;
			}
			set	
			{
				pendingRequestDate = value;
			}
		}

		public string ResultCode
		{
			get
			{
				return resultCode;
			}
			set	
			{
				resultCode = value;
			}
		}

		public string ResultMsg
		{
			get
			{
				return resultMsg;
			}
			set	
			{
				resultMsg = value;
			}
		}
	}
}