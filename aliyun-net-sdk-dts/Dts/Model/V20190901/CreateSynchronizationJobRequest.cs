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
using Aliyun.Acs.Dts;
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20190901;

namespace Aliyun.Acs.Dts.Model.V20190901
{
    public class CreateSynchronizationJobRequest : RpcAcsRequest<CreateSynchronizationJobResponse>
    {
        public CreateSynchronizationJobRequest()
            : base("Dts", "2019-09-01", "CreateSynchronizationJob")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string period;

		private string destRegion;

		private string clientToken;

		private string topology;

		private string networkType;

		private string ownerId;

		private int? usedTime;

		private string sourceEndpointInstanceType;

		private string synchronizationJobClass;

		private string sourceRegion;

		private string payType;

		private string destinationEndpointInstanceType;

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string DestRegion
		{
			get
			{
				return destRegion;
			}
			set	
			{
				destRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestRegion", value);
			}
		}

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

		public string Topology
		{
			get
			{
				return topology;
			}
			set	
			{
				topology = value;
				DictionaryUtil.Add(QueryParameters, "Topology", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "networkType", value);
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

		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceType", value);
			}
		}

		public string SynchronizationJobClass
		{
			get
			{
				return synchronizationJobClass;
			}
			set	
			{
				synchronizationJobClass = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationJobClass", value);
			}
		}

		public string SourceRegion
		{
			get
			{
				return sourceRegion;
			}
			set	
			{
				sourceRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceRegion", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public string DestinationEndpointInstanceType
		{
			get
			{
				return destinationEndpointInstanceType;
			}
			set	
			{
				destinationEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.InstanceType", value);
			}
		}

        public override CreateSynchronizationJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSynchronizationJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
