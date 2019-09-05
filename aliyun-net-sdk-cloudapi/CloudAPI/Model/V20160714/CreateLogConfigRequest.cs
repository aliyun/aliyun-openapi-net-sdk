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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateLogConfigRequest : RpcAcsRequest<CreateLogConfigResponse>
    {
        public CreateLogConfigRequest()
            : base("CloudAPI", "2016-07-14", "CreateLogConfig", "apigateway", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string slsLogStore;

		private string slsProject;

		private string logType;

		private string securityToken;

		public string SlsLogStore
		{
			get
			{
				return slsLogStore;
			}
			set	
			{
				slsLogStore = value;
				DictionaryUtil.Add(QueryParameters, "SlsLogStore", value);
			}
		}

		public string SlsProject
		{
			get
			{
				return slsProject;
			}
			set	
			{
				slsProject = value;
				DictionaryUtil.Add(QueryParameters, "SlsProject", value);
			}
		}

		public string LogType
		{
			get
			{
				return logType;
			}
			set	
			{
				logType = value;
				DictionaryUtil.Add(QueryParameters, "LogType", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

        public override CreateLogConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLogConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
