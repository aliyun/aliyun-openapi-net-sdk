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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class UpdateMCTemplateRequest : RpcAcsRequest<UpdateMCTemplateResponse>
    {
        public UpdateMCTemplateRequest()
            : base("Mts", "2014-06-18", "UpdateMCTemplate", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string politics;

		private long? resourceOwnerId;

		private string abuse;

		private string qrcode;

		private string porn;

		private string terrorism;

		private string logo;

		private string live;

		private string contraband;

		private string ad;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string templateId;

		private string name;

		private string spam;

		public string Politics
		{
			get
			{
				return politics;
			}
			set	
			{
				politics = value;
				DictionaryUtil.Add(QueryParameters, "Politics", value);
			}
		}

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

		public string Abuse
		{
			get
			{
				return abuse;
			}
			set	
			{
				abuse = value;
				DictionaryUtil.Add(QueryParameters, "Abuse", value);
			}
		}

		public string Qrcode
		{
			get
			{
				return qrcode;
			}
			set	
			{
				qrcode = value;
				DictionaryUtil.Add(QueryParameters, "Qrcode", value);
			}
		}

		public string Porn
		{
			get
			{
				return porn;
			}
			set	
			{
				porn = value;
				DictionaryUtil.Add(QueryParameters, "Porn", value);
			}
		}

		public string Terrorism
		{
			get
			{
				return terrorism;
			}
			set	
			{
				terrorism = value;
				DictionaryUtil.Add(QueryParameters, "Terrorism", value);
			}
		}

		public string Logo
		{
			get
			{
				return logo;
			}
			set	
			{
				logo = value;
				DictionaryUtil.Add(QueryParameters, "Logo", value);
			}
		}

		public string Live
		{
			get
			{
				return live;
			}
			set	
			{
				live = value;
				DictionaryUtil.Add(QueryParameters, "Live", value);
			}
		}

		public string Contraband
		{
			get
			{
				return contraband;
			}
			set	
			{
				contraband = value;
				DictionaryUtil.Add(QueryParameters, "Contraband", value);
			}
		}

		public string Ad
		{
			get
			{
				return ad;
			}
			set	
			{
				ad = value;
				DictionaryUtil.Add(QueryParameters, "Ad", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Spam
		{
			get
			{
				return spam;
			}
			set	
			{
				spam = value;
				DictionaryUtil.Add(QueryParameters, "spam", value);
			}
		}

        public override UpdateMCTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMCTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
