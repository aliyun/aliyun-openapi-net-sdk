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
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class ValidateExpressSyncConfigRequest : RpcAcsRequest<ValidateExpressSyncConfigResponse>
    {
        public ValidateExpressSyncConfigRequest()
            : base("sgw", "2018-05-11", "ValidateExpressSyncConfig", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string bucketRegion;

		private string securityToken;

		private string bucketName;

		private string name;

		private string bucketPrefix;

		public string BucketRegion
		{
			get
			{
				return bucketRegion;
			}
			set	
			{
				bucketRegion = value;
				DictionaryUtil.Add(QueryParameters, "BucketRegion", value);
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

		public string BucketName
		{
			get
			{
				return bucketName;
			}
			set	
			{
				bucketName = value;
				DictionaryUtil.Add(QueryParameters, "BucketName", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string BucketPrefix
		{
			get
			{
				return bucketPrefix;
			}
			set	
			{
				bucketPrefix = value;
				DictionaryUtil.Add(QueryParameters, "BucketPrefix", value);
			}
		}

        public override ValidateExpressSyncConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ValidateExpressSyncConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
