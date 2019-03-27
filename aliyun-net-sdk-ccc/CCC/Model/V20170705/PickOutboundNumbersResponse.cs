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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class PickOutboundNumbersResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<PickOutboundNumbers_DialNumberPair> dialNumberPairs;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<PickOutboundNumbers_DialNumberPair> DialNumberPairs
		{
			get
			{
				return dialNumberPairs;
			}
			set	
			{
				dialNumberPairs = value;
			}
		}

		public class PickOutboundNumbers_DialNumberPair
		{

			private PickOutboundNumbers_Callee callee;

			private PickOutboundNumbers_Caller caller;

			public PickOutboundNumbers_Callee Callee
			{
				get
				{
					return callee;
				}
				set	
				{
					callee = value;
				}
			}

			public PickOutboundNumbers_Caller Caller
			{
				get
				{
					return caller;
				}
				set	
				{
					caller = value;
				}
			}

			public class PickOutboundNumbers_Callee
			{

				private string number;

				private string province;

				private string city;

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string Province
				{
					get
					{
						return province;
					}
					set	
					{
						province = value;
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

			public class PickOutboundNumbers_Caller
			{

				private string number;

				private string province;

				private string city;

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string Province
				{
					get
					{
						return province;
					}
					set	
					{
						province = value;
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
