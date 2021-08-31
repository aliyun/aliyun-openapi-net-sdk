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
	public class ListHistoryDeployVersionResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListHistoryDeployVersion_PackageVersion> packageVersionList;

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

		public List<ListHistoryDeployVersion_PackageVersion> PackageVersionList
		{
			get
			{
				return packageVersionList;
			}
			set	
			{
				packageVersionList = value;
			}
		}

		public class ListHistoryDeployVersion_PackageVersion
		{

			private string id;

			private string packageVersion;

			private string appId;

			private string description;

			private string warUrl;

			private long? createTime;

			private long? updateTime;

			private string type;

			private string publicUrl;

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

			public string PackageVersion
			{
				get
				{
					return packageVersion;
				}
				set	
				{
					packageVersion = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
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

			public string WarUrl
			{
				get
				{
					return warUrl;
				}
				set	
				{
					warUrl = value;
				}
			}

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

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
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
		}
	}
}
