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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeAuditLogsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAuditLogs_Log> items;

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

		public List<DescribeAuditLogs_Log> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAuditLogs_Log
		{

			private long? id;

			private string productCode;

			private long? productId;

			private long? logTime;

			private string userId;

			private string userName;

			private string clientIp;

			private string clientPort;

			private string clientUa;

			private string instanceName;

			private long? creationTime;

			private string databaseName;

			private string tableName;

			private string columnName;

			private string packageName;

			private string ossObjectKey;

			private long? executeTime;

			private long? effectRow;

			private string operateType;

			private string ruleId;

			private string ruleName;

			private string warnLevel;

			private int? executeStatus;

			public long? Id
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public long? ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public long? LogTime
			{
				get
				{
					return logTime;
				}
				set	
				{
					logTime = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			public string ClientPort
			{
				get
				{
					return clientPort;
				}
				set	
				{
					clientPort = value;
				}
			}

			public string ClientUa
			{
				get
				{
					return clientUa;
				}
				set	
				{
					clientUa = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

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

			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
				}
			}

			public string PackageName
			{
				get
				{
					return packageName;
				}
				set	
				{
					packageName = value;
				}
			}

			public string OssObjectKey
			{
				get
				{
					return ossObjectKey;
				}
				set	
				{
					ossObjectKey = value;
				}
			}

			public long? ExecuteTime
			{
				get
				{
					return executeTime;
				}
				set	
				{
					executeTime = value;
				}
			}

			public long? EffectRow
			{
				get
				{
					return effectRow;
				}
				set	
				{
					effectRow = value;
				}
			}

			public string OperateType
			{
				get
				{
					return operateType;
				}
				set	
				{
					operateType = value;
				}
			}

			public string RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

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

			public string WarnLevel
			{
				get
				{
					return warnLevel;
				}
				set	
				{
					warnLevel = value;
				}
			}

			public int? ExecuteStatus
			{
				get
				{
					return executeStatus;
				}
				set	
				{
					executeStatus = value;
				}
			}
		}
	}
}
