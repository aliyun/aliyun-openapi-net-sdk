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
using Aliyun.Acs.oos;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class SetServiceSettingsRequest : RpcAcsRequest<SetServiceSettingsResponse>
    {
        public SetServiceSettingsRequest()
            : base("oos", "2019-06-01", "SetServiceSettings")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? deliverySlsEnabled;

		private string deliveryOssKeyPrefix;

		private bool? deliveryOssEnabled;

		private string deliverySlsProjectName;

		private string deliveryOssBucketName;

		public bool? DeliverySlsEnabled
		{
			get
			{
				return deliverySlsEnabled;
			}
			set	
			{
				deliverySlsEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DeliverySlsEnabled", value.ToString());
			}
		}

		public string DeliveryOssKeyPrefix
		{
			get
			{
				return deliveryOssKeyPrefix;
			}
			set	
			{
				deliveryOssKeyPrefix = value;
				DictionaryUtil.Add(QueryParameters, "DeliveryOssKeyPrefix", value);
			}
		}

		public bool? DeliveryOssEnabled
		{
			get
			{
				return deliveryOssEnabled;
			}
			set	
			{
				deliveryOssEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DeliveryOssEnabled", value.ToString());
			}
		}

		public string DeliverySlsProjectName
		{
			get
			{
				return deliverySlsProjectName;
			}
			set	
			{
				deliverySlsProjectName = value;
				DictionaryUtil.Add(QueryParameters, "DeliverySlsProjectName", value);
			}
		}

		public string DeliveryOssBucketName
		{
			get
			{
				return deliveryOssBucketName;
			}
			set	
			{
				deliveryOssBucketName = value;
				DictionaryUtil.Add(QueryParameters, "DeliveryOssBucketName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetServiceSettingsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetServiceSettingsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
