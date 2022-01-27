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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class RerunFlowRequest : RpcAcsRequest<RerunFlowResponse>
    {
        public RerunFlowRequest()
            : base("Emr", "2016-04-08", "RerunFlow", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string flowInstanceId;

		private bool? reRunFail;

		private string projectId;

		public string FlowInstanceId
		{
			get
			{
				return flowInstanceId;
			}
			set	
			{
				flowInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "FlowInstanceId", value);
			}
		}

		public bool? ReRunFail
		{
			get
			{
				return reRunFail;
			}
			set	
			{
				reRunFail = value;
				DictionaryUtil.Add(QueryParameters, "ReRunFail", value.ToString());
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

        public override RerunFlowResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RerunFlowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
