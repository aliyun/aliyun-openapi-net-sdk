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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBMiniEngineVersionsResponse : AcsResponse
	{

		private string dBInstanceId;

		private string requestId;

		private int? totalCount;

		private int? pageNumbers;

		private int? maxRecordsPerPage;

		private List<DescribeDBMiniEngineVersions_MinorVersionItemsItem> minorVersionItems;

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "PageNumbers")]
		public int? PageNumbers
		{
			get
			{
				return pageNumbers;
			}
			set	
			{
				pageNumbers = value;
			}
		}

		[JsonProperty(PropertyName = "MaxRecordsPerPage")]
		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
			}
		}

		[JsonProperty(PropertyName = "MinorVersionItems")]
		public List<DescribeDBMiniEngineVersions_MinorVersionItemsItem> MinorVersionItems
		{
			get
			{
				return minorVersionItems;
			}
			set	
			{
				minorVersionItems = value;
			}
		}

		public class DescribeDBMiniEngineVersions_MinorVersionItemsItem
		{

			private string releaseNote;

			private string nodeType;

			private bool? isHotfixVersion;

			private string engine;

			private string releaseType;

			private string statusDesc;

			private string engineVersion;

			private string minorVersion;

			private string communityMinorVersion;

			private string tag;

			private string expireStatus;

			private string expireDate;

			[JsonProperty(PropertyName = "ReleaseNote")]
			public string ReleaseNote
			{
				get
				{
					return releaseNote;
				}
				set	
				{
					releaseNote = value;
				}
			}

			[JsonProperty(PropertyName = "NodeType")]
			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			[JsonProperty(PropertyName = "IsHotfixVersion")]
			public bool? IsHotfixVersion
			{
				get
				{
					return isHotfixVersion;
				}
				set	
				{
					isHotfixVersion = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			[JsonProperty(PropertyName = "ReleaseType")]
			public string ReleaseType
			{
				get
				{
					return releaseType;
				}
				set	
				{
					releaseType = value;
				}
			}

			[JsonProperty(PropertyName = "StatusDesc")]
			public string StatusDesc
			{
				get
				{
					return statusDesc;
				}
				set	
				{
					statusDesc = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			[JsonProperty(PropertyName = "MinorVersion")]
			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
				}
			}

			[JsonProperty(PropertyName = "CommunityMinorVersion")]
			public string CommunityMinorVersion
			{
				get
				{
					return communityMinorVersion;
				}
				set	
				{
					communityMinorVersion = value;
				}
			}

			[JsonProperty(PropertyName = "Tag")]
			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			[JsonProperty(PropertyName = "ExpireStatus")]
			public string ExpireStatus
			{
				get
				{
					return expireStatus;
				}
				set	
				{
					expireStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ExpireDate")]
			public string ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}
		}
	}
}
