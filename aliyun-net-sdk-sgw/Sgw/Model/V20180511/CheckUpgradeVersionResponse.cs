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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class CheckUpgradeVersionResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private string option;

		private string latestVersion;

		private List<CheckUpgradeVersion_Patch> patches;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
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

		public string Option
		{
			get
			{
				return option;
			}
			set	
			{
				option = value;
			}
		}

		public string LatestVersion
		{
			get
			{
				return latestVersion;
			}
			set	
			{
				latestVersion = value;
			}
		}

		public List<CheckUpgradeVersion_Patch> Patches
		{
			get
			{
				return patches;
			}
			set	
			{
				patches = value;
			}
		}

		public class CheckUpgradeVersion_Patch
		{

			private string name;

			private string mD5;

			private string url;

			private string internalUrl;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string MD5
			{
				get
				{
					return mD5;
				}
				set	
				{
					mD5 = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string InternalUrl
			{
				get
				{
					return internalUrl;
				}
				set	
				{
					internalUrl = value;
				}
			}
		}
	}
}
