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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeGroupProductionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGroupProductions_DataItem> data;

		private DescribeGroupProductions_Page page;

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

		public List<DescribeGroupProductions_DataItem> Data
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

		public DescribeGroupProductions_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class DescribeGroupProductions_DataItem
		{

			private string groupName;

			private List<DescribeGroupProductions_Production> productions;

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public List<DescribeGroupProductions_Production> Productions
			{
				get
				{
					return productions;
				}
				set	
				{
					productions = value;
				}
			}

			public class DescribeGroupProductions_Production
			{

				private string code;

				private string name;

				private string shortName;

				private string description;

				private string group;

				private string defaultVersion;

				private string defaultDomain;

				private string ramCode;

				private string source;

				private List<DescribeGroupProductions_PolicyListItem> policyList;

				private List<string> versions;

				private List<string> fullDomains;

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

				public string ShortName
				{
					get
					{
						return shortName;
					}
					set	
					{
						shortName = value;
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

				public string Group
				{
					get
					{
						return group;
					}
					set	
					{
						group = value;
					}
				}

				public string DefaultVersion
				{
					get
					{
						return defaultVersion;
					}
					set	
					{
						defaultVersion = value;
					}
				}

				public string DefaultDomain
				{
					get
					{
						return defaultDomain;
					}
					set	
					{
						defaultDomain = value;
					}
				}

				public string RamCode
				{
					get
					{
						return ramCode;
					}
					set	
					{
						ramCode = value;
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

				public List<DescribeGroupProductions_PolicyListItem> PolicyList
				{
					get
					{
						return policyList;
					}
					set	
					{
						policyList = value;
					}
				}

				public List<string> Versions
				{
					get
					{
						return versions;
					}
					set	
					{
						versions = value;
					}
				}

				public List<string> FullDomains
				{
					get
					{
						return fullDomains;
					}
					set	
					{
						fullDomains = value;
					}
				}

				public class DescribeGroupProductions_PolicyListItem
				{

					private string policyName;

					private string type;

					public string PolicyName
					{
						get
						{
							return policyName;
						}
						set	
						{
							policyName = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}
				}
			}
		}

		public class DescribeGroupProductions_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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
		}
	}
}
