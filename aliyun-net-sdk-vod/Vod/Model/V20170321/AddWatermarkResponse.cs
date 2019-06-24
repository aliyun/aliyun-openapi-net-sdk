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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class AddWatermarkResponse : AcsResponse
	{

		private string requestId;

		private AddWatermark_WatermarkInfo watermarkInfo;

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

		public AddWatermark_WatermarkInfo WatermarkInfo
		{
			get
			{
				return watermarkInfo;
			}
			set	
			{
				watermarkInfo = value;
			}
		}

		public class AddWatermark_WatermarkInfo
		{

			private string creationTime;

			private string type;

			private string isDefault;

			private string watermarkId;

			private string name;

			private string fileUrl;

			private string watermarkConfig;

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

			public string IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string WatermarkId
			{
				get
				{
					return watermarkId;
				}
				set	
				{
					watermarkId = value;
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

			public string FileUrl
			{
				get
				{
					return fileUrl;
				}
				set	
				{
					fileUrl = value;
				}
			}

			public string WatermarkConfig
			{
				get
				{
					return watermarkConfig;
				}
				set	
				{
					watermarkConfig = value;
				}
			}
		}
	}
}
