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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListResourceGroupsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private bool? success;

		private string requestId;

		private List<ListResourceGroups_DataItem> data;

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

		public List<ListResourceGroups_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListResourceGroups_DataItem
		{

			private string identifier;

			private string cluster;

			private string bizExtKey;

			private bool? enableKp;

			private string updateTime;

			private string resourceGroupType;

			private string mode;

			private int? sequence;

			private bool? isDefault;

			private string createTime;

			private string name;

			private long? tenantId;

			private long? id;

			private int? status;

			private string specs;

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

			public string Cluster
			{
				get
				{
					return cluster;
				}
				set	
				{
					cluster = value;
				}
			}

			public string BizExtKey
			{
				get
				{
					return bizExtKey;
				}
				set	
				{
					bizExtKey = value;
				}
			}

			public bool? EnableKp
			{
				get
				{
					return enableKp;
				}
				set	
				{
					enableKp = value;
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

			public string ResourceGroupType
			{
				get
				{
					return resourceGroupType;
				}
				set	
				{
					resourceGroupType = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public int? Sequence
			{
				get
				{
					return sequence;
				}
				set	
				{
					sequence = value;
				}
			}

			public bool? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

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

			public int? Status
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

			public string Specs
			{
				get
				{
					return specs;
				}
				set	
				{
					specs = value;
				}
			}
		}
	}
}
