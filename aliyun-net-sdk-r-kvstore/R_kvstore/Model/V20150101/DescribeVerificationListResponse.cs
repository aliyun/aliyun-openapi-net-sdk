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
	public class DescribeVerificationListResponse : AcsResponse
	{

		private string requestId;

		private string replicaId;

		private int? pagNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeVerificationList_ItemsItem> items;

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

		public List<DescribeVerificationList_ItemsItem> Items
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

		public class DescribeVerificationList_ItemsItem
		{

			private string instanceIdA;

			private string instanceIdB;

			private string key;

			private string keyType;

			private string inconsistentType;

			private string occurTime;

			private string schema;

			private string inconsistentFields;

			public string InstanceIdA
			{
				get
				{
					return instanceIdA;
				}
				set	
				{
					instanceIdA = value;
				}
			}

			public string InstanceIdB
			{
				get
				{
					return instanceIdB;
				}
				set	
				{
					instanceIdB = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string KeyType
			{
				get
				{
					return keyType;
				}
				set	
				{
					keyType = value;
				}
			}

			public string InconsistentType
			{
				get
				{
					return inconsistentType;
				}
				set	
				{
					inconsistentType = value;
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

			public string Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

			public string InconsistentFields
			{
				get
				{
					return inconsistentFields;
				}
				set	
				{
					inconsistentFields = value;
				}
			}
		}
	}
}
