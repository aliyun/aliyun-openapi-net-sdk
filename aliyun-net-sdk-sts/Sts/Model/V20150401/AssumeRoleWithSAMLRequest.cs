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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sts.Transform;
using Aliyun.Acs.Sts.Transform.V20150401;

namespace Aliyun.Acs.Sts.Model.V20150401
{
    public class AssumeRoleWithSAMLRequest : RpcAcsRequest<AssumeRoleWithSAMLResponse>
    {
        public AssumeRoleWithSAMLRequest()
            : base("Sts", "2015-04-01", "AssumeRoleWithSAML", "sts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private string sAMLAssertion;

		private string roleArn;

		private string sAMLProviderArn;

		private long? durationSeconds;

		private string policy;

		public string SAMLAssertion
		{
			get
			{
				return sAMLAssertion;
			}
			set	
			{
				sAMLAssertion = value;
				DictionaryUtil.Add(QueryParameters, "SAMLAssertion", value);
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

		public string SAMLProviderArn
		{
			get
			{
				return sAMLProviderArn;
			}
			set	
			{
				sAMLProviderArn = value;
				DictionaryUtil.Add(QueryParameters, "SAMLProviderArn", value);
			}
		}

		public long? DurationSeconds
		{
			get
			{
				return durationSeconds;
			}
			set	
			{
				durationSeconds = value;
				DictionaryUtil.Add(QueryParameters, "DurationSeconds", value.ToString());
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

        public override AssumeRoleWithSAMLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AssumeRoleWithSAMLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
