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
    public class RemoveIPv6TranslatorAclListEntryRequest : RpcAcsRequest<RemoveIPv6TranslatorAclListEntryResponse>
    {
        public RemoveIPv6TranslatorAclListEntryRequest()
            : base("Vpc", "2016-04-28", "RemoveIPv6TranslatorAclListEntry", "vpc", "openAPI")
        {
        }

        private string aclId;

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string clientToken;

        private string regionId;

        private string ownerAccount;

        private string action;

        private long? ownerId;

        private string aclEntryId;

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

        public string AclEntryId
        {
            get
            {
                return aclEntryId;
            }
            set
            {
                aclEntryId = value;
                DictionaryUtil.Add(QueryParameters, "AclEntryId", value);
            }
        }

        public override RemoveIPv6TranslatorAclListEntryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RemoveIPv6TranslatorAclListEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}