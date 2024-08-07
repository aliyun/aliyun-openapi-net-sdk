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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListDataStreamsResponse : AcsResponse
	{

		private string requestId;

		private List<ListDataStreams_ResultItem> result;

		private ListDataStreams_Headers headers;

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

		public List<ListDataStreams_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public ListDataStreams_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListDataStreams_ResultItem
		{

			private long? totalStorageSize;

			private string indexTemplateName;

			private string ilmPolicyName;

			private string name;

			private string health;

			private long? managedStorageSize;

			private List<ListDataStreams_IndicesItem> indices;

			public long? TotalStorageSize
			{
				get
				{
					return totalStorageSize;
				}
				set	
				{
					totalStorageSize = value;
				}
			}

			public string IndexTemplateName
			{
				get
				{
					return indexTemplateName;
				}
				set	
				{
					indexTemplateName = value;
				}
			}

			public string IlmPolicyName
			{
				get
				{
					return ilmPolicyName;
				}
				set	
				{
					ilmPolicyName = value;
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

			public string Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public long? ManagedStorageSize
			{
				get
				{
					return managedStorageSize;
				}
				set	
				{
					managedStorageSize = value;
				}
			}

			public List<ListDataStreams_IndicesItem> Indices
			{
				get
				{
					return indices;
				}
				set	
				{
					indices = value;
				}
			}

			public class ListDataStreams_IndicesItem
			{

				private bool? isManaged;

				private string createTime;

				private long? size;

				private string managedStatus;

				private string name;

				private string health;

				public bool? IsManaged
				{
					get
					{
						return isManaged;
					}
					set	
					{
						isManaged = value;
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

				public long? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string ManagedStatus
				{
					get
					{
						return managedStatus;
					}
					set	
					{
						managedStatus = value;
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

				public string Health
				{
					get
					{
						return health;
					}
					set	
					{
						health = value;
					}
				}
			}
		}

		public class ListDataStreams_Headers
		{

			private long? xManagedStorageSize;

			private int? xManagedCount;

			public long? XManagedStorageSize
			{
				get
				{
					return xManagedStorageSize;
				}
				set	
				{
					xManagedStorageSize = value;
				}
			}

			public int? XManagedCount
			{
				get
				{
					return xManagedCount;
				}
				set	
				{
					xManagedCount = value;
				}
			}
		}
	}
}
