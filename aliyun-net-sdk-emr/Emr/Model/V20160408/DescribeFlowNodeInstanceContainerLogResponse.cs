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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeFlowNodeInstanceContainerLogResponse : AcsResponse
	{

		private string requestId;

		private bool? logEnd;

		private List<DescribeFlowNodeInstanceContainerLog_LogEntry> logEntrys;

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

		public bool? LogEnd
		{
			get
			{
				return logEnd;
			}
			set	
			{
				logEnd = value;
			}
		}

		public List<DescribeFlowNodeInstanceContainerLog_LogEntry> LogEntrys
		{
			get
			{
				return logEntrys;
			}
			set	
			{
				logEntrys = value;
			}
		}

		public class DescribeFlowNodeInstanceContainerLog_LogEntry
		{

			private string content;

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}
		}
	}
}
