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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ModifyIPv6TranslatorEntryRequest : RpcAcsRequest<ModifyIPv6TranslatorEntryResponse>
    {
        public ModifyIPv6TranslatorEntryRequest()
            : base("Vpc", "2016-04-28", "ModifyIPv6TranslatorEntry", "vpc", "openAPI")
        {
        }

        private int? backendIpv4Port;

        private string aclId;

        private long? resourceOwnerId;

        private string ipv6TranslatorEntryId;

        private string resourceOwnerAccount;

        private string entryName;

        private string ownerAccount;

        private long? ownerId;

        private string aclStatus;

        private int? entryBandwidth;

        private string aclType;

        private int? allocateIpv6Port;

        private string entryDescription;

        private string regionId;

        private string action;

        private string backendIpv4Addr;

        private string transProtocol;

        public int? BackendIpv4Port
        {
            get
            {
                return backendIpv4Port;
            }
            set
            {
                backendIpv4Port = value;
                DictionaryUtil.Add(QueryParameters, "BackendIpv4Port", value.ToString());
            }
        }

        public string AclId
        {
            get
            {
                return aclId;
            }
            set
            {
                aclId = value;
                DictionaryUtil.Add(QueryParameters, "AclId", value);
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

        public string Ipv6TranslatorEntryId
        {
            get
            {
                return ipv6TranslatorEntryId;
            }
            set
            {
                ipv6TranslatorEntryId = value;
                DictionaryUtil.Add(QueryParameters, "Ipv6TranslatorEntryId", value);
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

        public string EntryName
        {
            get
            {
                return entryName;
            }
            set
            {
                entryName = value;
                DictionaryUtil.Add(QueryParameters, "EntryName", value);
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

        public string AclStatus
        {
            get
            {
                return aclStatus;
            }
            set
            {
                aclStatus = value;
                DictionaryUtil.Add(QueryParameters, "AclStatus", value);
            }
        }

        public int? EntryBandwidth
        {
            get
            {
                return entryBandwidth;
            }
            set
            {
                entryBandwidth = value;
                DictionaryUtil.Add(QueryParameters, "EntryBandwidth", value.ToString());
            }
        }

        public string AclType
        {
            get
            {
                return aclType;
            }
            set
            {
                aclType = value;
                DictionaryUtil.Add(QueryParameters, "AclType", value);
            }
        }

        public int? AllocateIpv6Port
        {
            get
            {
                return allocateIpv6Port;
            }
            set
            {
                allocateIpv6Port = value;
                DictionaryUtil.Add(QueryParameters, "AllocateIpv6Port", value.ToString());
            }
        }

        public string EntryDescription
        {
            get
            {
                return entryDescription;
            }
            set
            {
                entryDescription = value;
                DictionaryUtil.Add(QueryParameters, "EntryDescription", value);
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

        public string BackendIpv4Addr
        {
            get
            {
                return backendIpv4Addr;
            }
            set
            {
                backendIpv4Addr = value;
                DictionaryUtil.Add(QueryParameters, "BackendIpv4Addr", value);
            }
        }

        public string TransProtocol
        {
            get
            {
                return transProtocol;
            }
            set
            {
                transProtocol = value;
                DictionaryUtil.Add(QueryParameters, "TransProtocol", value);
            }
        }

        public override ModifyIPv6TranslatorEntryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyIPv6TranslatorEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}