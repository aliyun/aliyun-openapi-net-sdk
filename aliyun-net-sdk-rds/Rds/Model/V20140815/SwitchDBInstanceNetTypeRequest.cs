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
    public class SwitchDBInstanceNetTypeRequest : RpcAcsRequest<SwitchDBInstanceNetTypeResponse>
    {
        public SwitchDBInstanceNetTypeRequest()
            : base("Rds", "2014-08-15", "SwitchDBInstanceNetType", "rds", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string connectionStringPrefix;

        private string connectionStringType;

        private string resourceOwnerAccount;

        private string clientToken;

        private string port;

        private string ownerAccount;

        private string action;

        private string dBInstanceId;

        private long? ownerId;

        private string accessKeyId;

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

        public string ConnectionStringPrefix
        {
            get
            {
                return connectionStringPrefix;
            }
            set
            {
                connectionStringPrefix = value;
                DictionaryUtil.Add(QueryParameters, "ConnectionStringPrefix", value);
            }
        }

        public string ConnectionStringType
        {
            get
            {
                return connectionStringType;
            }
            set
            {
                connectionStringType = value;
                DictionaryUtil.Add(QueryParameters, "ConnectionStringType", value);
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

        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
                DictionaryUtil.Add(QueryParameters, "Port", value);
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

        public override SwitchDBInstanceNetTypeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SwitchDBInstanceNetTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}