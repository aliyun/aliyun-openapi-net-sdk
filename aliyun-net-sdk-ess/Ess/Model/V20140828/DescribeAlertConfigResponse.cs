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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeAlertConfigResponse : AcsResponse
	{

		private int? successConfig;

		private int? failConfig;

		private int? rejectConfig;

		private string requestId;

		public int? SuccessConfig
		{
			get
			{
				return successConfig;
			}
			set	
			{
				successConfig = value;
			}
		}

		public int? FailConfig
		{
			get
			{
				return failConfig;
			}
			set	
			{
				failConfig = value;
			}
		}

		public int? RejectConfig
		{
			get
			{
				return rejectConfig;
			}
			set	
			{
				rejectConfig = value;
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
	}
}