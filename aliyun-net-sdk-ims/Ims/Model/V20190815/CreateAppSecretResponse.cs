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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class CreateAppSecretResponse : AcsResponse
	{

		private string requestId;

		private CreateAppSecret_AppSecret appSecret;

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

		public CreateAppSecret_AppSecret AppSecret
		{
			get
			{
				return appSecret;
			}
			set	
			{
				appSecret = value;
			}
		}

		public class CreateAppSecret_AppSecret
		{

			private string appSecretValue;

			private string appId;

			private string appSecretId;

			private string createDate;

			public string AppSecretValue
			{
				get
				{
					return appSecretValue;
				}
				set	
				{
					appSecretValue = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string AppSecretId
			{
				get
				{
					return appSecretId;
				}
				set	
				{
					appSecretId = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}
		}
	}
}
