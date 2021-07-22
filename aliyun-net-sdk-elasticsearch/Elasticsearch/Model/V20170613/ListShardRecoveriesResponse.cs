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
	public class ListShardRecoveriesResponse : AcsResponse
	{

		private string requestId;

		private List<ListShardRecoveries_ResultItem> result;

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

		public List<ListShardRecoveries_ResultItem> Result
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

		public class ListShardRecoveries_ResultItem
		{

			private string index;

			private string sourceHost;

			private string targetNode;

			private string stage;

			private long? filesTotal;

			private string filesPercent;

			private long? bytesTotal;

			private string bytesPercent;

			private long? translogOps;

			private string translogOpsPercent;

			private string sourceNode;

			private string targetHost;

			public string Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public string SourceHost
			{
				get
				{
					return sourceHost;
				}
				set	
				{
					sourceHost = value;
				}
			}

			public string TargetNode
			{
				get
				{
					return targetNode;
				}
				set	
				{
					targetNode = value;
				}
			}

			public string Stage
			{
				get
				{
					return stage;
				}
				set	
				{
					stage = value;
				}
			}

			public long? FilesTotal
			{
				get
				{
					return filesTotal;
				}
				set	
				{
					filesTotal = value;
				}
			}

			public string FilesPercent
			{
				get
				{
					return filesPercent;
				}
				set	
				{
					filesPercent = value;
				}
			}

			public long? BytesTotal
			{
				get
				{
					return bytesTotal;
				}
				set	
				{
					bytesTotal = value;
				}
			}

			public string BytesPercent
			{
				get
				{
					return bytesPercent;
				}
				set	
				{
					bytesPercent = value;
				}
			}

			public long? TranslogOps
			{
				get
				{
					return translogOps;
				}
				set	
				{
					translogOps = value;
				}
			}

			public string TranslogOpsPercent
			{
				get
				{
					return translogOpsPercent;
				}
				set	
				{
					translogOpsPercent = value;
				}
			}

			public string SourceNode
			{
				get
				{
					return sourceNode;
				}
				set	
				{
					sourceNode = value;
				}
			}

			public string TargetHost
			{
				get
				{
					return targetHost;
				}
				set	
				{
					targetHost = value;
				}
			}
		}
	}
}
