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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssIncrementCheckSettingResponse : AcsResponse
	{

		private string requestId;

		private bool? imageEnableLimit;

		private long? imageScanLimit;

		private int? videoFrameInterval;

		private int? videoMaxFrames;

		private int? videoMaxSize;

		private string autoFreezeType;

		private string callbackId;

		private string callbackName;

		private List<DescribeOssIncrementCheckSetting_BucketConfig> bucketConfigList;

		private List<string> imageSceneList;

		private List<string> videoSceneList;

		private List<string> videoAutoFreezeSceneList;

		private DescribeOssIncrementCheckSetting_ImageAutoFreeze imageAutoFreeze;

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

		public bool? ImageEnableLimit
		{
			get
			{
				return imageEnableLimit;
			}
			set	
			{
				imageEnableLimit = value;
			}
		}

		public long? ImageScanLimit
		{
			get
			{
				return imageScanLimit;
			}
			set	
			{
				imageScanLimit = value;
			}
		}

		public int? VideoFrameInterval
		{
			get
			{
				return videoFrameInterval;
			}
			set	
			{
				videoFrameInterval = value;
			}
		}

		public int? VideoMaxFrames
		{
			get
			{
				return videoMaxFrames;
			}
			set	
			{
				videoMaxFrames = value;
			}
		}

		public int? VideoMaxSize
		{
			get
			{
				return videoMaxSize;
			}
			set	
			{
				videoMaxSize = value;
			}
		}

		public string AutoFreezeType
		{
			get
			{
				return autoFreezeType;
			}
			set	
			{
				autoFreezeType = value;
			}
		}

		public string CallbackId
		{
			get
			{
				return callbackId;
			}
			set	
			{
				callbackId = value;
			}
		}

		public string CallbackName
		{
			get
			{
				return callbackName;
			}
			set	
			{
				callbackName = value;
			}
		}

		public List<DescribeOssIncrementCheckSetting_BucketConfig> BucketConfigList
		{
			get
			{
				return bucketConfigList;
			}
			set	
			{
				bucketConfigList = value;
			}
		}

		public List<string> ImageSceneList
		{
			get
			{
				return imageSceneList;
			}
			set	
			{
				imageSceneList = value;
			}
		}

		public List<string> VideoSceneList
		{
			get
			{
				return videoSceneList;
			}
			set	
			{
				videoSceneList = value;
			}
		}

		public List<string> VideoAutoFreezeSceneList
		{
			get
			{
				return videoAutoFreezeSceneList;
			}
			set	
			{
				videoAutoFreezeSceneList = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImageAutoFreeze ImageAutoFreeze
		{
			get
			{
				return imageAutoFreeze;
			}
			set	
			{
				imageAutoFreeze = value;
			}
		}

		public class DescribeOssIncrementCheckSetting_BucketConfig
		{

			private bool? selected;

			private string bucket;

			private List<string> prefixes;

			public bool? Selected
			{
				get
				{
					return selected;
				}
				set	
				{
					selected = value;
				}
			}

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public List<string> Prefixes
			{
				get
				{
					return prefixes;
				}
				set	
				{
					prefixes = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImageAutoFreeze
		{

			private bool? enabled;

			private string porn;

			private string terrorism;

			private string ad;

			private string live;

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

			public string Porn
			{
				get
				{
					return porn;
				}
				set	
				{
					porn = value;
				}
			}

			public string Terrorism
			{
				get
				{
					return terrorism;
				}
				set	
				{
					terrorism = value;
				}
			}

			public string Ad
			{
				get
				{
					return ad;
				}
				set	
				{
					ad = value;
				}
			}

			public string Live
			{
				get
				{
					return live;
				}
				set	
				{
					live = value;
				}
			}
		}
	}
}
