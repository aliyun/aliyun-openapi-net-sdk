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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("Rds", "2014-08-15", "DescribePrice", "rds", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? dBInstanceStorage;

        private int? quantity;

        private string resourceOwnerAccount;

        private string clientToken;

        private string ownerAccount;

        private string commodityCode;

        private string engineVersion;

        private long? ownerId;

        private string usedTime;

        private string accessKeyId;

        private string dBInstanceClass;

        private int? instanceUsedType;

        private string regionId;

        private string engine;

        private string action;

        private string zoneId;

        private string timeType;

        private string payType;

        private string orderType;

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

        public int? DBInstanceStorage
        {
            get
            {
                return dBInstanceStorage;
            }
            set
            {
                dBInstanceStorage = value;
                DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
            }
        }

        public int? Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
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

        public string CommodityCode
        {
            get
            {
                return commodityCode;
            }
            set
            {
                commodityCode = value;
                DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
            }
        }

        public string EngineVersion
        {
            get
            {
                return engineVersion;
            }
            set
            {
                engineVersion = value;
                DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
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

        public string UsedTime
        {
            get
            {
                return usedTime;
            }
            set
            {
                usedTime = value;
                DictionaryUtil.Add(QueryParameters, "UsedTime", value);
            }
        }

        public string AccessKeyId
        {
            get
            {
                return accessKeyId;
            }
            set
            {
                accessKeyId = value;
                DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
            }
        }

        public string DBInstanceClass
        {
            get
            {
                return dBInstanceClass;
            }
            set
            {
                dBInstanceClass = value;
                DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
            }
        }

        public int? InstanceUsedType
        {
            get
            {
                return instanceUsedType;
            }
            set
            {
                instanceUsedType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceUsedType", value.ToString());
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

        public string Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
                DictionaryUtil.Add(QueryParameters, "Engine", value);
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

        public string ZoneId
        {
            get
            {
                return zoneId;
            }
            set
            {
                zoneId = value;
                DictionaryUtil.Add(QueryParameters, "ZoneId", value);
            }
        }

        public string TimeType
        {
            get
            {
                return timeType;
            }
            set
            {
                timeType = value;
                DictionaryUtil.Add(QueryParameters, "TimeType", value);
            }
        }

        public string PayType
        {
            get
            {
                return payType;
            }
            set
            {
                payType = value;
                DictionaryUtil.Add(QueryParameters, "PayType", value);
            }
        }

        public string OrderType
        {
            get
            {
                return orderType;
            }
            set
            {
                orderType = value;
                DictionaryUtil.Add(QueryParameters, "OrderType", value);
            }
        }

        public override DescribePriceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}