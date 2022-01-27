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
	public class UpdateHookConfigurationResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private List<UpdateHookConfiguration_Configuration> hooksConfiguration;

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

		public List<UpdateHookConfiguration_Configuration> HooksConfiguration
		{
			get
			{
				return hooksConfiguration;
			}
			set	
			{
				hooksConfiguration = value;
			}
		}

		public class UpdateHookConfiguration_Configuration
		{

			private string name;

			private string script;

			private bool? ignoreFail;

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

			public string Script
			{
				get
				{
					return script;
				}
				set	
				{
					script = value;
				}
			}

			public bool? IgnoreFail
			{
				get
				{
					return ignoreFail;
				}
				set	
				{
					ignoreFail = value;
				}
			}
		}
	}
}
