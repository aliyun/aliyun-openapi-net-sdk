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

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class ListEnvsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private List<ListEnvs_Env> envs;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

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

		public List<ListEnvs_Env> Envs
		{
			get
			{
				return envs;
			}
			set	
			{
				envs = value;
			}
		}

		public class ListEnvs_Env
		{

			private long? createTime;

			private string envVersion;

			private long? modifiedTime;

			private long? usedCapacity;

			private string envName;

			private string envId;

			private List<ListEnvs_File> files;

			private List<ListEnvs_PropertiesItem> properties;

			private List<string> runningScenes;

			private List<string> relatedScenes;

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

			public string EnvVersion
			{
				get
				{
					return envVersion;
				}
				set	
				{
					envVersion = value;
				}
			}

			public long? ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public long? UsedCapacity
			{
				get
				{
					return usedCapacity;
				}
				set	
				{
					usedCapacity = value;
				}
			}

			public string EnvName
			{
				get
				{
					return envName;
				}
				set	
				{
					envName = value;
				}
			}

			public string EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}

			public List<ListEnvs_File> Files
			{
				get
				{
					return files;
				}
				set	
				{
					files = value;
				}
			}

			public List<ListEnvs_PropertiesItem> Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			public List<string> RunningScenes
			{
				get
				{
					return runningScenes;
				}
				set	
				{
					runningScenes = value;
				}
			}

			public List<string> RelatedScenes
			{
				get
				{
					return relatedScenes;
				}
				set	
				{
					relatedScenes = value;
				}
			}

			public class ListEnvs_File
			{

				private long? fileSize;

				private string md5;

				private string fileName;

				private string fileOssAddress;

				private long? fileId;

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
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

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string FileOssAddress
				{
					get
					{
						return fileOssAddress;
					}
					set	
					{
						fileOssAddress = value;
					}
				}

				public long? FileId
				{
					get
					{
						return fileId;
					}
					set	
					{
						fileId = value;
					}
				}
			}

			public class ListEnvs_PropertiesItem
			{

				private string name;

				private string _value;

				private string description;

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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
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
			}
		}
	}
}
