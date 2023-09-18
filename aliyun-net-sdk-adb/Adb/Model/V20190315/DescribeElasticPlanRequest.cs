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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class DescribeElasticPlanRequest : RpcAcsRequest<DescribeElasticPlanResponse>
    {
        public DescribeElasticPlanRequest()
            : base("adb", "2019-03-15", "DescribeElasticPlan", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private bool? elasticPlanEnable;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private long? ownerId;

		private string elasticPlanName;

		private string resourcePoolName;

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

		public bool? ElasticPlanEnable
		{
			get
			{
				return elasticPlanEnable;
			}
			set	
			{
				elasticPlanEnable = value;
				DictionaryUtil.Add(QueryParameters, "ElasticPlanEnable", value.ToString());
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
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

		public string ElasticPlanName
		{
			get
			{
				return elasticPlanName;
			}
			set	
			{
				elasticPlanName = value;
				DictionaryUtil.Add(QueryParameters, "ElasticPlanName", value);
			}
		}

		public string ResourcePoolName
		{
			get
			{
				return resourcePoolName;
			}
			set	
			{
				resourcePoolName = value;
				DictionaryUtil.Add(QueryParameters, "ResourcePoolName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeElasticPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeElasticPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
