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
	public class DescribesummaryResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<Describesummary_WarningSummary> warningSummarys;

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

		public List<Describesummary_WarningSummary> WarningSummarys
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

		public class Describesummary_WarningSummary
		{

			private long? riskId;

			private string riskName;

			private string level;

			private string typeAlias;

			private string subTypeAlias;

			private string lastFoundTime;

			private int? pendingCount;

			private int? totalCount;

			private string riskDetail;

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

			public int? PendingCount
			{
				get
				{
					return pendingCount;
				}
				set	
				{
					pendingCount = value;
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
		}
	}
}
