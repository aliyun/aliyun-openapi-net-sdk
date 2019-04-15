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
	public class DescribeRiskTypeResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private List<DescribeRiskType_RiskType> riskTypes;

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

		public List<DescribeRiskType_RiskType> RiskTypes
		{
			get
			{
				return riskTypes;
			}
			set	
			{
				riskTypes = value;
			}
		}

		public class DescribeRiskType_RiskType
		{

			private string typeName;

			private string alias;

			private string warnCount;

			private List<DescribeRiskType_SubType> subTypes;

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}

			public string WarnCount
			{
				get
				{
					return warnCount;
				}
				set	
				{
					warnCount = value;
				}
			}

			public List<DescribeRiskType_SubType> SubTypes
			{
				get
				{
					return subTypes;
				}
				set	
				{
					subTypes = value;
				}
			}

			public class DescribeRiskType_SubType
			{

				private string warnCount;

				private string typeName;

				private string alias;

				public string WarnCount
				{
					get
					{
						return warnCount;
					}
					set	
					{
						warnCount = value;
					}
				}

				public string TypeName
				{
					get
					{
						return typeName;
					}
					set	
					{
						typeName = value;
					}
				}

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}
			}
		}
	}
}
