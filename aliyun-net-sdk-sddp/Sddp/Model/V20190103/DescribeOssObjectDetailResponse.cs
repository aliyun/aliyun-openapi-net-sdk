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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeOssObjectDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeOssObjectDetail_OssObjectDetail ossObjectDetail;

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

		public DescribeOssObjectDetail_OssObjectDetail OssObjectDetail
		{
			get
			{
				return ossObjectDetail;
			}
			set	
			{
				ossObjectDetail = value;
			}
		}

		public class DescribeOssObjectDetail_OssObjectDetail
		{

			private string categoryName;

			private string name;

			private string bucketName;

			private string riskLevelName;

			private string regionId;

			private List<DescribeOssObjectDetail_Rule> ruleList;

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
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

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public string RiskLevelName
			{
				get
				{
					return riskLevelName;
				}
				set	
				{
					riskLevelName = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public List<DescribeOssObjectDetail_Rule> RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class DescribeOssObjectDetail_Rule
			{

				private string riskLevelName;

				private int? category;

				private string categoryName;

				private long? riskLevelId;

				private long? count;

				private string ruleName;

				private List<string> sampleList;

				public string RiskLevelName
				{
					get
					{
						return riskLevelName;
					}
					set	
					{
						riskLevelName = value;
					}
				}

				public int? Category
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

				public string CategoryName
				{
					get
					{
						return categoryName;
					}
					set	
					{
						categoryName = value;
					}
				}

				public long? RiskLevelId
				{
					get
					{
						return riskLevelId;
					}
					set	
					{
						riskLevelId = value;
					}
				}

				public long? Count
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

				public string RuleName
				{
					get
					{
						return ruleName;
					}
					set	
					{
						ruleName = value;
					}
				}

				public List<string> SampleList
				{
					get
					{
						return sampleList;
					}
					set	
					{
						sampleList = value;
					}
				}
			}
		}
	}
}
