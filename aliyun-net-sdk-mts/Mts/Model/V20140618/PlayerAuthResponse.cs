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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class PlayerAuthResponse : AcsResponse
	{

		private string requestId;

		private string logURL;

		private List<PlayerAuth__Switch> switchList;

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

		public string LogURL
		{
			get
			{
				return logURL;
			}
			set	
			{
				logURL = value;
			}
		}

		public List<PlayerAuth__Switch> SwitchList
		{
			get
			{
				return switchList;
			}
			set	
			{
				switchList = value;
			}
		}

		public class PlayerAuth__Switch
		{

			private string state;

			private string functionId;

			private string switchId;

			private string functionName;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string FunctionId
			{
				get
				{
					return functionId;
				}
				set	
				{
					functionId = value;
				}
			}

			public string SwitchId
			{
				get
				{
					return switchId;
				}
				set	
				{
					switchId = value;
				}
			}

			public string FunctionName
			{
				get
				{
					return functionName;
				}
				set	
				{
					functionName = value;
				}
			}
		}
	}
}