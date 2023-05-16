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
using Aliyun.Acs.ComputeNest.Transform;
using Aliyun.Acs.ComputeNest.Transform.V20210601;

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
    public class ContinueDeployServiceInstanceRequest : RpcAcsRequest<ContinueDeployServiceInstanceResponse>
    {
        public ContinueDeployServiceInstanceRequest()
            : base("ComputeNest", "2021-06-01", "ContinueDeployServiceInstance", "computenest", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string serviceInstanceId;

		private bool? dryRun;

		private string parameters;

		private List<string> options = new List<string>(){ };

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ServiceInstanceId
		{
			get
			{
				return serviceInstanceId;
			}
			set	
			{
				serviceInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceInstanceId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(QueryParameters, "Parameters", value);
			}
		}

		public List<string> Options
		{
			get
			{
				return options;
			}

			set
			{
				options = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ContinueDeployServiceInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ContinueDeployServiceInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
