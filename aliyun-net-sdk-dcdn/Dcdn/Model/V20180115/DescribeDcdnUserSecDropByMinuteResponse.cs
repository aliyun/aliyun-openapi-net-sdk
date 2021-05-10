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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnUserSecDropByMinuteResponse : AcsResponse
	{

		private string requestId;

		private string description;

		private int? totalCount;

		private int? len;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDcdnUserSecDropByMinute_RowsItem> rows;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
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

		public int? Len
		{
			get
			{
				return len;
			}
			set	
			{
				len = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<DescribeDcdnUserSecDropByMinute_RowsItem> Rows
		{
			get
			{
				return rows;
			}
			set	
			{
				rows = value;
			}
		}

		public class DescribeDcdnUserSecDropByMinute_RowsItem
		{

			private string ruleName;

			private string _object;

			private string domain;

			private string secFunc;

			private string tmStr;

			private int? drops;

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

			public string _Object
			{
				get
				{
					return _object;
				}
				set	
				{
					_object = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string SecFunc
			{
				get
				{
					return secFunc;
				}
				set	
				{
					secFunc = value;
				}
			}

			public string TmStr
			{
				get
				{
					return tmStr;
				}
				set	
				{
					tmStr = value;
				}
			}

			public int? Drops
			{
				get
				{
					return drops;
				}
				set	
				{
					drops = value;
				}
			}
		}
	}
}
