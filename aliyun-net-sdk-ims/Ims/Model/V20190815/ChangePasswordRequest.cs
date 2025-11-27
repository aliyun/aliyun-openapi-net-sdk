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
using Aliyun.Acs.Ims.Transform;
using Aliyun.Acs.Ims.Transform.V20190815;

namespace Aliyun.Acs.Ims.Model.V20190815
{
    public class ChangePasswordRequest : RpcAcsRequest<ChangePasswordResponse>
    {
        public ChangePasswordRequest()
            : base("Ims", "2019-08-15", "ChangePassword", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string oldPassword;

		private string newPassword;

		public string OldPassword
		{
			get
			{
				return oldPassword;
			}
			set	
			{
				oldPassword = value;
				DictionaryUtil.Add(QueryParameters, "OldPassword", value);
			}
		}

		public string NewPassword
		{
			get
			{
				return newPassword;
			}
			set	
			{
				newPassword = value;
				DictionaryUtil.Add(QueryParameters, "NewPassword", value);
			}
		}

        public override ChangePasswordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangePasswordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
