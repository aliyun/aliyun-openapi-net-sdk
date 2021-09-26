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
	public class DescribeNodeDevicesInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeNodeDevicesInfo_NodeDevice> nodeDevices;

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

		public List<DescribeNodeDevicesInfo_NodeDevice> NodeDevices
		{
			get
			{
				return nodeDevices;
			}
			set	
			{
				nodeDevices = value;
			}
		}

		public class DescribeNodeDevicesInfo_NodeDevice
		{

			private string nodeName;

			private List<DescribeNodeDevicesInfo_DeviceInfo> deviceInfos;

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public List<DescribeNodeDevicesInfo_DeviceInfo> DeviceInfos
			{
				get
				{
					return deviceInfos;
				}
				set	
				{
					deviceInfos = value;
				}
			}

			public class DescribeNodeDevicesInfo_DeviceInfo
			{

				private string instanceId;

				private string name;

				private string iP;

				private string server;

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

				public string IP
				{
					get
					{
						return iP;
					}
					set	
					{
						iP = value;
					}
				}

				public string Server
				{
					get
					{
						return server;
					}
					set	
					{
						server = value;
					}
				}
			}
		}
	}
}
