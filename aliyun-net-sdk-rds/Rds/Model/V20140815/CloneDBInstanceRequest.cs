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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CloneDBInstanceRequest : RpcAcsRequest<CloneDBInstanceResponse>
    {
        public CloneDBInstanceRequest()
            : base("Rds", "2014-08-15", "CloneDBInstance")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string clientToken;

		private string dBInstanceClass;

		private int? dBInstanceStorage;

		private string dBInstanceDescription;

		private string payType;

		private string instanceNetworkType;

		private string dBInstanceId;

		private string backupId;

		private string restoreTime;

		private string vPCId;

		private string vSwitchId;

		private string privateIpAddress;

		private string ownerAccount;

		private string usedTime;

		private string period;

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

		public string DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		public int? DBInstanceStorage
		{
			get
			{
				return dBInstanceStorage;
			}
			set	
			{
				dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		public string DBInstanceDescription
		{
			get
			{
				return dBInstanceDescription;
			}
			set	
			{
				dBInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceDescription", value);
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

		public string BackupId
		{
			get
			{
				return backupId;
			}
			set	
			{
				backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
			}
		}

		public string RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
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

		public string UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value);
			}
		}

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

        public override CloneDBInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CloneDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}