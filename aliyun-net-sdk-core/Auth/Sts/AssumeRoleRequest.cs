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
 
using System;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth.Sts
{
    public class AssumeRoleRequest : RpcAcsRequest<AssumeRoleResponse>
    {
        public AssumeRoleRequest()
            : base("Sts", "2015-04-01", "AssumeRole")
        {
            Protocol = Http.ProtocolType.HTTPS;
        }
        private long durationSeconds;
        private String policy;
        private String roleArn;
        private String roleSessionName;

        public long DurationSeconds
        {
            get
            {
                return durationSeconds;
            }
            set
            {
                durationSeconds = value;
                DictionaryUtil.Add(QueryParameters, "DurationSeconds", value);
            }
        }

        public string Policy
        {
            get
            {
                return policy;
            }
            set
            {
                policy = value;
                DictionaryUtil.Add(QueryParameters, "Policy", value);
            }
        }

        public string RoleArn
        {
            get
            {
                return roleArn;
            }
            set
            {
                roleArn = value;
                DictionaryUtil.Add(QueryParameters, "RoleArn", value);
            }
        }

        public string RoleSessionName
        {
            get
            {
                return roleSessionName;
            }
            set
            {
                roleSessionName = value;
                DictionaryUtil.Add(QueryParameters, "RoleSessionName", value);
            }
        }

        public override AssumeRoleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AssumeRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
