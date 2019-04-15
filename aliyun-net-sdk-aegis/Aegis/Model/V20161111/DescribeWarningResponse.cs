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
	public class DescribeWarningResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeWarning_Warning> warnings;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public List<DescribeWarning_Warning> Warnings
		{
			get
			{
				return warnings;
			}
			set	
			{
				warnings = value;
			}
		}

		public class DescribeWarning_Warning
		{

			private long? riskWarningId;

			private string riskName;

			private string uuid;

			private string rirstFoundTime;

			private string lastFoundTime;

			private string level;

			private string typeName;

			private string subTypeName;

			private string typeAlias;

			private string subTypeAlias;

			private int? status;

			private List<DescribeWarning_Detail> details;

			public long? RiskWarningId
			{
				get
				{
					return riskWarningId;
				}
				set	
				{
					riskWarningId = value;
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

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string RirstFoundTime
			{
				get
				{
					return rirstFoundTime;
				}
				set	
				{
					rirstFoundTime = value;
				}
			}

			public string LastFoundTime
			{
				get
				{
					return lastFoundTime;
				}
				set	
				{
					lastFoundTime = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
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

			public string SubTypeName
			{
				get
				{
					return subTypeName;
				}
				set	
				{
					subTypeName = value;
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

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public List<DescribeWarning_Detail> Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public class DescribeWarning_Detail
			{

				private List<DescribeWarning_DetailItem> detailItems;

				public List<DescribeWarning_DetailItem> DetailItems
				{
					get
					{
						return detailItems;
					}
					set	
					{
						detailItems = value;
					}
				}

				public class DescribeWarning_DetailItem
				{

					private string name;

					private string _value;

					private string type;

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

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
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
	}
}
