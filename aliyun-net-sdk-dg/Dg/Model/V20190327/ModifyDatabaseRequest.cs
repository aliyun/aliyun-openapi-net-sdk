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
using Aliyun.Acs.dg.Transform;
using Aliyun.Acs.dg.Transform.V20190327;

namespace Aliyun.Acs.dg.Model.V20190327
{
    public class ModifyDatabaseRequest : RpcAcsRequest<ModifyDatabaseResponse>
    {
        public ModifyDatabaseRequest()
            : base("dg", "2019-03-27", "ModifyDatabase", "dg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string host;

		private string dbUserName;

		private string dbDescription;

		private string instanceId;

		private string dbName;

		private int? port;

		private string dbPassword;

		private string dbType;

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(BodyParameters, "Host", value);
			}
		}

		public string DbUserName
		{
			get
			{
				return dbUserName;
			}
			set	
			{
				dbUserName = value;
				DictionaryUtil.Add(BodyParameters, "DbUserName", value);
			}
		}

		public string DbDescription
		{
			get
			{
				return dbDescription;
			}
			set	
			{
				dbDescription = value;
				DictionaryUtil.Add(BodyParameters, "DbDescription", value);
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
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
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
				DictionaryUtil.Add(BodyParameters, "DbName", value);
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
				DictionaryUtil.Add(BodyParameters, "Port", value.ToString());
			}
		}

		public string DbPassword
		{
			get
			{
				return dbPassword;
			}
			set	
			{
				dbPassword = value;
				DictionaryUtil.Add(BodyParameters, "DbPassword", value);
			}
		}

		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
				DictionaryUtil.Add(BodyParameters, "DbType", value);
			}
		}

        public override ModifyDatabaseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDatabaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
