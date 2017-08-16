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
    public class OSuborderDomainRequest : RpcAcsRequest<OSuborderDomainResponse>
    {
        public OSuborderDomainRequest()
            : base("Domain", "2016-05-11", "OSuborderDomain")
        {
        }

		private string endDate;

		private int? pageSize;

		private string type;

		private string startDate;

		private int? pageNum;

		private string accessKeyId;

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "endDate", value);
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
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "type", value);
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "startDate", value);
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
				DictionaryUtil.Add(QueryParameters, "pageNum", value.ToString());
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

        public override OSuborderDomainResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OSuborderDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}