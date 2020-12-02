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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class SetServiceSettingsResponse : AcsResponse
	{

		private string requestId;

		private List<SetServiceSettings_ServiceSetting> serviceSettings;

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

		public List<SetServiceSettings_ServiceSetting> ServiceSettings
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

		public class SetServiceSettings_ServiceSetting
		{

			private bool? deliveryOssEnabled;

			private string deliveryOssBucketName;

			private string deliveryOssKeyPrefix;

			private bool? deliverySlsEnabled;

			private string deliverySlsProjectName;

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
		}
	}
}
