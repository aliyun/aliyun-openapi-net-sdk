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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveAIProduceRulesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveAIProduceRules_RuleInfo> ruleInfoList;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "RuleInfoList")]
		public List<DescribeLiveAIProduceRules_RuleInfo> RuleInfoList
		{
			get
			{
				return ruleInfoList;
			}
			set	
			{
				ruleInfoList = value;
			}
		}

		public class DescribeLiveAIProduceRules_RuleInfo
		{

			private string domain;

			private string app;

			private string subtitleName;

			private bool? isLazy;

			private bool? isOrigin;

			private string rulesId;

			private string liveTemplate;

			private string gmtModifyTime;

			private string suffixName;

			private string description;

			[JsonProperty(PropertyName = "Domain")]
			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			[JsonProperty(PropertyName = "App")]
			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			[JsonProperty(PropertyName = "SubtitleName")]
			public string SubtitleName
			{
				get
				{
					return subtitleName;
				}
				set	
				{
					subtitleName = value;
				}
			}

			[JsonProperty(PropertyName = "IsLazy")]
			public bool? IsLazy
			{
				get
				{
					return isLazy;
				}
				set	
				{
					isLazy = value;
				}
			}

			[JsonProperty(PropertyName = "IsOrigin")]
			public bool? IsOrigin
			{
				get
				{
					return isOrigin;
				}
				set	
				{
					isOrigin = value;
				}
			}

			[JsonProperty(PropertyName = "RulesId")]
			public string RulesId
			{
				get
				{
					return rulesId;
				}
				set	
				{
					rulesId = value;
				}
			}

			[JsonProperty(PropertyName = "LiveTemplate")]
			public string LiveTemplate
			{
				get
				{
					return liveTemplate;
				}
				set	
				{
					liveTemplate = value;
				}
			}

			[JsonProperty(PropertyName = "GmtModifyTime")]
			public string GmtModifyTime
			{
				get
				{
					return gmtModifyTime;
				}
				set	
				{
					gmtModifyTime = value;
				}
			}

			[JsonProperty(PropertyName = "SuffixName")]
			public string SuffixName
			{
				get
				{
					return suffixName;
				}
				set	
				{
					suffixName = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
