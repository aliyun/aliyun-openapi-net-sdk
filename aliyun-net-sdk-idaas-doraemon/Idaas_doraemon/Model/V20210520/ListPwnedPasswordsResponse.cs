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

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
	public class ListPwnedPasswordsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? totalCount;

		private long? pageSize;

		private List<ListPwnedPasswords_Items> pwnedPasswordInfos;

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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListPwnedPasswords_Items> PwnedPasswordInfos
		{
			get
			{
				return pwnedPasswordInfos;
			}
			set	
			{
				pwnedPasswordInfos = value;
			}
		}

		public class ListPwnedPasswords_Items
		{

			private string hexPasswordSha1Hash;

			private long? pwnedCount;

			public string HexPasswordSha1Hash
			{
				get
				{
					return hexPasswordSha1Hash;
				}
				set	
				{
					hexPasswordSha1Hash = value;
				}
			}

			public long? PwnedCount
			{
				get
				{
					return pwnedCount;
				}
				set	
				{
					pwnedCount = value;
				}
			}
		}
	}
}
