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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class GetServiceSettingsResponse : AcsResponse
	{

		private string requestId;

		private List<GetServiceSettings_ServiceSetting> serviceSettings;

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "ServiceSettings")]
		public List<GetServiceSettings_ServiceSetting> ServiceSettings
		{
			get
			{
				return serviceSettings;
			}
			set	
			{
				serviceSettings = value;
			}
		}

		public class GetServiceSettings_ServiceSetting
		{

			private string deliveryOssBucketName;

			private string deliveryOssKeyPrefix;

			private bool? deliveryOssEnabled;

			private bool? deliverySlsEnabled;

			private string deliverySlsProjectName;

			private string rdcEnterpriseId;

			[JsonProperty(PropertyName = "DeliveryOssBucketName")]
			public string DeliveryOssBucketName
			{
				get
				{
					return deliveryOssBucketName;
				}
				set	
				{
					deliveryOssBucketName = value;
				}
			}

			[JsonProperty(PropertyName = "DeliveryOssKeyPrefix")]
			public string DeliveryOssKeyPrefix
			{
				get
				{
					return deliveryOssKeyPrefix;
				}
				set	
				{
					deliveryOssKeyPrefix = value;
				}
			}

			[JsonProperty(PropertyName = "DeliveryOssEnabled")]
			public bool? DeliveryOssEnabled
			{
				get
				{
					return deliveryOssEnabled;
				}
				set	
				{
					deliveryOssEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "DeliverySlsEnabled")]
			public bool? DeliverySlsEnabled
			{
				get
				{
					return deliverySlsEnabled;
				}
				set	
				{
					deliverySlsEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "DeliverySlsProjectName")]
			public string DeliverySlsProjectName
			{
				get
				{
					return deliverySlsProjectName;
				}
				set	
				{
					deliverySlsProjectName = value;
				}
			}

			[JsonProperty(PropertyName = "RdcEnterpriseId")]
			public string RdcEnterpriseId
			{
				get
				{
					return rdcEnterpriseId;
				}
				set	
				{
					rdcEnterpriseId = value;
				}
			}
		}
	}
}
