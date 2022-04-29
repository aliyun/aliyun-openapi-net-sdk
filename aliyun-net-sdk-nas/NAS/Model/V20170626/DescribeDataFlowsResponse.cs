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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeDataFlowsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeDataFlows_DataFlow> dataFlowInfo;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeDataFlows_DataFlow> DataFlowInfo
		{
			get
			{
				return dataFlowInfo;
			}
			set	
			{
				dataFlowInfo = value;
			}
		}

		public class DescribeDataFlows_DataFlow
		{

			private string fileSystemId;

			private string dataFlowId;

			private string fsetId;

			private string status;

			private string errorMessage;

			private string sourceStorage;

			private string sourceSecurityType;

			private long? throughput;

			private string description;

			private string createTime;

			private string updateTime;

			private string fileSystemPath;

			private string fsetDescription;

			private long? autoRefreshInterval;

			private string autoRefreshPolicy;

			private List<DescribeDataFlows_AutoRefreshItem> autoRefresh;

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string DataFlowId
			{
				get
				{
					return dataFlowId;
				}
				set	
				{
					dataFlowId = value;
				}
			}

			public string FsetId
			{
				get
				{
					return fsetId;
				}
				set	
				{
					fsetId = value;
				}
			}

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

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string SourceStorage
			{
				get
				{
					return sourceStorage;
				}
				set	
				{
					sourceStorage = value;
				}
			}

			public string SourceSecurityType
			{
				get
				{
					return sourceSecurityType;
				}
				set	
				{
					sourceSecurityType = value;
				}
			}

			public long? Throughput
			{
				get
				{
					return throughput;
				}
				set	
				{
					throughput = value;
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string FileSystemPath
			{
				get
				{
					return fileSystemPath;
				}
				set	
				{
					fileSystemPath = value;
				}
			}

			public string FsetDescription
			{
				get
				{
					return fsetDescription;
				}
				set	
				{
					fsetDescription = value;
				}
			}

			public long? AutoRefreshInterval
			{
				get
				{
					return autoRefreshInterval;
				}
				set	
				{
					autoRefreshInterval = value;
				}
			}

			public string AutoRefreshPolicy
			{
				get
				{
					return autoRefreshPolicy;
				}
				set	
				{
					autoRefreshPolicy = value;
				}
			}

			public List<DescribeDataFlows_AutoRefreshItem> AutoRefresh
			{
				get
				{
					return autoRefresh;
				}
				set	
				{
					autoRefresh = value;
				}
			}

			public class DescribeDataFlows_AutoRefreshItem
			{

				private string refreshPath;

				public string RefreshPath
				{
					get
					{
						return refreshPath;
					}
					set	
					{
						refreshPath = value;
					}
				}
			}
		}
	}
}
