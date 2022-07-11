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
	public class DescribeWebCCRulesResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribeWebCCRules_WebCCRule> webCCRules;

		public long? TotalCount
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

		public List<DescribeWebCCRules_WebCCRule> WebCCRules
		{
			get
			{
				return webCCRules;
			}
			set	
			{
				webCCRules = value;
			}
		}

		public class DescribeWebCCRules_WebCCRule
		{

			private int? ttl;

			private string act;

			private int? interval;

			private string mode;

			private string name;

			private string uri;

			private int? count;

			public int? Ttl
			{
				get
				{
					return ttl;
				}
				set	
				{
					ttl = value;
				}
			}

			public string Act
			{
				get
				{
					return act;
				}
				set	
				{
					act = value;
				}
			}

			public int? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
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

			public string Uri
			{
				get
				{
					return uri;
				}
				set	
				{
					uri = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
