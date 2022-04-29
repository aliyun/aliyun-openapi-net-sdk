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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeLogAnalysisResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private string code;

		private List<DescribeLogAnalysis_Analysis> analyses;

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

		public List<DescribeLogAnalysis_Analysis> Analyses
		{
			get
			{
				return analyses;
			}
			set	
			{
				analyses = value;
			}
		}

		public class DescribeLogAnalysis_Analysis
		{

			private string metaKey;

			private DescribeLogAnalysis_MetaValue metaValue;

			public string MetaKey
			{
				get
				{
					return metaKey;
				}
				set	
				{
					metaKey = value;
				}
			}

			public DescribeLogAnalysis_MetaValue MetaValue
			{
				get
				{
					return metaValue;
				}
				set	
				{
					metaValue = value;
				}
			}

			public class DescribeLogAnalysis_MetaValue
			{

				private string roleArn;

				private string region;

				private string logstore;

				private string project;

				public string RoleArn
				{
					get
					{
						return roleArn;
					}
					set	
					{
						roleArn = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string Logstore
				{
					get
					{
						return logstore;
					}
					set	
					{
						logstore = value;
					}
				}

				public string Project
				{
					get
					{
						return project;
					}
					set	
					{
						project = value;
					}
				}
			}
		}
	}
}
