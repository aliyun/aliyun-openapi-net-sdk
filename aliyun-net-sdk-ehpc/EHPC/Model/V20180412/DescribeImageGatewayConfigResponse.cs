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
	public class DescribeImageGatewayConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeImageGatewayConfig_Imagegw imagegw;

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

		public DescribeImageGatewayConfig_Imagegw Imagegw
		{
			get
			{
				return imagegw;
			}
			set	
			{
				imagegw = value;
			}
		}

		public class DescribeImageGatewayConfig_Imagegw
		{

			private string defaultImageLocation;

			private long? pullUpdateTimeout;

			private string mongoDBURI;

			private string imageExpirationTimeout;

			private string updateDateTime;

			private List<DescribeImageGatewayConfig_LocationInfo> locations;

			public string DefaultImageLocation
			{
				get
				{
					return defaultImageLocation;
				}
				set	
				{
					defaultImageLocation = value;
				}
			}

			public long? PullUpdateTimeout
			{
				get
				{
					return pullUpdateTimeout;
				}
				set	
				{
					pullUpdateTimeout = value;
				}
			}

			public string MongoDBURI
			{
				get
				{
					return mongoDBURI;
				}
				set	
				{
					mongoDBURI = value;
				}
			}

			public string ImageExpirationTimeout
			{
				get
				{
					return imageExpirationTimeout;
				}
				set	
				{
					imageExpirationTimeout = value;
				}
			}

			public string UpdateDateTime
			{
				get
				{
					return updateDateTime;
				}
				set	
				{
					updateDateTime = value;
				}
			}

			public List<DescribeImageGatewayConfig_LocationInfo> Locations
			{
				get
				{
					return locations;
				}
				set	
				{
					locations = value;
				}
			}

			public class DescribeImageGatewayConfig_LocationInfo
			{

				private string location;

				private string remoteType;

				private string authentication;

				private string uRL;

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string RemoteType
				{
					get
					{
						return remoteType;
					}
					set	
					{
						remoteType = value;
					}
				}

				public string Authentication
				{
					get
					{
						return authentication;
					}
					set	
					{
						authentication = value;
					}
				}

				public string URL
				{
					get
					{
						return uRL;
					}
					set	
					{
						uRL = value;
					}
				}
			}
		}
	}
}
