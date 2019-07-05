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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeKeywordLibResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeKeywordLib_KeywordLib> keywordLibList;

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

		public List<DescribeKeywordLib_KeywordLib> KeywordLibList
		{
			get
			{
				return keywordLibList;
			}
			set	
			{
				keywordLibList = value;
			}
		}

		public class DescribeKeywordLib_KeywordLib
		{

			private int? id;

			private string modifiedTime;

			private string name;

			private string code;

			private int? count;

			private string category;

			private string resourceType;

			private string libType;

			private string source;

			private string serviceModule;

			private string language;

			private string matchMode;

			private bool? enable;

			private List<string> bizTypes;

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string LibType
			{
				get
				{
					return libType;
				}
				set	
				{
					libType = value;
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

			public string ServiceModule
			{
				get
				{
					return serviceModule;
				}
				set	
				{
					serviceModule = value;
				}
			}

			public string Language
			{
				get
				{
					return language;
				}
				set	
				{
					language = value;
				}
			}

			public string MatchMode
			{
				get
				{
					return matchMode;
				}
				set	
				{
					matchMode = value;
				}
			}

			public bool? Enable
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

			public List<string> BizTypes
			{
				get
				{
					return bizTypes;
				}
				set	
				{
					bizTypes = value;
				}
			}
		}
	}
}
