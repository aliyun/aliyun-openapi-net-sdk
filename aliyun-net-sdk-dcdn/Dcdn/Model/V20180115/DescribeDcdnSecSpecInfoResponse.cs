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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnSecSpecInfoResponse : AcsResponse
	{

		private string requestId;

		private string version;

		private List<DescribeDcdnSecSpecInfo_RuleInfoItem> specInfos;

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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
			}
		}

		public List<DescribeDcdnSecSpecInfo_RuleInfoItem> SpecInfos
		{
			get
			{
				return specInfos;
			}
			set	
			{
				specInfos = value;
			}
		}

		public class DescribeDcdnSecSpecInfo_RuleInfoItem
		{

			private string ruleCode;

			private List<DescribeDcdnSecSpecInfo_ConfigItem> ruleConfigs;

			public string RuleCode
			{
				get
				{
					return ruleCode;
				}
				set	
				{
					ruleCode = value;
				}
			}

			public List<DescribeDcdnSecSpecInfo_ConfigItem> RuleConfigs
			{
				get
				{
					return ruleConfigs;
				}
				set	
				{
					ruleConfigs = value;
				}
			}

			public class DescribeDcdnSecSpecInfo_ConfigItem
			{

				private string code;

				private string expr;

				private string _value;

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

				public string Expr
				{
					get
					{
						return expr;
					}
					set	
					{
						expr = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
