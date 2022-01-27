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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDBInstanceNetworkTypeRequest : RpcAcsRequest<ModifyDBInstanceNetworkTypeResponse>
    {
        public ModifyDBInstanceNetworkTypeRequest()
            : base("Rds", "2014-08-15", "ModifyDBInstanceNetworkType", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string classicExpiredDays;

		private string dBInstanceId;

		private string readWriteSplittingPrivateIpAddress;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string vSwitchId;

		private string privateIpAddress;

		private string retainClassic;

		private string vPCId;

		private string instanceNetworkType;

		private int? readWriteSplittingClassicExpiredDays;

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

		public string ClassicExpiredDays
		{
			get
			{
				return classicExpiredDays;
			}
			set	
			{
				classicExpiredDays = value;
				DictionaryUtil.Add(QueryParameters, "ClassicExpiredDays", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string ReadWriteSplittingPrivateIpAddress
		{
			get
			{
				return readWriteSplittingPrivateIpAddress;
			}
			set	
			{
				readWriteSplittingPrivateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReadWriteSplittingPrivateIpAddress", value);
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

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string RetainClassic
		{
			get
			{
				return retainClassic;
			}
			set	
			{
				retainClassic = value;
				DictionaryUtil.Add(QueryParameters, "RetainClassic", value);
			}
		}

		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
			}
		}

		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		public int? ReadWriteSplittingClassicExpiredDays
		{
			get
			{
				return readWriteSplittingClassicExpiredDays;
			}
			set	
			{
				readWriteSplittingClassicExpiredDays = value;
				DictionaryUtil.Add(QueryParameters, "ReadWriteSplittingClassicExpiredDays", value.ToString());
			}
		}

        public override ModifyDBInstanceNetworkTypeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceNetworkTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
