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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetPackageResponse : AcsResponse
	{

		private string requestId;

		private GetPackage_Package package;

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

		public GetPackage_Package Package
		{
			get
			{
				return package;
			}
			set	
			{
				package = value;
			}
		}

		public class GetPackage_Package
		{

			private string projectName;

			private string packageName;

			private string creator;

			private string modifier;

			private long? createTime;

			private long? modifyTime;

			private string originName;

			private string type;

			private string md5;

			private string description;

			private string ossEndpoint;

			private string ossBucket;

			private string ossOwner;

			private string ossPath;

			private string tag;

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string PackageName
			{
				get
				{
					return packageName;
				}
				set	
				{
					packageName = value;
				}
			}

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public string Modifier
			{
				get
				{
					return modifier;
				}
				set	
				{
					modifier = value;
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

			public string OriginName
			{
				get
				{
					return originName;
				}
				set	
				{
					originName = value;
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

			public string Md5
			{
				get
				{
					return md5;
				}
				set	
				{
					md5 = value;
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

			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			public string OssOwner
			{
				get
				{
					return ossOwner;
				}
				set	
				{
					ossOwner = value;
				}
			}

			public string OssPath
			{
				get
				{
					return ossPath;
				}
				set	
				{
					ossPath = value;
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
		}
	}
}
