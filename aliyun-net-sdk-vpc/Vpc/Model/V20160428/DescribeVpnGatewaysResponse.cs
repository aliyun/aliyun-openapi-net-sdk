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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeVpnGatewaysResponse : AcsResponse
    {

        private string requestId;

        private int? totalCount;

        private int? pageNumber;

        private int? pageSize;

        private List<DescribeVpnGateways_VpnGateway> vpnGateways;

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

        public List<DescribeVpnGateways_VpnGateway> VpnGateways
        {
            get
            {
                return vpnGateways;
            }
            set
            {
                vpnGateways = value;
            }
        }

        public class DescribeVpnGateways_VpnGateway
        {

            private string vpnGatewayId;

            private string vpcId;

            private string vSwitchId;

            private string internetIp;

            private long? createTime;

            private long? endTime;

            private string spec;

            private string name;

            private string description;

            private string status;

            private string businessStatus;

            private string chargeType;

            private string ipsecVpn;

            private string sslVpn;

            private long? sslMaxConnections;

            public string VpnGatewayId
            {
                get
                {
                    return vpnGatewayId;
                }
                set
                {
                    vpnGatewayId = value;
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

            public string VSwitchId
            {
                get
                {
                    return vSwitchId;
                }
                set
                {
                    vSwitchId = value;
                }
            }

            public string InternetIp
            {
                get
                {
                    return internetIp;
                }
                set
                {
                    internetIp = value;
                }
            }

            public long? CreateTime
            {
                get
                {
                    return createTime;
                }
                set
                {
                    createTime = value;
                }
            }

            public long? EndTime
            {
                get
                {
                    return endTime;
                }
                set
                {
                    endTime = value;
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

            public string ChargeType
            {
                get
                {
                    return chargeType;
                }
                set
                {
                    chargeType = value;
                }
            }

            public string IpsecVpn
            {
                get
                {
                    return ipsecVpn;
                }
                set
                {
                    ipsecVpn = value;
                }
            }

            public string SslVpn
            {
                get
                {
                    return sslVpn;
                }
                set
                {
                    sslVpn = value;
                }
            }

            public long? SslMaxConnections
            {
                get
                {
                    return sslMaxConnections;
                }
                set
                {
                    sslMaxConnections = value;
                }
            }
        }
    }
}