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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class TracePushResponse : AcsResponse
	{

		private PushBasicInfo_ pushBasicInfo;

		private PushTaskInfo_ pushTaskInfo;

		private PushDeviceInfo_ pushDeviceInfo;

		public PushBasicInfo_ PushBasicInfo
		{
			get
			{
				return pushBasicInfo;
			}
			set	
			{
				pushBasicInfo = value;
			}
		}

		public PushTaskInfo_ PushTaskInfo
		{
			get
			{
				return pushTaskInfo;
			}
			set	
			{
				pushTaskInfo = value;
			}
		}

		public PushDeviceInfo_ PushDeviceInfo
		{
			get
			{
				return pushDeviceInfo;
			}
			set	
			{
				pushDeviceInfo = value;
			}
		}

		public class PushBasicInfo_{

			private long? appId;

			private string title;

			private string targetType;

			private string pushType;

			private string pushTime;

			private string expireTime;

			public long? AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}

			public string PushType
			{
				get
				{
					return pushType;
				}
				set	
				{
					pushType = value;
				}
			}

			public string PushTime
			{
				get
				{
					return pushTime;
				}
				set	
				{
					pushTime = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}
		}

		public class PushTaskInfo_{

			private bool? broadcast;

			private string acceptTime;

			private string androidTaskStatus;

			private string iOSTaskStatus;

			private string androidTaskErrCode;

			private string iOSTaskErrCode;

			private List<string> deviceSet;

			public bool? Broadcast
			{
				get
				{
					return broadcast;
				}
				set	
				{
					broadcast = value;
				}
			}

			public string AcceptTime
			{
				get
				{
					return acceptTime;
				}
				set	
				{
					acceptTime = value;
				}
			}

			public string AndroidTaskStatus
			{
				get
				{
					return androidTaskStatus;
				}
				set	
				{
					androidTaskStatus = value;
				}
			}

			public string IOSTaskStatus
			{
				get
				{
					return iOSTaskStatus;
				}
				set	
				{
					iOSTaskStatus = value;
				}
			}

			public string AndroidTaskErrCode
			{
				get
				{
					return androidTaskErrCode;
				}
				set	
				{
					androidTaskErrCode = value;
				}
			}

			public string IOSTaskErrCode
			{
				get
				{
					return iOSTaskErrCode;
				}
				set	
				{
					iOSTaskErrCode = value;
				}
			}

			public List<string> DeviceSet
			{
				get
				{
					return deviceSet;
				}
				set	
				{
					deviceSet = value;
				}
			}
		}

		public class PushDeviceInfo_{

			private bool? online;

			private string createTime;

			private string sentTime;

			private string arriveTime;

			private string clickTime;

			private string cleanTime;

			private string deviceStatus;

			private string deviceErrCode;

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
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

			public string SentTime
			{
				get
				{
					return sentTime;
				}
				set	
				{
					sentTime = value;
				}
			}

			public string ArriveTime
			{
				get
				{
					return arriveTime;
				}
				set	
				{
					arriveTime = value;
				}
			}

			public string ClickTime
			{
				get
				{
					return clickTime;
				}
				set	
				{
					clickTime = value;
				}
			}

			public string CleanTime
			{
				get
				{
					return cleanTime;
				}
				set	
				{
					cleanTime = value;
				}
			}

			public string DeviceStatus
			{
				get
				{
					return deviceStatus;
				}
				set	
				{
					deviceStatus = value;
				}
			}

			public string DeviceErrCode
			{
				get
				{
					return deviceErrCode;
				}
				set	
				{
					deviceErrCode = value;
				}
			}
		}
	}
}