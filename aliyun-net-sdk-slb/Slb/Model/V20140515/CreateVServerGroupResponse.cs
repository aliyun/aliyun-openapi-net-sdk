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

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class CreateVServerGroupResponse : AcsResponse
    {

        private string requestId;

        private string vServerGroupId;

        private List<CreateVServerGroup_BackendServer> backendServers;

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

        public string VServerGroupId
        {
            get
            {
                return vServerGroupId;
            }
            set
            {
                vServerGroupId = value;
            }
        }

        public List<CreateVServerGroup_BackendServer> BackendServers
        {
            get
            {
                return backendServers;
            }
            set
            {
                backendServers = value;
            }
        }

        public class CreateVServerGroup_BackendServer
        {

            private string serverId;

            private int? port;

            private int? weight;

            private string type;

            private string serverIp;

            private string vpcId;

            public string ServerId
            {
                get
                {
                    return serverId;
                }
                set
                {
                    serverId = value;
                }
            }

            public int? Port
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

            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            public string ServerIp
            {
                get
                {
                    return serverIp;
                }
                set
                {
                    serverIp = value;
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
        }
    }
}