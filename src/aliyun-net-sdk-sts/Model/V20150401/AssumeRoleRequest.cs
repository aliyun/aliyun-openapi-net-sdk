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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sts.Transform.V20150401;

namespace Aliyun.Acs.Sts.Model.V20150401
{
    public class AssumeRoleRequest : RpcAcsRequest<AssumeRoleResponse>
    {
        public AssumeRoleRequest()
            : base("Sts", "2015-04-01", "AssumeRole")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private long? _durationSeconds;

		private string _policy;

		private string _roleArn;

		private string _roleSessionName;

		public long? DurationSeconds
		{
			get
			{
				return _durationSeconds;
			}
			set	
			{
				_durationSeconds = value;
				DictionaryUtil.Add(QueryParameters, "DurationSeconds", value.ToString());
			}
		}

		public string Policy
		{
			get
			{
				return _policy;
			}
			set	
			{
				_policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

		public string RoleArn
		{
			get
			{
				return _roleArn;
			}
			set	
			{
				_roleArn = value;
				DictionaryUtil.Add(QueryParameters, "RoleArn", value);
			}
		}

		public string RoleSessionName
		{
			get
			{
				return _roleSessionName;
			}
			set	
			{
				_roleSessionName = value;
				DictionaryUtil.Add(QueryParameters, "RoleSessionName", value);
			}
		}

        public override AssumeRoleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AssumeRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}