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
using Aliyun.Acs.ResourceCenter;
using Aliyun.Acs.ResourceCenter.Transform;
using Aliyun.Acs.ResourceCenter.Transform.V20221201;

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
    public class ListResourceTypesRequest : RpcAcsRequest<ListResourceTypesResponse>
    {
        public ListResourceTypesRequest()
            : base("ResourceCenter", "2022-12-01", "ListResourceTypes")
        {
			Method = MethodType.POST;
        }

		private List<string> querys = new List<string>(){ };

		private string resourceType;

		private string acceptLanguage;

		public List<string> Querys
		{
			get
			{
				return querys;
			}

			set
			{
				querys = value;
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string AcceptLanguage
		{
			get
			{
				return acceptLanguage;
			}
			set	
			{
				acceptLanguage = value;
				DictionaryUtil.Add(QueryParameters, "AcceptLanguage", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListResourceTypesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListResourceTypesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
