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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class UpdateSecretVersionStageRequest : RpcAcsRequest<UpdateSecretVersionStageResponse>
    {
        public UpdateSecretVersionStageRequest()
            : base("Kms", "2016-01-20", "UpdateSecretVersionStage", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string moveToVersion;

		private string removeFromVersion;

		private string versionStage;

		private string secretName;

		[JsonProperty(PropertyName = "MoveToVersion")]
		public string MoveToVersion
		{
			get
			{
				return moveToVersion;
			}
			set	
			{
				moveToVersion = value;
				DictionaryUtil.Add(QueryParameters, "MoveToVersion", value);
			}
		}

		[JsonProperty(PropertyName = "RemoveFromVersion")]
		public string RemoveFromVersion
		{
			get
			{
				return removeFromVersion;
			}
			set	
			{
				removeFromVersion = value;
				DictionaryUtil.Add(QueryParameters, "RemoveFromVersion", value);
			}
		}

		[JsonProperty(PropertyName = "VersionStage")]
		public string VersionStage
		{
			get
			{
				return versionStage;
			}
			set	
			{
				versionStage = value;
				DictionaryUtil.Add(QueryParameters, "VersionStage", value);
			}
		}

		[JsonProperty(PropertyName = "SecretName")]
		public string SecretName
		{
			get
			{
				return secretName;
			}
			set	
			{
				secretName = value;
				DictionaryUtil.Add(QueryParameters, "SecretName", value);
			}
		}

        public override UpdateSecretVersionStageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSecretVersionStageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
