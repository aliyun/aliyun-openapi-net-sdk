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
	public class QueryCreateInstancePriceResponse : AcsResponse
	{

		private string requestId;

		private string origin;

		private string discount;

		private string amount;

		private string currency;

		private List<QueryCreateInstancePrice_Rule> rules;

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

		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
			}
		}

		public string Discount
		{
			get
			{
				return discount;
			}
			set	
			{
				discount = value;
			}
		}

		public string Amount
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

		public string Currency
		{
			get
			{
				return currency;
			}
			set	
			{
				currency = value;
			}
		}

		public List<QueryCreateInstancePrice_Rule> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
			}
		}

		public class QueryCreateInstancePrice_Rule
		{

			private long? ruleId;

			private string name;

			private string title;

			public long? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

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

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}
		}
	}
}
