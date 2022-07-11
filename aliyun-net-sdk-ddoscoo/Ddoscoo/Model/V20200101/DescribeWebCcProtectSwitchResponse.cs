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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeWebCcProtectSwitchResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebCcProtectSwitch_ProtectSwitch> protectSwitchList;

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

		public List<DescribeWebCcProtectSwitch_ProtectSwitch> ProtectSwitchList
		{
			get
			{
				return protectSwitchList;
			}
			set	
			{
				protectSwitchList = value;
			}
		}

		public class DescribeWebCcProtectSwitch_ProtectSwitch
		{

			private int? blackWhiteListEnable;

			private string aiTemplate;

			private int? preciseRuleEnable;

			private string domain;

			private string aiMode;

			private int? aiRuleEnable;

			private int? regionBlockEnable;

			private string ccTemplate;

			private int? ccCustomRuleEnable;

			private int? ccEnable;

			public int? BlackWhiteListEnable
			{
				get
				{
					return blackWhiteListEnable;
				}
				set	
				{
					blackWhiteListEnable = value;
				}
			}

			public string AiTemplate
			{
				get
				{
					return aiTemplate;
				}
				set	
				{
					aiTemplate = value;
				}
			}

			public int? PreciseRuleEnable
			{
				get
				{
					return preciseRuleEnable;
				}
				set	
				{
					preciseRuleEnable = value;
				}
			}

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

			public string AiMode
			{
				get
				{
					return aiMode;
				}
				set	
				{
					aiMode = value;
				}
			}

			public int? AiRuleEnable
			{
				get
				{
					return aiRuleEnable;
				}
				set	
				{
					aiRuleEnable = value;
				}
			}

			public int? RegionBlockEnable
			{
				get
				{
					return regionBlockEnable;
				}
				set	
				{
					regionBlockEnable = value;
				}
			}

			public string CcTemplate
			{
				get
				{
					return ccTemplate;
				}
				set	
				{
					ccTemplate = value;
				}
			}

			public int? CcCustomRuleEnable
			{
				get
				{
					return ccCustomRuleEnable;
				}
				set	
				{
					ccCustomRuleEnable = value;
				}
			}

			public int? CcEnable
			{
				get
				{
					return ccEnable;
				}
				set	
				{
					ccEnable = value;
				}
			}
		}
	}
}
