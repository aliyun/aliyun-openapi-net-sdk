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
using Aliyun.Acs.saf;
using Aliyun.Acs.saf.Transform;
using Aliyun.Acs.saf.Transform.V20190521;

namespace Aliyun.Acs.saf.Model.V20190521
{
    public class ExecuteExtendServiceRequest : RpcAcsRequest<ExecuteExtendServiceResponse>
    {
        public ExecuteExtendServiceRequest()
            : base("saf", "2019-05-21", "ExecuteExtendService")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.saf.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.saf.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string serviceParameters;

		private string service;

		private string region;

		public string ServiceParameters
		{
			get
			{
				return serviceParameters;
			}
			set	
			{
				serviceParameters = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParameters", value);
			}
		}

		public string Service
		{
			get
			{
				return service;
			}
			set	
			{
				service = value;
				DictionaryUtil.Add(QueryParameters, "Service", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExecuteExtendServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExecuteExtendServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
