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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeInstanceResponse : AcsResponse
	{

		private string status;

		private long? modifyTime;

		private string description;

		private string requestId;

		private string instanceId;

		private long? concurrency;

		private string modifyUserName;

		private string nluServiceType;

		private string name;

		private List<string> applicableOperations;

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

		public long? ModifyTime
		{
			get
			{
				return modifyTime;
			}
			set	
			{
				modifyTime = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public long? Concurrency
		{
			get
			{
				return concurrency;
			}
			set	
			{
				concurrency = value;
			}
		}

		public string ModifyUserName
		{
			get
			{
				return modifyUserName;
			}
			set	
			{
				modifyUserName = value;
			}
		}

		public string NluServiceType
		{
			get
			{
				return nluServiceType;
			}
			set	
			{
				nluServiceType = value;
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

		public List<string> ApplicableOperations
		{
			get
			{
				return applicableOperations;
			}
			set	
			{
				applicableOperations = value;
			}
		}
	}
}
