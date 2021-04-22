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
            : base("dms-enterprise", "2018-11-01", "UpdateInstance", "dms-enterprise", "openAPI")
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

		[JsonProperty(PropertyName = "SafeRuleId")]
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

		[JsonProperty(PropertyName = "EcsRegion")]
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

		[JsonProperty(PropertyName = "DdlOnline")]
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

		[JsonProperty(PropertyName = "UseDsql")]
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

		[JsonProperty(PropertyName = "Tid")]
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

		[JsonProperty(PropertyName = "Sid")]
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

		[JsonProperty(PropertyName = "DbaId")]
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

		[JsonProperty(PropertyName = "DataLinkName")]
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

		[JsonProperty(PropertyName = "InstanceSource")]
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

		[JsonProperty(PropertyName = "EnvType")]
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

		[JsonProperty(PropertyName = "Host")]
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

		[JsonProperty(PropertyName = "InstanceType")]
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

		[JsonProperty(PropertyName = "QueryTimeout")]
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

		[JsonProperty(PropertyName = "EcsInstanceId")]
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

		[JsonProperty(PropertyName = "ExportTimeout")]
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

		[JsonProperty(PropertyName = "DatabasePassword")]
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

		[JsonProperty(PropertyName = "InstanceAlias")]
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

		[JsonProperty(PropertyName = "DatabaseUser")]
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

		[JsonProperty(PropertyName = "InstanceId")]
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

		[JsonProperty(PropertyName = "Port")]
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

		[JsonProperty(PropertyName = "VpcId")]
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

		[JsonProperty(PropertyName = "SkipTest")]
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
