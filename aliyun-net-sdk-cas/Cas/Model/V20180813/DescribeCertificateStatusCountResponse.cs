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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeCertificateStatusCountResponse : AcsResponse
	{

		private string requestId;

		private int? payed;

		private int? checking;

		private int? checkedFail;

		private int? issued;

		private int? revoked;

		private int? closed;

		private int? willExpired;

		private int? expired;

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

		public int? Payed
		{
			get
			{
				return payed;
			}
			set	
			{
				payed = value;
			}
		}

		public int? Checking
		{
			get
			{
				return checking;
			}
			set	
			{
				checking = value;
			}
		}

		public int? CheckedFail
		{
			get
			{
				return checkedFail;
			}
			set	
			{
				checkedFail = value;
			}
		}

		public int? Issued
		{
			get
			{
				return issued;
			}
			set	
			{
				issued = value;
			}
		}

		public int? Revoked
		{
			get
			{
				return revoked;
			}
			set	
			{
				revoked = value;
			}
		}

		public int? Closed
		{
			get
			{
				return closed;
			}
			set	
			{
				closed = value;
			}
		}

		public int? WillExpired
		{
			get
			{
				return willExpired;
			}
			set	
			{
				willExpired = value;
			}
		}

		public int? Expired
		{
			get
			{
				return expired;
			}
			set	
			{
				expired = value;
			}
		}
	}
}
