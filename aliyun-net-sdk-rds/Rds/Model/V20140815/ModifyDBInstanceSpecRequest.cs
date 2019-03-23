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
    public class ModifyDBInstanceSpecRequest : RpcAcsRequest<ModifyDBInstanceSpecResponse>
    {
        public ModifyDBInstanceSpecRequest()
            : base("Rds", "2014-08-15", "ModifyDBInstanceSpec", "rds", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? dBInstanceStorage;

        private string resourceOwnerAccount;

        private string clientToken;

        private string ownerAccount;

        private string engineVersion;

        private long? ownerId;

        private string accessKeyId;

        private string dBInstanceClass;

        private string effectiveTime;

        private string action;

        private string dBInstanceId;

        private string payType;

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

        public string EffectiveTime
        {
            get
            {
                return effectiveTime;
            }
            set
            {
                effectiveTime = value;
                DictionaryUtil.Add(QueryParameters, "EffectiveTime", value);
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

        public override ModifyDBInstanceSpecResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}