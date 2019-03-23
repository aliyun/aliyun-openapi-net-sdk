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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ram.Model.V20150501
{
    public class GetPolicyVersionResponse : AcsResponse
    {

        private string requestId;

        private GetPolicyVersion_PolicyVersion policyVersion;

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

        public GetPolicyVersion_PolicyVersion PolicyVersion
        {
            get
            {
                return policyVersion;
            }
            set
            {
                policyVersion = value;
            }
        }

        public class GetPolicyVersion_PolicyVersion
        {

            private string versionId;

            private bool? isDefaultVersion;

            private string policyDocument;

            private string createDate;

            public string VersionId
            {
                get
                {
                    return versionId;
                }
                set
                {
                    versionId = value;
                }
            }

            public bool? IsDefaultVersion
            {
                get
                {
                    return isDefaultVersion;
                }
                set
                {
                    isDefaultVersion = value;
                }
            }

            public string PolicyDocument
            {
                get
                {
                    return policyDocument;
                }
                set
                {
                    policyDocument = value;
                }
            }

            public string CreateDate
            {
                get
                {
                    return createDate;
                }
                set
                {
                    createDate = value;
                }
            }
        }
    }
}
