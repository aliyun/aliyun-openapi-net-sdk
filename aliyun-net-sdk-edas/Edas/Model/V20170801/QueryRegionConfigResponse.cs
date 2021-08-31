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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class QueryRegionConfigResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private QueryRegionConfig_RegionConfig regionConfig;

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

		public int? Code
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

		public QueryRegionConfig_RegionConfig RegionConfig
		{
			get
			{
				return regionConfig;
			}
			set	
			{
				regionConfig = value;
			}
		}

		public class QueryRegionConfig_RegionConfig
		{

			private string addressServerHost;

			private string agentInstallScript;

			private string fileServerType;

			private string id;

			private string imageId;

			private string name;

			private int? no;

			private string tag;

			private QueryRegionConfig_FileServerConfig fileServerConfig;

			public string AddressServerHost
			{
				get
				{
					return addressServerHost;
				}
				set	
				{
					addressServerHost = value;
				}
			}

			public string AgentInstallScript
			{
				get
				{
					return agentInstallScript;
				}
				set	
				{
					agentInstallScript = value;
				}
			}

			public string FileServerType
			{
				get
				{
					return fileServerType;
				}
				set	
				{
					fileServerType = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public int? No
			{
				get
				{
					return no;
				}
				set	
				{
					no = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public QueryRegionConfig_FileServerConfig FileServerConfig
			{
				get
				{
					return fileServerConfig;
				}
				set	
				{
					fileServerConfig = value;
				}
			}

			public class QueryRegionConfig_FileServerConfig
			{

				private string bucket;

				private string internalUrl;

				private string publicUrl;

				private string vpcUrl;

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

				public string InternalUrl
				{
					get
					{
						return internalUrl;
					}
					set	
					{
						internalUrl = value;
					}
				}

				public string PublicUrl
				{
					get
					{
						return publicUrl;
					}
					set	
					{
						publicUrl = value;
					}
				}

				public string VpcUrl
				{
					get
					{
						return vpcUrl;
					}
					set	
					{
						vpcUrl = value;
					}
				}
			}
		}
	}
}
