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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeRisksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeRisks_Risk> risks;

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

		public List<DescribeRisks_Risk> Risks
		{
			get
			{
				return risks;
			}
			set	
			{
				risks = value;
			}
		}

		public class DescribeRisks_Risk
		{

			private long? riskId;

			private string riskName;

			private string riskDetail;

			private string riskType;

			private string typeAlias;

			private string subRiskType;

			private string subTypeAlias;

			public long? RiskId
			{
				get
				{
					return riskId;
				}
				set	
				{
					riskId = value;
				}
			}

			public string RiskName
			{
				get
				{
					return riskName;
				}
				set	
				{
					riskName = value;
				}
			}

			public string RiskDetail
			{
				get
				{
					return riskDetail;
				}
				set	
				{
					riskDetail = value;
				}
			}

			public string RiskType
			{
				get
				{
					return riskType;
				}
				set	
				{
					riskType = value;
				}
			}

			public string TypeAlias
			{
				get
				{
					return typeAlias;
				}
				set	
				{
					typeAlias = value;
				}
			}

			public string SubRiskType
			{
				get
				{
					return subRiskType;
				}
				set	
				{
					subRiskType = value;
				}
			}

			public string SubTypeAlias
			{
				get
				{
					return subTypeAlias;
				}
				set	
				{
					subTypeAlias = value;
				}
			}
		}
	}
}
