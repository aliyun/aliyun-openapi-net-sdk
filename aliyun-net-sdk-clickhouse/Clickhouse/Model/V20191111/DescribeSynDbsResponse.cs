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
	public class DescribeSynDbsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeSynDbs_SynDb> synDbs;

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

		public List<DescribeSynDbs_SynDb> SynDbs
		{
			get
			{
				return synDbs;
			}
			set	
			{
				synDbs = value;
			}
		}

		public class DescribeSynDbs_SynDb
		{

			private string rdsId;

			private string synDb;

			private bool? synStatus;

			private string errorMsg;

			private string rdsUserName;

			private string rdsPassword;

			private string rdsVpcUrl;

			public string RdsId
			{
				get
				{
					return rdsId;
				}
				set	
				{
					rdsId = value;
				}
			}

			public string SynDb
			{
				get
				{
					return synDb;
				}
				set	
				{
					synDb = value;
				}
			}

			public bool? SynStatus
			{
				get
				{
					return synStatus;
				}
				set	
				{
					synStatus = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public string RdsUserName
			{
				get
				{
					return rdsUserName;
				}
				set	
				{
					rdsUserName = value;
				}
			}

			public string RdsPassword
			{
				get
				{
					return rdsPassword;
				}
				set	
				{
					rdsPassword = value;
				}
			}

			public string RdsVpcUrl
			{
				get
				{
					return rdsVpcUrl;
				}
				set	
				{
					rdsVpcUrl = value;
				}
			}
		}
	}
}
