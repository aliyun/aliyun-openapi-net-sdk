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
    public class SwitchDBInstanceVpcRequest : RpcAcsRequest<SwitchDBInstanceVpcResponse>
    {
        public SwitchDBInstanceVpcRequest()
            : base("Rds", "2014-08-15", "SwitchDBInstanceVpc", "rds", "openAPI")
        {
        }

        private string vSwitchId;

        private string privateIpAddress;

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string vPCId;

        private string ownerAccount;

        private string action;

        private string dBInstanceId;

        private long? ownerId;

        private string accessKeyId;

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

        public override SwitchDBInstanceVpcResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SwitchDBInstanceVpcResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}