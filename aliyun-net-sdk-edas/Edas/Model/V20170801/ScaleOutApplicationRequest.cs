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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class ScaleOutApplicationRequest : RoaAcsRequest<ScaleOutApplicationResponse>
    {
        public ScaleOutApplicationRequest()
            : base("Edas", "2017-08-01", "ScaleOutApplication", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/changeorder/co_scale_out";
			Method = MethodType.POST;
        }

		private string ecuInfo;

		private string deployGroup;

		private string appId;

		public string EcuInfo
		{
			get
			{
				return ecuInfo;
			}
			set	
			{
				ecuInfo = value;
				DictionaryUtil.Add(QueryParameters, "EcuInfo", value);
			}
		}

		public string DeployGroup
		{
			get
			{
				return deployGroup;
			}
			set	
			{
				deployGroup = value;
				DictionaryUtil.Add(QueryParameters, "DeployGroup", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

        public override ScaleOutApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScaleOutApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
