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
using Aliyun.Acs.gpdb;
using Aliyun.Acs.gpdb.Transform;
using Aliyun.Acs.gpdb.Transform.V20160503;

namespace Aliyun.Acs.gpdb.Model.V20160503
{
    public class CreateECSDBInstanceRequest : RpcAcsRequest<CreateECSDBInstanceResponse>
    {
        public CreateECSDBInstanceRequest()
            : base("gpdb", "2016-05-03", "CreateECSDBInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.gpdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.gpdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string engineVersion;

		private string dBInstanceCategory;

		private string encryptionType;

		private string dBInstanceDescription;

		private string period;

		private string backupId;

		private string encryptionKey;

		private long? ownerId;

		private string securityIPList;

		private string vSwitchId;

		private string privateIpAddress;

		private string zoneId;

		private string instanceNetworkType;

		private string clientToken;

		private string instanceSpec;

		private int? storageSize;

		private string segStorageType;

		private int? masterNodeNum;

		private int? segNodeNum;

		private string engine;

		private string usedTime;

		private string vPCId;

		private string payType;

		private string srcDbInstanceName;

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public string DBInstanceCategory
		{
			get
			{
				return dBInstanceCategory;
			}
			set	
			{
				dBInstanceCategory = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceCategory", value);
			}
		}

		public string EncryptionType
		{
			get
			{
				return encryptionType;
			}
			set	
			{
				encryptionType = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionType", value);
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

		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionKey", value);
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

		public string SecurityIPList
		{
			get
			{
				return securityIPList;
			}
			set	
			{
				securityIPList = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPList", value);
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

		public string InstanceSpec
		{
			get
			{
				return instanceSpec;
			}
			set	
			{
				instanceSpec = value;
				DictionaryUtil.Add(QueryParameters, "InstanceSpec", value);
			}
		}

		public int? StorageSize
		{
			get
			{
				return storageSize;
			}
			set	
			{
				storageSize = value;
				DictionaryUtil.Add(QueryParameters, "StorageSize", value.ToString());
			}
		}

		public string SegStorageType
		{
			get
			{
				return segStorageType;
			}
			set	
			{
				segStorageType = value;
				DictionaryUtil.Add(QueryParameters, "SegStorageType", value);
			}
		}

		public int? MasterNodeNum
		{
			get
			{
				return masterNodeNum;
			}
			set	
			{
				masterNodeNum = value;
				DictionaryUtil.Add(QueryParameters, "MasterNodeNum", value.ToString());
			}
		}

		public int? SegNodeNum
		{
			get
			{
				return segNodeNum;
			}
			set	
			{
				segNodeNum = value;
				DictionaryUtil.Add(QueryParameters, "SegNodeNum", value.ToString());
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
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

		public string SrcDbInstanceName
		{
			get
			{
				return srcDbInstanceName;
			}
			set	
			{
				srcDbInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "SrcDbInstanceName", value);
			}
		}

        public override CreateECSDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateECSDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
