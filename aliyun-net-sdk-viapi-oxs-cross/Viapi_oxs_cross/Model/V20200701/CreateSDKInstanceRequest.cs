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
using Aliyun.Acs.viapi_oxs_cross;
using Aliyun.Acs.viapi_oxs_cross.Transform;
using Aliyun.Acs.viapi_oxs_cross.Transform.V20200701;

namespace Aliyun.Acs.viapi_oxs_cross.Model.V20200701
{
    public class CreateSDKInstanceRequest : RpcAcsRequest<CreateSDKInstanceResponse>
    {
        public CreateSDKInstanceRequest()
            : base("viapi-oxs-cross", "2020-07-01", "CreateSDKInstance")
        {
			Method = MethodType.POST;
        }

		private string recipe;

		private string bundleId;

		private string platform;

		private long? validFrom;

		private string pk;

		private long? validTo;

		public string Recipe
		{
			get
			{
				return recipe;
			}
			set	
			{
				recipe = value;
				DictionaryUtil.Add(QueryParameters, "Recipe", value);
			}
		}

		public string BundleId
		{
			get
			{
				return bundleId;
			}
			set	
			{
				bundleId = value;
				DictionaryUtil.Add(QueryParameters, "BundleId", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public long? ValidFrom
		{
			get
			{
				return validFrom;
			}
			set	
			{
				validFrom = value;
				DictionaryUtil.Add(QueryParameters, "ValidFrom", value.ToString());
			}
		}

		public string Pk
		{
			get
			{
				return pk;
			}
			set	
			{
				pk = value;
				DictionaryUtil.Add(QueryParameters, "Pk", value);
			}
		}

		public long? ValidTo
		{
			get
			{
				return validTo;
			}
			set	
			{
				validTo = value;
				DictionaryUtil.Add(QueryParameters, "ValidTo", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSDKInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSDKInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
