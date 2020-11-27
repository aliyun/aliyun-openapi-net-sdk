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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeModifyParameterLogResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeModifyParameterLog_ChangeLog> changeLogs;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeModifyParameterLog_ChangeLog> ChangeLogs
		{
			get
			{
				return changeLogs;
			}
			set	
			{
				changeLogs = value;
			}
		}

		public class DescribeModifyParameterLog_ChangeLog
		{

			private string parameterName;

			private string oldParameterValue;

			private string newParameterValue;

			private int? synced;

			private string changeTime;

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public string OldParameterValue
			{
				get
				{
					return oldParameterValue;
				}
				set	
				{
					oldParameterValue = value;
				}
			}

			public string NewParameterValue
			{
				get
				{
					return newParameterValue;
				}
				set	
				{
					newParameterValue = value;
				}
			}

			public int? Synced
			{
				get
				{
					return synced;
				}
				set	
				{
					synced = value;
				}
			}

			public string ChangeTime
			{
				get
				{
					return changeTime;
				}
				set	
				{
					changeTime = value;
				}
			}
		}
	}
}
