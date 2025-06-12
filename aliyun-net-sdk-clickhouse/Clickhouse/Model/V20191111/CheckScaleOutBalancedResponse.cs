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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class CheckScaleOutBalancedResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private string checkCode;

		private string timeDuration;

		private List<CheckScaleOutBalanced_TableDetail> tableDetails;

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

		public string CheckCode
		{
			get
			{
				return checkCode;
			}
			set	
			{
				checkCode = value;
			}
		}

		public string TimeDuration
		{
			get
			{
				return timeDuration;
			}
			set	
			{
				timeDuration = value;
			}
		}

		public List<CheckScaleOutBalanced_TableDetail> TableDetails
		{
			get
			{
				return tableDetails;
			}
			set	
			{
				tableDetails = value;
			}
		}

		public class CheckScaleOutBalanced_TableDetail
		{

			private string tableName;

			private string cluster;

			private string database;

			private int? detail;

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public string Cluster
			{
				get
				{
					return cluster;
				}
				set	
				{
					cluster = value;
				}
			}

			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			public int? Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}
		}
	}
}
