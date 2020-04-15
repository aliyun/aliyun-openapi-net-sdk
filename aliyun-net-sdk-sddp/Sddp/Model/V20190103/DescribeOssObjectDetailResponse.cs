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

			private string name;

			private string regionId;

			private string riskLevelName;

			private string bucketName;

			private string categoryName;

			private List<DescribeOssObjectDetail_Rule> ruleList;

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

				private string ruleName;

				private long? count;

				private int? category;

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
			}
		}
	}
}
