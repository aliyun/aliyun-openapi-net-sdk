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
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20190123;

namespace Aliyun.Acs.Drds.Model.V20190123
{
    public class ModifyAccountPrivilegeRequest : RpcAcsRequest<ModifyAccountPrivilegeResponse>
    {
        public ModifyAccountPrivilegeRequest()
            : base("Drds", "2019-01-23", "ModifyAccountPrivilege", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string drdsInstanceId;

		private string accountName;

		private List<string> dbPrivileges = new List<string>(){ };

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public List<string> DbPrivileges
		{
			get
			{
				return dbPrivileges;
			}

			set
			{
				dbPrivileges = value;
				if(dbPrivileges != null)
				{
					for (int depth1 = 0; depth1 < dbPrivileges.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"DbPrivilege." + (depth1 + 1), dbPrivileges[depth1]);
						DictionaryUtil.Add(QueryParameters,"DbPrivilege." + (depth1 + 1), dbPrivileges[depth1]);
					}
				}
			}
		}

		public class DbPrivilege
		{

			private string dbName;

			private string privilege;

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public string Privilege
			{
				get
				{
					return privilege;
				}
				set	
				{
					privilege = value;
				}
			}
		}

        public override ModifyAccountPrivilegeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAccountPrivilegeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
