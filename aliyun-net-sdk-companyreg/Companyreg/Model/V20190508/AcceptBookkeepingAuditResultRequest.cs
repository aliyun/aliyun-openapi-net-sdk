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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class AcceptBookkeepingAuditResultRequest : RpcAcsRequest<AcceptBookkeepingAuditResultResponse>
    {
        public AcceptBookkeepingAuditResultRequest()
            : base("companyreg", "2019-05-08", "AcceptBookkeepingAuditResult", "companyreg", "openAPI")
        {
        }

		private string note;

		private string orgCode;

		private string orgAddress;

		private string orgName;

		private long? serviceStartTime;

		private bool? auditResult;

		private string bizId;

		private string orgMobile;

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
				DictionaryUtil.Add(QueryParameters, "Note", value);
			}
		}

		public string OrgCode
		{
			get
			{
				return orgCode;
			}
			set	
			{
				orgCode = value;
				DictionaryUtil.Add(QueryParameters, "OrgCode", value);
			}
		}

		public string OrgAddress
		{
			get
			{
				return orgAddress;
			}
			set	
			{
				orgAddress = value;
				DictionaryUtil.Add(QueryParameters, "OrgAddress", value);
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
				DictionaryUtil.Add(QueryParameters, "OrgName", value);
			}
		}

		public long? ServiceStartTime
		{
			get
			{
				return serviceStartTime;
			}
			set	
			{
				serviceStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ServiceStartTime", value.ToString());
			}
		}

		public bool? AuditResult
		{
			get
			{
				return auditResult;
			}
			set	
			{
				auditResult = value;
				DictionaryUtil.Add(QueryParameters, "AuditResult", value.ToString());
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string OrgMobile
		{
			get
			{
				return orgMobile;
			}
			set	
			{
				orgMobile = value;
				DictionaryUtil.Add(QueryParameters, "OrgMobile", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AcceptBookkeepingAuditResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AcceptBookkeepingAuditResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
