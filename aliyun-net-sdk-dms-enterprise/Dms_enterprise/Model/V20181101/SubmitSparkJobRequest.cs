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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class SubmitSparkJobRequest : RpcAcsRequest<SubmitSparkJobResponse>
    {
        public SubmitSparkJobRequest()
            : base("dms-enterprise", "2018-11-01", "SubmitSparkJob", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mainClass;

		private string configuration;

		private OssInfo ossInfo_;

		private long? tid;

		private string mainFile;

		private string name;

		private List<string> files = new List<string>(){ };

		private string appCode;

		private List<string> arguments = new List<string>(){ };

		[JsonProperty(PropertyName = "MainClass")]
		public string MainClass
		{
			get
			{
				return mainClass;
			}
			set	
			{
				mainClass = value;
				DictionaryUtil.Add(BodyParameters, "MainClass", value);
			}
		}

		[JsonProperty(PropertyName = "Configuration")]
		public string Configuration
		{
			get
			{
				return configuration;
			}
			set	
			{
				configuration = value;
				DictionaryUtil.Add(BodyParameters, "Configuration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OssInfo")]
		public OssInfo OssInfo_
		{
			get
			{
				return ossInfo_;
			}

			set
			{
				ossInfo_ = value;
				DictionaryUtil.Add(BodyParameters, "OssInfo", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MainFile")]
		public string MainFile
		{
			get
			{
				return mainFile;
			}
			set	
			{
				mainFile = value;
				DictionaryUtil.Add(BodyParameters, "MainFile", value);
			}
		}

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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "Files")]
		public List<string> Files
		{
			get
			{
				return files;
			}

			set
			{
				files = value;
				if(files != null)
				{
					for (int depth1 = 0; depth1 < files.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Files." + (depth1 + 1), files[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "AppCode")]
		public string AppCode
		{
			get
			{
				return appCode;
			}
			set	
			{
				appCode = value;
				DictionaryUtil.Add(BodyParameters, "AppCode", value);
			}
		}

		[JsonProperty(PropertyName = "Arguments")]
		public List<string> Arguments
		{
			get
			{
				return arguments;
			}

			set
			{
				arguments = value;
				if(arguments != null)
				{
					for (int depth1 = 0; depth1 < arguments.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Arguments." + (depth1 + 1), arguments[depth1]);
					}
				}
			}
		}

		public class OssInfo
		{

			private string endpoint;

			private string accessKeySecret;

			private string accessKeyId;

			[JsonProperty(PropertyName = "Endpoint")]
			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
				}
			}

			[JsonProperty(PropertyName = "AccessKeySecret")]
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

			[JsonProperty(PropertyName = "AccessKeyId")]
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
		}

        public override SubmitSparkJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitSparkJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
