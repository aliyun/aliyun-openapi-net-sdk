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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class UpdateAppRequest : RpcAcsRequest<UpdateAppResponse>
    {
        public UpdateAppRequest()
            : base("retailcloud", "2018-03-13", "UpdateApp", "retailcloud", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string bizTitle;

		private string serviceType;

		private long? appId;

		private string operatingSystem;

		private string description;

		private string language;

		public string BizTitle
		{
			get
			{
				return bizTitle;
			}
			set	
			{
				bizTitle = value;
				DictionaryUtil.Add(BodyParameters, "BizTitle", value);
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
				DictionaryUtil.Add(BodyParameters, "ServiceType", value);
			}
		}

		public long? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(BodyParameters, "AppId", value.ToString());
			}
		}

		public string OperatingSystem
		{
			get
			{
				return operatingSystem;
			}
			set	
			{
				operatingSystem = value;
				DictionaryUtil.Add(BodyParameters, "OperatingSystem", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(BodyParameters, "Language", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateAppResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
