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
using Aliyun.Acs.Dm.Transform;
using Aliyun.Acs.Dm.Transform.V20170622;

namespace Aliyun.Acs.Dm.Model.V20170622
{
    public class CreateTemplateRequest : RpcAcsRequest<CreateTemplateResponse>
    {
        public CreateTemplateRequest()
            : base("Dm", "2017-06-22", "CreateTemplate", "dm", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private int? smsType;

		private string resourceOwnerAccount;

		private string templateText;

		private string templateNickName;

		private string remark;

		private long? ownerId;

		private string accessKeyId;

		private string templateSubject;

		private int? templateType;

		private string action;

		private string templateName;

		private int? fromType;

		private string smsContent;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? SmsType
		{
			get
			{
				return smsType;
			}
			set	
			{
				smsType = value;
				DictionaryUtil.Add(QueryParameters, "SmsType", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string TemplateText
		{
			get
			{
				return templateText;
			}
			set	
			{
				templateText = value;
				DictionaryUtil.Add(QueryParameters, "TemplateText", value);
			}
		}

		public string TemplateNickName
		{
			get
			{
				return templateNickName;
			}
			set	
			{
				templateNickName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateNickName", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string TemplateSubject
		{
			get
			{
				return templateSubject;
			}
			set	
			{
				templateSubject = value;
				DictionaryUtil.Add(QueryParameters, "TemplateSubject", value);
			}
		}

		public int? TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public int? FromType
		{
			get
			{
				return fromType;
			}
			set	
			{
				fromType = value;
				DictionaryUtil.Add(QueryParameters, "FromType", value.ToString());
			}
		}

		public string SmsContent
		{
			get
			{
				return smsContent;
			}
			set	
			{
				smsContent = value;
				DictionaryUtil.Add(QueryParameters, "SmsContent", value);
			}
		}

        public override CreateTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
