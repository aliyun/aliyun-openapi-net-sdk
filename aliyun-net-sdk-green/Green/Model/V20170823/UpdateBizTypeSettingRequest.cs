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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateBizTypeSettingRequest : RpcAcsRequest<UpdateBizTypeSettingResponse>
    {
        public UpdateBizTypeSettingRequest()
            : base("Green", "2017-08-23", "UpdateBizTypeSetting", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string antispam;

		private string porn;

		private string terrorism;

		private string bizTypeName;

		private string live;

		private string ad;

		private string resourceType;

		public string Antispam
		{
			get
			{
				return antispam;
			}
			set	
			{
				antispam = value;
				DictionaryUtil.Add(QueryParameters, "Antispam", value);
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

		public string BizTypeName
		{
			get
			{
				return bizTypeName;
			}
			set	
			{
				bizTypeName = value;
				DictionaryUtil.Add(QueryParameters, "BizTypeName", value);
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

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateBizTypeSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateBizTypeSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
