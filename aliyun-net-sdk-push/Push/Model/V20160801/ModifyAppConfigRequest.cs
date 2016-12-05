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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class ModifyAppConfigRequest : RpcAcsRequest<ModifyAppConfigResponse>
    {
        public ModifyAppConfigRequest()
            : base("Push", "2016-08-01", "ModifyAppConfig")
        {
        }

		private long? appKey;

		private string packageName;

		private string devCertKey;

		private string devCertPass;

		private string productCertKey;

		private string productCertPass;

		private string bundleId;

		private bool? boxFlag;

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string PackageName
		{
			get
			{
				return packageName;
			}
			set	
			{
				packageName = value;
				DictionaryUtil.Add(QueryParameters, "PackageName", value);
			}
		}

		public string DevCertKey
		{
			get
			{
				return devCertKey;
			}
			set	
			{
				devCertKey = value;
				DictionaryUtil.Add(QueryParameters, "DevCertKey", value);
			}
		}

		public string DevCertPass
		{
			get
			{
				return devCertPass;
			}
			set	
			{
				devCertPass = value;
				DictionaryUtil.Add(QueryParameters, "DevCertPass", value);
			}
		}

		public string ProductCertKey
		{
			get
			{
				return productCertKey;
			}
			set	
			{
				productCertKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductCertKey", value);
			}
		}

		public string ProductCertPass
		{
			get
			{
				return productCertPass;
			}
			set	
			{
				productCertPass = value;
				DictionaryUtil.Add(QueryParameters, "ProductCertPass", value);
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

		public bool? BoxFlag
		{
			get
			{
				return boxFlag;
			}
			set	
			{
				boxFlag = value;
				DictionaryUtil.Add(QueryParameters, "BoxFlag", value.ToString());
			}
		}

        public override ModifyAppConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyAppConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}