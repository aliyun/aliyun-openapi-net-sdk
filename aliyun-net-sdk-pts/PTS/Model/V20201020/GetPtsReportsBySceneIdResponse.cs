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

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class GetPtsReportsBySceneIdResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private List<GetPtsReportsBySceneId_ReportOverView> reportOverViewList;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<GetPtsReportsBySceneId_ReportOverView> ReportOverViewList
		{
			get
			{
				return reportOverViewList;
			}
			set	
			{
				reportOverViewList = value;
			}
		}

		public class GetPtsReportsBySceneId_ReportOverView
		{

			private string reportName;

			private string endTime;

			private string startTime;

			private int? agentCount;

			private string reportId;

			private long? vum;

			public string ReportName
			{
				get
				{
					return reportName;
				}
				set	
				{
					reportName = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public int? AgentCount
			{
				get
				{
					return agentCount;
				}
				set	
				{
					agentCount = value;
				}
			}

			public string ReportId
			{
				get
				{
					return reportId;
				}
				set	
				{
					reportId = value;
				}
			}

			public long? Vum
			{
				get
				{
					return vum;
				}
				set	
				{
					vum = value;
				}
			}
		}
	}
}
