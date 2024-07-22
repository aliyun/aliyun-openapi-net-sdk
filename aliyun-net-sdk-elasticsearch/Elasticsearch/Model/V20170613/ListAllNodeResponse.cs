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
	public class ListAllNodeResponse : AcsResponse
	{

		private string requestId;

		private List<ListAllNode_ResultItem> result;

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

		public List<ListAllNode_ResultItem> Result
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

		public class ListAllNode_ResultItem
		{

			private string heapPercent;

			private string zoneId;

			private string hostName;

			private string cpuPercent;

			private string host;

			private string nodeType;

			private string diskUsedPercent;

			private int? port;

			private string loadOneM;

			private string health;

			public string HeapPercent
			{
				get
				{
					return heapPercent;
				}
				set	
				{
					heapPercent = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public string CpuPercent
			{
				get
				{
					return cpuPercent;
				}
				set	
				{
					cpuPercent = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string DiskUsedPercent
			{
				get
				{
					return diskUsedPercent;
				}
				set	
				{
					diskUsedPercent = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string LoadOneM
			{
				get
				{
					return loadOneM;
				}
				set	
				{
					loadOneM = value;
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
}
