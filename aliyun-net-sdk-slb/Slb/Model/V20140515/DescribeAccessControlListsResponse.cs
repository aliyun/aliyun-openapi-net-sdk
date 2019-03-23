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
    public class DescribeAccessControlListsResponse : AcsResponse
    {

        private string requestId;

        private List<DescribeAccessControlLists_Acl> acls;

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

        public List<DescribeAccessControlLists_Acl> Acls
        {
            get
            {
                return acls;
            }
            set
            {
                acls = value;
            }
        }

        public class DescribeAccessControlLists_Acl
        {

            private string aclId;

            private string aclName;

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
        }
    }
}