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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeReplicaConflictInfoResponse : AcsResponse
	{

		private string requestId;

		private string replicaId;

		private int? pagNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeReplicaConflictInfo_ItemsItem> items;

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

		public string ReplicaId
		{
			get
			{
				return replicaId;
			}
			set	
			{
				replicaId = value;
			}
		}

		public int? PagNumber
		{
			get
			{
				return pagNumber;
			}
			set	
			{
				pagNumber = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<DescribeReplicaConflictInfo_ItemsItem> Items
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

		public class DescribeReplicaConflictInfo_ItemsItem
		{

			private string sourceInstanceId;

			private string destinationInstanceId;

			private string occurTime;

			private string detailInfo;

			private string confictKey;

			private string confictReason;

			private string databaseName;

			private string recoveryMode;

			private string conflictGtid;

			public string SourceInstanceId
			{
				get
				{
					return sourceInstanceId;
				}
				set	
				{
					sourceInstanceId = value;
				}
			}

			public string DestinationInstanceId
			{
				get
				{
					return destinationInstanceId;
				}
				set	
				{
					destinationInstanceId = value;
				}
			}

			public string OccurTime
			{
				get
				{
					return occurTime;
				}
				set	
				{
					occurTime = value;
				}
			}

			public string DetailInfo
			{
				get
				{
					return detailInfo;
				}
				set	
				{
					detailInfo = value;
				}
			}

			public string ConfictKey
			{
				get
				{
					return confictKey;
				}
				set	
				{
					confictKey = value;
				}
			}

			public string ConfictReason
			{
				get
				{
					return confictReason;
				}
				set	
				{
					confictReason = value;
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

			public string RecoveryMode
			{
				get
				{
					return recoveryMode;
				}
				set	
				{
					recoveryMode = value;
				}
			}

			public string ConflictGtid
			{
				get
				{
					return conflictGtid;
				}
				set	
				{
					conflictGtid = value;
				}
			}
		}
	}
}
