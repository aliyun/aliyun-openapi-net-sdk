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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class ListKmsInstancesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<ListKmsInstances_KmsInstance> kmsInstances;

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
		public long? TotalCount
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

		[JsonProperty(PropertyName = "PageNumber")]
		public long? PageNumber
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

		[JsonProperty(PropertyName = "PageSize")]
		public long? PageSize
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

		[JsonProperty(PropertyName = "KmsInstances")]
		public List<ListKmsInstances_KmsInstance> KmsInstances
		{
			get
			{
				return kmsInstances;
			}
			set	
			{
				kmsInstances = value;
			}
		}

		public class ListKmsInstances_KmsInstance
		{

			private string kmsInstanceArn;

			private string kmsInstanceId;

			[JsonProperty(PropertyName = "KmsInstanceArn")]
			public string KmsInstanceArn
			{
				get
				{
					return kmsInstanceArn;
				}
				set	
				{
					kmsInstanceArn = value;
				}
			}

			[JsonProperty(PropertyName = "KmsInstanceId")]
			public string KmsInstanceId
			{
				get
				{
					return kmsInstanceId;
				}
				set	
				{
					kmsInstanceId = value;
				}
			}
		}
	}
}
