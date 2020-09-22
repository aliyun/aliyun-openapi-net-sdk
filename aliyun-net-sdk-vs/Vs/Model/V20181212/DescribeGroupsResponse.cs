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
	public class DescribeGroupsResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNum;

		private long? pageCount;

		private long? totalCount;

		private List<DescribeGroups_Group> groups;

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

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public long? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
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

		public List<DescribeGroups_Group> Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
			}
		}

		public class DescribeGroups_Group
		{

			private string id;

			private string aliasId;

			private string name;

			private string description;

			private string app;

			private string region;

			private string inProtocol;

			private string outProtocol;

			private bool? enabled;

			private string status;

			private string createdTime;

			private string pushDomain;

			private string playDomain;

			private bool? lazyPull;

			private string callback;

			private int? captureInterval;

			private int? captureImage;

			private int? captureVideo;

			private string captureOssBucket;

			private string captureOssPath;

			private string gbId;

			private string gbIp;

			private long? gbPort;

			private List<string> gbUdpPorts;

			private List<string> gbTcpPorts;

			private DescribeGroups_Stats stats;

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

			public string AliasId
			{
				get
				{
					return aliasId;
				}
				set	
				{
					aliasId = value;
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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
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

			public string InProtocol
			{
				get
				{
					return inProtocol;
				}
				set	
				{
					inProtocol = value;
				}
			}

			public string OutProtocol
			{
				get
				{
					return outProtocol;
				}
				set	
				{
					outProtocol = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string PushDomain
			{
				get
				{
					return pushDomain;
				}
				set	
				{
					pushDomain = value;
				}
			}

			public string PlayDomain
			{
				get
				{
					return playDomain;
				}
				set	
				{
					playDomain = value;
				}
			}

			public bool? LazyPull
			{
				get
				{
					return lazyPull;
				}
				set	
				{
					lazyPull = value;
				}
			}

			public string Callback
			{
				get
				{
					return callback;
				}
				set	
				{
					callback = value;
				}
			}

			public int? CaptureInterval
			{
				get
				{
					return captureInterval;
				}
				set	
				{
					captureInterval = value;
				}
			}

			public int? CaptureImage
			{
				get
				{
					return captureImage;
				}
				set	
				{
					captureImage = value;
				}
			}

			public int? CaptureVideo
			{
				get
				{
					return captureVideo;
				}
				set	
				{
					captureVideo = value;
				}
			}

			public string CaptureOssBucket
			{
				get
				{
					return captureOssBucket;
				}
				set	
				{
					captureOssBucket = value;
				}
			}

			public string CaptureOssPath
			{
				get
				{
					return captureOssPath;
				}
				set	
				{
					captureOssPath = value;
				}
			}

			public string GbId
			{
				get
				{
					return gbId;
				}
				set	
				{
					gbId = value;
				}
			}

			public string GbIp
			{
				get
				{
					return gbIp;
				}
				set	
				{
					gbIp = value;
				}
			}

			public long? GbPort
			{
				get
				{
					return gbPort;
				}
				set	
				{
					gbPort = value;
				}
			}

			public List<string> GbUdpPorts
			{
				get
				{
					return gbUdpPorts;
				}
				set	
				{
					gbUdpPorts = value;
				}
			}

			public List<string> GbTcpPorts
			{
				get
				{
					return gbTcpPorts;
				}
				set	
				{
					gbTcpPorts = value;
				}
			}

			public DescribeGroups_Stats Stats
			{
				get
				{
					return stats;
				}
				set	
				{
					stats = value;
				}
			}

			public class DescribeGroups_Stats
			{

				private long? deviceNum;

				private long? iedNum;

				private long? ipcNum;

				private long? platformNum;

				public long? DeviceNum
				{
					get
					{
						return deviceNum;
					}
					set	
					{
						deviceNum = value;
					}
				}

				public long? IedNum
				{
					get
					{
						return iedNum;
					}
					set	
					{
						iedNum = value;
					}
				}

				public long? IpcNum
				{
					get
					{
						return ipcNum;
					}
					set	
					{
						ipcNum = value;
					}
				}

				public long? PlatformNum
				{
					get
					{
						return platformNum;
					}
					set	
					{
						platformNum = value;
					}
				}
			}
		}
	}
}
