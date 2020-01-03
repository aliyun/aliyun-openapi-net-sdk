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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class GetIfEcsTypeSupportHtConfigResponse : AcsResponse
	{

		private string requestId;

		private string instanceType;

		private bool? supportHtConfig;

		private bool? defaultHtEnabled;

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

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
			}
		}

		public bool? SupportHtConfig
		{
			get
			{
				return supportHtConfig;
			}
			set	
			{
				supportHtConfig = value;
			}
		}

		public bool? DefaultHtEnabled
		{
			get
			{
				return defaultHtEnabled;
			}
			set	
			{
				defaultHtEnabled = value;
			}
		}
	}
}
