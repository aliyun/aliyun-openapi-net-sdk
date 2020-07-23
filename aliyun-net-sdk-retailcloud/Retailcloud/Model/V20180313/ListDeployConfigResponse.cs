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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListDeployConfigResponse : AcsResponse
	{

		private int? code;

		private string errorMsg;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private long? totalCount;

		private List<ListDeployConfig_DeployConfigInstance> data;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListDeployConfig_DeployConfigInstance> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListDeployConfig_DeployConfigInstance
		{

			private long? id;

			private string name;

			private long? appId;

			private string envType;

			private ListDeployConfig_ContainerCodePath containerCodePath;

			private ListDeployConfig_ContainerYamlConf containerYamlConf;

			public long? Id
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

			public long? AppId
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

			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			public ListDeployConfig_ContainerCodePath ContainerCodePath
			{
				get
				{
					return containerCodePath;
				}
				set	
				{
					containerCodePath = value;
				}
			}

			public ListDeployConfig_ContainerYamlConf ContainerYamlConf
			{
				get
				{
					return containerYamlConf;
				}
				set	
				{
					containerYamlConf = value;
				}
			}

			public class ListDeployConfig_ContainerCodePath
			{

				private string codePath;

				public string CodePath
				{
					get
					{
						return codePath;
					}
					set	
					{
						codePath = value;
					}
				}
			}

			public class ListDeployConfig_ContainerYamlConf
			{

				private string deployment;

				private string configMap;

				private string statefulSet;

				private string cronJob;

				private List<string> configMapList;

				private List<string> secretList;

				public string Deployment
				{
					get
					{
						return deployment;
					}
					set	
					{
						deployment = value;
					}
				}

				public string ConfigMap
				{
					get
					{
						return configMap;
					}
					set	
					{
						configMap = value;
					}
				}

				public string StatefulSet
				{
					get
					{
						return statefulSet;
					}
					set	
					{
						statefulSet = value;
					}
				}

				public string CronJob
				{
					get
					{
						return cronJob;
					}
					set	
					{
						cronJob = value;
					}
				}

				public List<string> ConfigMapList
				{
					get
					{
						return configMapList;
					}
					set	
					{
						configMapList = value;
					}
				}

				public List<string> SecretList
				{
					get
					{
						return secretList;
					}
					set	
					{
						secretList = value;
					}
				}
			}
		}
	}
}
