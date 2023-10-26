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

namespace Aliyun.Acs.fnf.Model.V20190315
{
	public class StartExecutionResponse : AcsResponse
	{

		private string status;

		private string stoppedTime;

		private string requestId;

		private string startedTime;

		private string flowDefinition;

		private string externalInputUri;

		private string output;

		private string flowName;

		private string externalOutputUri;

		private string name;

		private string input;

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string StoppedTime
		{
			get
			{
				return stoppedTime;
			}
			set	
			{
				stoppedTime = value;
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

		public string StartedTime
		{
			get
			{
				return startedTime;
			}
			set	
			{
				startedTime = value;
			}
		}

		public string FlowDefinition
		{
			get
			{
				return flowDefinition;
			}
			set	
			{
				flowDefinition = value;
			}
		}

		public string ExternalInputUri
		{
			get
			{
				return externalInputUri;
			}
			set	
			{
				externalInputUri = value;
			}
		}

		public string Output
		{
			get
			{
				return output;
			}
			set	
			{
				output = value;
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
			}
		}

		public string ExternalOutputUri
		{
			get
			{
				return externalOutputUri;
			}
			set	
			{
				externalOutputUri = value;
			}
		}

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

		public string Input
		{
			get
			{
				return input;
			}
			set	
			{
				input = value;
			}
		}
	}
}
