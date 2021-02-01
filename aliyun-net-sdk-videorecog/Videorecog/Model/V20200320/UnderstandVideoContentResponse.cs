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

namespace Aliyun.Acs.videorecog.Model.V20200320
{
	public class UnderstandVideoContentResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private UnderstandVideoContent_Data data;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public UnderstandVideoContent_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class UnderstandVideoContent_Data
		{

			private string tagInfo;

			private UnderstandVideoContent_VideoInfo videoInfo;

			public string TagInfo
			{
				get
				{
					return tagInfo;
				}
				set	
				{
					tagInfo = value;
				}
			}

			public UnderstandVideoContent_VideoInfo VideoInfo
			{
				get
				{
					return videoInfo;
				}
				set	
				{
					videoInfo = value;
				}
			}

			public class UnderstandVideoContent_VideoInfo
			{

				private float? fps;

				private long? duration;

				private long? height;

				private long? width;

				public float? Fps
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

				public long? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
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
