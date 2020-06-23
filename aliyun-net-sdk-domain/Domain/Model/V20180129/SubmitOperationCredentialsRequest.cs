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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SubmitOperationCredentialsRequest : RpcAcsRequest<SubmitOperationCredentialsResponse>
    {
        public SubmitOperationCredentialsRequest()
            : base("Domain", "2018-01-29", "SubmitOperationCredentials", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string credentials;

		private long? auditRecordId;

		private int? regType;

		private int? auditType;

		private string lang;

		public string Credentials
		{
			get
			{
				return credentials;
			}
			set	
			{
				credentials = value;
				DictionaryUtil.Add(QueryParameters, "Credentials", value);
			}
		}

		public long? AuditRecordId
		{
			get
			{
				return auditRecordId;
			}
			set	
			{
				auditRecordId = value;
				DictionaryUtil.Add(QueryParameters, "AuditRecordId", value.ToString());
			}
		}

		public int? RegType
		{
			get
			{
				return regType;
			}
			set	
			{
				regType = value;
				DictionaryUtil.Add(QueryParameters, "RegType", value.ToString());
			}
		}

		public int? AuditType
		{
			get
			{
				return auditType;
			}
			set	
			{
				auditType = value;
				DictionaryUtil.Add(QueryParameters, "AuditType", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitOperationCredentialsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitOperationCredentialsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
