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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class QueryOssBucketsResponse : AcsResponse
	{

		private string requestId;

		private List<QueryOssBuckets_BucketItem> bucket;

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

		public List<QueryOssBuckets_BucketItem> Bucket
		{
			get
			{
				return bucket;
			}
			set	
			{
				bucket = value;
			}
		}

		public class QueryOssBuckets_BucketItem
		{

			private string name;

			private string location;

			private string storageClass;

			private long? extranetEndpoint;

			private long? intranetEndpoint;

			private string creationDate;

			private QueryOssBuckets_Owner owner;

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

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
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

			public long? ExtranetEndpoint
			{
				get
				{
					return extranetEndpoint;
				}
				set	
				{
					extranetEndpoint = value;
				}
			}

			public long? IntranetEndpoint
			{
				get
				{
					return intranetEndpoint;
				}
				set	
				{
					intranetEndpoint = value;
				}
			}

			public string CreationDate
			{
				get
				{
					return creationDate;
				}
				set	
				{
					creationDate = value;
				}
			}

			public QueryOssBuckets_Owner Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public class QueryOssBuckets_Owner
			{

				private string displayName;

				private string id;

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

				public string Id
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
			}
		}
	}
}