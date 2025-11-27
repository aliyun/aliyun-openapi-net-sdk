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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class SyncAppInstanceForPartnerResponse : AcsResponse
	{

		private string requestId;

		private SyncAppInstanceForPartner_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public SyncAppInstanceForPartner_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class SyncAppInstanceForPartner_Data
		{

			private SyncAppInstanceForPartner_AppInstance appInstance;

			[JsonProperty(PropertyName = "AppInstance")]
			public SyncAppInstanceForPartner_AppInstance AppInstance
			{
				get
				{
					return appInstance;
				}
				set	
				{
					appInstance = value;
				}
			}

			public class SyncAppInstanceForPartner_AppInstance
			{

				private string bizId;

				[JsonProperty(PropertyName = "BizId")]
				public string BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}
			}
		}
	}
}
