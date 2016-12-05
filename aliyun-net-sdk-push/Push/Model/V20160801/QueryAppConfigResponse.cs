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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryAppConfigResponse : AcsResponse
	{

		private AppConfig_ appConfig;

		public AppConfig_ AppConfig
		{
			get
			{
				return appConfig;
			}
			set	
			{
				appConfig = value;
			}
		}

		public class AppConfig_{

			private long? appKey;

			private string appId;

			private string appName;

			private string bundleId;

			private string packageName;

			private bool? boxFlag;

			private bool? android;

			private bool? iOS;

			private string productCertKey;

			private string productCertPass;

			private string devCertKey;

			private string devCertPass;

			public long? AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string BundleId
			{
				get
				{
					return bundleId;
				}
				set	
				{
					bundleId = value;
				}
			}

			public string PackageName
			{
				get
				{
					return packageName;
				}
				set	
				{
					packageName = value;
				}
			}

			public bool? BoxFlag
			{
				get
				{
					return boxFlag;
				}
				set	
				{
					boxFlag = value;
				}
			}

			public bool? Android
			{
				get
				{
					return android;
				}
				set	
				{
					android = value;
				}
			}

			public bool? IOS
			{
				get
				{
					return iOS;
				}
				set	
				{
					iOS = value;
				}
			}

			public string ProductCertKey
			{
				get
				{
					return productCertKey;
				}
				set	
				{
					productCertKey = value;
				}
			}

			public string ProductCertPass
			{
				get
				{
					return productCertPass;
				}
				set	
				{
					productCertPass = value;
				}
			}

			public string DevCertKey
			{
				get
				{
					return devCertKey;
				}
				set	
				{
					devCertKey = value;
				}
			}

			public string DevCertPass
			{
				get
				{
					return devCertPass;
				}
				set	
				{
					devCertPass = value;
				}
			}
		}
	}
}