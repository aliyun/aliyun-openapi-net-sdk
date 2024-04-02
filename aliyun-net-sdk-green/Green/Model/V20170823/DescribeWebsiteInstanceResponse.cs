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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeWebsiteInstanceResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeWebsiteInstance_WebsiteInstance> websiteInstanceList;

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

		public List<DescribeWebsiteInstance_WebsiteInstance> WebsiteInstanceList
		{
			get
			{
				return websiteInstanceList;
			}
			set	
			{
				websiteInstanceList = value;
			}
		}

		public class DescribeWebsiteInstance_WebsiteInstance
		{

			private string status;

			private string domain;

			private string indexPage;

			private string expiredTime;

			private int? websiteScanInterval;

			private string protocol;

			private string buyTime;

			private string instanceId;

			private int? indexPageScanInterval;

			public string Status
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

			public string IndexPage
			{
				get
				{
					return indexPage;
				}
				set	
				{
					indexPage = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public int? WebsiteScanInterval
			{
				get
				{
					return websiteScanInterval;
				}
				set	
				{
					websiteScanInterval = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string BuyTime
			{
				get
				{
					return buyTime;
				}
				set	
				{
					buyTime = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? IndexPageScanInterval
			{
				get
				{
					return indexPageScanInterval;
				}
				set	
				{
					indexPageScanInterval = value;
				}
			}
		}
	}
}
