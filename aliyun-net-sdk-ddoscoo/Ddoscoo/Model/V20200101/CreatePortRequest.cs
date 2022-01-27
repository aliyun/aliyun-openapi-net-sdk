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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class CreatePortRequest : RpcAcsRequest<CreatePortResponse>
    {
        public CreatePortRequest()
            : base("ddoscoo", "2020-01-01", "CreatePort")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string backendPort;

		private string frontendProtocol;

		private string instanceId;

		private List<string> realServerss = new List<string>(){ };

		private string frontendPort;

		public string BackendPort
		{
			get
			{
				return backendPort;
			}
			set	
			{
				backendPort = value;
				DictionaryUtil.Add(QueryParameters, "BackendPort", value);
			}
		}

		public string FrontendProtocol
		{
			get
			{
				return frontendProtocol;
			}
			set	
			{
				frontendProtocol = value;
				DictionaryUtil.Add(QueryParameters, "FrontendProtocol", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<string> RealServerss
		{
			get
			{
				return realServerss;
			}

			set
			{
				realServerss = value;
				for (int i = 0; i < realServerss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RealServers." + (i + 1) , realServerss[i]);
				}
			}
		}

		public string FrontendPort
		{
			get
			{
				return frontendPort;
			}
			set	
			{
				frontendPort = value;
				DictionaryUtil.Add(QueryParameters, "FrontendPort", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreatePortResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePortResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
