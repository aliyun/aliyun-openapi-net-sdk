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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class ModifyAppConfigRequest : RpcAcsRequest<ModifyAppConfigResponse>
    {
        public ModifyAppConfigRequest()
            : base("Push", "2016-08-01", "ModifyAppConfig")
        {
        }

		private long? _appKey;

		private string _packageName;

		private string _devCertKey;

		private string _devCertPass;

		private string _productCertKey;

		private string _productCertPass;

		private string _bundleId;

		private bool? _boxFlag;

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string PackageName
		{
			get
			{
				return _packageName;
			}
			set	
			{
				_packageName = value;
				DictionaryUtil.Add(QueryParameters, "PackageName", value);
			}
		}

		public string DevCertKey
		{
			get
			{
				return _devCertKey;
			}
			set	
			{
				_devCertKey = value;
				DictionaryUtil.Add(QueryParameters, "DevCertKey", value);
			}
		}

		public string DevCertPass
		{
			get
			{
				return _devCertPass;
			}
			set	
			{
				_devCertPass = value;
				DictionaryUtil.Add(QueryParameters, "DevCertPass", value);
			}
		}

		public string ProductCertKey
		{
			get
			{
				return _productCertKey;
			}
			set	
			{
				_productCertKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductCertKey", value);
			}
		}

		public string ProductCertPass
		{
			get
			{
				return _productCertPass;
			}
			set	
			{
				_productCertPass = value;
				DictionaryUtil.Add(QueryParameters, "ProductCertPass", value);
			}
		}

		public string BundleId
		{
			get
			{
				return _bundleId;
			}
			set	
			{
				_bundleId = value;
				DictionaryUtil.Add(QueryParameters, "BundleId", value);
			}
		}

		public bool? BoxFlag
		{
			get
			{
				return _boxFlag;
			}
			set	
			{
				_boxFlag = value;
				DictionaryUtil.Add(QueryParameters, "BoxFlag", value.ToString());
			}
		}

        public override ModifyAppConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyAppConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}