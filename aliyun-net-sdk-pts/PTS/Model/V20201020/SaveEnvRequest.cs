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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.PTS;
using Aliyun.Acs.PTS.Transform;
using Aliyun.Acs.PTS.Transform.V20201020;

namespace Aliyun.Acs.PTS.Model.V20201020
{
    public class SaveEnvRequest : RpcAcsRequest<SaveEnvResponse>
    {
        public SaveEnvRequest()
            : base("PTS", "2020-10-20", "SaveEnv")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private Env env_;

		[JsonProperty(PropertyName = "Env")]
		public Env Env_
		{
			get
			{
				return env_;
			}

			set
			{
				env_ = value;
				DictionaryUtil.Add(QueryParameters, "Env", JsonConvert.SerializeObject(value));

			}
		}

		public class Env
		{

			private string envName;

			private List<FilesItem> files = new List<FilesItem>(){ };

			private string jmeterPluginLabel;

			private string envId;

			private List<PropertiesItem> properties = new List<PropertiesItem>(){ };

			[JsonProperty(PropertyName = "EnvName")]
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

			[JsonProperty(PropertyName = "Files")]
			public List<FilesItem> Files
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

			[JsonProperty(PropertyName = "JmeterPluginLabel")]
			public string JmeterPluginLabel
			{
				get
				{
					return jmeterPluginLabel;
				}
				set	
				{
					jmeterPluginLabel = value;
				}
			}

			[JsonProperty(PropertyName = "EnvId")]
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

			[JsonProperty(PropertyName = "Properties")]
			public List<PropertiesItem> Properties
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

			public class FilesItem
			{

				private string fileName;

				private string fileOssAddress;

				[JsonProperty(PropertyName = "FileName")]
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

				[JsonProperty(PropertyName = "FileOssAddress")]
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
			}

			public class PropertiesItem
			{

				private string name;

				private string description;

				private string value_;

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

				[JsonProperty(PropertyName = "Value")]
				public string Value_
				{
					get
					{
						return value_;
					}
					set	
					{
						value_ = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveEnvResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveEnvResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
