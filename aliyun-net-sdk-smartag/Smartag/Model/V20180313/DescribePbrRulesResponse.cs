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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribePbrRulesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribePbrRules_PbrRule> pbrRules;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribePbrRules_PbrRule> PbrRules
		{
			get
			{
				return pbrRules;
			}
			set	
			{
				pbrRules = value;
			}
		}

		public class DescribePbrRules_PbrRule
		{

			private string pbrRuleId;

			private string srcCidr;

			private string dstCidr;

			private string srcPort;

			private string dstPort;

			private string protocol;

			private string name;

			private string description;

			public string PbrRuleId
			{
				get
				{
					return pbrRuleId;
				}
				set	
				{
					pbrRuleId = value;
				}
			}

			public string SrcCidr
			{
				get
				{
					return srcCidr;
				}
				set	
				{
					srcCidr = value;
				}
			}

			public string DstCidr
			{
				get
				{
					return dstCidr;
				}
				set	
				{
					dstCidr = value;
				}
			}

			public string SrcPort
			{
				get
				{
					return srcPort;
				}
				set	
				{
					srcPort = value;
				}
			}

			public string DstPort
			{
				get
				{
					return dstPort;
				}
				set	
				{
					dstPort = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
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
