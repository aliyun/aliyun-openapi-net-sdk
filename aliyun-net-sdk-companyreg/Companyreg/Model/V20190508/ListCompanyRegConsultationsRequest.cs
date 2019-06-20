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
    public class ListCompanyRegConsultationsRequest : RpcAcsRequest<ListCompanyRegConsultationsResponse>
    {
        public ListCompanyRegConsultationsRequest()
            : base("companyreg", "2019-05-08", "ListCompanyRegConsultations", "companyreg", "openAPI")
        {
        }

		private long? endGmtCreate;

		private string city;

		private int? pageSize;

		private string bizId;

		private long? startGmtCreate;

		private int? pageNum;

		public long? EndGmtCreate
		{
			get
			{
				return endGmtCreate;
			}
			set	
			{
				endGmtCreate = value;
				DictionaryUtil.Add(QueryParameters, "EndGmtCreate", value.ToString());
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
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

		public long? StartGmtCreate
		{
			get
			{
				return startGmtCreate;
			}
			set	
			{
				startGmtCreate = value;
				DictionaryUtil.Add(QueryParameters, "StartGmtCreate", value.ToString());
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

        public override ListCompanyRegConsultationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCompanyRegConsultationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
