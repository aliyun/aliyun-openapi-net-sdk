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

namespace Aliyun.Acs.Cms.Model.V20170301
{
	public class NodeListResponse : AcsResponse
	{

		private int? errorCode;

		private string errorMessage;

		private bool? success;

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? pageTotal;

		private int? total;

		private List<NodeList_Node> nodes;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public int? PageNumber
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

		public int? PageTotal
		{
			get
			{
				return pageTotal;
			}
			set	
			{
				pageTotal = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<NodeList_Node> Nodes
		{
			get
			{
				return nodes;
			}
			set	
			{
				nodes = value;
			}
		}

		public class NodeList_Node
		{

			private string instanceId;

			private string serialNumber;

			private string hostName;

			private long? aliUid;

			private string operatingSystem;

			private string ipGroup;

			private string region;

			private string tianjimonVersion;

			private string eipAddress;

			private string eipId;

			private bool? aliyunHost;

			private string natIp;

			private string networkType;

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

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string OperatingSystem
			{
				get
				{
					return operatingSystem;
				}
				set	
				{
					operatingSystem = value;
				}
			}

			public string IpGroup
			{
				get
				{
					return ipGroup;
				}
				set	
				{
					ipGroup = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string TianjimonVersion
			{
				get
				{
					return tianjimonVersion;
				}
				set	
				{
					tianjimonVersion = value;
				}
			}

			public string EipAddress
			{
				get
				{
					return eipAddress;
				}
				set	
				{
					eipAddress = value;
				}
			}

			public string EipId
			{
				get
				{
					return eipId;
				}
				set	
				{
					eipId = value;
				}
			}

			public bool? AliyunHost
			{
				get
				{
					return aliyunHost;
				}
				set	
				{
					aliyunHost = value;
				}
			}

			public string NatIp
			{
				get
				{
					return natIp;
				}
				set	
				{
					natIp = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}
		}
	}
}