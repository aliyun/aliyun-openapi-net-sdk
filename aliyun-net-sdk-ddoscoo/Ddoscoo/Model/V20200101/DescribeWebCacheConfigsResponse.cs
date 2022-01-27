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
	public class DescribeWebCacheConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWebCacheConfigs_CacheConfig> domainCacheConfigs;

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

		public List<DescribeWebCacheConfigs_CacheConfig> DomainCacheConfigs
		{
			get
			{
				return domainCacheConfigs;
			}
			set	
			{
				domainCacheConfigs = value;
			}
		}

		public class DescribeWebCacheConfigs_CacheConfig
		{

			private string mode;

			private int? enable;

			private string domain;

			private List<DescribeWebCacheConfigs_CustomRule> customRules;

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

			public int? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
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

			public List<DescribeWebCacheConfigs_CustomRule> CustomRules
			{
				get
				{
					return customRules;
				}
				set	
				{
					customRules = value;
				}
			}

			public class DescribeWebCacheConfigs_CustomRule
			{

				private string mode;

				private string name;

				private long? cacheTtl;

				private string uri;

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

				public long? CacheTtl
				{
					get
					{
						return cacheTtl;
					}
					set	
					{
						cacheTtl = value;
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
			}
		}
	}
}
