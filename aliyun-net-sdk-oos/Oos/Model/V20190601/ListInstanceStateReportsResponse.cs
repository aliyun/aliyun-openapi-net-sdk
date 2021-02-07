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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListInstanceStateReportsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListInstanceStateReports_StateReport> stateReports;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListInstanceStateReports_StateReport> StateReports
		{
			get
			{
				return stateReports;
			}
			set	
			{
				stateReports = value;
			}
		}

		public class ListInstanceStateReports_StateReport
		{

			private string reportTime;

			private string instanceId;

			private string stateConfigurationId;

			private string mode;

			private string reportStatus;

			private string successApplyTime;

			private string reportInfo;

			public string ReportTime
			{
				get
				{
					return reportTime;
				}
				set	
				{
					reportTime = value;
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

			public string StateConfigurationId
			{
				get
				{
					return stateConfigurationId;
				}
				set	
				{
					stateConfigurationId = value;
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

			public string ReportStatus
			{
				get
				{
					return reportStatus;
				}
				set	
				{
					reportStatus = value;
				}
			}

			public string SuccessApplyTime
			{
				get
				{
					return successApplyTime;
				}
				set	
				{
					successApplyTime = value;
				}
			}

			public string ReportInfo
			{
				get
				{
					return reportInfo;
				}
				set	
				{
					reportInfo = value;
				}
			}
		}
	}
}
