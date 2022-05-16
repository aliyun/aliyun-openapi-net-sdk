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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeConfigurationPriceResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeConfigurationPrice_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public DescribeConfigurationPrice_Data Data
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

		public class DescribeConfigurationPrice_Data
		{

			private List<DescribeConfigurationPrice_Rule> rules;

			private DescribeConfigurationPrice_BagUsage bagUsage;

			private DescribeConfigurationPrice_Order order;

			public List<DescribeConfigurationPrice_Rule> Rules
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

			public DescribeConfigurationPrice_BagUsage BagUsage
			{
				get
				{
					return bagUsage;
				}
				set	
				{
					bagUsage = value;
				}
			}

			public DescribeConfigurationPrice_Order Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}

			public class DescribeConfigurationPrice_Rule
			{

				private long? ruleDescId;

				private string name;

				public long? RuleDescId
				{
					get
					{
						return ruleDescId;
					}
					set	
					{
						ruleDescId = value;
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
			}

			public class DescribeConfigurationPrice_BagUsage
			{

				private float? cpu;

				private float? mem;

				public float? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public float? Mem
				{
					get
					{
						return mem;
					}
					set	
					{
						mem = value;
					}
				}
			}

			public class DescribeConfigurationPrice_Order
			{

				private float? originalAmount;

				private float? discountAmount;

				private float? tradeAmount;

				private List<string> ruleIds;

				public float? OriginalAmount
				{
					get
					{
						return originalAmount;
					}
					set	
					{
						originalAmount = value;
					}
				}

				public float? DiscountAmount
				{
					get
					{
						return discountAmount;
					}
					set	
					{
						discountAmount = value;
					}
				}

				public float? TradeAmount
				{
					get
					{
						return tradeAmount;
					}
					set	
					{
						tradeAmount = value;
					}
				}

				public List<string> RuleIds
				{
					get
					{
						return ruleIds;
					}
					set	
					{
						ruleIds = value;
					}
				}
			}
		}
	}
}
