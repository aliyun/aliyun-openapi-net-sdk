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
using Aliyun.Acs.Domain;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class UpdateDomainToDomainGroupRequest : RpcAcsRequest<UpdateDomainToDomainGroupResponse>
    {
        public UpdateDomainToDomainGroupRequest()
            : base("Domain", "2018-01-29", "UpdateDomainToDomainGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fileToUpload;

		private List<string> domainNames = new List<string>(){ };

		private bool? replace;

		private long? domainGroupId;

		private int? dataSource;

		private string userClientIp;

		private string lang;

		public string FileToUpload
		{
			get
			{
				return fileToUpload;
			}
			set	
			{
				fileToUpload = value;
				DictionaryUtil.Add(BodyParameters, "FileToUpload", value);
			}
		}

		public List<string> DomainNames
		{
			get
			{
				return domainNames;
			}

			set
			{
				domainNames = value;
				for (int i = 0; i < domainNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainName." + (i + 1) , domainNames[i]);
				}
			}
		}

		public bool? Replace
		{
			get
			{
				return replace;
			}
			set	
			{
				replace = value;
				DictionaryUtil.Add(QueryParameters, "Replace", value.ToString());
			}
		}

		public long? DomainGroupId
		{
			get
			{
				return domainGroupId;
			}
			set	
			{
				domainGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DomainGroupId", value.ToString());
			}
		}

		public int? DataSource
		{
			get
			{
				return dataSource;
			}
			set	
			{
				dataSource = value;
				DictionaryUtil.Add(QueryParameters, "DataSource", value.ToString());
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

        public override UpdateDomainToDomainGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDomainToDomainGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
