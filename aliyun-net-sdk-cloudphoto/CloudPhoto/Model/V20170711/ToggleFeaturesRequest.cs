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
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class ToggleFeaturesRequest : RpcAcsRequest<ToggleFeaturesResponse>
    {
        public ToggleFeaturesRequest()
            : base("CloudPhoto", "2017-07-11", "ToggleFeatures", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private List<string> disabledFeaturess;

		private string storeName;

		private List<string> enabledFeaturess;

		public List<string> DisabledFeaturess
		{
			get
			{
				return disabledFeaturess;
			}

			set
			{
				disabledFeaturess = value;
				for (int i = 0; i < disabledFeaturess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DisabledFeatures." + (i + 1) , disabledFeaturess[i]);
				}
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public List<string> EnabledFeaturess
		{
			get
			{
				return enabledFeaturess;
			}

			set
			{
				enabledFeaturess = value;
				for (int i = 0; i < enabledFeaturess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EnabledFeatures." + (i + 1) , enabledFeaturess[i]);
				}
			}
		}

        public override ToggleFeaturesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ToggleFeaturesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}