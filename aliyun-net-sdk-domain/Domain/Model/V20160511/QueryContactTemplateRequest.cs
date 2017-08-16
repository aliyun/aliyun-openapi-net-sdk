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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class QueryContactTemplateRequest : RpcAcsRequest<QueryContactTemplateResponse>
    {
        public QueryContactTemplateRequest()
            : base("Domain", "2016-05-11", "QueryContactTemplate")
        {
        }

		private string cCompany;

		private string auditStatus;

		private bool? defaultTemplate;

		private string eCompany;

		private string userClientIp;

		private int? pageSize;

		private string lang;

		private int? pageNum;

		private string accessKeyId;

		private long? contactTemplateId;

		private string regType;

		public string CCompany
		{
			get
			{
				return cCompany;
			}
			set	
			{
				cCompany = value;
				DictionaryUtil.Add(QueryParameters, "CCompany", value);
			}
		}

		public string AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
				DictionaryUtil.Add(QueryParameters, "AuditStatus", value);
			}
		}

		public bool? DefaultTemplate
		{
			get
			{
				return defaultTemplate;
			}
			set	
			{
				defaultTemplate = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTemplate", value.ToString());
			}
		}

		public string ECompany
		{
			get
			{
				return eCompany;
			}
			set	
			{
				eCompany = value;
				DictionaryUtil.Add(QueryParameters, "ECompany", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public long? ContactTemplateId
		{
			get
			{
				return contactTemplateId;
			}
			set	
			{
				contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value.ToString());
			}
		}

		public string RegType
		{
			get
			{
				return regType;
			}
			set	
			{
				regType = value;
				DictionaryUtil.Add(QueryParameters, "RegType", value);
			}
		}

        public override QueryContactTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryContactTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}