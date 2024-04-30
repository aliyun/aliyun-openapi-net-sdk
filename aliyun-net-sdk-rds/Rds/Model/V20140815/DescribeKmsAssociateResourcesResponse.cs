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
	public class DescribeKmsAssociateResourcesResponse : AcsResponse
	{

		private string requestId;

		private bool? associateStatus;

		private List<DescribeKmsAssociateResources_DBInstance> associateDBInstances;

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

		[JsonProperty(PropertyName = "AssociateStatus")]
		public bool? AssociateStatus
		{
			get
			{
				return associateStatus;
			}
			set	
			{
				associateStatus = value;
			}
		}

		[JsonProperty(PropertyName = "AssociateDBInstances")]
		public List<DescribeKmsAssociateResources_DBInstance> AssociateDBInstances
		{
			get
			{
				return associateDBInstances;
			}
			set	
			{
				associateDBInstances = value;
			}
		}

		public class DescribeKmsAssociateResources_DBInstance
		{

			private string dBInstanceName;

			private string engine;

			private string status;

			private string keyUsedBy;

			[JsonProperty(PropertyName = "DBInstanceName")]
			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "KeyUsedBy")]
			public string KeyUsedBy
			{
				get
				{
					return keyUsedBy;
				}
				set	
				{
					keyUsedBy = value;
				}
			}
		}
	}
}
