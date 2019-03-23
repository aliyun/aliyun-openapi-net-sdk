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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyInstanceAttributeRequest : RpcAcsRequest<ModifyInstanceAttributeResponse>
    {
        public ModifyInstanceAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceAttribute", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private bool? recyclable;

        private string ownerAccount;

        private string description;

        private string creditSpecification;

        private long? ownerId;

        private bool? deletionProtection;

        private string userData;

        private string password;

        private string hostName;

        private string instanceId;

        private string instanceName;

        private string action;

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

        public bool? Recyclable
        {
            get
            {
                return recyclable;
            }
            set
            {
                recyclable = value;
                DictionaryUtil.Add(QueryParameters, "Recyclable", value.ToString());
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

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                DictionaryUtil.Add(QueryParameters, "Description", value);
            }
        }

        public string CreditSpecification
        {
            get
            {
                return creditSpecification;
            }
            set
            {
                creditSpecification = value;
                DictionaryUtil.Add(QueryParameters, "CreditSpecification", value);
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

        public bool? DeletionProtection
        {
            get
            {
                return deletionProtection;
            }
            set
            {
                deletionProtection = value;
                DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
            }
        }

        public string UserData
        {
            get
            {
                return userData;
            }
            set
            {
                userData = value;
                DictionaryUtil.Add(QueryParameters, "UserData", value);
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                DictionaryUtil.Add(QueryParameters, "Password", value);
            }
        }

        public string HostName
        {
            get
            {
                return hostName;
            }
            set
            {
                hostName = value;
                DictionaryUtil.Add(QueryParameters, "HostName", value);
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

        public string InstanceName
        {
            get
            {
                return instanceName;
            }
            set
            {
                instanceName = value;
                DictionaryUtil.Add(QueryParameters, "InstanceName", value);
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

        public override ModifyInstanceAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}