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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class CreateErAttachmentRequest : RpcAcsRequest<CreateErAttachmentResponse>
    {
        public CreateErAttachmentRequest()
            : base("eflo", "2022-05-30", "CreateErAttachment", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string resourceTenantId;

		private bool? autoReceiveAllRoute;

		private string instanceType;

		private string erAttachmentName;

		private string erId;

		private string instanceId;

		public string ResourceTenantId
		{
			get
			{
				return resourceTenantId;
			}
			set	
			{
				resourceTenantId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceTenantId", value);
			}
		}

		public bool? AutoReceiveAllRoute
		{
			get
			{
				return autoReceiveAllRoute;
			}
			set	
			{
				autoReceiveAllRoute = value;
				DictionaryUtil.Add(BodyParameters, "AutoReceiveAllRoute", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(BodyParameters, "InstanceType", value);
			}
		}

		public string ErAttachmentName
		{
			get
			{
				return erAttachmentName;
			}
			set	
			{
				erAttachmentName = value;
				DictionaryUtil.Add(BodyParameters, "ErAttachmentName", value);
			}
		}

		public string ErId
		{
			get
			{
				return erId;
			}
			set	
			{
				erId = value;
				DictionaryUtil.Add(BodyParameters, "ErId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateErAttachmentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateErAttachmentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
