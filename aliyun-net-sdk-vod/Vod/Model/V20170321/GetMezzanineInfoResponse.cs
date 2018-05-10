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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetMezzanineInfoResponse : AcsResponse
	{

		private string requestId;

		private GetMezzanineInfo_Mezzanine mezzanine;

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

		public GetMezzanineInfo_Mezzanine Mezzanine
		{
			get
			{
				return mezzanine;
			}
			set	
			{
				mezzanine = value;
			}
		}

		public class GetMezzanineInfo_Mezzanine
		{

			private string videoId;

			private string bitrate;

			private string creationTime;

			private string duration;

			private string fps;

			private long? height;

			private long? width;

			private long? size;

			private string status;

			private string fileURL;

			private string fileName;

			private string cRC64;

			private string preprocessStatus;

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}

			public string Bitrate
			{
				get
				{
					return bitrate;
				}
				set	
				{
					bitrate = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Duration
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

			public string Fps
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

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
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

			public string FileURL
			{
				get
				{
					return fileURL;
				}
				set	
				{
					fileURL = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public string CRC64
			{
				get
				{
					return cRC64;
				}
				set	
				{
					cRC64 = value;
				}
			}

			public string PreprocessStatus
			{
				get
				{
					return preprocessStatus;
				}
				set	
				{
					preprocessStatus = value;
				}
			}
		}
	}
}