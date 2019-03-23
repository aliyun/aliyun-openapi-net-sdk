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
    public class DescribeAccessControlListAttributeResponse : AcsResponse
    {

        private string requestId;

        private string aclId;

        private string aclName;

        private List<DescribeAccessControlListAttribute_AclEntry> aclEntrys;

        private List<DescribeAccessControlListAttribute_RelatedListener> relatedListeners;

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

        public string AclId
        {
            get
            {
                return aclId;
            }
            set
            {
                aclId = value;
            }
        }

        public string AclName
        {
            get
            {
                return aclName;
            }
            set
            {
                aclName = value;
            }
        }

        public List<DescribeAccessControlListAttribute_AclEntry> AclEntrys
        {
            get
            {
                return aclEntrys;
            }
            set
            {
                aclEntrys = value;
            }
        }

        public List<DescribeAccessControlListAttribute_RelatedListener> RelatedListeners
        {
            get
            {
                return relatedListeners;
            }
            set
            {
                relatedListeners = value;
            }
        }

        public class DescribeAccessControlListAttribute_AclEntry
        {

            private string aclEntryIP;

            private string aclEntryComment;

            public string AclEntryIP
            {
                get
                {
                    return aclEntryIP;
                }
                set
                {
                    aclEntryIP = value;
                }
            }

            public string AclEntryComment
            {
                get
                {
                    return aclEntryComment;
                }
                set
                {
                    aclEntryComment = value;
                }
            }
        }

        public class DescribeAccessControlListAttribute_RelatedListener
        {

            private string loadBalancerId;

            private int? listenerPort;

            private string aclType;

            private string protocol;

            public string LoadBalancerId
            {
                get
                {
                    return loadBalancerId;
                }
                set
                {
                    loadBalancerId = value;
                }
            }

            public int? ListenerPort
            {
                get
                {
                    return listenerPort;
                }
                set
                {
                    listenerPort = value;
                }
            }

            public string AclType
            {
                get
                {
                    return aclType;
                }
                set
                {
                    aclType = value;
                }
            }

            public string Protocol
            {
                get
                {
                    return protocol;
                }
                set
                {
                    protocol = value;
                }
            }
        }
    }
}