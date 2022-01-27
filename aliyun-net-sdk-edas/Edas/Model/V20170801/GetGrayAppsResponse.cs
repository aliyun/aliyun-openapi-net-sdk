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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetGrayAppsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private GetGrayApps_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public GetGrayApps_Data Data
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

		public class GetGrayApps_Data
		{

			private GetGrayApps_Result result;

			public GetGrayApps_Result Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public class GetGrayApps_Result
			{

				private string appId;

				private string applicationType;

				private string appname;

				private string defaultGroupId;

				private string packageVersion;

				private string regionId;

				private string developType;

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

				public string ApplicationType
				{
					get
					{
						return applicationType;
					}
					set	
					{
						applicationType = value;
					}
				}

				public string Appname
				{
					get
					{
						return appname;
					}
					set	
					{
						appname = value;
					}
				}

				public string DefaultGroupId
				{
					get
					{
						return defaultGroupId;
					}
					set	
					{
						defaultGroupId = value;
					}
				}

				public string PackageVersion
				{
					get
					{
						return packageVersion;
					}
					set	
					{
						packageVersion = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string DevelopType
				{
					get
					{
						return developType;
					}
					set	
					{
						developType = value;
					}
				}
			}
		}
	}
}
