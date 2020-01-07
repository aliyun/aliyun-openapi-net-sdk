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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class CreateDeployConfigRequest : RpcAcsRequest<CreateDeployConfigResponse>
    {
        public CreateDeployConfigRequest()
            : base("retailcloud", "2018-03-13", "CreateDeployConfig", "retailcloud", "openAPI")
        {
        }

		private string codePath;

		private long? appId;

		private string configMap;

		private string statefulSet;

		private string envType;

		private string name;

		private string deployment;

		public string CodePath
		{
			get
			{
				return codePath;
			}
			set	
			{
				codePath = value;
				DictionaryUtil.Add(QueryParameters, "CodePath", value);
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
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ConfigMap", value);
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
				DictionaryUtil.Add(QueryParameters, "StatefulSet", value);
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
				DictionaryUtil.Add(QueryParameters, "EnvType", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Deployment
		{
			get
			{
				return deployment;
			}
			set	
			{
				deployment = value;
				DictionaryUtil.Add(QueryParameters, "Deployment", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDeployConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDeployConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
