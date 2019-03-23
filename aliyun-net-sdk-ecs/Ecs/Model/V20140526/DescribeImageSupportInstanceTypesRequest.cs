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
    public class DescribeImageSupportInstanceTypesRequest : RpcAcsRequest<DescribeImageSupportInstanceTypesResponse>
    {
        public DescribeImageSupportInstanceTypesRequest()
            : base("Ecs", "2014-05-26", "DescribeImageSupportInstanceTypes", "ecs", "openAPI")
        {
        }

        private string actionType;

        private List<Filter> filters;

        private long? resourceOwnerId;

        private string imageId;

        private string resourceOwnerAccount;

        private string regionId;

        private string action;

        private long? ownerId;

        public string ActionType
        {
            get
            {
                return actionType;
            }
            set
            {
                actionType = value;
                DictionaryUtil.Add(QueryParameters, "ActionType", value);
            }
        }

        public List<Filter> Filters
        {
            get
            {
                return filters;
            }

            set
            {
                filters = value;
                for (int i = 0; i < filters.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "Filter." + (i + 1) + ".Value", filters[i].Value);
                    DictionaryUtil.Add(QueryParameters, "Filter." + (i + 1) + ".Key", filters[i].Key);
                }
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

        public string ImageId
        {
            get
            {
                return imageId;
            }
            set
            {
                imageId = value;
                DictionaryUtil.Add(QueryParameters, "ImageId", value);
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

        public class Filter
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

        public override DescribeImageSupportInstanceTypesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeImageSupportInstanceTypesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}