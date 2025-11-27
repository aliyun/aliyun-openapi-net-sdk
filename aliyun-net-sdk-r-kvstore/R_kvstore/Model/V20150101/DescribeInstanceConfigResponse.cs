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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeInstanceConfigResponse : AcsResponse
	{

		private string config;

		private string requestId;

		private string paramReplMode;

		private string paramReplTimeout;

		private string paramNoLooseSentinelEnabled;

		private string paramSentinelCompatEnable;

		private string paramNoLooseSentinelPasswordFreeAccess;

		private string paramNoLooseSentinelPasswordFreeCommands;

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
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

		public string ParamReplMode
		{
			get
			{
				return paramReplMode;
			}
			set	
			{
				paramReplMode = value;
			}
		}

		public string ParamReplTimeout
		{
			get
			{
				return paramReplTimeout;
			}
			set	
			{
				paramReplTimeout = value;
			}
		}

		public string ParamNoLooseSentinelEnabled
		{
			get
			{
				return paramNoLooseSentinelEnabled;
			}
			set	
			{
				paramNoLooseSentinelEnabled = value;
			}
		}

		public string ParamSentinelCompatEnable
		{
			get
			{
				return paramSentinelCompatEnable;
			}
			set	
			{
				paramSentinelCompatEnable = value;
			}
		}

		public string ParamNoLooseSentinelPasswordFreeAccess
		{
			get
			{
				return paramNoLooseSentinelPasswordFreeAccess;
			}
			set	
			{
				paramNoLooseSentinelPasswordFreeAccess = value;
			}
		}

		public string ParamNoLooseSentinelPasswordFreeCommands
		{
			get
			{
				return paramNoLooseSentinelPasswordFreeCommands;
			}
			set	
			{
				paramNoLooseSentinelPasswordFreeCommands = value;
			}
		}
	}
}
