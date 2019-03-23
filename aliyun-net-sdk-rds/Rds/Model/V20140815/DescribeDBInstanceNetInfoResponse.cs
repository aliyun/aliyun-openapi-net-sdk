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

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeDBInstanceNetInfoResponse : AcsResponse
    {

        private string requestId;

        private string instanceNetworkType;

        private string securityIPMode;

        private List<DescribeDBInstanceNetInfo_DBInstanceNetInfo> dBInstanceNetInfos;

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

        public string InstanceNetworkType
        {
            get
            {
                return instanceNetworkType;
            }
            set
            {
                instanceNetworkType = value;
            }
        }

        public string SecurityIPMode
        {
            get
            {
                return securityIPMode;
            }
            set
            {
                securityIPMode = value;
            }
        }

        public List<DescribeDBInstanceNetInfo_DBInstanceNetInfo> DBInstanceNetInfos
        {
            get
            {
                return dBInstanceNetInfos;
            }
            set
            {
                dBInstanceNetInfos = value;
            }
        }

        public class DescribeDBInstanceNetInfo_DBInstanceNetInfo
        {

            private string upgradeable;

            private string expiredTime;

            private string connectionString;

            private string iPAddress;

            private string iPType;

            private string port;

            private string vPCId;

            private string vSwitchId;

            private string connectionStringType;

            private string maxDelayTime;

            private string distributionType;

            private List<DescribeDBInstanceNetInfo_SecurityIPGroup> securityIPGroups;

            private List<DescribeDBInstanceNetInfo_DBInstanceWeight> dBInstanceWeights;

            public string Upgradeable
            {
                get
                {
                    return upgradeable;
                }
                set
                {
                    upgradeable = value;
                }
            }

            public string ExpiredTime
            {
                get
                {
                    return expiredTime;
                }
                set
                {
                    expiredTime = value;
                }
            }

            public string ConnectionString
            {
                get
                {
                    return connectionString;
                }
                set
                {
                    connectionString = value;
                }
            }

            public string IPAddress
            {
                get
                {
                    return iPAddress;
                }
                set
                {
                    iPAddress = value;
                }
            }

            public string IPType
            {
                get
                {
                    return iPType;
                }
                set
                {
                    iPType = value;
                }
            }

            public string Port
            {
                get
                {
                    return port;
                }
                set
                {
                    port = value;
                }
            }

            public string VPCId
            {
                get
                {
                    return vPCId;
                }
                set
                {
                    vPCId = value;
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

            public string ConnectionStringType
            {
                get
                {
                    return connectionStringType;
                }
                set
                {
                    connectionStringType = value;
                }
            }

            public string MaxDelayTime
            {
                get
                {
                    return maxDelayTime;
                }
                set
                {
                    maxDelayTime = value;
                }
            }

            public string DistributionType
            {
                get
                {
                    return distributionType;
                }
                set
                {
                    distributionType = value;
                }
            }

            public List<DescribeDBInstanceNetInfo_SecurityIPGroup> SecurityIPGroups
            {
                get
                {
                    return securityIPGroups;
                }
                set
                {
                    securityIPGroups = value;
                }
            }

            public List<DescribeDBInstanceNetInfo_DBInstanceWeight> DBInstanceWeights
            {
                get
                {
                    return dBInstanceWeights;
                }
                set
                {
                    dBInstanceWeights = value;
                }
            }

            public class DescribeDBInstanceNetInfo_SecurityIPGroup
            {

                private string securityIPGroupName;

                private string securityIPs;

                public string SecurityIPGroupName
                {
                    get
                    {
                        return securityIPGroupName;
                    }
                    set
                    {
                        securityIPGroupName = value;
                    }
                }

                public string SecurityIPs
                {
                    get
                    {
                        return securityIPs;
                    }
                    set
                    {
                        securityIPs = value;
                    }
                }
            }

            public class DescribeDBInstanceNetInfo_DBInstanceWeight
            {

                private string dBInstanceId;

                private string dBInstanceType;

                private string availability;

                private string weight;

                public string DBInstanceId
                {
                    get
                    {
                        return dBInstanceId;
                    }
                    set
                    {
                        dBInstanceId = value;
                    }
                }

                public string DBInstanceType
                {
                    get
                    {
                        return dBInstanceType;
                    }
                    set
                    {
                        dBInstanceType = value;
                    }
                }

                public string Availability
                {
                    get
                    {
                        return availability;
                    }
                    set
                    {
                        availability = value;
                    }
                }

                public string Weight
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
            }
        }
    }
}