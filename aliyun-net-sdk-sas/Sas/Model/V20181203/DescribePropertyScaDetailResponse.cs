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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribePropertyScaDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePropertyScaDetail_PropertySca> propertys;

		private DescribePropertyScaDetail_PageInfo pageInfo;

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

		public List<DescribePropertyScaDetail_PropertySca> Propertys
		{
			get
			{
				return propertys;
			}
			set	
			{
				propertys = value;
			}
		}

		public DescribePropertyScaDetail_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribePropertyScaDetail_PropertySca
		{

			private string instanceName;

			private string ip;

			private string create;

			private long? createTimestamp;

			private string uuid;

			private string instanceId;

			private string intranetIp;

			private string internetIp;

			private string name;

			private string type;

			private string version;

			private string pid;

			private string bizType;

			private string bizTypeDispaly;

			private string port;

			private string containerName;

			private string path;

			private string ppid;

			private string processUser;

			private string listenIp;

			private string listenStatus;

			private string listenProtocol;

			private long? processStarted;

			private string cmdline;

			private string configPath;

			private string webPath;

			private string proof;

			private string imageName;

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string Pid
			{
				get
				{
					return pid;
				}
				set	
				{
					pid = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BizTypeDispaly
			{
				get
				{
					return bizTypeDispaly;
				}
				set	
				{
					bizTypeDispaly = value;
				}
			}

			public string Port
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

			public string ContainerName
			{
				get
				{
					return containerName;
				}
				set	
				{
					containerName = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string Ppid
			{
				get
				{
					return ppid;
				}
				set	
				{
					ppid = value;
				}
			}

			public string ProcessUser
			{
				get
				{
					return processUser;
				}
				set	
				{
					processUser = value;
				}
			}

			public string ListenIp
			{
				get
				{
					return listenIp;
				}
				set	
				{
					listenIp = value;
				}
			}

			public string ListenStatus
			{
				get
				{
					return listenStatus;
				}
				set	
				{
					listenStatus = value;
				}
			}

			public string ListenProtocol
			{
				get
				{
					return listenProtocol;
				}
				set	
				{
					listenProtocol = value;
				}
			}

			public long? ProcessStarted
			{
				get
				{
					return processStarted;
				}
				set	
				{
					processStarted = value;
				}
			}

			public string Cmdline
			{
				get
				{
					return cmdline;
				}
				set	
				{
					cmdline = value;
				}
			}

			public string ConfigPath
			{
				get
				{
					return configPath;
				}
				set	
				{
					configPath = value;
				}
			}

			public string WebPath
			{
				get
				{
					return webPath;
				}
				set	
				{
					webPath = value;
				}
			}

			public string Proof
			{
				get
				{
					return proof;
				}
				set	
				{
					proof = value;
				}
			}

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}
		}

		public class DescribePropertyScaDetail_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public int? PageSize
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

			public int? TotalCount
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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
