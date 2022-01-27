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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayImagesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayImages_Image> images;

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Images")]
		public List<DescribeGatewayImages_Image> Images
		{
			get
			{
				return images;
			}
			set	
			{
				images = value;
			}
		}

		public class DescribeGatewayImages_Image
		{

			private string type;

			private string description;

			private string version;

			private long? size;

			private string url;

			private string title;

			private string mD5;

			private string name;

			private string modifiedDate;

			[JsonProperty(PropertyName = "Type")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "Version")]
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

			[JsonProperty(PropertyName = "Size")]
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

			[JsonProperty(PropertyName = "Url")]
			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			[JsonProperty(PropertyName = "Title")]
			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			[JsonProperty(PropertyName = "MD5")]
			public string MD5
			{
				get
				{
					return mD5;
				}
				set	
				{
					mD5 = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
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

			[JsonProperty(PropertyName = "ModifiedDate")]
			public string ModifiedDate
			{
				get
				{
					return modifiedDate;
				}
				set	
				{
					modifiedDate = value;
				}
			}
		}
	}
}
