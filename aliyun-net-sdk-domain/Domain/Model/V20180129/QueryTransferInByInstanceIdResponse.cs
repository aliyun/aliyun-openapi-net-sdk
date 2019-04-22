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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryTransferInByInstanceIdResponse : AcsResponse
	{

		private string requestId;

		private string submissionDate;

		private string modificationDate;

		private string userId;

		private string instanceId;

		private string domainName;

		private int? status;

		private string simpleTransferInStatus;

		private string resultCode;

		private string resultDate;

		private string resultMsg;

		private string transferAuthorizationCodeSubmissionDate;

		private bool? needMailCheck;

		private string email;

		private bool? whoisMailStatus;

		private string expirationDate;

		private int? progressBarType;

		private long? submissionDateLong;

		private long? modificationDateLong;

		private long? resultDateLong;

		private long? expirationDateLong;

		private long? transferAuthorizationCodeSubmissionDateLong;

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

		public string SubmissionDate
		{
			get
			{
				return submissionDate;
			}
			set	
			{
				submissionDate = value;
			}
		}

		public string ModificationDate
		{
			get
			{
				return modificationDate;
			}
			set	
			{
				modificationDate = value;
			}
		}

		public string UserId
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
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

		public string SimpleTransferInStatus
		{
			get
			{
				return simpleTransferInStatus;
			}
			set	
			{
				simpleTransferInStatus = value;
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

		public string ResultDate
		{
			get
			{
				return resultDate;
			}
			set	
			{
				resultDate = value;
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

		public string TransferAuthorizationCodeSubmissionDate
		{
			get
			{
				return transferAuthorizationCodeSubmissionDate;
			}
			set	
			{
				transferAuthorizationCodeSubmissionDate = value;
			}
		}

		public bool? NeedMailCheck
		{
			get
			{
				return needMailCheck;
			}
			set	
			{
				needMailCheck = value;
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

		public bool? WhoisMailStatus
		{
			get
			{
				return whoisMailStatus;
			}
			set	
			{
				whoisMailStatus = value;
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

		public int? ProgressBarType
		{
			get
			{
				return progressBarType;
			}
			set	
			{
				progressBarType = value;
			}
		}

		public long? SubmissionDateLong
		{
			get
			{
				return submissionDateLong;
			}
			set	
			{
				submissionDateLong = value;
			}
		}

		public long? ModificationDateLong
		{
			get
			{
				return modificationDateLong;
			}
			set	
			{
				modificationDateLong = value;
			}
		}

		public long? ResultDateLong
		{
			get
			{
				return resultDateLong;
			}
			set	
			{
				resultDateLong = value;
			}
		}

		public long? ExpirationDateLong
		{
			get
			{
				return expirationDateLong;
			}
			set	
			{
				expirationDateLong = value;
			}
		}

		public long? TransferAuthorizationCodeSubmissionDateLong
		{
			get
			{
				return transferAuthorizationCodeSubmissionDateLong;
			}
			set	
			{
				transferAuthorizationCodeSubmissionDateLong = value;
			}
		}
	}
}
