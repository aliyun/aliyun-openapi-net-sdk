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
	public class DescribeTemplatesResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNum;

		private long? pageCount;

		private long? totalCount;

		private List<DescribeTemplates_Template> templates;

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

		public List<DescribeTemplates_Template> Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public class DescribeTemplates_Template
		{

			private string id;

			private string name;

			private string description;

			private string type;

			private string region;

			private string ossBucket;

			private string ossEndpoint;

			private string ossFilePrefix;

			private string trigger;

			private string startTime;

			private string endTime;

			private long? interval;

			private long? retention;

			private string fileFormat;

			private string jpgOverwrite;

			private string jpgSequence;

			private string jpgOnDemand;

			private string mp4;

			private string flv;

			private string hlsM3u8;

			private string hlsTs;

			private string callback;

			private string createdTime;

			private List<DescribeTemplates_TransConfig> transConfigs;

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

			public string OssFilePrefix
			{
				get
				{
					return ossFilePrefix;
				}
				set	
				{
					ossFilePrefix = value;
				}
			}

			public string Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public long? Retention
			{
				get
				{
					return retention;
				}
				set	
				{
					retention = value;
				}
			}

			public string FileFormat
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

			public string JpgOverwrite
			{
				get
				{
					return jpgOverwrite;
				}
				set	
				{
					jpgOverwrite = value;
				}
			}

			public string JpgSequence
			{
				get
				{
					return jpgSequence;
				}
				set	
				{
					jpgSequence = value;
				}
			}

			public string JpgOnDemand
			{
				get
				{
					return jpgOnDemand;
				}
				set	
				{
					jpgOnDemand = value;
				}
			}

			public string Mp4
			{
				get
				{
					return mp4;
				}
				set	
				{
					mp4 = value;
				}
			}

			public string Flv
			{
				get
				{
					return flv;
				}
				set	
				{
					flv = value;
				}
			}

			public string HlsM3u8
			{
				get
				{
					return hlsM3u8;
				}
				set	
				{
					hlsM3u8 = value;
				}
			}

			public string HlsTs
			{
				get
				{
					return hlsTs;
				}
				set	
				{
					hlsTs = value;
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

			public List<DescribeTemplates_TransConfig> TransConfigs
			{
				get
				{
					return transConfigs;
				}
				set	
				{
					transConfigs = value;
				}
			}

			public class DescribeTemplates_TransConfig
			{

				private string id;

				private string name;

				private string videoCodec;

				private long? videoBitrate;

				private long? fps;

				private long? gop;

				private long? height;

				private long? width;

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

				public string VideoCodec
				{
					get
					{
						return videoCodec;
					}
					set	
					{
						videoCodec = value;
					}
				}

				public long? VideoBitrate
				{
					get
					{
						return videoBitrate;
					}
					set	
					{
						videoBitrate = value;
					}
				}

				public long? Fps
				{
					get
					{
						return fps;
					}
					set	
					{
						fps = value;
					}
				}

				public long? Gop
				{
					get
					{
						return gop;
					}
					set	
					{
						gop = value;
					}
				}

				public long? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public long? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}
			}
		}
	}
}
