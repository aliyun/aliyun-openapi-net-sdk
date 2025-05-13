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
using Aliyun.Acs.schedulerx2.Transform;
using Aliyun.Acs.schedulerx2.Transform.V20190430;

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
    public class UpdateJobScriptRequest : RpcAcsRequest<UpdateJobScriptResponse>
    {
        public UpdateJobScriptRequest()
            : base("schedulerx2", "2019-04-30", "UpdateJobScript", "schedulerx2", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string namespaceSource;

		private long? jobId;

		private string groupId;

		private string _namespace;

		private string scriptContent;

		private string versionDescription;

		public string NamespaceSource
		{
			get
			{
				return namespaceSource;
			}
			set	
			{
				namespaceSource = value;
				DictionaryUtil.Add(BodyParameters, "NamespaceSource", value);
			}
		}

		public long? JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(BodyParameters, "JobId", value.ToString());
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(BodyParameters, "Namespace", value);
			}
		}

		public string ScriptContent
		{
			get
			{
				return scriptContent;
			}
			set	
			{
				scriptContent = value;
				DictionaryUtil.Add(BodyParameters, "ScriptContent", value);
			}
		}

		public string VersionDescription
		{
			get
			{
				return versionDescription;
			}
			set	
			{
				versionDescription = value;
				DictionaryUtil.Add(BodyParameters, "VersionDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateJobScriptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateJobScriptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
