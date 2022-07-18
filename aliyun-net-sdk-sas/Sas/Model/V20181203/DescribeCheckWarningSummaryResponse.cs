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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeCheckWarningSummaryResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private int? count;

		private List<DescribeCheckWarningSummary_WarningSummary> warningSummarys;

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

		public List<DescribeCheckWarningSummary_WarningSummary> WarningSummarys
		{
			get
			{
				return warningSummarys;
			}
			set	
			{
				warningSummarys = value;
			}
		}

		public class DescribeCheckWarningSummary_WarningSummary
		{

			private int? lowWarningCount;

			private int? checkCount;

			private int? mediumWarningCount;

			private string lastFoundTime;

			private long? riskId;

			private string subTypeAlias;

			private int? warningMachineCount;

			private int? highWarningCount;

			private string typeAlias;

			private string riskName;

			private string level;

			private bool? checkExploit;

			private bool? databaseRisk;

			public int? LowWarningCount
			{
				get
				{
					return lowWarningCount;
				}
				set	
				{
					lowWarningCount = value;
				}
			}

			public int? CheckCount
			{
				get
				{
					return checkCount;
				}
				set	
				{
					checkCount = value;
				}
			}

			public int? MediumWarningCount
			{
				get
				{
					return mediumWarningCount;
				}
				set	
				{
					mediumWarningCount = value;
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

			public int? WarningMachineCount
			{
				get
				{
					return warningMachineCount;
				}
				set	
				{
					warningMachineCount = value;
				}
			}

			public int? HighWarningCount
			{
				get
				{
					return highWarningCount;
				}
				set	
				{
					highWarningCount = value;
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

			public bool? CheckExploit
			{
				get
				{
					return checkExploit;
				}
				set	
				{
					checkExploit = value;
				}
			}

			public bool? DatabaseRisk
			{
				get
				{
					return databaseRisk;
				}
				set	
				{
					databaseRisk = value;
				}
			}
		}
	}
}
