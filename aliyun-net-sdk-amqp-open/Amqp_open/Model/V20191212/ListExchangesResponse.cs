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

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
	public class ListExchangesResponse : AcsResponse
	{

		private string requestId;

		private ListExchanges_Data data;

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

		public ListExchanges_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListExchanges_Data
		{

			private string nextToken;

			private int? maxResults;

			private List<ListExchanges_ExchangeVO> exchanges;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<ListExchanges_ExchangeVO> Exchanges
			{
				get
				{
					return exchanges;
				}
				set	
				{
					exchanges = value;
				}
			}

			public class ListExchanges_ExchangeVO
			{

				private string name;

				private string vHostName;

				private string exchangeType;

				private bool? autoDeleteState;

				private string attributes;

				private long? createTime;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string VHostName
				{
					get
					{
						return vHostName;
					}
					set	
					{
						vHostName = value;
					}
				}

				public string ExchangeType
				{
					get
					{
						return exchangeType;
					}
					set	
					{
						exchangeType = value;
					}
				}

				public bool? AutoDeleteState
				{
					get
					{
						return autoDeleteState;
					}
					set	
					{
						autoDeleteState = value;
					}
				}

				public string Attributes
				{
					get
					{
						return attributes;
					}
					set	
					{
						attributes = value;
					}
				}

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}
			}
		}
	}
}
