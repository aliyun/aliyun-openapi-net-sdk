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
	public class ListCustomImagesResponse : AcsResponse
	{

		private string requestId;

		private List<ListCustomImages_ImageInfo> images;

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

		public List<ListCustomImages_ImageInfo> Images
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

		public class ListCustomImages_ImageInfo
		{

			private string uid;

			private string imageId;

			private string imageName;

			private string imageOwnerAlias;

			private string description;

			private string status;

			private string productCode;

			private string skuCode;

			private string pricingCycle;

			private string postInstallScript;

			private int? size;

			private ListCustomImages_BaseOsTag baseOsTag;

			private ListCustomImages_OsTag osTag;

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
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

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string SkuCode
			{
				get
				{
					return skuCode;
				}
				set	
				{
					skuCode = value;
				}
			}

			public string PricingCycle
			{
				get
				{
					return pricingCycle;
				}
				set	
				{
					pricingCycle = value;
				}
			}

			public string PostInstallScript
			{
				get
				{
					return postInstallScript;
				}
				set	
				{
					postInstallScript = value;
				}
			}

			public int? Size
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

			public ListCustomImages_BaseOsTag BaseOsTag
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

			public ListCustomImages_OsTag OsTag
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

			public class ListCustomImages_BaseOsTag
			{

				private string osTag;

				private string platform;

				private string version;

				private string architecture;

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
			}

			public class ListCustomImages_OsTag
			{

				private string osTag;

				private string baseOsTag;

				private string platform;

				private string version;

				private string architecture;

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
			}
		}
	}
}
