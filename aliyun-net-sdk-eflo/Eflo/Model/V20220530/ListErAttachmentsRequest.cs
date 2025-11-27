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
    public class ListErAttachmentsRequest : RpcAcsRequest<ListErAttachmentsResponse>
    {
        public ListErAttachmentsRequest()
            : base("eflo", "2022-05-30", "ListErAttachments", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private string resourceTenantId;

		private string resourceGroupId;

		private bool? autoReceiveAllRoute;

		private int? pageSize;

		private string instanceType;

		private string erAttachmentName;

		private string erId;

		private string instanceId;

		private string erAttachmentId;

		private bool? enablePage;

		private string status;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupId", value);
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
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

		public string ErAttachmentId
		{
			get
			{
				return erAttachmentId;
			}
			set	
			{
				erAttachmentId = value;
				DictionaryUtil.Add(BodyParameters, "ErAttachmentId", value);
			}
		}

		public bool? EnablePage
		{
			get
			{
				return enablePage;
			}
			set	
			{
				enablePage = value;
				DictionaryUtil.Add(BodyParameters, "EnablePage", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListErAttachmentsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListErAttachmentsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
