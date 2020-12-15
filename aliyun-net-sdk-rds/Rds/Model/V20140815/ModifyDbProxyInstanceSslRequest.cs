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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDbProxyInstanceSslRequest : RpcAcsRequest<ModifyDbProxyInstanceSslResponse>
    {
        public ModifyDbProxyInstanceSslRequest()
            : base("Rds", "2014-08-15", "ModifyDbProxyInstanceSsl", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dbProxySslEnabled;

		private string dbProxyConnectString;

		private string dbInstanceId;

		private string dbProxyEndpointId;

		public string DbProxySslEnabled
		{
			get
			{
				return dbProxySslEnabled;
			}
			set	
			{
				dbProxySslEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DbProxySslEnabled", value);
			}
		}

		public string DbProxyConnectString
		{
			get
			{
				return dbProxyConnectString;
			}
			set	
			{
				dbProxyConnectString = value;
				DictionaryUtil.Add(QueryParameters, "DbProxyConnectString", value);
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
				DictionaryUtil.Add(QueryParameters, "DbInstanceId", value);
			}
		}

		public string DbProxyEndpointId
		{
			get
			{
				return dbProxyEndpointId;
			}
			set	
			{
				dbProxyEndpointId = value;
				DictionaryUtil.Add(QueryParameters, "DbProxyEndpointId", value);
			}
		}

        public override ModifyDbProxyInstanceSslResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDbProxyInstanceSslResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
