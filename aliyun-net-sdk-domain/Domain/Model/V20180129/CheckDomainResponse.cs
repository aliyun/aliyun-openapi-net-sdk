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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class CheckDomainResponse : AcsResponse
	{

		private string requestId;

		private string avail;

		private long? price;

		private string domainName;

		private string premium;

		private bool? dynamicCheck;

		private string reason;

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
	}
}
