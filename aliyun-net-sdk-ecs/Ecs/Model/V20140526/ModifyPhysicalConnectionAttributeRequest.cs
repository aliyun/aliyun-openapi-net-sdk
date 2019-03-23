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
    public class ModifyPhysicalConnectionAttributeRequest : RpcAcsRequest<ModifyPhysicalConnectionAttributeResponse>
    {
        public ModifyPhysicalConnectionAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyPhysicalConnectionAttribute", "ecs", "openAPI")
        {
        }

        private string redundantPhysicalConnectionId;

        private string peerLocation;

        private long? resourceOwnerId;

        private string portType;

        private string circuitCode;

        private int? bandwidth;

        private string clientToken;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private string description;

        private long? ownerId;

        private string lineOperator;

        private string regionId;

        private string physicalConnectionId;

        private string name;

        private string action;

        private string userCidr;

        public string RedundantPhysicalConnectionId
        {
            get
            {
                return redundantPhysicalConnectionId;
            }
            set
            {
                redundantPhysicalConnectionId = value;
                DictionaryUtil.Add(QueryParameters, "RedundantPhysicalConnectionId", value);
            }
        }

        public string PeerLocation
        {
            get
            {
                return peerLocation;
            }
            set
            {
                peerLocation = value;
                DictionaryUtil.Add(QueryParameters, "PeerLocation", value);
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

        public string PortType
        {
            get
            {
                return portType;
            }
            set
            {
                portType = value;
                DictionaryUtil.Add(QueryParameters, "PortType", value);
            }
        }

        public string CircuitCode
        {
            get
            {
                return circuitCode;
            }
            set
            {
                circuitCode = value;
                DictionaryUtil.Add(QueryParameters, "CircuitCode", value);
            }
        }

        public int? Bandwidth
        {
            get
            {
                return bandwidth;
            }
            set
            {
                bandwidth = value;
                DictionaryUtil.Add(QueryParameters, "bandwidth", value.ToString());
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

        public string LineOperator
        {
            get
            {
                return lineOperator;
            }
            set
            {
                lineOperator = value;
                DictionaryUtil.Add(QueryParameters, "LineOperator", value);
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

        public string PhysicalConnectionId
        {
            get
            {
                return physicalConnectionId;
            }
            set
            {
                physicalConnectionId = value;
                DictionaryUtil.Add(QueryParameters, "PhysicalConnectionId", value);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                DictionaryUtil.Add(QueryParameters, "Name", value);
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

        public string UserCidr
        {
            get
            {
                return userCidr;
            }
            set
            {
                userCidr = value;
                DictionaryUtil.Add(QueryParameters, "UserCidr", value);
            }
        }

        public override ModifyPhysicalConnectionAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyPhysicalConnectionAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}