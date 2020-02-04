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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainDnssecInfoResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string status;

		private string dsRecord;

		private string digest;

		private string digestType;

		private string algorithm;

		private string publicKey;

		private string keyTag;

		private string flags;

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

		public string DsRecord
		{
			get
			{
				return dsRecord;
			}
			set	
			{
				dsRecord = value;
			}
		}

		public string Digest
		{
			get
			{
				return digest;
			}
			set	
			{
				digest = value;
			}
		}

		public string DigestType
		{
			get
			{
				return digestType;
			}
			set	
			{
				digestType = value;
			}
		}

		public string Algorithm
		{
			get
			{
				return algorithm;
			}
			set	
			{
				algorithm = value;
			}
		}

		public string PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
			}
		}

		public string KeyTag
		{
			get
			{
				return keyTag;
			}
			set	
			{
				keyTag = value;
			}
		}

		public string Flags
		{
			get
			{
				return flags;
			}
			set	
			{
				flags = value;
			}
		}
	}
}
