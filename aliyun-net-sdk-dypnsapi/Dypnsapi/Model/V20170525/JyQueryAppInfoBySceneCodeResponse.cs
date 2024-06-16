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

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
	public class JyQueryAppInfoBySceneCodeResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private JyQueryAppInfoBySceneCode_Data data;

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

		public JyQueryAppInfoBySceneCode_Data Data
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

		public class JyQueryAppInfoBySceneCode_Data
		{

			private string cmAppId;

			private string cmAppKey;

			private string ctAppId;

			private string ctAppKey;

			public string CmAppId
			{
				get
				{
					return cmAppId;
				}
				set	
				{
					cmAppId = value;
				}
			}

			public string CmAppKey
			{
				get
				{
					return cmAppKey;
				}
				set	
				{
					cmAppKey = value;
				}
			}

			public string CtAppId
			{
				get
				{
					return ctAppId;
				}
				set	
				{
					ctAppId = value;
				}
			}

			public string CtAppKey
			{
				get
				{
					return ctAppKey;
				}
				set	
				{
					ctAppKey = value;
				}
			}
		}
	}
}
