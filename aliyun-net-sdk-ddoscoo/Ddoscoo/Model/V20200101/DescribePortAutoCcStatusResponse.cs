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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribePortAutoCcStatusResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePortAutoCcStatus_Status> portAutoCcStatus;

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

		public List<DescribePortAutoCcStatus_Status> PortAutoCcStatus
		{
			get
			{
				return portAutoCcStatus;
			}
			set	
			{
				portAutoCcStatus = value;
			}
		}

		public class DescribePortAutoCcStatus_Status
		{

			private string mode;

			private string webSwitch;

			private string webMode;

			private string _switch;

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

			public string WebSwitch
			{
				get
				{
					return webSwitch;
				}
				set	
				{
					webSwitch = value;
				}
			}

			public string WebMode
			{
				get
				{
					return webMode;
				}
				set	
				{
					webMode = value;
				}
			}

			public string _Switch
			{
				get
				{
					return _switch;
				}
				set	
				{
					_switch = value;
				}
			}
		}
	}
}
