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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListImagesResponse : AcsResponse
	{

		private string requestId;

		private List<ListImages_OsInfo> osTags;

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

		public List<ListImages_OsInfo> OsTags
		{
			get
			{
				return osTags;
			}
			set	
			{
				osTags = value;
			}
		}

		public class ListImages_OsInfo
		{

			private string osTag;

			private string platform;

			private string version;

			private string architecture;

			private string baseOsTag;

			private string imageId;

			public string OsTag
			{
				get
				{
					return osTag;
				}
				set	
				{
					osTag = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string Architecture
			{
				get
				{
					return architecture;
				}
				set	
				{
					architecture = value;
				}
			}

			public string BaseOsTag
			{
				get
				{
					return baseOsTag;
				}
				set	
				{
					baseOsTag = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}
		}
	}
}
