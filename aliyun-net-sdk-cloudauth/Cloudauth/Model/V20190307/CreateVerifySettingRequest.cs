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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class CreateVerifySettingRequest : RpcAcsRequest<CreateVerifySettingResponse>
    {
        public CreateVerifySettingRequest()
            : base("Cloudauth", "2019-03-07", "CreateVerifySetting", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? guideStep;

		private bool? resultStep;

		private string solution;

		private string bizName;

		private string bizType;

		private bool? privacyStep;

		public bool? GuideStep
		{
			get
			{
				return guideStep;
			}
			set	
			{
				guideStep = value;
				DictionaryUtil.Add(QueryParameters, "GuideStep", value.ToString());
			}
		}

		public bool? ResultStep
		{
			get
			{
				return resultStep;
			}
			set	
			{
				resultStep = value;
				DictionaryUtil.Add(QueryParameters, "ResultStep", value.ToString());
			}
		}

		public string Solution
		{
			get
			{
				return solution;
			}
			set	
			{
				solution = value;
				DictionaryUtil.Add(QueryParameters, "Solution", value);
			}
		}

		public string BizName
		{
			get
			{
				return bizName;
			}
			set	
			{
				bizName = value;
				DictionaryUtil.Add(QueryParameters, "BizName", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public bool? PrivacyStep
		{
			get
			{
				return privacyStep;
			}
			set	
			{
				privacyStep = value;
				DictionaryUtil.Add(QueryParameters, "PrivacyStep", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVerifySettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVerifySettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
