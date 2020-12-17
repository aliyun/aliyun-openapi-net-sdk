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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeSpotAdviceRequest : RpcAcsRequest<DescribeSpotAdviceResponse>
    {
        public DescribeSpotAdviceRequest()
            : base("Ecs", "2014-05-26", "DescribeSpotAdvice", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gpuSpec;

		private long? resourceOwnerId;

		private float? memory;

		private List<string> instanceTypess = new List<string>(){ };

		private int? minCores;

		private int? cores;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string instanceTypeFamily;

		private long? ownerId;

		private string instanceFamilyLevel;

		private string zoneId;

		private int? gpuAmount;

		private float? minMemory;

		public string GpuSpec
		{
			get
			{
				return gpuSpec;
			}
			set	
			{
				gpuSpec = value;
				DictionaryUtil.Add(QueryParameters, "GpuSpec", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public float? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
			}
		}

		public List<string> InstanceTypess
		{
			get
			{
				return instanceTypess;
			}

			set
			{
				instanceTypess = value;
				for (int i = 0; i < instanceTypess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypes." + (i + 1) , instanceTypess[i]);
				}
			}
		}

		public int? MinCores
		{
			get
			{
				return minCores;
			}
			set	
			{
				minCores = value;
				DictionaryUtil.Add(QueryParameters, "MinCores", value.ToString());
			}
		}

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "Cores", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string InstanceTypeFamily
		{
			get
			{
				return instanceTypeFamily;
			}
			set	
			{
				instanceTypeFamily = value;
				DictionaryUtil.Add(QueryParameters, "InstanceTypeFamily", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string InstanceFamilyLevel
		{
			get
			{
				return instanceFamilyLevel;
			}
			set	
			{
				instanceFamilyLevel = value;
				DictionaryUtil.Add(QueryParameters, "InstanceFamilyLevel", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public int? GpuAmount
		{
			get
			{
				return gpuAmount;
			}
			set	
			{
				gpuAmount = value;
				DictionaryUtil.Add(QueryParameters, "GpuAmount", value.ToString());
			}
		}

		public float? MinMemory
		{
			get
			{
				return minMemory;
			}
			set	
			{
				minMemory = value;
				DictionaryUtil.Add(QueryParameters, "MinMemory", value.ToString());
			}
		}

        public override DescribeSpotAdviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSpotAdviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
