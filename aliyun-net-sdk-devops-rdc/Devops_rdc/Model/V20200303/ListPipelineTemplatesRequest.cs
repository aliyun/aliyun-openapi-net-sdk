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
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class ListPipelineTemplatesRequest : RpcAcsRequest<ListPipelineTemplatesResponse>
    {
        public ListPipelineTemplatesRequest()
            : base("devops-rdc", "2020-03-03", "ListPipelineTemplates")
        {
        }

		private int? pageStart;

		private int? pageNum;

		private string orgId;

		public int? PageStart
		{
			get
			{
				return pageStart;
			}
			set	
			{
				pageStart = value;
				DictionaryUtil.Add(QueryParameters, "PageStart", value.ToString());
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

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(QueryParameters, "OrgId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPipelineTemplatesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPipelineTemplatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
