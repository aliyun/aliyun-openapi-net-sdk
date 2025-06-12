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
using Aliyun.Acs.clickhouse.Transform;
using Aliyun.Acs.clickhouse.Transform.V20191111;

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
    public class CheckClickhouseToRDSRequest : RpcAcsRequest<CheckClickhouseToRDSResponse>
    {
        public CheckClickhouseToRDSRequest()
            : base("clickhouse", "2019-11-11", "CheckClickhouseToRDS", "service", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string rdsVpcId;

		private string ckPassword;

		private string rdsPassword;

		private string ckUserName;

		private string resourceOwnerAccount;

		private string dbClusterId;

		private string ownerAccount;

		private string rdsId;

		private long? ownerId;

		private long? clickhousePort;

		private long? rdsPort;

		private string rdsVpcUrl;

		private string rdsUserName;

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

		public string RdsVpcId
		{
			get
			{
				return rdsVpcId;
			}
			set	
			{
				rdsVpcId = value;
				DictionaryUtil.Add(QueryParameters, "RdsVpcId", value);
			}
		}

		public string CkPassword
		{
			get
			{
				return ckPassword;
			}
			set	
			{
				ckPassword = value;
				DictionaryUtil.Add(QueryParameters, "CkPassword", value);
			}
		}

		public string RdsPassword
		{
			get
			{
				return rdsPassword;
			}
			set	
			{
				rdsPassword = value;
				DictionaryUtil.Add(QueryParameters, "RdsPassword", value);
			}
		}

		public string CkUserName
		{
			get
			{
				return ckUserName;
			}
			set	
			{
				ckUserName = value;
				DictionaryUtil.Add(QueryParameters, "CkUserName", value);
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

		public string DbClusterId
		{
			get
			{
				return dbClusterId;
			}
			set	
			{
				dbClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DbClusterId", value);
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

		public string RdsId
		{
			get
			{
				return rdsId;
			}
			set	
			{
				rdsId = value;
				DictionaryUtil.Add(QueryParameters, "RdsId", value);
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

		public long? ClickhousePort
		{
			get
			{
				return clickhousePort;
			}
			set	
			{
				clickhousePort = value;
				DictionaryUtil.Add(QueryParameters, "ClickhousePort", value.ToString());
			}
		}

		public long? RdsPort
		{
			get
			{
				return rdsPort;
			}
			set	
			{
				rdsPort = value;
				DictionaryUtil.Add(QueryParameters, "RdsPort", value.ToString());
			}
		}

		public string RdsVpcUrl
		{
			get
			{
				return rdsVpcUrl;
			}
			set	
			{
				rdsVpcUrl = value;
				DictionaryUtil.Add(QueryParameters, "RdsVpcUrl", value);
			}
		}

		public string RdsUserName
		{
			get
			{
				return rdsUserName;
			}
			set	
			{
				rdsUserName = value;
				DictionaryUtil.Add(QueryParameters, "RdsUserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckClickhouseToRDSResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckClickhouseToRDSResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
