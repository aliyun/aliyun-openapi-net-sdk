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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class DescribeDeprecatedTemplateResponse : AcsResponse
	{

		private string requestId;

		private DescribeDeprecatedTemplate_Result result;

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

		public DescribeDeprecatedTemplate_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeDeprecatedTemplate_Result
		{

			private bool? dataStream;

			private string indexTemplate;

			private long? order;

			private string version;

			private List<string> indexPatterns;

			private DescribeDeprecatedTemplate_Template template;

			public bool? DataStream
			{
				get
				{
					return dataStream;
				}
				set	
				{
					dataStream = value;
				}
			}

			public string IndexTemplate
			{
				get
				{
					return indexTemplate;
				}
				set	
				{
					indexTemplate = value;
				}
			}

			public long? Order
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

			public List<string> IndexPatterns
			{
				get
				{
					return indexPatterns;
				}
				set	
				{
					indexPatterns = value;
				}
			}

			public DescribeDeprecatedTemplate_Template Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public class DescribeDeprecatedTemplate_Template
			{

				private string aliases;

				private string mappings;

				private string settings;

				public string Aliases
				{
					get
					{
						return aliases;
					}
					set	
					{
						aliases = value;
					}
				}

				public string Mappings
				{
					get
					{
						return mappings;
					}
					set	
					{
						mappings = value;
					}
				}

				public string Settings
				{
					get
					{
						return settings;
					}
					set	
					{
						settings = value;
					}
				}
			}
		}
	}
}
