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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class EnableRightsSeparationRequest : RpcAcsRequest<EnableRightsSeparationResponse>
    {
        public EnableRightsSeparationRequest()
            : base("polardbx", "2020-02-02", "EnableRightsSeparation", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string securityAccountPassword;

		private string securityAccountDescription;

		private string auditAccountPassword;

		private string dBInstanceName;

		private string securityAccountName;

		private string auditAccountName;

		private string auditAccountDescription;

		public string SecurityAccountPassword
		{
			get
			{
				return securityAccountPassword;
			}
			set	
			{
				securityAccountPassword = value;
				DictionaryUtil.Add(QueryParameters, "SecurityAccountPassword", value);
			}
		}

		public string SecurityAccountDescription
		{
			get
			{
				return securityAccountDescription;
			}
			set	
			{
				securityAccountDescription = value;
				DictionaryUtil.Add(QueryParameters, "SecurityAccountDescription", value);
			}
		}

		public string AuditAccountPassword
		{
			get
			{
				return auditAccountPassword;
			}
			set	
			{
				auditAccountPassword = value;
				DictionaryUtil.Add(QueryParameters, "AuditAccountPassword", value);
			}
		}

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		public string SecurityAccountName
		{
			get
			{
				return securityAccountName;
			}
			set	
			{
				securityAccountName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityAccountName", value);
			}
		}

		public string AuditAccountName
		{
			get
			{
				return auditAccountName;
			}
			set	
			{
				auditAccountName = value;
				DictionaryUtil.Add(QueryParameters, "AuditAccountName", value);
			}
		}

		public string AuditAccountDescription
		{
			get
			{
				return auditAccountDescription;
			}
			set	
			{
				auditAccountDescription = value;
				DictionaryUtil.Add(QueryParameters, "AuditAccountDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EnableRightsSeparationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EnableRightsSeparationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
