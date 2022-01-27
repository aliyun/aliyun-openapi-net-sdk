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

			private string domain;

			private int? blackWhiteListEnable;

			private int? regionBlockEnable;

			private int? ccEnable;

			private int? ccCustomRuleEnable;

			private int? preciseRuleEnable;

			private int? aiRuleEnable;

			private string ccTemplate;

			private string aiTemplate;

			private string aiMode;

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
		}
	}
}
