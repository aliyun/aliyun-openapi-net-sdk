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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class CheckDomainResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string avail;

		private string premium;

		private string reason;

		private long? price;

		private bool? dynamicCheck;

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

		public string Avail
		{
			get
			{
				return avail;
			}
			set	
			{
				avail = value;
			}
		}

		public string Premium
		{
			get
			{
				return premium;
			}
			set	
			{
				premium = value;
			}
		}

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
			}
		}

		public long? Price
		{
			get
			{
				return price;
			}
			set	
			{
				price = value;
			}
		}

		public bool? DynamicCheck
		{
			get
			{
				return dynamicCheck;
			}
			set	
			{
				dynamicCheck = value;
			}
		}
	}
}
