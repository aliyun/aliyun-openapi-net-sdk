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
    public class ModifyPrepayInstanceSpecRequest : RpcAcsRequest<ModifyPrepayInstanceSpecResponse>
    {
        public ModifyPrepayInstanceSpecRequest()
            : base("Ecs", "2014-05-26", "ModifyPrepayInstanceSpec", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private bool? autoPay;

        private string resourceOwnerAccount;

        private string clientToken;

        private string ownerAccount;

        private long? ownerId;

        private string operatorType;

        private string systemDiskCategory;

        private string instanceId;

        private string regionId;

        private bool? migrateAcrossZone;

        private string action;

        private string instanceType;

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

        public bool? AutoPay
        {
            get
            {
                return autoPay;
            }
            set
            {
                autoPay = value;
                DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
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

        public string OperatorType
        {
            get
            {
                return operatorType;
            }
            set
            {
                operatorType = value;
                DictionaryUtil.Add(QueryParameters, "OperatorType", value);
            }
        }

        public string SystemDiskCategory
        {
            get
            {
                return systemDiskCategory;
            }
            set
            {
                systemDiskCategory = value;
                DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
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

        public bool? MigrateAcrossZone
        {
            get
            {
                return migrateAcrossZone;
            }
            set
            {
                migrateAcrossZone = value;
                DictionaryUtil.Add(QueryParameters, "MigrateAcrossZone", value.ToString());
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

        public string InstanceType
        {
            get
            {
                return instanceType;
            }
            set
            {
                instanceType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceType", value);
            }
        }

        public override ModifyPrepayInstanceSpecResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyPrepayInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}