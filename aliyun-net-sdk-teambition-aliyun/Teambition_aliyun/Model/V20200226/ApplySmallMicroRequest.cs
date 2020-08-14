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
using Aliyun.Acs.teambition_aliyun;
using Aliyun.Acs.teambition_aliyun.Transform;
using Aliyun.Acs.teambition_aliyun.Transform.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Model.V20200226
{
    public class ApplySmallMicroRequest : RpcAcsRequest<ApplySmallMicroResponse>
    {
        public ApplySmallMicroRequest()
            : base("teambition-aliyun", "2020-02-26", "ApplySmallMicro")
        {
			Method = MethodType.POST;
        }

		private string applicantEmail;

		private string developScale;

		private string type;

		private string orgId;

		private string applicantPosition;

		private string developLanguage;

		private string orgName;

		private string applicantTel;

		private string solution;

		private string forHelp;

		private string applicantName;

		private string businessModel;

		public string ApplicantEmail
		{
			get
			{
				return applicantEmail;
			}
			set	
			{
				applicantEmail = value;
				DictionaryUtil.Add(BodyParameters, "ApplicantEmail", value);
			}
		}

		public string DevelopScale
		{
			get
			{
				return developScale;
			}
			set	
			{
				developScale = value;
				DictionaryUtil.Add(QueryParameters, "DevelopScale", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public string ApplicantPosition
		{
			get
			{
				return applicantPosition;
			}
			set	
			{
				applicantPosition = value;
				DictionaryUtil.Add(BodyParameters, "ApplicantPosition", value);
			}
		}

		public string DevelopLanguage
		{
			get
			{
				return developLanguage;
			}
			set	
			{
				developLanguage = value;
				DictionaryUtil.Add(BodyParameters, "DevelopLanguage", value);
			}
		}

		public string OrgName
		{
			get
			{
				return orgName;
			}
			set	
			{
				orgName = value;
				DictionaryUtil.Add(BodyParameters, "OrgName", value);
			}
		}

		public string ApplicantTel
		{
			get
			{
				return applicantTel;
			}
			set	
			{
				applicantTel = value;
				DictionaryUtil.Add(BodyParameters, "ApplicantTel", value);
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
				DictionaryUtil.Add(BodyParameters, "Solution", value);
			}
		}

		public string ForHelp
		{
			get
			{
				return forHelp;
			}
			set	
			{
				forHelp = value;
				DictionaryUtil.Add(BodyParameters, "ForHelp", value);
			}
		}

		public string ApplicantName
		{
			get
			{
				return applicantName;
			}
			set	
			{
				applicantName = value;
				DictionaryUtil.Add(BodyParameters, "ApplicantName", value);
			}
		}

		public string BusinessModel
		{
			get
			{
				return businessModel;
			}
			set	
			{
				businessModel = value;
				DictionaryUtil.Add(BodyParameters, "BusinessModel", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ApplySmallMicroResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplySmallMicroResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
