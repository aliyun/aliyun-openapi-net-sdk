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
    public class ChangeInstanceAzoneRequest : RpcAcsRequest<ChangeInstanceAzoneResponse>
    {
        public ChangeInstanceAzoneRequest()
            : base("Drds", "2019-01-23", "ChangeInstanceAzone", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string targetAzoneId;

		private string drdsRegionId;

		private string drdsInstanceId;

		private string originAzoneId;

		private bool? changeVSwitch;

		private string newVSwitch;

		public string TargetAzoneId
		{
			get
			{
				return targetAzoneId;
			}
			set	
			{
				targetAzoneId = value;
				DictionaryUtil.Add(QueryParameters, "TargetAzoneId", value);
			}
		}

		public string DrdsRegionId
		{
			get
			{
				return drdsRegionId;
			}
			set	
			{
				drdsRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsRegionId", value);
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

		public string OriginAzoneId
		{
			get
			{
				return originAzoneId;
			}
			set	
			{
				originAzoneId = value;
				DictionaryUtil.Add(QueryParameters, "OriginAzoneId", value);
			}
		}

		public bool? ChangeVSwitch
		{
			get
			{
				return changeVSwitch;
			}
			set	
			{
				changeVSwitch = value;
				DictionaryUtil.Add(QueryParameters, "ChangeVSwitch", value.ToString());
			}
		}

		public string NewVSwitch
		{
			get
			{
				return newVSwitch;
			}
			set	
			{
				newVSwitch = value;
				DictionaryUtil.Add(QueryParameters, "NewVSwitch", value);
			}
		}

        public override ChangeInstanceAzoneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeInstanceAzoneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
