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
    public class DescribeTagsRequest : RpcAcsRequest<DescribeTagsResponse>
    {
        public DescribeTagsRequest()
            : base("Ecs", "2014-05-26", "DescribeTags", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceId;

        private string resourceOwnerAccount;

        private string regionId;

        private int? pageSize;

        private string action;

        private List<Tag> tags;

        private long? ownerId;

        private string resourceType;

        private int? pageNumber;

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

        public string ResourceId
        {
            get
            {
                return resourceId;
            }
            set
            {
                resourceId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceId", value);
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

        public int? PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
                DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

        public string ResourceType
        {
            get
            {
                return resourceType;
            }
            set
            {
                resourceType = value;
                DictionaryUtil.Add(QueryParameters, "ResourceType", value);
            }
        }

        public int? PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
                DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

        public override DescribeTagsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}