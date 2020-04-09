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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeRuleMonitorResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeRuleMonitor_Item> ruleMonitors;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeRuleMonitor_Item> RuleMonitors
		{
			get
			{
				return ruleMonitors;
			}
			set	
			{
				ruleMonitors = value;
			}
		}

		public class DescribeRuleMonitor_Item
		{

			private string antibotType;

			private long? pv;

			private string ruleId;

			private long? index;

			private string domain;

			private string antibotWatch;

			public string AntibotType
			{
				get
				{
					return antibotType;
				}
				set	
				{
					antibotType = value;
				}
			}

			public long? Pv
			{
				get
				{
					return pv;
				}
				set	
				{
					pv = value;
				}
			}

			public string RuleId
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

			public long? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
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

			public string AntibotWatch
			{
				get
				{
					return antibotWatch;
				}
				set	
				{
					antibotWatch = value;
				}
			}
		}
	}
}
