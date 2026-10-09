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

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
	public class GetNamespaceResponse : AcsResponse
	{

		private string requestId;

		private GetNamespace_Data data;

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

		public GetNamespace_Data Data
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

		public class GetNamespace_Data
		{

			private string description;

			private int? promptCount;

			private string createdTime;

			private int? skillCount;

			private string source;

			private string name;

			private string publicDomain;

			private int? sourceIndex;

			private string ipWhitelist;

			private string scanPolicy;

			private bool? publicAccessEnabled;

			private string namespaceId;

			private string tags;

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

			public int? PromptCount
			{
				get
				{
					return promptCount;
				}
				set	
				{
					promptCount = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public int? SkillCount
			{
				get
				{
					return skillCount;
				}
				set	
				{
					skillCount = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
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

			public string PublicDomain
			{
				get
				{
					return publicDomain;
				}
				set	
				{
					publicDomain = value;
				}
			}

			public int? SourceIndex
			{
				get
				{
					return sourceIndex;
				}
				set	
				{
					sourceIndex = value;
				}
			}

			public string IpWhitelist
			{
				get
				{
					return ipWhitelist;
				}
				set	
				{
					ipWhitelist = value;
				}
			}

			public string ScanPolicy
			{
				get
				{
					return scanPolicy;
				}
				set	
				{
					scanPolicy = value;
				}
			}

			public bool? PublicAccessEnabled
			{
				get
				{
					return publicAccessEnabled;
				}
				set	
				{
					publicAccessEnabled = value;
				}
			}

			public string NamespaceId
			{
				get
				{
					return namespaceId;
				}
				set	
				{
					namespaceId = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}
		}
	}
}
