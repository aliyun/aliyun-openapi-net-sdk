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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeNatGatewaysResponse : AcsResponse
    {

        private string requestId;

        private int? totalCount;

        private int? pageNumber;

        private int? pageSize;

        private List<DescribeNatGateways_NatGateway> natGateways;

        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public int? TotalCount
        {
            get
            {
                return totalCount;
            }
            set
            {
                totalCount = value;
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
            }
        }

        public List<DescribeNatGateways_NatGateway> NatGateways
        {
            get
            {
                return natGateways;
            }
            set
            {
                natGateways = value;
            }
        }

        public class DescribeNatGateways_NatGateway
        {

            private string natGatewayId;

            private string regionId;

            private string name;

            private string description;

            private string vpcId;

            private string spec;

            private string instanceChargeType;

            private string businessStatus;

            private string creationTime;

            private string status;

            private List<string> forwardTableIds;

            private List<string> bandwidthPackageIds;

            public string NatGatewayId
            {
                get
                {
                    return natGatewayId;
                }
                set
                {
                    natGatewayId = value;
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
                }
            }

            public string Spec
            {
                get
                {
                    return spec;
                }
                set
                {
                    spec = value;
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
                }
            }

            public string BusinessStatus
            {
                get
                {
                    return businessStatus;
                }
                set
                {
                    businessStatus = value;
                }
            }

            public string CreationTime
            {
                get
                {
                    return creationTime;
                }
                set
                {
                    creationTime = value;
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
                }
            }

            public List<string> ForwardTableIds
            {
                get
                {
                    return forwardTableIds;
                }
                set
                {
                    forwardTableIds = value;
                }
            }

            public List<string> BandwidthPackageIds
            {
                get
                {
                    return bandwidthPackageIds;
                }
                set
                {
                    bandwidthPackageIds = value;
                }
            }
        }
    }
}