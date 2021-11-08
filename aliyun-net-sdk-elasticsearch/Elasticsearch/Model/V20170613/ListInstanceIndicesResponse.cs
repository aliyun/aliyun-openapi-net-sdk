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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListInstanceIndicesResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstanceIndices_ResultItem> result;

		private ListInstanceIndices_Headers headers;

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

		public List<ListInstanceIndices_ResultItem> Result
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

		public ListInstanceIndices_Headers Headers
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

		public class ListInstanceIndices_ResultItem
		{

			private string isManaged;

			private string createTime;

			private long? size;

			private string managedStatus;

			private string name;

			private string health;

			private string phase;

			private string ilmExplain;

			public string IsManaged
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

			public string Phase
			{
				get
				{
					return phase;
				}
				set	
				{
					phase = value;
				}
			}

			public string IlmExplain
			{
				get
				{
					return ilmExplain;
				}
				set	
				{
					ilmExplain = value;
				}
			}
		}

		public class ListInstanceIndices_Headers
		{

			private long? xManagedStorageSize;

			private int? xManagedCount;

			private long? xOSSStorageSize;

			private int? xOSSCount;

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

			public long? XOSSStorageSize
			{
				get
				{
					return xOSSStorageSize;
				}
				set	
				{
					xOSSStorageSize = value;
				}
			}

			public int? XOSSCount
			{
				get
				{
					return xOSSCount;
				}
				set	
				{
					xOSSCount = value;
				}
			}
		}
	}
}
