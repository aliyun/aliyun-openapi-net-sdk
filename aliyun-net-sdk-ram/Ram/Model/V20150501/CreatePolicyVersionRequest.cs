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
using Aliyun.Acs.Ram.Transform;
using Aliyun.Acs.Ram.Transform.V20150501;

namespace Aliyun.Acs.Ram.Model.V20150501
{
    public class CreatePolicyVersionRequest : RpcAcsRequest<CreatePolicyVersionResponse>
    {
        public CreatePolicyVersionRequest()
            : base("Ram", "2015-05-01", "CreatePolicyVersion", "Ram", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ram.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ram.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? setAsDefault;

		private string rotateStrategy;

		private string policyName;

		private string policyDocument;

		public bool? SetAsDefault
		{
			get
			{
				return setAsDefault;
			}
			set	
			{
				setAsDefault = value;
				DictionaryUtil.Add(QueryParameters, "SetAsDefault", value.ToString());
			}
		}

		public string RotateStrategy
		{
			get
			{
				return rotateStrategy;
			}
			set	
			{
				rotateStrategy = value;
				DictionaryUtil.Add(QueryParameters, "RotateStrategy", value);
			}
		}

		public string PolicyName
		{
			get
			{
				return policyName;
			}
			set	
			{
				policyName = value;
				DictionaryUtil.Add(QueryParameters, "PolicyName", value);
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
				DictionaryUtil.Add(QueryParameters, "PolicyDocument", value);
			}
		}

        public override CreatePolicyVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePolicyVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
