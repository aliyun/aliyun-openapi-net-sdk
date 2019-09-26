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

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
	public class BindAxnExtensionResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private BindAxnExtension_SecretBindDTO secretBindDTO;

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

		public BindAxnExtension_SecretBindDTO SecretBindDTO
		{
			get
			{
				return secretBindDTO;
			}
			set	
			{
				secretBindDTO = value;
			}
		}

		public class BindAxnExtension_SecretBindDTO
		{

			private string subsId;

			private string secretNo;

			private string extension;

			public string SubsId
			{
				get
				{
					return subsId;
				}
				set	
				{
					subsId = value;
				}
			}

			public string SecretNo
			{
				get
				{
					return secretNo;
				}
				set	
				{
					secretNo = value;
				}
			}

			public string Extension
			{
				get
				{
					return extension;
				}
				set	
				{
					extension = value;
				}
			}
		}
	}
}
