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
    public class CreateInstanceAccountRequest : RpcAcsRequest<CreateInstanceAccountResponse>
    {
        public CreateInstanceAccountRequest()
            : base("Drds", "2019-01-23", "CreateInstanceAccount", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string drdsInstanceId;

		private string password;

		private string accountName;

		private List<DbPrivilege> dbPrivileges = new List<DbPrivilege>(){ };

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

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
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

		public List<DbPrivilege> DbPrivileges
		{
			get
			{
				return dbPrivileges;
			}

			set
			{
				dbPrivileges = value;
				for (int i = 0; i < dbPrivileges.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DbPrivilege." + (i + 1) + ".DbName", dbPrivileges[i].DbName);
					DictionaryUtil.Add(QueryParameters,"DbPrivilege." + (i + 1) + ".Privilege", dbPrivileges[i].Privilege);
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

        public override CreateInstanceAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
