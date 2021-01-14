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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class UpdateInstanceRequest : RpcAcsRequest<UpdateInstanceResponse>
    {
        public UpdateInstanceRequest()
            : base("dms-enterprise", "2018-11-01", "UpdateInstance", "dmsenterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string safeRuleId;

		private string ecsRegion;

		private int? ddlOnline;

		private int? useDsql;

		private long? tid;

		private string sid;

		private string dbaId;

		private string dataLinkName;

		private string instanceSource;

		private string envType;

		private string host;

		private string instanceType;

		private int? queryTimeout;

		private string ecsInstanceId;

		private int? exportTimeout;

		private string databasePassword;

		private string instanceAlias;

		private string databaseUser;

		private string instanceId;

		private int? port;

		private string vpcId;

		private bool? skipTest;

		public string SafeRuleId
		{
			get
			{
				return safeRuleId;
			}
			set	
			{
				safeRuleId = value;
				DictionaryUtil.Add(QueryParameters, "SafeRuleId", value);
			}
		}

		public string EcsRegion
		{
			get
			{
				return ecsRegion;
			}
			set	
			{
				ecsRegion = value;
				DictionaryUtil.Add(QueryParameters, "EcsRegion", value);
			}
		}

		public int? DdlOnline
		{
			get
			{
				return ddlOnline;
			}
			set	
			{
				ddlOnline = value;
				DictionaryUtil.Add(QueryParameters, "DdlOnline", value.ToString());
			}
		}

		public int? UseDsql
		{
			get
			{
				return useDsql;
			}
			set	
			{
				useDsql = value;
				DictionaryUtil.Add(QueryParameters, "UseDsql", value.ToString());
			}
		}

		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		public string Sid
		{
			get
			{
				return sid;
			}
			set	
			{
				sid = value;
				DictionaryUtil.Add(QueryParameters, "Sid", value);
			}
		}

		public string DbaId
		{
			get
			{
				return dbaId;
			}
			set	
			{
				dbaId = value;
				DictionaryUtil.Add(QueryParameters, "DbaId", value);
			}
		}

		public string DataLinkName
		{
			get
			{
				return dataLinkName;
			}
			set	
			{
				dataLinkName = value;
				DictionaryUtil.Add(QueryParameters, "DataLinkName", value);
			}
		}

		public string InstanceSource
		{
			get
			{
				return instanceSource;
			}
			set	
			{
				instanceSource = value;
				DictionaryUtil.Add(QueryParameters, "InstanceSource", value);
			}
		}

		public string EnvType
		{
			get
			{
				return envType;
			}
			set	
			{
				envType = value;
				DictionaryUtil.Add(QueryParameters, "EnvType", value);
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(QueryParameters, "Host", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public int? QueryTimeout
		{
			get
			{
				return queryTimeout;
			}
			set	
			{
				queryTimeout = value;
				DictionaryUtil.Add(QueryParameters, "QueryTimeout", value.ToString());
			}
		}

		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceId", value);
			}
		}

		public int? ExportTimeout
		{
			get
			{
				return exportTimeout;
			}
			set	
			{
				exportTimeout = value;
				DictionaryUtil.Add(QueryParameters, "ExportTimeout", value.ToString());
			}
		}

		public string DatabasePassword
		{
			get
			{
				return databasePassword;
			}
			set	
			{
				databasePassword = value;
				DictionaryUtil.Add(QueryParameters, "DatabasePassword", value);
			}
		}

		public string InstanceAlias
		{
			get
			{
				return instanceAlias;
			}
			set	
			{
				instanceAlias = value;
				DictionaryUtil.Add(QueryParameters, "InstanceAlias", value);
			}
		}

		public string DatabaseUser
		{
			get
			{
				return databaseUser;
			}
			set	
			{
				databaseUser = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseUser", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public bool? SkipTest
		{
			get
			{
				return skipTest;
			}
			set	
			{
				skipTest = value;
				DictionaryUtil.Add(QueryParameters, "SkipTest", value.ToString());
			}
		}

        public override UpdateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
