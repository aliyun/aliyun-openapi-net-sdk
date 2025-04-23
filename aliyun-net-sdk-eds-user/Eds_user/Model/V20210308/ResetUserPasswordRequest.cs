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
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class ResetUserPasswordRequest : RpcAcsRequest<ResetUserPasswordResponse>
    {
        public ResetUserPasswordRequest()
            : base("eds-user", "2021-03-08", "ResetUserPassword", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> userss = new List<string>(){ };

		private int? notifyType;

		[JsonProperty(PropertyName = "Users")]
		public List<string> Userss
		{
			get
			{
				return userss;
			}

			set
			{
				userss = value;
			}
		}

		[JsonProperty(PropertyName = "NotifyType")]
		public int? NotifyType
		{
			get
			{
				return notifyType;
			}
			set	
			{
				notifyType = value;
				DictionaryUtil.Add(BodyParameters, "NotifyType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ResetUserPasswordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResetUserPasswordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
