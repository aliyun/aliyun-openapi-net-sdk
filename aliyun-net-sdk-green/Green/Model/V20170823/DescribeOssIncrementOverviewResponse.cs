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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssIncrementOverviewResponse : AcsResponse
	{

		private int? videoCount;

		private int? adUnhandleCount;

		private string requestId;

		private int? voiceAntispamUnhandleCount;

		private int? videoFrameCount;

		private int? audioCount;

		private int? pornUnhandleCount;

		private int? imageCount;

		private int? terrorismUnhandleCount;

		private int? liveUnhandleCount;

		public int? VideoCount
		{
			get
			{
				return videoCount;
			}
			set	
			{
				videoCount = value;
			}
		}

		public int? AdUnhandleCount
		{
			get
			{
				return adUnhandleCount;
			}
			set	
			{
				adUnhandleCount = value;
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

		public int? VoiceAntispamUnhandleCount
		{
			get
			{
				return voiceAntispamUnhandleCount;
			}
			set	
			{
				voiceAntispamUnhandleCount = value;
			}
		}

		public int? VideoFrameCount
		{
			get
			{
				return videoFrameCount;
			}
			set	
			{
				videoFrameCount = value;
			}
		}

		public int? AudioCount
		{
			get
			{
				return audioCount;
			}
			set	
			{
				audioCount = value;
			}
		}

		public int? PornUnhandleCount
		{
			get
			{
				return pornUnhandleCount;
			}
			set	
			{
				pornUnhandleCount = value;
			}
		}

		public int? ImageCount
		{
			get
			{
				return imageCount;
			}
			set	
			{
				imageCount = value;
			}
		}

		public int? TerrorismUnhandleCount
		{
			get
			{
				return terrorismUnhandleCount;
			}
			set	
			{
				terrorismUnhandleCount = value;
			}
		}

		public int? LiveUnhandleCount
		{
			get
			{
				return liveUnhandleCount;
			}
			set	
			{
				liveUnhandleCount = value;
			}
		}
	}
}
