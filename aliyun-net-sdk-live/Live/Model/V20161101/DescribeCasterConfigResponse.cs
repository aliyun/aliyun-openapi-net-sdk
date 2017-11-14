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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCasterConfigResponse : AcsResponse
	{

		private string requestId;

		private string casterId;

		private string casterName;

		private string domainName;

		private float? delay;

		private string urgentMaterialId;

		private DescribeCasterConfig_TranscodeConfig transcodeConfig;

		private DescribeCasterConfig_RecordConfig recordConfig;

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

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
			}
		}

		public string CasterName
		{
			get
			{
				return casterName;
			}
			set	
			{
				casterName = value;
			}
		}

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

		public float? Delay
		{
			get
			{
				return delay;
			}
			set	
			{
				delay = value;
			}
		}

		public string UrgentMaterialId
		{
			get
			{
				return urgentMaterialId;
			}
			set	
			{
				urgentMaterialId = value;
			}
		}

		public DescribeCasterConfig_TranscodeConfig TranscodeConfig
		{
			get
			{
				return transcodeConfig;
			}
			set	
			{
				transcodeConfig = value;
			}
		}

		public DescribeCasterConfig_RecordConfig RecordConfig
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

		public class DescribeCasterConfig_TranscodeConfig
		{

			private string casterTemplate;

			private List<string> liveTemplateIds;

			public string CasterTemplate
			{
				get
				{
					return casterTemplate;
				}
				set	
				{
					casterTemplate = value;
				}
			}

			public List<string> LiveTemplateIds
			{
				get
				{
					return liveTemplateIds;
				}
				set	
				{
					liveTemplateIds = value;
				}
			}
		}

		public class DescribeCasterConfig_RecordConfig
		{

			private string ossEndpoint;

			private string ossBucket;

			private List<DescribeCasterConfig_RecordFormatItem> recordFormat;

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

			public List<DescribeCasterConfig_RecordFormatItem> RecordFormat
			{
				get
				{
					return recordFormat;
				}
				set	
				{
					recordFormat = value;
				}
			}

			public class DescribeCasterConfig_RecordFormatItem
			{

				private string format;

				private string ossObjectPrefix;

				private string sliceOssObjectPrefix;

				private int? cycleDuration;

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public string OssObjectPrefix
				{
					get
					{
						return ossObjectPrefix;
					}
					set	
					{
						ossObjectPrefix = value;
					}
				}

				public string SliceOssObjectPrefix
				{
					get
					{
						return sliceOssObjectPrefix;
					}
					set	
					{
						sliceOssObjectPrefix = value;
					}
				}

				public int? CycleDuration
				{
					get
					{
						return cycleDuration;
					}
					set	
					{
						cycleDuration = value;
					}
				}
			}
		}
	}
}