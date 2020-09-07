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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class ListSecretParameterVersionsRequest : RpcAcsRequest<ListSecretParameterVersionsResponse>
    {
        public ListSecretParameterVersionsRequest()
            : base("oos", "2019-06-01", "ListSecretParameterVersions", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? withDecryption;

		private string nextToken;

		private string name;

		private int? maxResults;

		private string shareType;

		public bool? WithDecryption
		{
			get
			{
				return withDecryption;
			}
			set	
			{
				withDecryption = value;
				DictionaryUtil.Add(QueryParameters, "WithDecryption", value.ToString());
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public string ShareType
		{
			get
			{
				return shareType;
			}
			set	
			{
				shareType = value;
				DictionaryUtil.Add(QueryParameters, "ShareType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSecretParameterVersionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSecretParameterVersionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
