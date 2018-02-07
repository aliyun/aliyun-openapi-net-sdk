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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeStratetyDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeStratetyDetail_Strategy strategy;

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

		public DescribeStratetyDetail_Strategy Strategy
		{
			get
			{
				return strategy;
			}
			set	
			{
				strategy = value;
			}
		}

		public class DescribeStratetyDetail_Strategy
		{

			private int? cycleDays;

			private string name;

			private int? id;

			private int? cycleStartTime;

			private int? type;

			private List<DescribeStratetyDetail_RiskTypeWhiteListQueryResult> riskTypeWhiteListQueryResultList;

			public int? CycleDays
			{
				get
				{
					return cycleDays;
				}
				set	
				{
					cycleDays = value;
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

			public int? CycleStartTime
			{
				get
				{
					return cycleStartTime;
				}
				set	
				{
					cycleStartTime = value;
				}
			}

			public int? Type
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

			public List<DescribeStratetyDetail_RiskTypeWhiteListQueryResult> RiskTypeWhiteListQueryResultList
			{
				get
				{
					return riskTypeWhiteListQueryResultList;
				}
				set	
				{
					riskTypeWhiteListQueryResultList = value;
				}
			}

			public class DescribeStratetyDetail_RiskTypeWhiteListQueryResult
			{

				private string typeName;

				private string alias;

				private bool? on;

				private List<DescribeStratetyDetail_SubTyp> subTypes;

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

				public bool? On
				{
					get
					{
						return on;
					}
					set	
					{
						on = value;
					}
				}

				public List<DescribeStratetyDetail_SubTyp> SubTypes
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

				public class DescribeStratetyDetail_SubTyp
				{

					private string typeName;

					private string alias;

					private bool? on;

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

					public bool? On
					{
						get
						{
							return on;
						}
						set	
						{
							on = value;
						}
					}
				}
			}
		}
	}
}