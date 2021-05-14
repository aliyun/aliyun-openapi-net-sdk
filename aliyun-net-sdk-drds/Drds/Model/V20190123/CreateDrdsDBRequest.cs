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
    public class CreateDrdsDBRequest : RpcAcsRequest<CreateDrdsDBResponse>
    {
        public CreateDrdsDBRequest()
            : base("Drds", "2019-01-23", "CreateDrdsDB", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string encode;

		private List<string> rdsInstances = new List<string>(){ };

		private string type;

		private string password;

		private List<RdsSuperAccount> rdsSuperAccounts = new List<RdsSuperAccount>(){ };

		private string accountName;

		private string drdsInstanceId;

		private bool? dbInstanceIsCreating;

		private List<InstDbName> instDbNames = new List<InstDbName>(){ };

		private string dbName;

		private string dbInstType;

		public string Encode
		{
			get
			{
				return encode;
			}
			set	
			{
				encode = value;
				DictionaryUtil.Add(QueryParameters, "Encode", value);
			}
		}

		public List<string> RdsInstances
		{
			get
			{
				return rdsInstances;
			}

			set
			{
				rdsInstances = value;
				for (int i = 0; i < rdsInstances.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RdsInstance." + (i + 1) , rdsInstances[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "Type", value);
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

		public List<RdsSuperAccount> RdsSuperAccounts
		{
			get
			{
				return rdsSuperAccounts;
			}

			set
			{
				rdsSuperAccounts = value;
				for (int i = 0; i < rdsSuperAccounts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RdsSuperAccount." + (i + 1) + ".Password", rdsSuperAccounts[i].Password);
					DictionaryUtil.Add(QueryParameters,"RdsSuperAccount." + (i + 1) + ".AccountName", rdsSuperAccounts[i].AccountName);
					DictionaryUtil.Add(QueryParameters,"RdsSuperAccount." + (i + 1) + ".DbInstanceId", rdsSuperAccounts[i].DbInstanceId);
				}
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

		public bool? DbInstanceIsCreating
		{
			get
			{
				return dbInstanceIsCreating;
			}
			set	
			{
				dbInstanceIsCreating = value;
				DictionaryUtil.Add(QueryParameters, "DbInstanceIsCreating", value.ToString());
			}
		}

		public List<InstDbName> InstDbNames
		{
			get
			{
				return instDbNames;
			}

			set
			{
				instDbNames = value;
				for (int i = 0; i < instDbNames.Count; i++)
				{
					for (int j = 0; j < instDbNames[i].ShardDbNames.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"InstDbName." + (i + 1) + ".ShardDbName." +(j + 1), instDbNames[i].ShardDbNames[j]);
					}
					DictionaryUtil.Add(QueryParameters,"InstDbName." + (i + 1) + ".DbInstanceId", instDbNames[i].DbInstanceId);
				}
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(QueryParameters, "DbName", value);
			}
		}

		public string DbInstType
		{
			get
			{
				return dbInstType;
			}
			set	
			{
				dbInstType = value;
				DictionaryUtil.Add(QueryParameters, "DbInstType", value);
			}
		}

		public class RdsSuperAccount
		{

			private string password;

			private string accountName;

			private string dbInstanceId;

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
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
				}
			}

			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}
		}

		public class InstDbName
		{

			private List<string> shardDbNames = new List<string>(){ };

			private string dbInstanceId;

			public List<string> ShardDbNames
			{
				get
				{
					return shardDbNames;
				}
				set	
				{
					shardDbNames = value;
				}
			}

			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}
		}

        public override CreateDrdsDBResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDrdsDBResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
