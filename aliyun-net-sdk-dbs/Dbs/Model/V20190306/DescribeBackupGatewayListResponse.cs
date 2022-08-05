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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeBackupGatewayListResponse : AcsResponse
	{

		private int? httpStatusCode;

		private int? pageNum;

		private string requestId;

		private string errCode;

		private bool? success;

		private string errMessage;

		private int? totalPages;

		private int? totalElements;

		private int? pageSize;

		private List<DescribeBackupGatewayList_BackupGateway> items;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

		public int? TotalElements
		{
			get
			{
				return totalElements;
			}
			set	
			{
				totalElements = value;
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

		public List<DescribeBackupGatewayList_BackupGateway> Items
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

		public class DescribeBackupGatewayList_BackupGateway
		{

			private string displayName;

			private long? backupGatewayCreateTime;

			private string backupGatewayId;

			private string region;

			private string identifier;

			private string sourceEndpointInternetIP;

			private string backupGatewayStatus;

			private string sourceEndpointIntranetIP;

			private long? lastHeartbeatTime;

			private string sourceEndpointHostname;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public long? BackupGatewayCreateTime
			{
				get
				{
					return backupGatewayCreateTime;
				}
				set	
				{
					backupGatewayCreateTime = value;
				}
			}

			public string BackupGatewayId
			{
				get
				{
					return backupGatewayId;
				}
				set	
				{
					backupGatewayId = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public string SourceEndpointInternetIP
			{
				get
				{
					return sourceEndpointInternetIP;
				}
				set	
				{
					sourceEndpointInternetIP = value;
				}
			}

			public string BackupGatewayStatus
			{
				get
				{
					return backupGatewayStatus;
				}
				set	
				{
					backupGatewayStatus = value;
				}
			}

			public string SourceEndpointIntranetIP
			{
				get
				{
					return sourceEndpointIntranetIP;
				}
				set	
				{
					sourceEndpointIntranetIP = value;
				}
			}

			public long? LastHeartbeatTime
			{
				get
				{
					return lastHeartbeatTime;
				}
				set	
				{
					lastHeartbeatTime = value;
				}
			}

			public string SourceEndpointHostname
			{
				get
				{
					return sourceEndpointHostname;
				}
				set	
				{
					sourceEndpointHostname = value;
				}
			}
		}
	}
}
