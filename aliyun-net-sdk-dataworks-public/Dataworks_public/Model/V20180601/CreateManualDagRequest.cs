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
using Aliyun.Acs.dataworks_public.Transform.V20180601;

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
    public class CreateManualDagRequest : RpcAcsRequest<CreateManualDagResponse>
    {
        public CreateManualDagRequest()
            : base("dataworks-public", "2018-06-01", "CreateManualDag")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectName;

		private string bizdate;

		private string flowName;

		private string dagPara;

		private string nodePara;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(QueryParameters, "ProjectName", value);
			}
		}

		public string Bizdate
		{
			get
			{
				return bizdate;
			}
			set	
			{
				bizdate = value;
				DictionaryUtil.Add(QueryParameters, "Bizdate", value);
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
				DictionaryUtil.Add(QueryParameters, "FlowName", value);
			}
		}

		public string DagPara
		{
			get
			{
				return dagPara;
			}
			set	
			{
				dagPara = value;
				DictionaryUtil.Add(QueryParameters, "DagPara", value);
			}
		}

		public string NodePara
		{
			get
			{
				return nodePara;
			}
			set	
			{
				nodePara = value;
				DictionaryUtil.Add(QueryParameters, "NodePara", value);
			}
		}

        public override CreateManualDagResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateManualDagResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
