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
	public class DescribeWebsiteScanResultResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeWebsiteScanResult_WebsiteScanResult> websiteScanResultList;

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

		public List<DescribeWebsiteScanResult_WebsiteScanResult> WebsiteScanResultList
		{
			get
			{
				return websiteScanResultList;
			}
			set	
			{
				websiteScanResultList = value;
			}
		}

		public class DescribeWebsiteScanResult_WebsiteScanResult
		{

			private string scanTime;

			private string domain;

			private int? sourceRiskCount;

			private int? imageRiskCount;

			private string url;

			private int? textRiskCount;

			private int? handleStatus;

			private string instanceId;

			private string taskId;

			private int? id;

			private List<string> labels;

			public string ScanTime
			{
				get
				{
					return scanTime;
				}
				set	
				{
					scanTime = value;
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

			public int? SourceRiskCount
			{
				get
				{
					return sourceRiskCount;
				}
				set	
				{
					sourceRiskCount = value;
				}
			}

			public int? ImageRiskCount
			{
				get
				{
					return imageRiskCount;
				}
				set	
				{
					imageRiskCount = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public int? TextRiskCount
			{
				get
				{
					return textRiskCount;
				}
				set	
				{
					textRiskCount = value;
				}
			}

			public int? HandleStatus
			{
				get
				{
					return handleStatus;
				}
				set	
				{
					handleStatus = value;
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

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
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

			public List<string> Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}
		}
	}
}
