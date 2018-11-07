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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class GetTemplateInfoResponse : AcsResponse
	{

		private string requestId;

		private int? mixMode;

		private int? serviceMode;

		private string callBack;

		private int? maxMixStreamCount;

		private int? mediaConfig;

		private GetTemplateInfo_LayOut layOut;

		private GetTemplateInfo_RecordConfig recordConfig;

		private GetTemplateInfo_LiveConfig liveConfig;

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

		public int? MixMode
		{
			get
			{
				return mixMode;
			}
			set	
			{
				mixMode = value;
			}
		}

		public int? ServiceMode
		{
			get
			{
				return serviceMode;
			}
			set	
			{
				serviceMode = value;
			}
		}

		public string CallBack
		{
			get
			{
				return callBack;
			}
			set	
			{
				callBack = value;
			}
		}

		public int? MaxMixStreamCount
		{
			get
			{
				return maxMixStreamCount;
			}
			set	
			{
				maxMixStreamCount = value;
			}
		}

		public int? MediaConfig
		{
			get
			{
				return mediaConfig;
			}
			set	
			{
				mediaConfig = value;
			}
		}

		public GetTemplateInfo_LayOut LayOut
		{
			get
			{
				return layOut;
			}
			set	
			{
				layOut = value;
			}
		}

		public GetTemplateInfo_RecordConfig RecordConfig
		{
			get
			{
				return recordConfig;
			}
			set	
			{
				recordConfig = value;
			}
		}

		public GetTemplateInfo_LiveConfig LiveConfig
		{
			get
			{
				return liveConfig;
			}
			set	
			{
				liveConfig = value;
			}
		}

		public class GetTemplateInfo_LayOut
		{

			private string color;

			private int? cutmode;

			private int? layoutID;

			public string Color
			{
				get
				{
					return color;
				}
				set	
				{
					color = value;
				}
			}

			public int? Cutmode
			{
				get
				{
					return cutmode;
				}
				set	
				{
					cutmode = value;
				}
			}

			public int? LayoutID
			{
				get
				{
					return layoutID;
				}
				set	
				{
					layoutID = value;
				}
			}
		}

		public class GetTemplateInfo_RecordConfig
		{

			private string storageType;

			private int? fileFormat;

			private string ossEndpoint;

			private string ossBucket;

			private int? vodTranscodeGroupId;

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public int? FileFormat
			{
				get
				{
					return fileFormat;
				}
				set	
				{
					fileFormat = value;
				}
			}

			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			public int? VodTranscodeGroupId
			{
				get
				{
					return vodTranscodeGroupId;
				}
				set	
				{
					vodTranscodeGroupId = value;
				}
			}
		}

		public class GetTemplateInfo_LiveConfig
		{

			private string domainName;

			private string appName;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}
		}
	}
}