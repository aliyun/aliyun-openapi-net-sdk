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
	public class DescribeComplianceSummaryResponse : AcsResponse
	{

		private string requestId;

		private DescribeComplianceSummary_ComplianceSummary complianceSummary;

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

		public DescribeComplianceSummary_ComplianceSummary ComplianceSummary
		{
			get
			{
				return complianceSummary;
			}
			set	
			{
				complianceSummary = value;
			}
		}

		public class DescribeComplianceSummary_ComplianceSummary
		{

			private DescribeComplianceSummary_ComplianceSummaryByConfigRule complianceSummaryByConfigRule;

			private DescribeComplianceSummary_ComplianceSummaryByResource complianceSummaryByResource;

			public DescribeComplianceSummary_ComplianceSummaryByConfigRule ComplianceSummaryByConfigRule
			{
				get
				{
					return complianceSummaryByConfigRule;
				}
				set	
				{
					complianceSummaryByConfigRule = value;
				}
			}

			public DescribeComplianceSummary_ComplianceSummaryByResource ComplianceSummaryByResource
			{
				get
				{
					return complianceSummaryByResource;
				}
				set	
				{
					complianceSummaryByResource = value;
				}
			}

			public class DescribeComplianceSummary_ComplianceSummaryByConfigRule
			{

				private long? complianceSummaryTimestamp;

				private int? compliantCount;

				private int? nonCompliantCount;

				private long? totalCount;

				public long? ComplianceSummaryTimestamp
				{
					get
					{
						return complianceSummaryTimestamp;
					}
					set	
					{
						complianceSummaryTimestamp = value;
					}
				}

				public int? CompliantCount
				{
					get
					{
						return compliantCount;
					}
					set	
					{
						compliantCount = value;
					}
				}

				public int? NonCompliantCount
				{
					get
					{
						return nonCompliantCount;
					}
					set	
					{
						nonCompliantCount = value;
					}
				}

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
			}

			public class DescribeComplianceSummary_ComplianceSummaryByResource
			{

				private long? complianceSummaryTimestamp;

				private int? compliantCount;

				private int? nonCompliantCount;

				private long? totalCount;

				public long? ComplianceSummaryTimestamp
				{
					get
					{
						return complianceSummaryTimestamp;
					}
					set	
					{
						complianceSummaryTimestamp = value;
					}
				}

				public int? CompliantCount
				{
					get
					{
						return compliantCount;
					}
					set	
					{
						compliantCount = value;
					}
				}

				public int? NonCompliantCount
				{
					get
					{
						return nonCompliantCount;
					}
					set	
					{
						nonCompliantCount = value;
					}
				}

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
			}
		}
	}
}
