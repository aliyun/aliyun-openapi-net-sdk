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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiIpControlsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeApiIpControls_ApiIpControlItem> apiIpControls;

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

		public List<DescribeApiIpControls_ApiIpControlItem> ApiIpControls
		{
			get
			{
				return apiIpControls;
			}
			set	
			{
				apiIpControls = value;
			}
		}

		public class DescribeApiIpControls_ApiIpControlItem
		{

			private string apiId;

			private string apiName;

			private string ipControlId;

			private string ipControlName;

			private string boundTime;

			public string ApiId
			{
				get
				{
					return apiId;
				}
				set	
				{
					apiId = value;
				}
			}

			public string ApiName
			{
				get
				{
					return apiName;
				}
				set	
				{
					apiName = value;
				}
			}

			public string IpControlId
			{
				get
				{
					return ipControlId;
				}
				set	
				{
					ipControlId = value;
				}
			}

			public string IpControlName
			{
				get
				{
					return ipControlName;
				}
				set	
				{
					ipControlName = value;
				}
			}

			public string BoundTime
			{
				get
				{
					return boundTime;
				}
				set	
				{
					boundTime = value;
				}
			}
		}
	}
}
