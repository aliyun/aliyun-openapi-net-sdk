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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class SwitchSynchronizationEndpointRequest : RpcAcsRequest<SwitchSynchronizationEndpointResponse>
    {
        public SwitchSynchronizationEndpointRequest()
            : base("Dts", "2020-01-01", "SwitchSynchronizationEndpoint", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string synchronizationJobId;

		private string endpointType;

		private string accountId;

		private string endpointPort;

		private string endpointInstanceType;

		private string sourceEndpointOwnerID;

		private string sourceEndpointRole;

		private string endpointIP;

		private string ownerId;

		private string endpointInstanceId;

		private string synchronizationDirection;

		public string SynchronizationJobId
		{
			get
			{
				return synchronizationJobId;
			}
			set	
			{
				synchronizationJobId = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationJobId", value);
			}
		}

		public string EndpointType
		{
			get
			{
				return endpointType;
			}
			set	
			{
				endpointType = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint.Type", value);
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public string EndpointPort
		{
			get
			{
				return endpointPort;
			}
			set	
			{
				endpointPort = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint.Port", value);
			}
		}

		public string EndpointInstanceType
		{
			get
			{
				return endpointInstanceType;
			}
			set	
			{
				endpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint.InstanceType", value);
			}
		}

		public string SourceEndpointOwnerID
		{
			get
			{
				return sourceEndpointOwnerID;
			}
			set	
			{
				sourceEndpointOwnerID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.OwnerID", value);
			}
		}

		public string SourceEndpointRole
		{
			get
			{
				return sourceEndpointRole;
			}
			set	
			{
				sourceEndpointRole = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Role", value);
			}
		}

		public string EndpointIP
		{
			get
			{
				return endpointIP;
			}
			set	
			{
				endpointIP = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint.IP", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string EndpointInstanceId
		{
			get
			{
				return endpointInstanceId;
			}
			set	
			{
				endpointInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint.InstanceId", value);
			}
		}

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationDirection", value);
			}
		}

        public override SwitchSynchronizationEndpointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SwitchSynchronizationEndpointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
