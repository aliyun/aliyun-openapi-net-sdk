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
    public class DescribeInstancesRequest : RpcAcsRequest<DescribeInstancesResponse>
    {
        public DescribeInstancesRequest()
            : base("Ecs", "2014-05-26", "DescribeInstances", "ecs", "openAPI")
        {
        }

        private string innerIpAddresses;

        private long? resourceOwnerId;

        private string imageId;

        private string privateIpAddresses;

        private string hpcClusterId;

        private string filter2Value;

        private string filter4Value;

        private bool? ioOptimized;

        private string securityGroupId;

        private string keyPairName;

        private string filter4Key;

        private int? pageNumber;

        private string resourceGroupId;

        private string lockReason;

        private string filter1Key;

        private string regionId;

        private string rdmaIpAddresses;

        private bool? deviceAvailable;

        private int? pageSize;

        private string action;

        private string publicIpAddresses;

        private string instanceType;

        private List<Tag> tags;

        private string instanceChargeType;

        private string filter3Value;

        private bool? dryRun;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private string instanceTypeFamily;

        private string filter1Value;

        private bool? needSaleCycle;

        private string filter2Key;

        private long? ownerId;

        private string vSwitchId;

        private string eipAddresses;

        private string instanceName;

        private string instanceIds;

        private string internetChargeType;

        private string vpcId;

        private string zoneId;

        private string filter3Key;

        private string instanceNetworkType;

        private string status;

        public string InnerIpAddresses
        {
            get
            {
                return innerIpAddresses;
            }
            set
            {
                innerIpAddresses = value;
                DictionaryUtil.Add(QueryParameters, "InnerIpAddresses", value);
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

        public string PrivateIpAddresses
        {
            get
            {
                return privateIpAddresses;
            }
            set
            {
                privateIpAddresses = value;
                DictionaryUtil.Add(QueryParameters, "PrivateIpAddresses", value);
            }
        }

        public string HpcClusterId
        {
            get
            {
                return hpcClusterId;
            }
            set
            {
                hpcClusterId = value;
                DictionaryUtil.Add(QueryParameters, "HpcClusterId", value);
            }
        }

        public string Filter2Value
        {
            get
            {
                return filter2Value;
            }
            set
            {
                filter2Value = value;
                DictionaryUtil.Add(QueryParameters, "Filter.2.Value", value);
            }
        }

        public string Filter4Value
        {
            get
            {
                return filter4Value;
            }
            set
            {
                filter4Value = value;
                DictionaryUtil.Add(QueryParameters, "Filter.4.Value", value);
            }
        }

        public bool? IoOptimized
        {
            get
            {
                return ioOptimized;
            }
            set
            {
                ioOptimized = value;
                DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
            }
        }

        public string SecurityGroupId
        {
            get
            {
                return securityGroupId;
            }
            set
            {
                securityGroupId = value;
                DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
            }
        }

        public string KeyPairName
        {
            get
            {
                return keyPairName;
            }
            set
            {
                keyPairName = value;
                DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
            }
        }

        public string Filter4Key
        {
            get
            {
                return filter4Key;
            }
            set
            {
                filter4Key = value;
                DictionaryUtil.Add(QueryParameters, "Filter.4.Key", value);
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

        public string ResourceGroupId
        {
            get
            {
                return resourceGroupId;
            }
            set
            {
                resourceGroupId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
            }
        }

        public string LockReason
        {
            get
            {
                return lockReason;
            }
            set
            {
                lockReason = value;
                DictionaryUtil.Add(QueryParameters, "LockReason", value);
            }
        }

        public string Filter1Key
        {
            get
            {
                return filter1Key;
            }
            set
            {
                filter1Key = value;
                DictionaryUtil.Add(QueryParameters, "Filter.1.Key", value);
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

        public string RdmaIpAddresses
        {
            get
            {
                return rdmaIpAddresses;
            }
            set
            {
                rdmaIpAddresses = value;
                DictionaryUtil.Add(QueryParameters, "RdmaIpAddresses", value);
            }
        }

        public bool? DeviceAvailable
        {
            get
            {
                return deviceAvailable;
            }
            set
            {
                deviceAvailable = value;
                DictionaryUtil.Add(QueryParameters, "DeviceAvailable", value.ToString());
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

        public string PublicIpAddresses
        {
            get
            {
                return publicIpAddresses;
            }
            set
            {
                publicIpAddresses = value;
                DictionaryUtil.Add(QueryParameters, "PublicIpAddresses", value);
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

        public string InstanceChargeType
        {
            get
            {
                return instanceChargeType;
            }
            set
            {
                instanceChargeType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
            }
        }

        public string Filter3Value
        {
            get
            {
                return filter3Value;
            }
            set
            {
                filter3Value = value;
                DictionaryUtil.Add(QueryParameters, "Filter.3.Value", value);
            }
        }

        public bool? DryRun
        {
            get
            {
                return dryRun;
            }
            set
            {
                dryRun = value;
                DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

        public string InstanceTypeFamily
        {
            get
            {
                return instanceTypeFamily;
            }
            set
            {
                instanceTypeFamily = value;
                DictionaryUtil.Add(QueryParameters, "InstanceTypeFamily", value);
            }
        }

        public string Filter1Value
        {
            get
            {
                return filter1Value;
            }
            set
            {
                filter1Value = value;
                DictionaryUtil.Add(QueryParameters, "Filter.1.Value", value);
            }
        }

        public bool? NeedSaleCycle
        {
            get
            {
                return needSaleCycle;
            }
            set
            {
                needSaleCycle = value;
                DictionaryUtil.Add(QueryParameters, "NeedSaleCycle", value.ToString());
            }
        }

        public string Filter2Key
        {
            get
            {
                return filter2Key;
            }
            set
            {
                filter2Key = value;
                DictionaryUtil.Add(QueryParameters, "Filter.2.Key", value);
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

        public string VSwitchId
        {
            get
            {
                return vSwitchId;
            }
            set
            {
                vSwitchId = value;
                DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
            }
        }

        public string EipAddresses
        {
            get
            {
                return eipAddresses;
            }
            set
            {
                eipAddresses = value;
                DictionaryUtil.Add(QueryParameters, "EipAddresses", value);
            }
        }

        public string InstanceName
        {
            get
            {
                return instanceName;
            }
            set
            {
                instanceName = value;
                DictionaryUtil.Add(QueryParameters, "InstanceName", value);
            }
        }

        public string InstanceIds
        {
            get
            {
                return instanceIds;
            }
            set
            {
                instanceIds = value;
                DictionaryUtil.Add(QueryParameters, "InstanceIds", value);
            }
        }

        public string InternetChargeType
        {
            get
            {
                return internetChargeType;
            }
            set
            {
                internetChargeType = value;
                DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
            }
        }

        public string VpcId
        {
            get
            {
                return vpcId;
            }
            set
            {
                vpcId = value;
                DictionaryUtil.Add(QueryParameters, "VpcId", value);
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

        public string Filter3Key
        {
            get
            {
                return filter3Key;
            }
            set
            {
                filter3Key = value;
                DictionaryUtil.Add(QueryParameters, "Filter.3.Key", value);
            }
        }

        public string InstanceNetworkType
        {
            get
            {
                return instanceNetworkType;
            }
            set
            {
                instanceNetworkType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                DictionaryUtil.Add(QueryParameters, "Status", value);
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

        public override DescribeInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}