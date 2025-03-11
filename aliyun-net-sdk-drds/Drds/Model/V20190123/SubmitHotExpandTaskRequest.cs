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
    public class SubmitHotExpandTaskRequest : RpcAcsRequest<SubmitHotExpandTaskResponse>
    {
        public SubmitHotExpandTaskRequest()
            : base("Drds", "2019-01-23", "SubmitHotExpandTask", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string taskDesc;

		private string taskName;

		private List<string> mappings = new List<string>(){ };

		private List<string> supperAccountMappings = new List<string>(){ };

		private List<string> extendedMappings = new List<string>(){ };

		private string drdsInstanceId;

		private List<string> instanceDbMappings = new List<string>(){ };

		private string dbName;

		public string TaskDesc
		{
			get
			{
				return taskDesc;
			}
			set	
			{
				taskDesc = value;
				DictionaryUtil.Add(QueryParameters, "TaskDesc", value);
			}
		}

		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		public List<string> Mappings
		{
			get
			{
				return mappings;
			}

			set
			{
				mappings = value;
				if(mappings != null)
				{
					for (int depth1 = 0; depth1 < mappings.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"Mapping." + (depth1 + 1), mappings[depth1]);
					}
				}
			}
		}

		public List<string> SupperAccountMappings
		{
			get
			{
				return supperAccountMappings;
			}

			set
			{
				supperAccountMappings = value;
				if(supperAccountMappings != null)
				{
					for (int depth1 = 0; depth1 < supperAccountMappings.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"SupperAccountMapping." + (depth1 + 1), supperAccountMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"SupperAccountMapping." + (depth1 + 1), supperAccountMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"SupperAccountMapping." + (depth1 + 1), supperAccountMappings[depth1]);
					}
				}
			}
		}

		public List<string> ExtendedMappings
		{
			get
			{
				return extendedMappings;
			}

			set
			{
				extendedMappings = value;
				if(extendedMappings != null)
				{
					for (int depth1 = 0; depth1 < extendedMappings.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ExtendedMapping." + (depth1 + 1), extendedMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"ExtendedMapping." + (depth1 + 1), extendedMappings[depth1]);
					}
				}
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

		public List<string> InstanceDbMappings
		{
			get
			{
				return instanceDbMappings;
			}

			set
			{
				instanceDbMappings = value;
				if(instanceDbMappings != null)
				{
					for (int depth1 = 0; depth1 < instanceDbMappings.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"InstanceDbMapping." + (depth1 + 1), instanceDbMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"InstanceDbMapping." + (depth1 + 1), instanceDbMappings[depth1]);
					}
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

		public class Mapping
		{

			private string tbShardColumn;

			private string dbShardColumn;

			private string shardTbValue;

			private string hotDbName;

			private string shardDbValue;

			private string hotTableName;

			private string logicTable;

			public string TbShardColumn
			{
				get
				{
					return tbShardColumn;
				}
				set	
				{
					tbShardColumn = value;
				}
			}

			public string DbShardColumn
			{
				get
				{
					return dbShardColumn;
				}
				set	
				{
					dbShardColumn = value;
				}
			}

			public string ShardTbValue
			{
				get
				{
					return shardTbValue;
				}
				set	
				{
					shardTbValue = value;
				}
			}

			public string HotDbName
			{
				get
				{
					return hotDbName;
				}
				set	
				{
					hotDbName = value;
				}
			}

			public string ShardDbValue
			{
				get
				{
					return shardDbValue;
				}
				set	
				{
					shardDbValue = value;
				}
			}

			public string HotTableName
			{
				get
				{
					return hotTableName;
				}
				set	
				{
					hotTableName = value;
				}
			}

			public string LogicTable
			{
				get
				{
					return logicTable;
				}
				set	
				{
					logicTable = value;
				}
			}
		}

		public class SupperAccountMapping
		{

			private string instanceName;

			private string supperAccount;

			private string supperPassword;

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string SupperAccount
			{
				get
				{
					return supperAccount;
				}
				set	
				{
					supperAccount = value;
				}
			}

			public string SupperPassword
			{
				get
				{
					return supperPassword;
				}
				set	
				{
					supperPassword = value;
				}
			}
		}

		public class ExtendedMapping
		{

			private string srcInstanceId;

			private string srcDb;

			public string SrcInstanceId
			{
				get
				{
					return srcInstanceId;
				}
				set	
				{
					srcInstanceId = value;
				}
			}

			public string SrcDb
			{
				get
				{
					return srcDb;
				}
				set	
				{
					srcDb = value;
				}
			}
		}

		public class InstanceDbMapping
		{

			private string dbList;

			private string instanceName;

			public string DbList
			{
				get
				{
					return dbList;
				}
				set	
				{
					dbList = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}
		}

        public override SubmitHotExpandTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitHotExpandTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
