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
    public class CreateRouteEntryRequest : RpcAcsRequest<CreateRouteEntryResponse>
    {
        public CreateRouteEntryRequest()
            : base("Vpc", "2016-04-28", "CreateRouteEntry", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string routeEntryName;

        private string resourceOwnerAccount;

        private string clientToken;

        private string destinationCidrBlock;

        private string ownerAccount;

        private long? ownerId;

        private string privateIpAddress;

        private string regionId;

        private string action;

        private string nextHopId;

        private string nextHopType;

        private List<NextHopList> nextHopLists;

        private string routeTableId;

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

        public string RouteEntryName
        {
            get
            {
                return routeEntryName;
            }
            set
            {
                routeEntryName = value;
                DictionaryUtil.Add(QueryParameters, "RouteEntryName", value);
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

        public string DestinationCidrBlock
        {
            get
            {
                return destinationCidrBlock;
            }
            set
            {
                destinationCidrBlock = value;
                DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
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

        public string NextHopId
        {
            get
            {
                return nextHopId;
            }
            set
            {
                nextHopId = value;
                DictionaryUtil.Add(QueryParameters, "NextHopId", value);
            }
        }

        public string NextHopType
        {
            get
            {
                return nextHopType;
            }
            set
            {
                nextHopType = value;
                DictionaryUtil.Add(QueryParameters, "NextHopType", value);
            }
        }

        public List<NextHopList> NextHopLists
        {
            get
            {
                return nextHopLists;
            }

            set
            {
                nextHopLists = value;
                for (int i = 0; i < nextHopLists.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "NextHopList." + (i + 1) + ".Weight", nextHopLists[i].Weight);
                    DictionaryUtil.Add(QueryParameters, "NextHopList." + (i + 1) + ".NextHopId", nextHopLists[i].NextHopId);
                    DictionaryUtil.Add(QueryParameters, "NextHopList." + (i + 1) + ".NextHopType", nextHopLists[i].NextHopType);
                }
            }
        }

        public string RouteTableId
        {
            get
            {
                return routeTableId;
            }
            set
            {
                routeTableId = value;
                DictionaryUtil.Add(QueryParameters, "RouteTableId", value);
            }
        }

        public class NextHopList
        {

            private int? weight;

            private string nextHopId;

            private string nextHopType;

            public int? Weight
            {
                get
                {
                    return weight;
                }
                set
                {
                    weight = value;
                }
            }

            public string NextHopId
            {
                get
                {
                    return nextHopId;
                }
                set
                {
                    nextHopId = value;
                }
            }

            public string NextHopType
            {
                get
                {
                    return nextHopType;
                }
                set
                {
                    nextHopType = value;
                }
            }
        }

        public override CreateRouteEntryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}