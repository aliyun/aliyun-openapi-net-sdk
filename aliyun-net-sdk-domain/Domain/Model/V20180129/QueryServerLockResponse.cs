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
	public class QueryServerLockResponse : AcsResponse
	{

		private string requestId;

		private string gmtCreate;

		private string gmtModified;

		private string userId;

		private string domainName;

		private string domainInstanceId;

		private string lockProductId;

		private string startDate;

		private string expireDate;

		private string lockInstanceId;

		private int? serverLockStatus;

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

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
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

		public string DomainInstanceId
		{
			get
			{
				return domainInstanceId;
			}
			set	
			{
				domainInstanceId = value;
			}
		}

		public string LockProductId
		{
			get
			{
				return lockProductId;
			}
			set	
			{
				lockProductId = value;
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
			}
		}

		public string ExpireDate
		{
			get
			{
				return expireDate;
			}
			set	
			{
				expireDate = value;
			}
		}

		public string LockInstanceId
		{
			get
			{
				return lockInstanceId;
			}
			set	
			{
				lockInstanceId = value;
			}
		}

		public int? ServerLockStatus
		{
			get
			{
				return serverLockStatus;
			}
			set	
			{
				serverLockStatus = value;
			}
		}
	}
}