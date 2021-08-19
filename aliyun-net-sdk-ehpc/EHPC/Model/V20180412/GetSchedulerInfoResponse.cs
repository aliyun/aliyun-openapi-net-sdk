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
	public class GetSchedulerInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetSchedulerInfo_SchedInfoItem> schedInfo;

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

		public List<GetSchedulerInfo_SchedInfoItem> SchedInfo
		{
			get
			{
				return schedInfo;
			}
			set	
			{
				schedInfo = value;
			}
		}

		public class GetSchedulerInfo_SchedInfoItem
		{

			private string schedName;

			private string configuration;

			public string SchedName
			{
				get
				{
					return schedName;
				}
				set	
				{
					schedName = value;
				}
			}

			public string Configuration
			{
				get
				{
					return configuration;
				}
				set	
				{
					configuration = value;
				}
			}
		}
	}
}
