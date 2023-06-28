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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20211201;

namespace Aliyun.Acs.adb.Model.V20211201
{
    public class SubmitSparkAppRequest : RpcAcsRequest<SubmitSparkAppResponse>
    {
        public SubmitSparkAppRequest()
            : base("adb", "2021-12-01", "SubmitSparkApp", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupName;

		private string agentVersion;

		private string data;

		private string appName;

		private long? templateFileId;

		private string dBClusterId;

		private string appType;

		private string agentSource;

		public string ResourceGroupName
		{
			get
			{
				return resourceGroupName;
			}
			set	
			{
				resourceGroupName = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupName", value);
			}
		}

		public string AgentVersion
		{
			get
			{
				return agentVersion;
			}
			set	
			{
				agentVersion = value;
				DictionaryUtil.Add(BodyParameters, "AgentVersion", value);
			}
		}

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(BodyParameters, "Data", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(BodyParameters, "AppName", value);
			}
		}

		public long? TemplateFileId
		{
			get
			{
				return templateFileId;
			}
			set	
			{
				templateFileId = value;
				DictionaryUtil.Add(BodyParameters, "TemplateFileId", value.ToString());
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(BodyParameters, "DBClusterId", value);
			}
		}

		public string AppType
		{
			get
			{
				return appType;
			}
			set	
			{
				appType = value;
				DictionaryUtil.Add(BodyParameters, "AppType", value);
			}
		}

		public string AgentSource
		{
			get
			{
				return agentSource;
			}
			set	
			{
				agentSource = value;
				DictionaryUtil.Add(BodyParameters, "AgentSource", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitSparkAppResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitSparkAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
