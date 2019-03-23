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
    public class DescribeDBInstancesAsCsvResponse : AcsResponse
    {

        private string requestId;

        private List<DescribeDBInstancesAsCsv_DBInstanceAttribute> items;

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

        public List<DescribeDBInstancesAsCsv_DBInstanceAttribute> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        public class DescribeDBInstancesAsCsv_DBInstanceAttribute
        {

            private string dBInstanceId;

            private string payType;

            private string dBInstanceClassType;

            private string dBInstanceType;

            private string regionId;

            private string connectionString;

            private string port;

            private string engine;

            private string engineVersion;

            private string dBInstanceClass;

            private long? dBInstanceMemory;

            private int? dBInstanceStorage;

            private string dBInstanceNetType;

            private string dBInstanceStatus;

            private string dBInstanceDescription;

            private string lockMode;

            private string lockReason;

            private string readDelayTime;

            private int? dBMaxQuantity;

            private int? accountMaxQuantity;

            private string creationTime;

            private string expireTime;

            private string maintainTime;

            private string availabilityValue;

            private int? maxIOPS;

            private int? maxConnections;

            private string masterInstanceId;

            private string dBInstanceCPU;

            private string incrementSourceDBInstanceId;

            private string guardDBInstanceId;

            private string tempDBInstanceId;

            private string securityIPList;

            private string zoneId;

            private string instanceNetworkType;

            private string category;

            private string accountType;

            private string supportUpgradeAccountType;

            private string vpcId;

            private string vSwitchId;

            private string connectionMode;

            private string tags;

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

            public string PayType
            {
                get
                {
                    return payType;
                }
                set
                {
                    payType = value;
                }
            }

            public string DBInstanceClassType
            {
                get
                {
                    return dBInstanceClassType;
                }
                set
                {
                    dBInstanceClassType = value;
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

            public string Engine
            {
                get
                {
                    return engine;
                }
                set
                {
                    engine = value;
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
                }
            }

            public long? DBInstanceMemory
            {
                get
                {
                    return dBInstanceMemory;
                }
                set
                {
                    dBInstanceMemory = value;
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
                }
            }

            public string DBInstanceNetType
            {
                get
                {
                    return dBInstanceNetType;
                }
                set
                {
                    dBInstanceNetType = value;
                }
            }

            public string DBInstanceStatus
            {
                get
                {
                    return dBInstanceStatus;
                }
                set
                {
                    dBInstanceStatus = value;
                }
            }

            public string DBInstanceDescription
            {
                get
                {
                    return dBInstanceDescription;
                }
                set
                {
                    dBInstanceDescription = value;
                }
            }

            public string LockMode
            {
                get
                {
                    return lockMode;
                }
                set
                {
                    lockMode = value;
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
                }
            }

            public string ReadDelayTime
            {
                get
                {
                    return readDelayTime;
                }
                set
                {
                    readDelayTime = value;
                }
            }

            public int? DBMaxQuantity
            {
                get
                {
                    return dBMaxQuantity;
                }
                set
                {
                    dBMaxQuantity = value;
                }
            }

            public int? AccountMaxQuantity
            {
                get
                {
                    return accountMaxQuantity;
                }
                set
                {
                    accountMaxQuantity = value;
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

            public string ExpireTime
            {
                get
                {
                    return expireTime;
                }
                set
                {
                    expireTime = value;
                }
            }

            public string MaintainTime
            {
                get
                {
                    return maintainTime;
                }
                set
                {
                    maintainTime = value;
                }
            }

            public string AvailabilityValue
            {
                get
                {
                    return availabilityValue;
                }
                set
                {
                    availabilityValue = value;
                }
            }

            public int? MaxIOPS
            {
                get
                {
                    return maxIOPS;
                }
                set
                {
                    maxIOPS = value;
                }
            }

            public int? MaxConnections
            {
                get
                {
                    return maxConnections;
                }
                set
                {
                    maxConnections = value;
                }
            }

            public string MasterInstanceId
            {
                get
                {
                    return masterInstanceId;
                }
                set
                {
                    masterInstanceId = value;
                }
            }

            public string DBInstanceCPU
            {
                get
                {
                    return dBInstanceCPU;
                }
                set
                {
                    dBInstanceCPU = value;
                }
            }

            public string IncrementSourceDBInstanceId
            {
                get
                {
                    return incrementSourceDBInstanceId;
                }
                set
                {
                    incrementSourceDBInstanceId = value;
                }
            }

            public string GuardDBInstanceId
            {
                get
                {
                    return guardDBInstanceId;
                }
                set
                {
                    guardDBInstanceId = value;
                }
            }

            public string TempDBInstanceId
            {
                get
                {
                    return tempDBInstanceId;
                }
                set
                {
                    tempDBInstanceId = value;
                }
            }

            public string SecurityIPList
            {
                get
                {
                    return securityIPList;
                }
                set
                {
                    securityIPList = value;
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

            public string Category
            {
                get
                {
                    return category;
                }
                set
                {
                    category = value;
                }
            }

            public string AccountType
            {
                get
                {
                    return accountType;
                }
                set
                {
                    accountType = value;
                }
            }

            public string SupportUpgradeAccountType
            {
                get
                {
                    return supportUpgradeAccountType;
                }
                set
                {
                    supportUpgradeAccountType = value;
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

            public string ConnectionMode
            {
                get
                {
                    return connectionMode;
                }
                set
                {
                    connectionMode = value;
                }
            }

            public string Tags
            {
                get
                {
                    return tags;
                }
                set
                {
                    tags = value;
                }
            }
        }
    }
}