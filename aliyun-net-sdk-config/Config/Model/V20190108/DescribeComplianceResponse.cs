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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class DescribeComplianceResponse : AcsResponse
	{

		private string requestId;

		private DescribeCompliance_ComplianceResult complianceResult;

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

		public DescribeCompliance_ComplianceResult ComplianceResult
		{
			get
			{
				return complianceResult;
			}
			set	
			{
				complianceResult = value;
			}
		}

		public class DescribeCompliance_ComplianceResult
		{

			private long? totalCount;

			private List<DescribeCompliance_CompliancesItem> compliances;

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

			public List<DescribeCompliance_CompliancesItem> Compliances
			{
				get
				{
					return compliances;
				}
				set	
				{
					compliances = value;
				}
			}

			public class DescribeCompliance_CompliancesItem
			{

				private string complianceType;

				private int? count;

				public string ComplianceType
				{
					get
					{
						return complianceType;
					}
					set	
					{
						complianceType = value;
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
}
