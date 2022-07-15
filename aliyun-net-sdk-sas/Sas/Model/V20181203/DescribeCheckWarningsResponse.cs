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
	public class DescribeCheckWarningsResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private int? count;

		private List<DescribeCheckWarnings_CheckWarning> checkWarnings;

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

		public List<DescribeCheckWarnings_CheckWarning> CheckWarnings
		{
			get
			{
				return checkWarnings;
			}
			set	
			{
				checkWarnings = value;
			}
		}

		public class DescribeCheckWarnings_CheckWarning
		{

			private int? status;

			private long? checkWarningId;

			private string type;

			private string uuid;

			private string item;

			private long? checkId;

			private string level;

			private string reason;

			private int? fixStatus;

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

			public long? CheckWarningId
			{
				get
				{
					return checkWarningId;
				}
				set	
				{
					checkWarningId = value;
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

			public string Item
			{
				get
				{
					return item;
				}
				set	
				{
					item = value;
				}
			}

			public long? CheckId
			{
				get
				{
					return checkId;
				}
				set	
				{
					checkId = value;
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

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public int? FixStatus
			{
				get
				{
					return fixStatus;
				}
				set	
				{
					fixStatus = value;
				}
			}
		}
	}
}
