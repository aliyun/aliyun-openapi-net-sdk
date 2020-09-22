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
	public class DescribeDeviceResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string name;

		private string description;

		private string groupId;

		private string parentId;

		private string directoryId;

		private string type;

		private bool? autoStart;

		private bool? enabled;

		private string protocol;

		private string status;

		private string gbId;

		private string ip;

		private long? port;

		private string url;

		private string username;

		private string password;

		private string vendor;

		private string dsn;

		private string longitude;

		private string latitude;

		private bool? autoPos;

		private long? posInterval;

		private string alarmMethod;

		private string createdTime;

		private string registeredTime;

		private string channelSyncTime;

		private string _params;

		private DescribeDevice_Stats stats;

		private DescribeDevice_Directory directory;

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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
			}
		}

		public string DirectoryId
		{
			get
			{
				return directoryId;
			}
			set	
			{
				directoryId = value;
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

		public bool? AutoStart
		{
			get
			{
				return autoStart;
			}
			set	
			{
				autoStart = value;
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

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
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

		public long? Port
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

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
			}
		}

		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
			}
		}

		public string Dsn
		{
			get
			{
				return dsn;
			}
			set	
			{
				dsn = value;
			}
		}

		public string Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
			}
		}

		public string Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
			}
		}

		public bool? AutoPos
		{
			get
			{
				return autoPos;
			}
			set	
			{
				autoPos = value;
			}
		}

		public long? PosInterval
		{
			get
			{
				return posInterval;
			}
			set	
			{
				posInterval = value;
			}
		}

		public string AlarmMethod
		{
			get
			{
				return alarmMethod;
			}
			set	
			{
				alarmMethod = value;
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

		public string RegisteredTime
		{
			get
			{
				return registeredTime;
			}
			set	
			{
				registeredTime = value;
			}
		}

		public string ChannelSyncTime
		{
			get
			{
				return channelSyncTime;
			}
			set	
			{
				channelSyncTime = value;
			}
		}

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
			}
		}

		public DescribeDevice_Stats Stats
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

		public DescribeDevice_Directory Directory
		{
			get
			{
				return directory;
			}
			set	
			{
				directory = value;
			}
		}

		public class DescribeDevice_Stats
		{

			private long? channelNum;

			private long? streamNum;

			private long? onlineNum;

			private long? offlineNum;

			private long? failedNum;

			public long? ChannelNum
			{
				get
				{
					return channelNum;
				}
				set	
				{
					channelNum = value;
				}
			}

			public long? StreamNum
			{
				get
				{
					return streamNum;
				}
				set	
				{
					streamNum = value;
				}
			}

			public long? OnlineNum
			{
				get
				{
					return onlineNum;
				}
				set	
				{
					onlineNum = value;
				}
			}

			public long? OfflineNum
			{
				get
				{
					return offlineNum;
				}
				set	
				{
					offlineNum = value;
				}
			}

			public long? FailedNum
			{
				get
				{
					return failedNum;
				}
				set	
				{
					failedNum = value;
				}
			}
		}

		public class DescribeDevice_Directory
		{

			private string id;

			private string name;

			private string description;

			private string groupId;

			private string parentId;

			private string createdTime;

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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
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
		}
	}
}
