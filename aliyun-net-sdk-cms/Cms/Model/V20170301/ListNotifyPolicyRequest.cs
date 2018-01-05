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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20170301;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20170301
{
    public class ListNotifyPolicyRequest : RpcAcsRequest<ListNotifyPolicyResponse>
    {
        public ListNotifyPolicyRequest()
            : base("Cms", "2017-03-01", "ListNotifyPolicy", "cms", "openAPI")
        {
        }

		private string policyType;

		private string alertName;

		private int? pageSize;

		private string id;

		private string dimensions;

		private string accessKeyId;

		public string PolicyType
		{
			get
			{
				return policyType;
			}
			set	
			{
				policyType = value;
				DictionaryUtil.Add(QueryParameters, "PolicyType", value);
			}
		}

		public string AlertName
		{
			get
			{
				return alertName;
			}
			set	
			{
				alertName = value;
				DictionaryUtil.Add(QueryParameters, "AlertName", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string Dimensions
		{
			get
			{
				return dimensions;
			}
			set	
			{
				dimensions = value;
				DictionaryUtil.Add(QueryParameters, "Dimensions", value);
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

        public override ListNotifyPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListNotifyPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}