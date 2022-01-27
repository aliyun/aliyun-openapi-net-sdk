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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class CreateMediaResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private CreateMedia_Model model;

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

		public CreateMedia_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class CreateMedia_Model
		{

			private long? createTime;

			private long? modifyTime;

			private string tenantId;

			private string mediaName;

			private string mediaId;

			private string mediaType;

			private string firstScene;

			private string secondScene;

			private string mediaStatus;

			private string accessStatus;

			private string os;

			private string config;

			private string keyWords;

			private string accessWay;

			private string extInfo;

			private long? version;

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string MediaName
			{
				get
				{
					return mediaName;
				}
				set	
				{
					mediaName = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string MediaType
			{
				get
				{
					return mediaType;
				}
				set	
				{
					mediaType = value;
				}
			}

			public string FirstScene
			{
				get
				{
					return firstScene;
				}
				set	
				{
					firstScene = value;
				}
			}

			public string SecondScene
			{
				get
				{
					return secondScene;
				}
				set	
				{
					secondScene = value;
				}
			}

			public string MediaStatus
			{
				get
				{
					return mediaStatus;
				}
				set	
				{
					mediaStatus = value;
				}
			}

			public string AccessStatus
			{
				get
				{
					return accessStatus;
				}
				set	
				{
					accessStatus = value;
				}
			}

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public string KeyWords
			{
				get
				{
					return keyWords;
				}
				set	
				{
					keyWords = value;
				}
			}

			public string AccessWay
			{
				get
				{
					return accessWay;
				}
				set	
				{
					accessWay = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public long? Version
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
		}
	}
}
