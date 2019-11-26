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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CreateLDAPConfigRequest : RpcAcsRequest<CreateLDAPConfigResponse>
    {
        public CreateLDAPConfigRequest()
            : base("NAS", "2017-06-26", "CreateLDAPConfig", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string searchBase;

		private string fileSystemId;

		private string uRI;

		private string bindDN;

		public string SearchBase
		{
			get
			{
				return searchBase;
			}
			set	
			{
				searchBase = value;
				DictionaryUtil.Add(QueryParameters, "SearchBase", value);
			}
		}

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		public string URI
		{
			get
			{
				return uRI;
			}
			set	
			{
				uRI = value;
				DictionaryUtil.Add(QueryParameters, "URI", value);
			}
		}

		public string BindDN
		{
			get
			{
				return bindDN;
			}
			set	
			{
				bindDN = value;
				DictionaryUtil.Add(QueryParameters, "BindDN", value);
			}
		}

        public override CreateLDAPConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLDAPConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
