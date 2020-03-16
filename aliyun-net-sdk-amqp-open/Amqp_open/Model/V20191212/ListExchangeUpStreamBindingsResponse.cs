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
	public class ListExchangeUpStreamBindingsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private bool? success;

		private ListExchangeUpStreamBindings_Data data;

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

		public int? Code
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ListExchangeUpStreamBindings_Data Data
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

		public class ListExchangeUpStreamBindings_Data
		{

			private string nextToken;

			private int? maxResults;

			private List<ListExchangeUpStreamBindings_BindingVO> bindings;

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

			public List<ListExchangeUpStreamBindings_BindingVO> Bindings
			{
				get
				{
					return bindings;
				}
				set	
				{
					bindings = value;
				}
			}

			public class ListExchangeUpStreamBindings_BindingVO
			{

				private string sourceExchange;

				private string destinationName;

				private string bindingType;

				private string bindingKey;

				private string argument;

				public string SourceExchange
				{
					get
					{
						return sourceExchange;
					}
					set	
					{
						sourceExchange = value;
					}
				}

				public string DestinationName
				{
					get
					{
						return destinationName;
					}
					set	
					{
						destinationName = value;
					}
				}

				public string BindingType
				{
					get
					{
						return bindingType;
					}
					set	
					{
						bindingType = value;
					}
				}

				public string BindingKey
				{
					get
					{
						return bindingKey;
					}
					set	
					{
						bindingKey = value;
					}
				}

				public string Argument
				{
					get
					{
						return argument;
					}
					set	
					{
						argument = value;
					}
				}
			}
		}
	}
}
