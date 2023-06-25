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

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
	public class DescribeOnDemandInstanceStatusResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOnDemandInstanceStatus_Instance> instances;

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

		public List<DescribeOnDemandInstanceStatus_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeOnDemandInstanceStatus_Instance
		{

			private string userId;

			private string mode;

			private string instanceId;

			private string declared;

			private string registedAs;

			private string net;

			private string desc;

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
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

			public string Declared
			{
				get
				{
					return declared;
				}
				set	
				{
					declared = value;
				}
			}

			public string RegistedAs
			{
				get
				{
					return registedAs;
				}
				set	
				{
					registedAs = value;
				}
			}

			public string Net
			{
				get
				{
					return net;
				}
				set	
				{
					net = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}
		}
	}
}
