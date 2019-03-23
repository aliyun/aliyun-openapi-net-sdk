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
    public class AttachKeyPairResponse : AcsResponse
    {

        private string requestId;

        private string totalCount;

        private string failCount;

        private string keyPairName;

        private List<AttachKeyPair_Result> results;

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

        public string TotalCount
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

        public string FailCount
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

        public string KeyPairName
        {
            get
            {
                return keyPairName;
            }
            set
            {
                keyPairName = value;
            }
        }

        public List<AttachKeyPair_Result> Results
        {
            get
            {
                return results;
            }
            set
            {
                results = value;
            }
        }

        public class AttachKeyPair_Result
        {

            private string instanceId;

            private string success;

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

            public string Success
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