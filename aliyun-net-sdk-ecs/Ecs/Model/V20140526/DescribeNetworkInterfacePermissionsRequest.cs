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
    public class DescribeNetworkInterfacePermissionsRequest : RpcAcsRequest<DescribeNetworkInterfacePermissionsResponse>
    {
        public DescribeNetworkInterfacePermissionsRequest()
            : base("Ecs", "2014-05-26", "DescribeNetworkInterfacePermissions", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? pageNumber;

        private string regionId;

        private int? pageSize;

        private string action;

        private List<string> networkInterfacePermissionIds;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private string networkInterfaceId;

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

        public List<string> NetworkInterfacePermissionIds
        {
            get
            {
                return networkInterfacePermissionIds;
            }

            set
            {
                networkInterfacePermissionIds = value;
                for (int i = 0; i < networkInterfacePermissionIds.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "NetworkInterfacePermissionId." + (i + 1), networkInterfacePermissionIds[i]);
                }
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

        public string NetworkInterfaceId
        {
            get
            {
                return networkInterfaceId;
            }
            set
            {
                networkInterfaceId = value;
                DictionaryUtil.Add(QueryParameters, "NetworkInterfaceId", value);
            }
        }

        public override DescribeNetworkInterfacePermissionsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeNetworkInterfacePermissionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}