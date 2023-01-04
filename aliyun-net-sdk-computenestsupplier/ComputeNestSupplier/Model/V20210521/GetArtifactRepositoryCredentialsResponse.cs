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

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
	public class GetArtifactRepositoryCredentialsResponse : AcsResponse
	{

		private string requestId;

		private string expireDate;

		private List<GetArtifactRepositoryCredentials_AvailableResourcesItem> availableResources;

		private GetArtifactRepositoryCredentials_Credentials credentials;

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

		public string ExpireDate
		{
			get
			{
				return expireDate;
			}
			set	
			{
				expireDate = value;
			}
		}

		public List<GetArtifactRepositoryCredentials_AvailableResourcesItem> AvailableResources
		{
			get
			{
				return availableResources;
			}
			set	
			{
				availableResources = value;
			}
		}

		public GetArtifactRepositoryCredentials_Credentials Credentials
		{
			get
			{
				return credentials;
			}
			set	
			{
				credentials = value;
			}
		}

		public class GetArtifactRepositoryCredentials_AvailableResourcesItem
		{

			private string regionId;

			private string repositoryName;

			private string path;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string RepositoryName
			{
				get
				{
					return repositoryName;
				}
				set	
				{
					repositoryName = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}
		}

		public class GetArtifactRepositoryCredentials_Credentials
		{

			private string username;

			private string password;

			private string accessKeyId;

			private string accessKeySecret;

			private string securityToken;

			public string Username
			{
				get
				{
					return username;
				}
				set	
				{
					username = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string SecurityToken
			{
				get
				{
					return securityToken;
				}
				set	
				{
					securityToken = value;
				}
			}
		}
	}
}
