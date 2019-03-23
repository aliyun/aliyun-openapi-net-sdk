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
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateDBInstance", "rds", "openAPI")
        {
        }

        private string connectionMode;

        private long? resourceOwnerId;

        private int? dBInstanceStorage;

        private string systemDBCharset;

        private string clientToken;

        private string engineVersion;

        private string accessKeyId;

        private string resourceGroupId;

        private string regionId;

        private string engine;

        private string action;

        private string dBInstanceDescription;

        private string dBInstanceStorageType;

        private string businessInfo;

        private string dBInstanceNetType;

        private string period;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private string usedTime;

        private string dBInstanceClass;

        private string securityIPList;

        private string vSwitchId;

        private string privateIpAddress;

        private string vPCId;

        private string tunnelId;

        private string zoneId;

        private string payType;

        private string instanceNetworkType;

        public string ConnectionMode
        {
            get
            {
                return connectionMode;
            }
            set
            {
                connectionMode = value;
                DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
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

        public string SystemDBCharset
        {
            get
            {
                return systemDBCharset;
            }
            set
            {
                systemDBCharset = value;
                DictionaryUtil.Add(QueryParameters, "SystemDBCharset", value);
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

        public string AccessKeyId
        {
            get
            {
                return accessKeyId;
            }
            set
            {
                accessKeyId = value;
                DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
            }
        }

        public string ResourceGroupId
        {
            get
            {
                return resourceGroupId;
            }
            set
            {
                resourceGroupId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
            }
        }

        public string RegionId
        {
            get
            {
                return regionId;
            }
            set
            {
                regionId = value;
                DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

        public string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
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

        public string DBInstanceStorageType
        {
            get
            {
                return dBInstanceStorageType;
            }
            set
            {
                dBInstanceStorageType = value;
                DictionaryUtil.Add(QueryParameters, "DBInstanceStorageType", value);
            }
        }

        public string BusinessInfo
        {
            get
            {
                return businessInfo;
            }
            set
            {
                businessInfo = value;
                DictionaryUtil.Add(QueryParameters, "BusinessInfo", value);
            }
        }

        public string DBInstanceNetType
        {
            get
            {
                return dBInstanceNetType;
            }
            set
            {
                dBInstanceNetType = value;
                DictionaryUtil.Add(QueryParameters, "DBInstanceNetType", value);
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

        public string TunnelId
        {
            get
            {
                return tunnelId;
            }
            set
            {
                tunnelId = value;
                DictionaryUtil.Add(QueryParameters, "TunnelId", value);
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

        public override CreateDBInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}