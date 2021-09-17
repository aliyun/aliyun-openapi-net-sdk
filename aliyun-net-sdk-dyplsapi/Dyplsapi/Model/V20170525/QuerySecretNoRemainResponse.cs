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

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
	public class QuerySecretNoRemainResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private QuerySecretNoRemain_SecretRemainDTO secretRemainDTO;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public QuerySecretNoRemain_SecretRemainDTO SecretRemainDTO
		{
			get
			{
				return secretRemainDTO;
			}
			set	
			{
				secretRemainDTO = value;
			}
		}

		public class QuerySecretNoRemain_SecretRemainDTO
		{

			private long? amount;

			private string city;

			private List<QuerySecretNoRemain_RemainDTO> remainDTOList;

			public long? Amount
			{
				get
				{
					return amount;
				}
				set	
				{
					amount = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public List<QuerySecretNoRemain_RemainDTO> RemainDTOList
			{
				get
				{
					return remainDTOList;
				}
				set	
				{
					remainDTOList = value;
				}
			}

			public class QuerySecretNoRemain_RemainDTO
			{

				private long? amount;

				private string city;

				public long? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string City
				{
					get
					{
						return city;
					}
					set	
					{
						city = value;
					}
				}
			}
		}
	}
}
