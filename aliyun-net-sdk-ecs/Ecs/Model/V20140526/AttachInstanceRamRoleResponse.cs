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
    public class AttachInstanceRamRoleResponse : AcsResponse
    {

        private string requestId;

        private int? totalCount;

        private int? failCount;

        private string ramRoleName;

        private List<AttachInstanceRamRole_AttachInstanceRamRoleResult> attachInstanceRamRoleResults;

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

        public int? FailCount
        {
            get
            {
                return failCount;
            }
            set
            {
                failCount = value;
            }
        }

        public string RamRoleName
        {
            get
            {
                return ramRoleName;
            }
            set
            {
                ramRoleName = value;
            }
        }

        public List<AttachInstanceRamRole_AttachInstanceRamRoleResult> AttachInstanceRamRoleResults
        {
            get
            {
                return attachInstanceRamRoleResults;
            }
            set
            {
                attachInstanceRamRoleResults = value;
            }
        }

        public class AttachInstanceRamRole_AttachInstanceRamRoleResult
        {

            private string instanceId;

            private bool? success;

            private string code;

            private string message;

            public string InstanceId
            {
                get
                {
                    return instanceId;
                }
                set
                {
                    instanceId = value;
                }
            }

            public bool? Success
            {
                get
                {
                    return success;
                }
                set
                {
                    success = value;
                }
            }

            public string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
                }
            }

            public string Message
            {
                get
                {
                    return message;
                }
                set
                {
                    message = value;
                }
            }
        }
    }
}