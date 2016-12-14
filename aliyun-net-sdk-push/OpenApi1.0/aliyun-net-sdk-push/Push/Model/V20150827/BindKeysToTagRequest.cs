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
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class BindKeysToTagRequest : RpcAcsRequest<BindKeysToTagResponse>
    {
        public BindKeysToTagRequest()
            : base("Push", "2015-08-27", "BindKeysToTag")
        {
        }

		private long? appKey;

		private string clientKey;

		private int? keyType;

		private string tagName;

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

		public string ClientKey
		{
			get
			{
				return clientKey;
			}
			set	
			{
				clientKey = value;
				DictionaryUtil.Add(QueryParameters, "ClientKey", value);
			}
		}

		public int? KeyType
		{
			get
			{
				return keyType;
			}
			set	
			{
				keyType = value;
				DictionaryUtil.Add(QueryParameters, "KeyType", value.ToString());
			}
		}

		public string TagName
		{
			get
			{
				return tagName;
			}
			set	
			{
				tagName = value;
				DictionaryUtil.Add(QueryParameters, "TagName", value);
			}
		}

        public override BindKeysToTagResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BindKeysToTagResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}