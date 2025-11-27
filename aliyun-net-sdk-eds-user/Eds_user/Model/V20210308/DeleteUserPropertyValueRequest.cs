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
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class DeleteUserPropertyValueRequest : RpcAcsRequest<DeleteUserPropertyValueResponse>
    {
        public DeleteUserPropertyValueRequest()
            : base("eds-user", "2021-03-08", "DeleteUserPropertyValue", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? propertyValueId;

		private long? userId;

		private long? propertyId;

		public long? PropertyValueId
		{
			get
			{
				return propertyValueId;
			}
			set	
			{
				propertyValueId = value;
				DictionaryUtil.Add(BodyParameters, "PropertyValueId", value.ToString());
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value.ToString());
			}
		}

		public long? PropertyId
		{
			get
			{
				return propertyId;
			}
			set	
			{
				propertyId = value;
				DictionaryUtil.Add(BodyParameters, "PropertyId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteUserPropertyValueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteUserPropertyValueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
