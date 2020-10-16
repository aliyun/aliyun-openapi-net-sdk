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
    public class CreateElasticityAssuranceRequest : RpcAcsRequest<CreateElasticityAssuranceResponse>
    {
        public CreateElasticityAssuranceRequest()
            : base("Ecs", "2014-05-26", "CreateElasticityAssurance", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string description;

		private string startTime;

		private string privatePoolOptionsMatchCriteria;

		private List<string> instanceTypes = new List<string>(){ };

		private int? period;

		private string resourceOwnerAccount;

		private string privatePoolOptionsName;

		private string ownerAccount;

		private string assuranceTimes;

		private long? ownerId;

		private int? instanceCpuCoreCount;

		private string periodUnit;

		private List<string> zoneIds = new List<string>(){ };

		private int? instanceAmount;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string PrivatePoolOptionsMatchCriteria
		{
			get
			{
				return privatePoolOptionsMatchCriteria;
			}
			set	
			{
				privatePoolOptionsMatchCriteria = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.MatchCriteria", value);
			}
		}

		public List<string> InstanceTypes
		{
			get
			{
				return instanceTypes;
			}

			set
			{
				instanceTypes = value;
				for (int i = 0; i < instanceTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceType." + (i + 1) , instanceTypes[i]);
				}
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
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

		public string PrivatePoolOptionsName
		{
			get
			{
				return privatePoolOptionsName;
			}
			set	
			{
				privatePoolOptionsName = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.Name", value);
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

		public string AssuranceTimes
		{
			get
			{
				return assuranceTimes;
			}
			set	
			{
				assuranceTimes = value;
				DictionaryUtil.Add(QueryParameters, "AssuranceTimes", value);
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

		public int? InstanceCpuCoreCount
		{
			get
			{
				return instanceCpuCoreCount;
			}
			set	
			{
				instanceCpuCoreCount = value;
				DictionaryUtil.Add(QueryParameters, "InstanceCpuCoreCount", value.ToString());
			}
		}

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public List<string> ZoneIds
		{
			get
			{
				return zoneIds;
			}

			set
			{
				zoneIds = value;
				for (int i = 0; i < zoneIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ZoneId." + (i + 1) , zoneIds[i]);
				}
			}
		}

		public int? InstanceAmount
		{
			get
			{
				return instanceAmount;
			}
			set	
			{
				instanceAmount = value;
				DictionaryUtil.Add(QueryParameters, "InstanceAmount", value.ToString());
			}
		}

        public override CreateElasticityAssuranceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateElasticityAssuranceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
