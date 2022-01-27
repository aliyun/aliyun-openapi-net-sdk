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
    public class SubmitSmoothExpandTaskRequest : RpcAcsRequest<SubmitSmoothExpandTaskResponse>
    {
        public SubmitSmoothExpandTaskRequest()
            : base("Drds", "2019-01-23", "SubmitSmoothExpandTask", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string drdsInstanceId;

		private bool? dbInstanceIsCreating;

		private List<RdsSuperInstances> rdsSuperInstancess = new List<RdsSuperInstances>(){ };

		private string dbName;

		private List<TransferTaskInfos> transferTaskInfoss = new List<TransferTaskInfos>(){ };

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

		public List<RdsSuperInstances> RdsSuperInstancess
		{
			get
			{
				return rdsSuperInstancess;
			}

			set
			{
				rdsSuperInstancess = value;
				for (int i = 0; i < rdsSuperInstancess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RdsSuperInstances." + (i + 1) + ".Password", rdsSuperInstancess[i].Password);
					DictionaryUtil.Add(QueryParameters,"RdsSuperInstances." + (i + 1) + ".AccountName", rdsSuperInstancess[i].AccountName);
					DictionaryUtil.Add(QueryParameters,"RdsSuperInstances." + (i + 1) + ".RdsName", rdsSuperInstancess[i].RdsName);
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

		public List<TransferTaskInfos> TransferTaskInfoss
		{
			get
			{
				return transferTaskInfoss;
			}

			set
			{
				transferTaskInfoss = value;
				for (int i = 0; i < transferTaskInfoss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TransferTaskInfos." + (i + 1) + ".DbName", transferTaskInfoss[i].DbName);
					DictionaryUtil.Add(QueryParameters,"TransferTaskInfos." + (i + 1) + ".SrcInstanceName", transferTaskInfoss[i].SrcInstanceName);
					DictionaryUtil.Add(QueryParameters,"TransferTaskInfos." + (i + 1) + ".InstanceType", transferTaskInfoss[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"TransferTaskInfos." + (i + 1) + ".DstInstanceName", transferTaskInfoss[i].DstInstanceName);
				}
			}
		}

		public class RdsSuperInstances
		{

			private string password;

			private string accountName;

			private string rdsName;

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

			public string RdsName
			{
				get
				{
					return rdsName;
				}
				set	
				{
					rdsName = value;
				}
			}
		}

		public class TransferTaskInfos
		{

			private string dbName;

			private string srcInstanceName;

			private string instanceType;

			private string dstInstanceName;

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

			public string SrcInstanceName
			{
				get
				{
					return srcInstanceName;
				}
				set	
				{
					srcInstanceName = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string DstInstanceName
			{
				get
				{
					return dstInstanceName;
				}
				set	
				{
					dstInstanceName = value;
				}
			}
		}

        public override SubmitSmoothExpandTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitSmoothExpandTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
