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
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class ModifyDefaultLevelRequest : RpcAcsRequest<ModifyDefaultLevelResponse>
    {
        public ModifyDefaultLevelRequest()
            : base("Sddp", "2019-01-03", "ModifyDefaultLevel", "sddp", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? defaultId;

		private string lang;

		private string sensitiveIds;

		public long? DefaultId
		{
			get
			{
				return defaultId;
			}
			set	
			{
				defaultId = value;
				DictionaryUtil.Add(QueryParameters, "DefaultId", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string SensitiveIds
		{
			get
			{
				return sensitiveIds;
			}
			set	
			{
				sensitiveIds = value;
				DictionaryUtil.Add(QueryParameters, "SensitiveIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDefaultLevelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDefaultLevelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
