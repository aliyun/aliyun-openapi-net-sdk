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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRecordTemplatesResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? totalPage;

		private List<DescribeRecordTemplates_Template> templates;

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

		public long? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public long? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<DescribeRecordTemplates_Template> Templates
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

		public class DescribeRecordTemplates_Template
		{

			private string createTime;

			private string templateId;

			private string name;

			private int? mediaEncode;

			private int? backgroundColor;

			private int? fileSplitInterval;

			private string taskProfile;

			private string ossBucket;

			private string ossFilePrefix;

			private string mnsQueue;

			private List<string> layoutIds;

			private List<string> formats;

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

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
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

			public int? MediaEncode
			{
				get
				{
					return mediaEncode;
				}
				set	
				{
					mediaEncode = value;
				}
			}

			public int? BackgroundColor
			{
				get
				{
					return backgroundColor;
				}
				set	
				{
					backgroundColor = value;
				}
			}

			public int? FileSplitInterval
			{
				get
				{
					return fileSplitInterval;
				}
				set	
				{
					fileSplitInterval = value;
				}
			}

			public string TaskProfile
			{
				get
				{
					return taskProfile;
				}
				set	
				{
					taskProfile = value;
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

			public string MnsQueue
			{
				get
				{
					return mnsQueue;
				}
				set	
				{
					mnsQueue = value;
				}
			}

			public List<string> LayoutIds
			{
				get
				{
					return layoutIds;
				}
				set	
				{
					layoutIds = value;
				}
			}

			public List<string> Formats
			{
				get
				{
					return formats;
				}
				set	
				{
					formats = value;
				}
			}
		}
	}
}
