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
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class UpdatePipelineEnvVarsRequest : RpcAcsRequest<UpdatePipelineEnvVarsResponse>
    {
        public UpdatePipelineEnvVarsRequest()
            : base("devops-rdc", "2020-03-03", "UpdatePipelineEnvVars")
        {
			Method = MethodType.POST;
        }

		private string envVars;

		private string orgId;

		private long? pipelineId;

		public string EnvVars
		{
			get
			{
				return envVars;
			}
			set	
			{
				envVars = value;
				DictionaryUtil.Add(QueryParameters, "EnvVars", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(QueryParameters, "OrgId", value);
			}
		}

		public long? PipelineId
		{
			get
			{
				return pipelineId;
			}
			set	
			{
				pipelineId = value;
				DictionaryUtil.Add(QueryParameters, "PipelineId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdatePipelineEnvVarsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdatePipelineEnvVarsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
