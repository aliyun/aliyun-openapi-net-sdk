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
    public class CreateSnapshotRequest : RpcAcsRequest<CreateSnapshotResponse>
    {
        public CreateSnapshotRequest()
            : base("Ecs", "2014-05-26", "CreateSnapshot", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string clientToken;

        private string ownerAccount;

        private string action;

        private string description;

        private string diskId;

        private string snapshotName;

        private List<Tag> tags;

        private long? ownerId;

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

        public string DiskId
        {
            get
            {
                return diskId;
            }
            set
            {
                diskId = value;
                DictionaryUtil.Add(QueryParameters, "DiskId", value);
            }
        }

        public string SnapshotName
        {
            get
            {
                return snapshotName;
            }
            set
            {
                snapshotName = value;
                DictionaryUtil.Add(QueryParameters, "SnapshotName", value);
            }
        }

        public List<Tag> Tags
        {
            get
            {
                return tags;
            }

            set
            {
                tags = value;
                for (int i = 0; i < tags.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Value", tags[i].Value);
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Key", tags[i].Key);
                }
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

        public class Tag
        {

            private string value_;

            private string key;

            public string Value
            {
                get
                {
                    return value_;
                }
                set
                {
                    value_ = value;
                }
            }

            public string Key
            {
                get
                {
                    return key;
                }
                set
                {
                    key = value;
                }
            }
        }

        public override CreateSnapshotResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateSnapshotResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}