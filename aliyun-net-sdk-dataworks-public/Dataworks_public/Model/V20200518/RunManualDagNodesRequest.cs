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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class RunManualDagNodesRequest : RpcAcsRequest<RunManualDagNodesResponse>
    {
        public RunManualDagNodesRequest()
            : base("dataworks-public", "2020-05-18", "RunManualDagNodes")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectEnv;

		private string projectName;

		private string bizDate;

		private string flowName;

		private string dagParameters;

		private string nodeParameters;

		public string ProjectEnv
		{
			get
			{
				return projectEnv;
			}
			set	
			{
				projectEnv = value;
				DictionaryUtil.Add(BodyParameters, "ProjectEnv", value);
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
			}
		}

		public string BizDate
		{
			get
			{
				return bizDate;
			}
			set	
			{
				bizDate = value;
				DictionaryUtil.Add(BodyParameters, "BizDate", value);
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
				DictionaryUtil.Add(BodyParameters, "FlowName", value);
			}
		}

		public string DagParameters
		{
			get
			{
				return dagParameters;
			}
			set	
			{
				dagParameters = value;
				DictionaryUtil.Add(BodyParameters, "DagParameters", value);
			}
		}

		public string NodeParameters
		{
			get
			{
				return nodeParameters;
			}
			set	
			{
				nodeParameters = value;
				DictionaryUtil.Add(BodyParameters, "NodeParameters", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunManualDagNodesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunManualDagNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
