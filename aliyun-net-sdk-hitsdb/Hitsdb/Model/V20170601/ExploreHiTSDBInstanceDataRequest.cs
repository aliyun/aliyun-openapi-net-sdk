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
using Aliyun.Acs.hitsdb.Transform;
using Aliyun.Acs.hitsdb.Transform.V20170601;

namespace Aliyun.Acs.hitsdb.Model.V20170601
{
    public class ExploreHiTSDBInstanceDataRequest : RpcAcsRequest<ExploreHiTSDBInstanceDataResponse>
    {
        public ExploreHiTSDBInstanceDataRequest()
            : base("hitsdb", "2017-06-01", "ExploreHiTSDBInstanceData", "hitsdb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reverseVpcIp;

		private long? resourceOwnerId;

		private int? reverseVpcPort;

		private string passWord;

		private string securityToken;

		private long? end;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string aggregator;

		private long? start;

		private long? ownerId;

		private string tagFilter;

		private string instanceId;

		private string metric;

		private string downSampleAggregator;

		private string downSampleTime;

		private string userName;

		public string ReverseVpcIp
		{
			get
			{
				return reverseVpcIp;
			}
			set	
			{
				reverseVpcIp = value;
				DictionaryUtil.Add(QueryParameters, "ReverseVpcIp", value);
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

		public int? ReverseVpcPort
		{
			get
			{
				return reverseVpcPort;
			}
			set	
			{
				reverseVpcPort = value;
				DictionaryUtil.Add(QueryParameters, "ReverseVpcPort", value.ToString());
			}
		}

		public string PassWord
		{
			get
			{
				return passWord;
			}
			set	
			{
				passWord = value;
				DictionaryUtil.Add(QueryParameters, "PassWord", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public long? End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
				DictionaryUtil.Add(QueryParameters, "End", value.ToString());
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

		public string Aggregator
		{
			get
			{
				return aggregator;
			}
			set	
			{
				aggregator = value;
				DictionaryUtil.Add(QueryParameters, "Aggregator", value);
			}
		}

		public long? Start
		{
			get
			{
				return start;
			}
			set	
			{
				start = value;
				DictionaryUtil.Add(QueryParameters, "Start", value.ToString());
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

		public string TagFilter
		{
			get
			{
				return tagFilter;
			}
			set	
			{
				tagFilter = value;
				DictionaryUtil.Add(QueryParameters, "TagFilter", value);
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

		public string Metric
		{
			get
			{
				return metric;
			}
			set	
			{
				metric = value;
				DictionaryUtil.Add(QueryParameters, "Metric", value);
			}
		}

		public string DownSampleAggregator
		{
			get
			{
				return downSampleAggregator;
			}
			set	
			{
				downSampleAggregator = value;
				DictionaryUtil.Add(QueryParameters, "DownSampleAggregator", value);
			}
		}

		public string DownSampleTime
		{
			get
			{
				return downSampleTime;
			}
			set	
			{
				downSampleTime = value;
				DictionaryUtil.Add(QueryParameters, "DownSampleTime", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExploreHiTSDBInstanceDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExploreHiTSDBInstanceDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
