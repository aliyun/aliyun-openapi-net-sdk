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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class ListBucketsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<ListBuckets_BucketInfo> bucketInfos;

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

		public List<ListBuckets_BucketInfo> BucketInfos
		{
			get
			{
				return bucketInfos;
			}
			set	
			{
				bucketInfos = value;
			}
		}

		public class ListBuckets_BucketInfo
		{

			private string bucketName;

			private string comment;

			private string bucketAcl;

			private string dataRedundancyType;

			private string storageClass;

			private string dispatcherType;

			private string resourceType;

			private string createTime;

			private string modifyTime;

			private string endpoint;

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string BucketAcl
			{
				get
				{
					return bucketAcl;
				}
				set	
				{
					bucketAcl = value;
				}
			}

			public string DataRedundancyType
			{
				get
				{
					return dataRedundancyType;
				}
				set	
				{
					dataRedundancyType = value;
				}
			}

			public string StorageClass
			{
				get
				{
					return storageClass;
				}
				set	
				{
					storageClass = value;
				}
			}

			public string DispatcherType
			{
				get
				{
					return dispatcherType;
				}
				set	
				{
					dispatcherType = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
				}
			}
		}
	}
}
